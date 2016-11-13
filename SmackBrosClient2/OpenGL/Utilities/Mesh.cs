using System;
#if OPENGL4
using OpenTK.Graphics.OpenGL4;
#else
using OpenTK.Graphics.OpenGL;
#endif
using NeptuneRenderEngine.Engine.Interface.Buffers;
using NeptuneRenderEngine.Engine.Interface.Data;
using NeptuneRenderEngine.Engine.Interface.Drawing;

namespace NeptuneRenderEngine.Engine.Utilities
{
    public struct MeshSubData
    {
        public int Start, End;
    }

    public class Mesh
    {
        public readonly ArrayBuffer VertexBuffer = new ArrayBuffer();

        public MeshSubData[] SubDatas { get; private set; }
        public int Length { get; private set; }

        public Mesh()
        {
            SubDatas = new MeshSubData[0];
        }

        public void SetData(Vertex3f3f2f[] data, params MeshSubData[] subDatas)
        {
            Console.WriteLine(Vertex3f3f2f.Size + ", " + data.Length);
            Length = data.Length;
            VertexBuffer.BufferData(Vertex3f3f2f.Size, data, BufferUsageHint.StaticDraw);
        }

        public VaoBinding[] GetBindings(string positionName, string normalName, string texcoordName)
        {
            return Vertex3f3f2f.GetBindings(positionName, normalName, texcoordName);
        }
    }
}
