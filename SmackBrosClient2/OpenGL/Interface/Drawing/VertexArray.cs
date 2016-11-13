using System.Linq;
#if OPENGL4
using OpenTK.Graphics.OpenGL4;
#else
using OpenTK.Graphics.OpenGL;
#endif
using NeptuneRenderEngine.Engine.Interface.Buffers;
using NeptuneRenderEngine.Engine.Interface.Shaders;

namespace NeptuneRenderEngine.Engine.Interface.Drawing
{
    public struct VaoBinding
    {
        public string ShaderName;
        public int Length;
        public VertexAttribPointerType PointerType;
        public bool Normalized;

        public int Size
        {
            get
            {
                return Length *
                    (PointerType == VertexAttribPointerType.Byte || PointerType == VertexAttribPointerType.UnsignedByte ? 1 :
                    (PointerType == VertexAttribPointerType.Short || PointerType == VertexAttribPointerType.UnsignedShort ? 2 :
                    (PointerType == VertexAttribPointerType.Int || PointerType == VertexAttribPointerType.UnsignedInt ? 4 :
                    (PointerType == VertexAttribPointerType.HalfFloat ? 2 :
                    (PointerType == VertexAttribPointerType.Float ? 4 :
                    (PointerType == VertexAttribPointerType.Double ? 8 : 0))))));
            }
        }
    }

    public class VertexArray : GLO
    {

        public VertexArray() : base("VertexArray")
        {
            
        }

        protected override int Generate()
        {
            int id;
            GL.GenVertexArrays(1, out id);
            return id;
        }

        public override void Delete()
        {
#if OPENGL4
            GL.DeleteVertexArray(ID);
#else
            GL.DeleteVertexArrays(1, new []{ID});
#endif
        }

        public void SetLayout<T>(ShaderProgram program, T buffer, params VaoBinding[] layout) where T : DBO<T>, new()
        {
            BindingHelper<VertexArray>.Use(this, obj => BindingHelper<T>.Use(buffer, buf =>
            {
                int stride = layout.Sum(binding => binding.Size);
                int offset = 0;
                foreach (var binding in layout)
                {
                    int pos = program.GetAttribLocation(binding.ShaderName);
                    if (pos < 0)
                    {
                        offset += binding.Size;
                        continue;
                    }

                    GL.VertexAttribPointer(pos, binding.Length, binding.PointerType, binding.Normalized, stride, offset);
                    GL.EnableVertexAttribArray(pos);

                    offset += binding.Size;
                }
            }));
        }

        public override void Bind(int id)
        {
            GL.BindVertexArray(id);
        }
    }
}
