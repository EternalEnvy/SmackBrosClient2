using System;
using System.Runtime.InteropServices;
#if OPENGL4
using OpenTK.Graphics.OpenGL4;
#else
using OpenTK.Graphics.OpenGL;
#endif

namespace NeptuneRenderEngine.Engine.Interface.Buffers
{
    public abstract class DBO<T> : GLO where T : DBO<T>, new()
    {
        public readonly BufferTarget BufferTarget;

        protected DBO(BufferTarget bufferTarget, int defaultID = 0)
            : base(bufferTarget.ToString(), defaultID)
        {
            BufferTarget = bufferTarget;
        }

        protected override int Generate()
        {
            int i;
            GL.GenBuffers(1, out i);
            return i;
        }

        public override void Delete()
        {
#if OPENGL4
            GL.DeleteBuffer(ID);
#else
            GL.DeleteBuffers(1, new[] { ID });
#endif
        }

        public override void Bind(int id)
        {
            //if (GLStates.GetState_BindBuffer(BufferTarget) == id) return;
            GL.BindBuffer(BufferTarget, id);
        }

        public void BufferData(int size, IntPtr data, BufferUsageHint usageHint)
        {
            BindingHelper<T>.Use((T)this, obj => GL.BufferData(BufferTarget, new IntPtr(size), data, usageHint));
        }

        public void BufferData<T2>(T2[] data, BufferUsageHint usageHint) where T2 : struct
        {
            int elementSize = Marshal.SizeOf(default(T2));
            BindingHelper<T>.Use((T)this, obj => GL.BufferData(BufferTarget, new IntPtr(elementSize * data.Length), data, usageHint));
        }

        public void BufferData<T2>(int elementSize, T2[] data, BufferUsageHint usageHint) where T2 : struct
        {
            BindingHelper<T>.Use((T)this, obj => GL.BufferData(BufferTarget, new IntPtr(elementSize * data.Length), data, usageHint));
        }

        public void BufferData<T2>(T2[,] data, BufferUsageHint usageHint) where T2 : struct
        {
            int elementSize = Marshal.SizeOf(default(T2));
            BindingHelper<T>.Use((T)this, obj => GL.BufferData(BufferTarget, new IntPtr(elementSize * data.Length), data, usageHint));
        }

        public void BufferData<T2>(int elementSize, T2[,] data, BufferUsageHint usageHint) where T2 : struct
        {
            BindingHelper<T>.Use((T)this, obj => GL.BufferData(BufferTarget, new IntPtr(elementSize * data.Length), data, usageHint));
        }

        public void BufferData<T2>(T2[,,] data, BufferUsageHint usageHint) where T2 : struct
        {
            int elementSize = Marshal.SizeOf(default(T2));
            BindingHelper<T>.Use((T)this, obj => GL.BufferData(BufferTarget, new IntPtr(elementSize * data.Length), data, usageHint));
        }

        public void BufferData<T2>(int elementSize, T2[,,] data, BufferUsageHint usageHint) where T2 : struct
        {
            BindingHelper<T>.Use((T)this, obj => GL.BufferData(BufferTarget, new IntPtr(elementSize * data.Length), data, usageHint));
        }
    }
}
