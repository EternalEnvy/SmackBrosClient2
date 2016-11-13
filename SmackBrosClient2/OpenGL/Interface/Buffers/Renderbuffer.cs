#if OPENGL4
using OpenTK.Graphics.OpenGL4;
#else
using OpenTK.Graphics.OpenGL;
#endif

namespace NeptuneRenderEngine.Engine.Interface.Buffers
{
    public abstract class RBO<T> : GLO where T : RBO<T>, new()
    {
        public readonly RenderbufferTarget RenderbufferTarget;

        protected RBO(RenderbufferTarget renderbufferTarget, int defaultID = 0)
            : base(renderbufferTarget.ToString(), defaultID)
        {
            RenderbufferTarget = renderbufferTarget;
        }

        protected override int Generate()
        {
            int i;
            GL.GenRenderbuffers(1, out i);
            return i;
        }

        public override void Delete()
        {
#if OPENGL4
            GL.DeleteRenderbuffer(ID);
#else
            GL.DeleteRenderbuffers(1, new []{ID});
#endif
        }

        public override void Bind(int id)
        {
            //if (GLStates.GetState_BindRenderbuffer(RenderbufferTarget) == id) return;
            GL.BindRenderbuffer(RenderbufferTarget, id);

        }

        public void Storage(RenderbufferStorage storage, int width, int height)
        {
            BindingHelper<T>.Use((T)this, t => GL.RenderbufferStorage(RenderbufferTarget, storage, width, height));
        }
    }

    public class Renderbuffer : RBO<Renderbuffer>
    {
        public Renderbuffer()
            : base(RenderbufferTarget.Renderbuffer)
        {
        }

        public Renderbuffer(int defaultID = 0)
            : base(RenderbufferTarget.Renderbuffer, defaultID)
        {
        }
    }

    public class RenderbufferExt : RBO<RenderbufferExt>
    {
        public RenderbufferExt()
            : base(RenderbufferTarget.RenderbufferExt)
        {
        }

        public RenderbufferExt(int defaultID = 0)
            : base(RenderbufferTarget.RenderbufferExt, defaultID)
        {
        }
    }
}
