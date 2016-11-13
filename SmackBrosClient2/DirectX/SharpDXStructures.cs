using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using SharpDX;
using SharpDX.D3DCompiler;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
using SharpDX.Windows;
using Assimp;
using Buffer = SharpDX.Direct3D11.Buffer;
using Device = SharpDX.Direct3D11.Device;
using MapFlags = SharpDX.Direct3D11.MapFlags;

namespace SmackBrosClient2.DirectX
{
    struct VertexShaderData
    {
        public Matrix worldViewProj;
        public Matrix worldView;
        public Matrix world;
    };

    struct PixelShaderData
    {
        public SharpDX.Vector4 lightPos;
    };
}
