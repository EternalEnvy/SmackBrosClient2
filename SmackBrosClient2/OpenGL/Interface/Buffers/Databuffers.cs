#if OPENGL4
using BT = OpenTK.Graphics.OpenGL4.BufferTarget;
#else
using BT = OpenTK.Graphics.OpenGL.BufferTarget;
#endif

namespace NeptuneRenderEngine.Engine.Interface.Buffers
{
#if OPENGL4
    public class ArrayBuffer : DBO<ArrayBuffer> { public ArrayBuffer() : base(BT.ArrayBuffer) { } }
    public class ElementArrayBuffer : DBO<ElementArrayBuffer> { public ElementArrayBuffer() : base(BT.ElementArrayBuffer) { } }
    public class PixelPackBuffer : DBO<PixelPackBuffer> { public PixelPackBuffer() : base(BT.PixelPackBuffer) { } }
    public class PixelUnpackBuffer : DBO<PixelUnpackBuffer> { public PixelUnpackBuffer() : base(BT.PixelUnpackBuffer) { } }
    public class UniformBuffer : DBO<UniformBuffer> { public UniformBuffer() : base(BT.UniformBuffer) { } }
    public class TextureBuffer : DBO<TextureBuffer> { public TextureBuffer() : base(BT.TextureBuffer) { } }
    public class TransformFeedbackBuffer : DBO<TransformFeedbackBuffer> { public TransformFeedbackBuffer() : base(BT.TransformFeedbackBuffer) { } }
    public class CopyReadBuffer : DBO<CopyReadBuffer> { public CopyReadBuffer() : base(BT.CopyReadBuffer) { } }
    public class CopyWriteBuffer : DBO<CopyWriteBuffer> { public CopyWriteBuffer() : base(BT.CopyWriteBuffer) { } }
    public class DrawIndirectBuffer : DBO<DrawIndirectBuffer> { public DrawIndirectBuffer() : base(BT.DrawIndirectBuffer) { } }
    public class ShaderStorageBuffer : DBO<ShaderStorageBuffer> { public ShaderStorageBuffer() : base(BT.ShaderStorageBuffer) { } }
    public class DispatchIndirectBuffer : DBO<DispatchIndirectBuffer> { public DispatchIndirectBuffer() : base(BT.DispatchIndirectBuffer) { } }
    public class QueryBuffer : DBO<QueryBuffer> { public QueryBuffer() : base(BT.QueryBuffer) { } }
    public class AtomicCounterBuffer : DBO<AtomicCounterBuffer> { public AtomicCounterBuffer() : base(BT.AtomicCounterBuffer) { } }
#else
    public class ArrayBuffer : DBO<ArrayBuffer> { public ArrayBuffer() : base(BT.ArrayBuffer) { } }
    public class ElementArrayBuffer : DBO<ElementArrayBuffer> { public ElementArrayBuffer() : base(BT.ElementArrayBuffer) { } }
    public class PixelPackBuffer : DBO<PixelPackBuffer> { public PixelPackBuffer() : base(BT.PixelPackBuffer) { } }
    public class PixelUnpackBuffer : DBO<PixelUnpackBuffer> { public PixelUnpackBuffer() : base(BT.PixelUnpackBuffer) { } }
    public class UniformBuffer : DBO<UniformBuffer> { public UniformBuffer() : base(BT.UniformBuffer) { } }
    public class TextureBuffer : DBO<TextureBuffer> { public TextureBuffer() : base(BT.TextureBuffer) { } }
    public class TransformFeedbackBuffer : DBO<TransformFeedbackBuffer> { public TransformFeedbackBuffer() : base(BT.TransformFeedbackBuffer) { } }
    public class CopyReadBuffer : DBO<CopyReadBuffer> { public CopyReadBuffer() : base(BT.CopyReadBuffer) { } }
    public class CopyWriteBuffer : DBO<CopyWriteBuffer> { public CopyWriteBuffer() : base(BT.CopyWriteBuffer) { } }
#endif
}