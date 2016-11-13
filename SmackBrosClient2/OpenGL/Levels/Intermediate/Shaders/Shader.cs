using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;

namespace System
{
    public static partial class StringExtensions
    {
        public static T To<T>(this object obj)
        {
            if (typeof (T) == typeof (Int32)) return (T) (object) Convert.ToInt32(obj);

            return (T) obj;
        }
    }

}
namespace NeptuneRenderEngine.Engine.Levels.Intermediate.Shaders
{
	public struct ShaderVersion
	{
		public int Major;
		public int Minor;
		public string Source;
	}

	public struct ShaderLoad
	{
		public ShaderVersion[] Versions;
		public Dictionary<string, string> Library;
	}

	public class Shader
	{
		public enum Token
		{
			Null = 0, If, Else, Code, End, String
		}

		public enum State
		{
			Increase, Decrease, New, Ignore
		}

        public class Block
        {
            public Block Previous = null;
            public Block Next = null;
            public Block Parent = null;
			public Token Token;
			public object[] Parameters = new object[0];
			public string[] Lines = new string[0];
		    public Block[] Children = new Block[0];

            public static void RecursiveFix(Block[] blocks)
            {
                for (int i = 0; i < blocks.Length; i++)
                {
                    blocks[i].RecursiveFix(null, i + 1 < blocks.Length ? blocks[i + 1] : null, i - 1 >= 0 ? blocks[i - 1] : null);
                }
            }

            public void RecursiveFix(Block parent, Block next, Block prev)
            {
                Parent = parent;
                Next = next;
                Previous = prev;

                for (int i = 0; i < Children.Length; i++)
                {
                    Children[i].RecursiveFix(null, i + 1 < Children.Length ? Children[i + 1] : null, i - 1 >= 0 ? Children[i - 1] : null);
                }
            }
		}

		public static State GetLevel(Token t)
		{
			switch(t)
			{
			case Token.If:
				return State.Increase;
			case Token.Else:
				return State.New;
			case Token.End:
				return State.Decrease;
			case Token.Code:
				return State.Increase;
			default:
				return State.Ignore;
			}
		}

		public static string CapitalizeFirst(string str)
		{
			return str.Substring(0, 1).ToUpper() + str.Substring(1, str.Length - 1);
		}

		public static Tuple<Token, State, string> GetTokenString(string line)
		{
            if (!line.Contains("#>"))
            {
                return new Tuple<Token, State, string>(Token.String, State.Ignore, line);
            }
		    int ind = line.LastIndexOf("#>", StringComparison.InvariantCulture);
            var split = line.Substring(ind + 2)
				.Trim()
				.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);

		    //Console.WriteLine(split[0]);
		    Token token;
		    token = split.Any() && Enum.TryParse(CapitalizeFirst(split[0]), out token) ? token : Token.String; //Token))Enum.Parse(typeof(Token), CapitalizeFirst(split[0]));
			var state = GetLevel(token);
            var str = split.Count() > 0 ? (split.Count() > 2 ? split.Skip(1) : split).Aggregate((s, s1) => string.Format(
                    "{0} {1}",
                    s,
                    s1)) : "";
			return new Tuple<Token, State, string>(
				token,
				state,
                str);
		}

		public static Tuple<Token, State, string>[] Tokenize(string[] lines)
		{
			return lines.Select(GetTokenString).ToArray();
		}

        public static void RecPrint(Block block, int level = 0)
        {
            var spacing = String.Join("", Enumerable.Range(0, level).Select(item => " "));
            Console.WriteLine("{0}{1}: {2}", spacing, block.Token, block.Lines.Any() ? block.Lines.Select(item => string.Format("\n {0}{1}", spacing, item)).Aggregate((s, s1) => s + s1) : "");
            foreach(var bl in block.Children)
                RecPrint(bl, level + 1);
        }

		public static Shader Load(string path)
		{
			var lines = File.ReadAllLines(path).Select(item => item.Split('\n')).SelectMany(item => item).ToArray();

            var collect = new Stack<List<Block>>();
            collect.Push(new List<Block>());

		    var stack = new Stack<Tuple<Token, State, string>>();
            foreach (var tok in Tokenize(lines))
            {
                if (tok.Item2 == State.Increase)
                {
                    stack.Push(tok);
                    collect.Push(new List<Block>());
                }
                else if (tok.Item2 == State.New)
                {
                    var pop = stack.Pop();
                    var block = new Block { Children = collect.Pop().ToArray(), Token = pop.Item1, Parameters = pop.Item3.Split(' ').Select(item => (object)item).ToArray() };
                    collect.Peek().Add(block);
                    stack.Push(tok);
                    collect.Push(new List<Block>());
                }
                else if (tok.Item2 == State.Decrease)
                {
                    var pop = stack.Pop();
                    var block = new Block { Children = collect.Pop().ToArray(), Token = pop.Item1, Parameters = pop.Item3.Split(' ').Select(item => (object)item).ToArray() };
                    collect.Peek().Add(block);
                }
                else if (tok.Item2 == State.Ignore)
                {
                    collect.Peek().Add(new Block { Token = tok.Item1, Lines = new[] { tok.Item3 } });
                }
            }
		    var blocks = collect.Pop().ToArray();
            Block.RecursiveFix(blocks);
            return new Shader(blocks);
		}

		private Block[] _blocks = new Block[0];
		public Shader(Block[] blocks)
		{
			_blocks = blocks;
		}

		public bool Evaluate(int major, int minor, Block block)
		{
		    int thisMajor = 0;
		    int thisMinor = 0;
            if (block.Token == Token.Else)
            {
                if (block.Previous == null || block.Previous.Token != Token.If) return false;
                if (Evaluate(major, minor, block.Previous)) return false;
                return true;
            }
		    return block.Token != Token.If ||
                (block.Token == Token.If && 
                    int.TryParse((string)block.Parameters[0], out thisMajor) &&
                    int.TryParse((string)block.Parameters[1], out thisMinor) && (thisMajor < major || (thisMajor == major && thisMinor <= minor)));
		}

        private string Whitespace(int indent)
        {
            return String.Join("", Enumerable.Range(0, indent).Select(item => " "));
        }

        private void Rec_Build(int maj, int min, Block block, ref StringBuilder builder, int level = 0)
        {
            //if(block.Token != Token.String) builder.AppendFormat("{0}{1}: {2}\n", Whitespace(level), block.Token, Evaluate(maj, min, block));
            if (!Evaluate(maj, min, block)) return;
            if (block.Token == Token.Code)
            {
                
            }
            else if (block.Token == Token.String) builder.AppendLine(String.Join("\n", block.Lines));
            else
            {
                foreach (var bl in block.Children)
                    Rec_Build(maj, min, bl, ref builder, level + 1);
            }
        }

		public void Build(int major, int minor, ref StringBuilder builder)
		{
		    foreach (var block in _blocks)
		        Rec_Build(major, minor, block, ref builder);
		}
	}
}

