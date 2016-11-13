using System.Linq;
#if OPENGL4
using OpenTK.Graphics.OpenGL4;
#else
using OpenTK.Graphics.OpenGL;
#endif

namespace NeptuneRenderEngine.Engine.Interface.Shaders
{
    public class Shader : GLO
    {
        public readonly ShaderType ShaderType;

        public Shader(ShaderType shaderType) : base(shaderType.ToString())
        {
            ShaderType = shaderType;
        }

        protected override int Generate()
        {
            return GL.CreateShader(ShaderType);
        }

        public override void Delete()
        {
            GL.DeleteShader(ID);
        }

        public string Source { get; private set; }

        public void SetSource(string source)
        {
            GL.ShaderSource(ID, source);
            Source = source;
        }

        public void SetSource(string[] source)
        {
            SetSource(source.Aggregate((s, s1) => s + "\n" + s1));
        }

        public bool Compile()
        {
            try
            {
                GL.CompileShader(ID);
            }
            catch (GLException)
            {
                return false;
            }
            return true;
        }

        public string Log
        {
            get
            {
                return GL.GetShaderInfoLog(ID);
            }
        }

        public override void Bind(int id)
        {
            
        }
    }
}
