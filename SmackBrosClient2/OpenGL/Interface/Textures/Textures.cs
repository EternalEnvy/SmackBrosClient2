using System;
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

namespace NeptuneRenderEngine.Engine.Interface.Textures
{
	public class Texture1D : Texture
	{
		private int _width;

		public Texture1D() : base(TextureTarget.Texture1D)
		{
		}

		public Texture1D(int defaultID) : base(TextureTarget.Texture1D, defaultID)
		{
		}		
		public void TexImage(int xSize, IntPtr data = default(IntPtr), PIF pif = PIF.Rgb, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0)
		{
			_width = xSize; 
			BindingHelper<Texture1D>.Push(this);
			GL.TexImage1D(TextureTarget, mipMapLevel, pif, xSize, 0, pf, pt, data);
			BindingHelper<Texture1D>.Pop();
		}
		
		public void TexSubImage(int xOffset, int xSize, IntPtr data = default(IntPtr), PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0)
		{
			if(xOffset < 0 || xOffset + xSize >= _width)
				throw new GLException("Image sub data out of bounds!");
			BindingHelper<Texture1D>.Push(this);
			GL.TexSubImage1D(TextureTarget, mipMapLevel, xOffset, xSize, pf, pt, data);
			BindingHelper<Texture1D>.Pop();
		}
		
		public void TexImage<T>(int xSize, ref T data, PIF pif = PIF.Rgb, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			_width = xSize; 
			BindingHelper<Texture1D>.Push(this);
			GL.TexImage1D(TextureTarget, mipMapLevel, pif, xSize, 0, pf, pt, ref data);
			BindingHelper<Texture1D>.Pop();
		}
		
		public void TexSubImage<T>(int xOffset, int xSize, ref T data, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			if(xOffset < 0 || xOffset + xSize >= _width)
				throw new GLException("Image sub data out of bounds!");
			BindingHelper<Texture1D>.Push(this);
			GL.TexSubImage1D(TextureTarget, mipMapLevel, xOffset, xSize, pf, pt, ref data);
			BindingHelper<Texture1D>.Pop();
		}
		
		public void TexImage<T>(int xSize, T[] data, PIF pif = PIF.Rgb, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			_width = xSize; 
			BindingHelper<Texture1D>.Push(this);
			GL.TexImage1D(TextureTarget, mipMapLevel, pif, xSize, 0, pf, pt, data);
			BindingHelper<Texture1D>.Pop();
		}
		
		public void TexSubImage<T>(int xOffset, int xSize, T[] data, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			if(xOffset < 0 || xOffset + xSize >= _width)
				throw new GLException("Image sub data out of bounds!");
			BindingHelper<Texture1D>.Push(this);
			GL.TexSubImage1D(TextureTarget, mipMapLevel, xOffset, xSize, pf, pt, data);
			BindingHelper<Texture1D>.Pop();
		}
		
		public void TexImage<T>(int xSize, T[,] data, PIF pif = PIF.Rgb, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			_width = xSize; 
			BindingHelper<Texture1D>.Push(this);
			GL.TexImage1D(TextureTarget, mipMapLevel, pif, xSize, 0, pf, pt, data);
			BindingHelper<Texture1D>.Pop();
		}
		
		public void TexSubImage<T>(int xOffset, int xSize, T[,] data, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			if(xOffset < 0 || xOffset + xSize >= _width)
				throw new GLException("Image sub data out of bounds!");
			BindingHelper<Texture1D>.Push(this);
			GL.TexSubImage1D(TextureTarget, mipMapLevel, xOffset, xSize, pf, pt, data);
			BindingHelper<Texture1D>.Pop();
		}
		
		public void TexImage<T>(int xSize, T[,,] data, PIF pif = PIF.Rgb, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			_width = xSize; 
			BindingHelper<Texture1D>.Push(this);
			GL.TexImage1D(TextureTarget, mipMapLevel, pif, xSize, 0, pf, pt, data);
			BindingHelper<Texture1D>.Pop();
		}
		
		public void TexSubImage<T>(int xOffset, int xSize, T[,,] data, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			if(xOffset < 0 || xOffset + xSize >= _width)
				throw new GLException("Image sub data out of bounds!");
			BindingHelper<Texture1D>.Push(this);
			GL.TexSubImage1D(TextureTarget, mipMapLevel, xOffset, xSize, pf, pt, data);
			BindingHelper<Texture1D>.Pop();
		}
		
