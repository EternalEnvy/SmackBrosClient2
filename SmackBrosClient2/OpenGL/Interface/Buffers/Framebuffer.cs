using System;
using NeptuneRenderEngine.Engine.Interface.Textures;
#if OPENGL4
using OpenTK.Graphics.OpenGL4;
using PIF = OpenTK.Graphics.OpenGL4.PixelInternalFormat;
using PF = OpenTK.Graphics.OpenGL4.PixelFormat;
using PT = OpenTK.Graphics.OpenGL4.PixelType;
#else
using OpenTK.Graphics.OpenGL;
using PIF = OpenTK.Graphics.OpenGL.PixelInternalFormat;
using PF = OpenTK.Graphics.OpenGL.PixelFormat;
using PT = OpenTK.Graphics.OpenGL.PixelType;
#endif

namespace NeptuneRenderEngine.Engine.Interface.Buffers
{
    public abstract class FBO<T> : GLO where T : FBO<T>, new()
    {
        public readonly FramebufferTarget FramebufferTarget;

        protected FBO(FramebufferTarget framebufferTarget, int defaultID = 0) : base(framebufferTarget.ToString(), defaultID)
        {
            FramebufferTarget = framebufferTarget;
        }

        protected override int Generate()
        {
            int i;
            GL.GenFramebuffers(1, out i);
            return i;
        }

        public override void Delete()
        {
#if OPENGL4
            GL.DeleteFramebuffer(ID);
#else
            GL.DeleteFramebuffers(1, new[] { ID });
#endif
        }

        public override void Bind(int id)
        {
            GL.BindFramebuffer(FramebufferTarget, id);
        }

		public void AttachTexture(Texture texture, FramebufferAttachment attachment, int lodLevel = 0) { 
			BindingHelper<T>.Use((T)this, t => GL.FramebufferTexture(FramebufferTarget, attachment, texture.ID, lodLevel)); }
		public void AttachTexture(Texture1D texture, FramebufferAttachment attachment, int lodLevel = 0) { 
			BindingHelper<T>.Use((T)this, t => GL.FramebufferTexture(FramebufferTarget, attachment, texture.ID, lodLevel)); }
		public void AttachTexture(Texture2D texture, FramebufferAttachment attachment, int lodLevel = 0) { 
			BindingHelper<T>.Use((T)this, t => GL.FramebufferTexture(FramebufferTarget, attachment, texture.ID, lodLevel)); }
		public void AttachTexture(Texture3D texture, FramebufferAttachment attachment, int lodLevel = 0) { 
			BindingHelper<T>.Use((T)this, t => GL.FramebufferTexture(FramebufferTarget, attachment, texture.ID, lodLevel)); }

        public void AttachRenderbuffer<TRbo>(RBO<TRbo> renderBuffer, FramebufferAttachment attachment) where TRbo : RBO<TRbo>, new() { 
			BindingHelper<T>.Use((T)this, obj => GL.FramebufferRenderbuffer(FramebufferTarget, attachment, renderBuffer.RenderbufferTarget, renderBuffer.ID)); }

		public Texture1D AttachTexture1D(int length, PIF pif, PF pf, PT pt, FramebufferAttachment attachment, int lodLevel = 0)
		{ 
			var tex = new Texture1D();
			tex.TexImage(length, IntPtr.Zero, pif, pf, pt);
            tex.SetTextureMagFilter(TextureMagFilter.Linear);
            tex.SetTextureMinFilter(TextureMinFilter.Linear);
            GL.TexParameter(tex.TextureTarget, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToBorder);
            GL.TexParameter(tex.TextureTarget, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToBorder);
            GL.TexParameter(tex.TextureTarget, TextureParameterName.TextureWrapR, (int)TextureWrapMode.ClampToBorder);
			BindingHelper<T>.Use((T)this, t => GL.FramebufferTexture(FramebufferTarget, attachment, tex.ID, lodLevel)); 
			return tex;
		}

		public Texture2D AttachTexture2D(int width, int height, PIF pif, PF pf, PT pt, FramebufferAttachment attachment, int lodLevel = 0)
		{ 
			var tex = new Texture2D();
			tex.TexImage(width, height, IntPtr.Zero, pif, pf, pt);
            tex.SetTextureMagFilter(TextureMagFilter.Linear);
            tex.SetTextureMinFilter(TextureMinFilter.Linear);
            GL.TexParameter(tex.TextureTarget, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToBorder);
            GL.TexParameter(tex.TextureTarget, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToBorder);
            GL.TexParameter(tex.TextureTarget, TextureParameterName.TextureWrapR, (int)TextureWrapMode.ClampToBorder);
			BindingHelper<T>.Use((T)this, t => GL.FramebufferTexture(FramebufferTarget, attachment, tex.ID, lodLevel)); 
			return tex;
		}

		public Texture3D AttachTexture3D(int width, int height, int depth, PIF pif, PF pf, PT pt, FramebufferAttachment attachment, int lodLevel = 0)
		{ 
			var tex = new Texture3D();
			tex.TexImage(width, height, depth, IntPtr.Zero, pif, pf, pt);
            tex.SetTextureMagFilter(TextureMagFilter.Linear);
            tex.SetTextureMinFilter(TextureMinFilter.Linear);
            GL.TexParameter(tex.TextureTarget, TextureParameterName.TextureWrapS, (int)TextureWrapMode.ClampToBorder);
            GL.TexParameter(tex.TextureTarget, TextureParameterName.TextureWrapT, (int)TextureWrapMode.ClampToBorder);
            GL.TexParameter(tex.TextureTarget, TextureParameterName.TextureWrapR, (int)TextureWrapMode.ClampToBorder);
			BindingHelper<T>.Use((T)this, t => GL.FramebufferTexture(FramebufferTarget, attachment, tex.ID, lodLevel)); 
			return tex;
		}

		public void DrawBuffers(params DrawBuffersEnum[] enums)
		{
			BindingHelper<T>.Use((T)this, t => GL.DrawBuffers(enums.Length, enums)); 
		}
    }

	public class ReadFramebuffer : FBO<ReadFramebuffer> 
	{
		public ReadFramebuffer() : base(FramebufferTarget.ReadFramebuffer) { }
        public ReadFramebuffer(int defaultID = 0) : base(FramebufferTarget.ReadFramebuffer, defaultID) { }
	}
	public class DrawFramebuffer : FBO<DrawFramebuffer> 
	{
		public DrawFramebuffer() : base(FramebufferTarget.DrawFramebuffer) { }
        public DrawFramebuffer(int defaultID = 0) : base(FramebufferTarget.DrawFramebuffer, defaultID) { }
	}
	public class Framebuffer : FBO<Framebuffer> 
	{
		public Framebuffer() : base(FramebufferTarget.Framebuffer) { }
        public Framebuffer(int defaultID = 0) : base(FramebufferTarget.Framebuffer, defaultID) { }
	}
	public class FramebufferExt : FBO<FramebufferExt> 
	{
		public FramebufferExt() : base(FramebufferTarget.FramebufferExt) { }
        public FramebufferExt(int defaultID = 0) : base(FramebufferTarget.FramebufferExt, defaultID) { }
	}
}
