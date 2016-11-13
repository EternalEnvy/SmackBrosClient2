using NeptuneRenderEngine.Engine.Interface.Buffers;
using NeptuneRenderEngine.Engine.Interface.Drawing;
#if OPENGL4
using BUH = OpenTK.Graphics.OpenGL4.BufferUsageHint;
using VAPT = OpenTK.Graphics.OpenGL4.VertexAttribPointerType;
#else
using BUH = OpenTK.Graphics.OpenGL.BufferUsageHint;
using VAPT = OpenTK.Graphics.OpenGL.VertexAttribPointerType;
#endif

namespace NeptuneRenderEngine.Engine.Interface.Data
{
// ReSharper disable CheckNamespace
// ReSharper disable InconsistentNaming
	public struct Vertex2f
	{
		public float x0;
		public float y0;

		public static readonly int Size = 8;

		public Vertex2f(float x0, float y0)
	    {
			this.x0 = x0;
			this.y0 = y0;
		}
	
		public static VaoBinding[] GetBindings(string float0name)
		{
			return new [] 
			{ 
				new VaoBinding{ Length = 2, PointerType = VAPT.Float, ShaderName = float0name }
			};
		}
	}		
	 
	public struct Vertex2f2f
	{
		public float x0;
		public float y0;
		public float x1;
		public float y1;

		public static readonly int Size = 16;

		public Vertex2f2f(float x0, float y0, float x1, float y1)
	    {
			this.x0 = x0;
			this.y0 = y0;
			this.x1 = x1;
			this.y1 = y1;
		}
	
		public static VaoBinding[] GetBindings(string float0name, string float1name)
		{
			return new [] 
			{ 
				new VaoBinding{ Length = 2, PointerType = VAPT.Float, ShaderName = float0name },
				new VaoBinding{ Length = 2, PointerType = VAPT.Float, ShaderName = float1name }
			};
		}
	}		
	 
	public struct Vertex3f2f
	{
		public float x0;
		public float y0;
		public float z0;
		public float u0;
		public float v0;

		public static readonly int Size = 20;

		public Vertex3f2f(float x0, float y0, float z0, float u0, float v0)
	    {
			this.x0 = x0;
			this.y0 = y0;
			this.z0 = z0;
			this.u0 = u0;
			this.v0 = v0;
		}
	
		public static VaoBinding[] GetBindings(string float0name, string float1name)
		{
			return new [] 
			{ 
				new VaoBinding{ Length = 3, PointerType = VAPT.Float, ShaderName = float0name },
				new VaoBinding{ Length = 2, PointerType = VAPT.Float, ShaderName = float1name }
			};
		}
	}		
	 
	public struct Vertex3f3f
	{
		public float x0;
		public float y0;
		public float z0;
		public float x1;
		public float y1;
		public float z1;

		public static readonly int Size = 24;

		public Vertex3f3f(float x0, float y0, float z0, float x1, float y1, float z1)
	    {
			this.x0 = x0;
			this.y0 = y0;
			this.z0 = z0;
			this.x1 = x1;
			this.y1 = y1;
			this.z1 = z1;
		}
	
		public static VaoBinding[] GetBindings(string float0name, string float1name)
		{
			return new [] 
			{ 
				new VaoBinding{ Length = 3, PointerType = VAPT.Float, ShaderName = float0name },
				new VaoBinding{ Length = 3, PointerType = VAPT.Float, ShaderName = float1name }
			};
		}
	}		
	 
	public struct Vertex3f3f2f
	{
		public float x0;
		public float y0;
		public float z0;
		public float x1;
		public float y1;
		public float z1;
		public float u0;
		public float v0;

		public static readonly int Size = 32;

		public Vertex3f3f2f(float x0, float y0, float z0, float x1, float y1, float z1, float u0, float v0)
	    {
			this.x0 = x0;
			this.y0 = y0;
			this.z0 = z0;
			this.x1 = x1;
			this.y1 = y1;
			this.z1 = z1;
			this.u0 = u0;
			this.v0 = v0;
		}
	