		public void SetTextureMagFilter(TextureMagFilter filter)
		{
			BindingHelper<Texture1D>.Use(this, t => GL.TexParameter(TextureTarget, TextureParameterName.TextureMagFilter, (int)filter));
		}

		public void SetTextureMinFilter(TextureMinFilter filter)
		{
			BindingHelper<Texture1D>.Use(this, t => GL.TexParameter(TextureTarget, TextureParameterName.TextureMinFilter, (int)filter));
		}

		public int[] GetSize()
		{
			return new[] { _width };
		}

		public int GetWidth() 
		{
			return _width;
		}
	}
	public class Texture2D : Texture
	{
		private int _width, _height;

		public Texture2D() : base(TextureTarget.Texture2D)
		{
		}

		public Texture2D(int defaultID) : base(TextureTarget.Texture2D, defaultID)
		{
		}		
		public void TexImage(int xSize, int ySize, IntPtr data = default(IntPtr), PIF pif = PIF.Rgb, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0)
		{
			_width = xSize; _height = ySize; 
			BindingHelper<Texture2D>.Push(this);
			GL.TexImage2D(TextureTarget, mipMapLevel, pif, xSize, ySize, 0, pf, pt, data);
			BindingHelper<Texture2D>.Pop();
		}
		
		public void TexSubImage(int xOffset, int yOffset, int xSize, int ySize, IntPtr data = default(IntPtr), PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0)
		{
			if(xOffset < 0 || xOffset + xSize >= _width || yOffset < 0 || yOffset + ySize >= _height)
				throw new GLException("Image sub data out of bounds!");
			BindingHelper<Texture2D>.Push(this);
			GL.TexSubImage2D(TextureTarget, mipMapLevel, xOffset, yOffset, xSize, ySize, pf, pt, data);
			BindingHelper<Texture2D>.Pop();
		}
		
		public void TexImage<T>(int xSize, int ySize, ref T data, PIF pif = PIF.Rgb, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			_width = xSize; _height = ySize; 
			BindingHelper<Texture2D>.Push(this);
			GL.TexImage2D(TextureTarget, mipMapLevel, pif, xSize, ySize, 0, pf, pt, ref data);
			BindingHelper<Texture2D>.Pop();
		}
		
		public void TexSubImage<T>(int xOffset, int yOffset, int xSize, int ySize, ref T data, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			if(xOffset < 0 || xOffset + xSize >= _width || yOffset < 0 || yOffset + ySize >= _height)
				throw new GLException("Image sub data out of bounds!");
			BindingHelper<Texture2D>.Push(this);
			GL.TexSubImage2D(TextureTarget, mipMapLevel, xOffset, yOffset, xSize, ySize, pf, pt, ref data);
			BindingHelper<Texture2D>.Pop();
		}
		
		public void TexImage<T>(int xSize, int ySize, T[] data, PIF pif = PIF.Rgb, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			_width = xSize; _height = ySize; 
			BindingHelper<Texture2D>.Push(this);
			GL.TexImage2D(TextureTarget, mipMapLevel, pif, xSize, ySize, 0, pf, pt, data);
			BindingHelper<Texture2D>.Pop();
		}
		
		public void TexSubImage<T>(int xOffset, int yOffset, int xSize, int ySize, T[] data, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			if(xOffset < 0 || xOffset + xSize >= _width || yOffset < 0 || yOffset + ySize >= _height)
				throw new GLException("Image sub data out of bounds!");
			BindingHelper<Texture2D>.Push(this);
			GL.TexSubImage2D(TextureTarget, mipMapLevel, xOffset, yOffset, xSize, ySize, pf, pt, data);
			BindingHelper<Texture2D>.Pop();
		}
		
		public void TexImage<T>(int xSize, int ySize, T[,] data, PIF pif = PIF.Rgb, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			_width = xSize; _height = ySize; 
			BindingHelper<Texture2D>.Push(this);
			GL.TexImage2D(TextureTarget, mipMapLevel, pif, xSize, ySize, 0, pf, pt, data);
			BindingHelper<Texture2D>.Pop();
		}
		
