using System.Drawing;
using System.Drawing.Imaging;
#if OPENGL4
using OpenTK.Graphics.OpenGL4;
using PixelFormat = OpenTK.Graphics.OpenGL4.PixelFormat;
#else
using OpenTK.Graphics.OpenGL;
using PixelFormat = OpenTK.Graphics.OpenGL.PixelFormat;
#endif

namespace NeptuneRenderEngine.Engine.Interface.Textures
{
    public abstract class Texture : GLO
    {
        public readonly TextureTarget TextureTarget;

        protected Texture(TextureTarget textureTarget) : base(textureTarget.ToString())
        {
            TextureTarget = textureTarget;
        }
        protected Texture(TextureTarget textureTarget, int defaultID) : base(textureTarget.ToString(), defaultID)
        {
            TextureTarget = textureTarget;
        }

        protected override int Generate()
        {
            int i;
            GL.GenTextures(1, out i);
            return i;
        }

        public override void Delete()
        {
            GL.DeleteTexture(ID);
        }

        public override void Bind(int id)
        {
            //if (GLStates.GetState_BindTexture(TextureTarget) == id) return;
            GL.BindTexture(TextureTarget, id);
            //GL.BindTextures(0, 1, new []{id});
        }

        public static Texture2D CreateTexture2D(Bitmap bitmap)
        {
            var bmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            var texture = new Texture2D();
            texture.Bind();
            texture.TexImage(bmapData.Width, bmapData.Height, bmapData.Scan0, PixelInternalFormat.Rgba, PixelFormat.Bgra, PixelType.UnsignedByte);
            texture.SetTextureMinFilter(TextureMinFilter.Linear);
            texture.SetTextureMagFilter(TextureMagFilter.Linear);
            texture.Bind(0);

            bitmap.UnlockBits(bmapData);

            return texture;
        }
    }
}