		public static VaoBinding[] GetBindings(string float0name, string float1name, string float2name)
		{
			return new [] 
			{ 
				new VaoBinding{ Length = 3, PointerType = VAPT.Float, ShaderName = float0name },
				new VaoBinding{ Length = 3, PointerType = VAPT.Float, ShaderName = float1name },
				new VaoBinding{ Length = 2, PointerType = VAPT.Float, ShaderName = float2name }
			};
		}
	}		
	 
	public struct Vertex3ui3ui2f
	{
		public uint ui0;
		public uint ui1;
		public uint ui2;
		public uint ui3;
		public uint ui4;
		public uint ui5;
		public float f6;
		public float f7;

		public static readonly int Size = 32;

		public Vertex3ui3ui2f(uint ui0, uint ui1, uint ui2, uint ui3, uint ui4, uint ui5, float f6, float f7)
	    {
			this.ui0 = ui0;
			this.ui1 = ui1;
			this.ui2 = ui2;
			this.ui3 = ui3;
			this.ui4 = ui4;
			this.ui5 = ui5;
			this.f6 = f6;
			this.f7 = f7;
		}
	
		public static VaoBinding[] GetBindings(string unsignedint0name, string unsignedint1name, string float2name)
		{
			return new [] 
			{ 
				new VaoBinding{ Length = 3, PointerType = VAPT.UnsignedInt, ShaderName = unsignedint0name },
				new VaoBinding{ Length = 3, PointerType = VAPT.UnsignedInt, ShaderName = unsignedint1name },
				new VaoBinding{ Length = 2, PointerType = VAPT.Float, ShaderName = float2name }
			};
		}
	}		
	 
	public struct Vertex2f2ui
	{
		public float x0;
		public float y0;
		public uint x1;
		public uint y1;

		public static readonly int Size = 16;

		public Vertex2f2ui(float x0, float y0, uint x1, uint y1)
	    {
			this.x0 = x0;
			this.y0 = y0;
			this.x1 = x1;
			this.y1 = y1;
		}
	
		public static VaoBinding[] GetBindings(string float0name, string unsignedint1name)
		{
			return new [] 
			{ 
				new VaoBinding{ Length = 2, PointerType = VAPT.Float, ShaderName = float0name },
				new VaoBinding{ Length = 2, PointerType = VAPT.UnsignedInt, ShaderName = unsignedint1name }
			};
		}
	}		
	 
	public struct Vertex2f2i
	{
		public float x0;
		public float y0;
		public int x1;
		public int y1;

		public static readonly int Size = 16;

		public Vertex2f2i(float x0, float y0, int x1, int y1)
	    {
			this.x0 = x0;
			this.y0 = y0;
			this.x1 = x1;
			this.y1 = y1;
		}
	
		public static VaoBinding[] GetBindings(string float0name, string int1name)
		{
			return new [] 
			{ 
				new VaoBinding{ Length = 2, PointerType = VAPT.Float, ShaderName = float0name },
				new VaoBinding{ Length = 2, PointerType = VAPT.Int, ShaderName = int1name }
			};
		}
	}		
	 