		public void TexSubImage<T>(int xOffset, int yOffset, int xSize, int ySize, T[,] data, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			if(xOffset < 0 || xOffset + xSize >= _width || yOffset < 0 || yOffset + ySize >= _height)
				throw new GLException("Image sub data out of bounds!");
			BindingHelper<Texture2D>.Push(this);
			GL.TexSubImage2D(TextureTarget, mipMapLevel, xOffset, yOffset, xSize, ySize, pf, pt, data);
			BindingHelper<Texture2D>.Pop();
		}
		
		public void TexImage<T>(int xSize, int ySize, T[,,] data, PIF pif = PIF.Rgb, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			_width = xSize; _height = ySize; 
			BindingHelper<Texture2D>.Push(this);
			GL.TexImage2D(TextureTarget, mipMapLevel, pif, xSize, ySize, 0, pf, pt, data);
			BindingHelper<Texture2D>.Pop();
		}
		
		public void TexSubImage<T>(int xOffset, int yOffset, int xSize, int ySize, T[,,] data, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			if(xOffset < 0 || xOffset + xSize >= _width || yOffset < 0 || yOffset + ySize >= _height)
				throw new GLException("Image sub data out of bounds!");
			BindingHelper<Texture2D>.Push(this);
			GL.TexSubImage2D(TextureTarget, mipMapLevel, xOffset, yOffset, xSize, ySize, pf, pt, data);
			BindingHelper<Texture2D>.Pop();
		}
		
		public void SetTextureMagFilter(TextureMagFilter filter)
		{
			BindingHelper<Texture2D>.Use(this, t => GL.TexParameter(TextureTarget, TextureParameterName.TextureMagFilter, (int)filter));
		}

		public void SetTextureMinFilter(TextureMinFilter filter)
		{
			BindingHelper<Texture2D>.Use(this, t => GL.TexParameter(TextureTarget, TextureParameterName.TextureMinFilter, (int)filter));
		}

		public int[] GetSize()
		{
			return new[] { _width, _height };
		}

		public int GetWidth() 
		{
			return _width;
		}

		public int GetHeight() 
		{
			return _height;
		}
	}
	public class Texture3D : Texture
	{
		private int _width, _height, _depth;

		public Texture3D() : base(TextureTarget.Texture3D)
		{
		}

		public Texture3D(int defaultID) : base(TextureTarget.Texture3D, defaultID)
		{
		}		
		public void TexImage(int xSize, int ySize, int zSize, IntPtr data = default(IntPtr), PIF pif = PIF.Rgb, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0)
		{
			_width = xSize; _height = ySize; _depth = zSize; 
			BindingHelper<Texture3D>.Push(this);
			GL.TexImage3D(TextureTarget, mipMapLevel, pif, xSize, ySize, zSize, 0, pf, pt, data);
			BindingHelper<Texture3D>.Pop();
		}
		
		public void TexSubImage(int xOffset, int yOffset, int zOffset, int xSize, int ySize, int zSize, IntPtr data = default(IntPtr), PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0)
		{
			if(xOffset < 0 || xOffset + xSize >= _width || yOffset < 0 || yOffset + ySize >= _height || zOffset < 0 || zOffset + zSize >= _depth)
				throw new GLException("Image sub data out of bounds!");
			BindingHelper<Texture3D>.Push(this);
			GL.TexSubImage3D(TextureTarget, mipMapLevel, xOffset, yOffset, zOffset, xSize, ySize, zSize, pf, pt, data);
			BindingHelper<Texture3D>.Pop();
		}
		
		public void TexImage<T>(int xSize, int ySize, int zSize, ref T data, PIF pif = PIF.Rgb, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			_width = xSize; _height = ySize; _depth = zSize; 
			BindingHelper<Texture3D>.Push(this);
			GL.TexImage3D(TextureTarget, mipMapLevel, pif, xSize, ySize, zSize, 0, pf, pt, ref data);
			BindingHelper<Texture3D>.Pop();
		}
		
		public void TexSubImage<T>(int xOffset, int yOffset, int zOffset, int xSize, int ySize, int zSize, ref T data, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			if(xOffset < 0 || xOffset + xSize >= _width || yOffset < 0 || yOffset + ySize >= _height || zOffset < 0 || zOffset + zSize >= _depth)
				throw new GLException("Image sub data out of bounds!");
			BindingHelper<Texture3D>.Push(this);
			GL.TexSubImage3D(TextureTarget, mipMapLevel, xOffset, yOffset, zOffset, xSize, ySize, zSize, pf, pt, ref data);
			BindingHelper<Texture3D>.Pop();
		}
		