	public static class BufferVertexExtension
	{
		public static void BufferData(this ArrayBuffer buffer, Vertex2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f.Size, data, hint); }
		public static void BufferData(this ArrayBuffer buffer, Vertex2f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2f.Size, data, hint); }
		public static void BufferData(this ArrayBuffer buffer, Vertex3f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f2f.Size, data, hint); }
		public static void BufferData(this ArrayBuffer buffer, Vertex3f3f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f3f.Size, data, hint); }
		public static void BufferData(this ArrayBuffer buffer, Vertex3f3f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f3f2f.Size, data, hint); }
		public static void BufferData(this ArrayBuffer buffer, Vertex3ui3ui2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3ui3ui2f.Size, data, hint); }
		public static void BufferData(this ArrayBuffer buffer, Vertex2f2ui[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2ui.Size, data, hint); }
		public static void BufferData(this ArrayBuffer buffer, Vertex2f2i[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2i.Size, data, hint); }

		public static void BufferData(this ElementArrayBuffer buffer, Vertex2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f.Size, data, hint); }
		public static void BufferData(this ElementArrayBuffer buffer, Vertex2f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2f.Size, data, hint); }
		public static void BufferData(this ElementArrayBuffer buffer, Vertex3f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f2f.Size, data, hint); }
		public static void BufferData(this ElementArrayBuffer buffer, Vertex3f3f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f3f.Size, data, hint); }
		public static void BufferData(this ElementArrayBuffer buffer, Vertex3f3f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f3f2f.Size, data, hint); }
		public static void BufferData(this ElementArrayBuffer buffer, Vertex3ui3ui2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3ui3ui2f.Size, data, hint); }
		public static void BufferData(this ElementArrayBuffer buffer, Vertex2f2ui[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2ui.Size, data, hint); }
		public static void BufferData(this ElementArrayBuffer buffer, Vertex2f2i[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2i.Size, data, hint); }

		public static void BufferData(this PixelPackBuffer buffer, Vertex2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f.Size, data, hint); }
		public static void BufferData(this PixelPackBuffer buffer, Vertex2f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2f.Size, data, hint); }
		public static void BufferData(this PixelPackBuffer buffer, Vertex3f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f2f.Size, data, hint); }
		public static void BufferData(this PixelPackBuffer buffer, Vertex3f3f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f3f.Size, data, hint); }
		public static void BufferData(this PixelPackBuffer buffer, Vertex3f3f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f3f2f.Size, data, hint); }
		public static void BufferData(this PixelPackBuffer buffer, Vertex3ui3ui2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3ui3ui2f.Size, data, hint); }
		public static void BufferData(this PixelPackBuffer buffer, Vertex2f2ui[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2ui.Size, data, hint); }
		public static void BufferData(this PixelPackBuffer buffer, Vertex2f2i[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2i.Size, data, hint); }

		public static void BufferData(this PixelUnpackBuffer buffer, Vertex2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f.Size, data, hint); }
		public static void BufferData(this PixelUnpackBuffer buffer, Vertex2f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2f.Size, data, hint); }
		public static void BufferData(this PixelUnpackBuffer buffer, Vertex3f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f2f.Size, data, hint); }
		public static void BufferData(this PixelUnpackBuffer buffer, Vertex3f3f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f3f.Size, data, hint); }
		public static void BufferData(this PixelUnpackBuffer buffer, Vertex3f3f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f3f2f.Size, data, hint); }
		public static void BufferData(this PixelUnpackBuffer buffer, Vertex3ui3ui2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3ui3ui2f.Size, data, hint); }
		public static void BufferData(this PixelUnpackBuffer buffer, Vertex2f2ui[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2ui.Size, data, hint); }
		public static void BufferData(this PixelUnpackBuffer buffer, Vertex2f2i[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2i.Size, data, hint); }

		public static void BufferData(this UniformBuffer buffer, Vertex2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f.Size, data, hint); }
		public static void BufferData(this UniformBuffer buffer, Vertex2f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2f.Size, data, hint); }
		public static void BufferData(this UniformBuffer buffer, Vertex3f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f2f.Size, data, hint); }
		public static void BufferData(this UniformBuffer buffer, Vertex3f3f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f3f.Size, data, hint); }
		public static void BufferData(this UniformBuffer buffer, Vertex3f3f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f3f2f.Size, data, hint); }
		public static void BufferData(this UniformBuffer buffer, Vertex3ui3ui2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3ui3ui2f.Size, data, hint); }
		public static void BufferData(this UniformBuffer buffer, Vertex2f2ui[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2ui.Size, data, hint); }
		public static void BufferData(this UniformBuffer buffer, Vertex2f2i[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2i.Size, data, hint); }

		public static void BufferData(this TextureBuffer buffer, Vertex2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f.Size, data, hint); }
		public static void BufferData(this TextureBuffer buffer, Vertex2f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2f.Size, data, hint); }
		public static void BufferData(this TextureBuffer buffer, Vertex3f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f2f.Size, data, hint); }
		public static void BufferData(this TextureBuffer buffer, Vertex3f3f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f3f.Size, data, hint); }
		public static void BufferData(this TextureBuffer buffer, Vertex3f3f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f3f2f.Size, data, hint); }
		public static void BufferData(this TextureBuffer buffer, Vertex3ui3ui2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3ui3ui2f.Size, data, hint); }
		public static void BufferData(this TextureBuffer buffer, Vertex2f2ui[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2ui.Size, data, hint); }
		public static void BufferData(this TextureBuffer buffer, Vertex2f2i[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2i.Size, data, hint); }

		public static void BufferData(this TransformFeedbackBuffer buffer, Vertex2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f.Size, data, hint); }
		public static void BufferData(this TransformFeedbackBuffer buffer, Vertex2f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2f.Size, data, hint); }
		public static void BufferData(this TransformFeedbackBuffer buffer, Vertex3f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f2f.Size, data, hint); }
		public static void BufferData(this TransformFeedbackBuffer buffer, Vertex3f3f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f3f.Size, data, hint); }
		public static void BufferData(this TransformFeedbackBuffer buffer, Vertex3f3f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f3f2f.Size, data, hint); }
		public static void BufferData(this TransformFeedbackBuffer buffer, Vertex3ui3ui2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3ui3ui2f.Size, data, hint); }
		public static void BufferData(this TransformFeedbackBuffer buffer, Vertex2f2ui[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2ui.Size, data, hint); }
		public static void BufferData(this TransformFeedbackBuffer buffer, Vertex2f2i[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2i.Size, data, hint); }

		public static void BufferData(this CopyReadBuffer buffer, Vertex2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f.Size, data, hint); }
		public static void BufferData(this CopyReadBuffer buffer, Vertex2f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2f.Size, data, hint); }
		public static void BufferData(this CopyReadBuffer buffer, Vertex3f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f2f.Size, data, hint); }
		public static void BufferData(this CopyReadBuffer buffer, Vertex3f3f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f3f.Size, data, hint); }
		public static void BufferData(this CopyReadBuffer buffer, Vertex3f3f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f3f2f.Size, data, hint); }
		public static void BufferData(this CopyReadBuffer buffer, Vertex3ui3ui2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3ui3ui2f.Size, data, hint); }
		public static void BufferData(this CopyReadBuffer buffer, Vertex2f2ui[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2ui.Size, data, hint); }
		public static void BufferData(this CopyReadBuffer buffer, Vertex2f2i[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2i.Size, data, hint); }

		public static void BufferData(this CopyWriteBuffer buffer, Vertex2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f.Size, data, hint); }
		public static void BufferData(this CopyWriteBuffer buffer, Vertex2f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2f.Size, data, hint); }
		public static void BufferData(this CopyWriteBuffer buffer, Vertex3f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f2f.Size, data, hint); }
		public static void BufferData(this CopyWriteBuffer buffer, Vertex3f3f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f3f.Size, data, hint); }
		public static void BufferData(this CopyWriteBuffer buffer, Vertex3f3f2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3f3f2f.Size, data, hint); }
		public static void BufferData(this CopyWriteBuffer buffer, Vertex3ui3ui2f[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex3ui3ui2f.Size, data, hint); }
		public static void BufferData(this CopyWriteBuffer buffer, Vertex2f2ui[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2ui.Size, data, hint); }
		public static void BufferData(this CopyWriteBuffer buffer, Vertex2f2i[] data, BUH hint = BUH.StaticDraw) { buffer.BufferData(Vertex2f2i.Size, data, hint); }

	}	
// ReSharper restore CheckNamespace
// ReSharper restore InconsistentNaming
}