		public void TexImage<T>(int xSize, int ySize, int zSize, T[] data, PIF pif = PIF.Rgb, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			_width = xSize; _height = ySize; _depth = zSize; 
			BindingHelper<Texture3D>.Push(this);
			GL.TexImage3D(TextureTarget, mipMapLevel, pif, xSize, ySize, zSize, 0, pf, pt, data);
			BindingHelper<Texture3D>.Pop();
		}
		
		public void TexSubImage<T>(int xOffset, int yOffset, int zOffset, int xSize, int ySize, int zSize, T[] data, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			if(xOffset < 0 || xOffset + xSize >= _width || yOffset < 0 || yOffset + ySize >= _height || zOffset < 0 || zOffset + zSize >= _depth)
				throw new GLException("Image sub data out of bounds!");
			BindingHelper<Texture3D>.Push(this);
			GL.TexSubImage3D(TextureTarget, mipMapLevel, xOffset, yOffset, zOffset, xSize, ySize, zSize, pf, pt, data);
			BindingHelper<Texture3D>.Pop();
		}
		
		public void TexImage<T>(int xSize, int ySize, int zSize, T[,] data, PIF pif = PIF.Rgb, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			_width = xSize; _height = ySize; _depth = zSize; 
			BindingHelper<Texture3D>.Push(this);
			GL.TexImage3D(TextureTarget, mipMapLevel, pif, xSize, ySize, zSize, 0, pf, pt, data);
			BindingHelper<Texture3D>.Pop();
		}
		
		public void TexSubImage<T>(int xOffset, int yOffset, int zOffset, int xSize, int ySize, int zSize, T[,] data, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			if(xOffset < 0 || xOffset + xSize >= _width || yOffset < 0 || yOffset + ySize >= _height || zOffset < 0 || zOffset + zSize >= _depth)
				throw new GLException("Image sub data out of bounds!");
			BindingHelper<Texture3D>.Push(this);
			GL.TexSubImage3D(TextureTarget, mipMapLevel, xOffset, yOffset, zOffset, xSize, ySize, zSize, pf, pt, data);
			BindingHelper<Texture3D>.Pop();
		}
		
		public void TexImage<T>(int xSize, int ySize, int zSize, T[,,] data, PIF pif = PIF.Rgb, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			_width = xSize; _height = ySize; _depth = zSize; 
			BindingHelper<Texture3D>.Push(this);
			GL.TexImage3D(TextureTarget, mipMapLevel, pif, xSize, ySize, zSize, 0, pf, pt, data);
			BindingHelper<Texture3D>.Pop();
		}
		
		public void TexSubImage<T>(int xOffset, int yOffset, int zOffset, int xSize, int ySize, int zSize, T[,,] data, PF pf = PF.Rgb, PT pt = PT.UnsignedByte, int mipMapLevel = 0) where T : struct
		{
			if(xOffset < 0 || xOffset + xSize >= _width || yOffset < 0 || yOffset + ySize >= _height || zOffset < 0 || zOffset + zSize >= _depth)
				throw new GLException("Image sub data out of bounds!");
			BindingHelper<Texture3D>.Push(this);
			GL.TexSubImage3D(TextureTarget, mipMapLevel, xOffset, yOffset, zOffset, xSize, ySize, zSize, pf, pt, data);
			BindingHelper<Texture3D>.Pop();
		}
		
		public void SetTextureMagFilter(TextureMagFilter filter)
		{
			BindingHelper<Texture3D>.Use(this, t => GL.TexParameter(TextureTarget, TextureParameterName.TextureMagFilter, (int)filter));
		}

		public void SetTextureMinFilter(TextureMinFilter filter)
		{
			BindingHelper<Texture3D>.Use(this, t => GL.TexParameter(TextureTarget, TextureParameterName.TextureMinFilter, (int)filter));
		}

		public int[] GetSize()
		{
			return new[] { _width, _height, _depth };
		}

		public int GetWidth() 
		{
			return _width;
		}

		public int GetHeight() 
		{
			return _height;
		}

		public int GetDepth() 
		{
			return _depth;
		}
	}
}