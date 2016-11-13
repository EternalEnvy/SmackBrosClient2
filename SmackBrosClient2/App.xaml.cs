// Copyright (c) 2010-2012 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
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
using Buffer = SharpDX.Direct3D11.Buffer;
using Device = SharpDX.Direct3D11.Device;
using System.Windows;
using SharpDX.Mathematics.Interop;
using SmackBrosClient2.DirectX;

namespace SmackBrosClient2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        [STAThread]
        public static void Main()
        {
            var application = new App();
            application.InitializeComponent();
            application.Run();

            var form = new RenderForm("SharpDX - Load Mesh Sample");
            form.Width = 1280;
            form.Height = 720;

            // SwapChain description
            var desc = new SwapChainDescription()
            {
                BufferCount = 1,
                ModeDescription =
                    new ModeDescription(form.Width, form.Height,
                                        new Rational(60, 1), Format.R8G8B8A8_UNorm),
                IsWindowed = true,
                OutputHandle = form.Handle,
                SampleDescription = new SampleDescription(1, 0),
                SwapEffect = SwapEffect.Discard,
                Usage = Usage.RenderTargetOutput
            };

            // Create Device and SwapChain
            Device device;
            SwapChain swapChain;
            Device.CreateWithSwapChain(DriverType.Hardware, DeviceCreationFlags.Debug, desc, out device, out swapChain);
            var context = device.ImmediateContext;

            // Ignore all windows events
            var factory = swapChain.GetParent<Factory>();
            factory.MakeWindowAssociation(form.Handle, WindowAssociationFlags.IgnoreAll);

            // New RenderTargetView from the backbuffer
            var backBuffer = Texture2D.FromSwapChain<Texture2D>(swapChain, 0);
            var renderView = new RenderTargetView(device, backBuffer);

            //Load model
            String fileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "sponza/sponza.3ds");
            ModelLoader modelLoader = new ModelLoader(device);

            Model model = modelLoader.Load(fileName);

            // Compile Vertex and Pixel shaders
            var vertexShaderByteCode = ShaderBytecode.CompileFromFile("LoadMesh.fx", "VS", "vs_5_0");
            var vertexShader = new VertexShader(device, vertexShaderByteCode);

            var pixelShaderByteCode = ShaderBytecode.CompileFromFile("LoadMesh.fx", "PS", "ps_5_0");
            var pixelShader = new PixelShader(device, pixelShaderByteCode);

            model.SetInputLayout(device, ShaderSignature.GetInputSignature(vertexShaderByteCode) );

            // Create Depth Buffer & View
            var depthBuffer = new Texture2D(device, new Texture2DDescription()
            {
                Format = Format.D32_Float_S8X24_UInt,
                ArraySize = 1,
                MipLevels = 1,
                Width = form.Width,
                Height = form.Height,
                SampleDescription = new SampleDescription(1, 0),
                Usage = ResourceUsage.Default,
                BindFlags = BindFlags.DepthStencil,
                CpuAccessFlags = CpuAccessFlags.None,
                OptionFlags = ResourceOptionFlags.None
            });

            var depthView = new DepthStencilView(device, depthBuffer);

            //create sampler from texture
            var sampler = new SamplerState(device, new SamplerStateDescription()
            {
                Filter = Filter.MinMagMipLinear,
                AddressU = TextureAddressMode.Wrap,
                AddressV = TextureAddressMode.Wrap,
                AddressW = TextureAddressMode.Wrap,
                BorderColor = Color.Black,
                ComparisonFunction = Comparison.Never,
                MaximumAnisotropy = 16,
                MipLodBias = 0,
                MinimumLod = 0,
                MaximumLod = 16,
            });

            // Create Constant Buffers
            var vertexConstantBuffer = new Buffer(device, Utilities.SizeOf<VertexShaderData>(), ResourceUsage.Default, BindFlags.ConstantBuffer, CpuAccessFlags.None, ResourceOptionFlags.None, 0);
            var pixelConstantBuffer = new Buffer(device, Utilities.SizeOf<PixelShaderData>(), ResourceUsage.Default, BindFlags.ConstantBuffer, CpuAccessFlags.None, ResourceOptionFlags.None, 0);     

            // Prepare some of the stages. The others are mesh dependent and will be set later       
            context.VertexShader.Set(vertexShader);
            var viewport = new Viewport(0, 0, form.ClientSize.Width, form.ClientSize.Height, 0.0f, 1.0f);
            RawViewportF rawViewPort;
            rawViewPort.X = viewport.X;
            rawViewPort.Y = viewport.Y;
            rawViewPort.Height = viewport.Height;
            rawViewPort.Width = viewport.Width;
            rawViewPort.MinDepth = viewport.MinDepth;
            rawViewPort.MaxDepth = viewport.MaxDepth;
            RawViewportF[] k = {rawViewPort};
            context.Rasterizer.SetViewports(k);
            context.PixelShader.Set(pixelShader);
            context.PixelShader.SetSampler(0, sampler);
            context.OutputMerger.SetTargets(depthView, renderView);
            context.VertexShader.SetConstantBuffer(0, vertexConstantBuffer);
            context.PixelShader.SetConstantBuffer(0, pixelConstantBuffer);          

            //allocate data structs for the vertex and pixel constant buffers
            VertexShaderData vsData = new VertexShaderData();
            PixelShaderData psData = new PixelShaderData();

            //set light position
            psData.lightPos = new SharpDX.Vector4(0, 2.5f, 0, 0);

            //update pixel shader constant buffer. Only need to do this once.
            context.UpdateSubresource(ref psData, pixelConstantBuffer);

            // Calc projection matrix
            var proj = Matrix.PerspectiveFovLH((float)Math.PI / 4.0f, form.Width / (float)form.Height, 0.1f, 100.0f);

            // Use clock
            var clock = new Stopwatch();
            clock.Start();

            // Main loop
            RenderLoop.Run(form, () =>
            {
                var time = clock.ElapsedMilliseconds / 1000.0f;

                // Prepare matrices
                SharpDX.Vector3 cameraPosition = new SharpDX.Vector3(0, 3, 5.0f);
                SharpDX.Vector3 cameraLookAt = new SharpDX.Vector3(0, 2.0f, 0);

                //rotate camera
                Vector4 tempPos = SharpDX.Vector3.Transform(cameraPosition, Matrix.RotationY(0.2f * time));
                cameraPosition = new SharpDX.Vector3(tempPos.X, tempPos.Y, tempPos.Z);

                //calculate the view matrix 
                var view = Matrix.LookAtLH(cameraPosition, cameraLookAt, SharpDX.Vector3.UnitY);
                var viewProj = Matrix.Multiply(view, proj);

                // Clear views
                context.ClearDepthStencilView(depthView, DepthStencilClearFlags.Depth, 1.0f, 0);
                context.ClearRenderTargetView(renderView, Color.Black);

                // Update transformation matrices
                vsData.world = Matrix.Translation(0, -model.AABoxCentre.Y / 2, 0);
                vsData.worldView = vsData.world * view;
                vsData.worldViewProj = vsData.world * viewProj;

                //transpose matrices before sending them to the shader
                vsData.world.Transpose();
                vsData.worldView.Transpose();
                vsData.worldViewProj.Transpose();

                //update vertex shader constant buffer
                context.UpdateSubresource(ref vsData, vertexConstantBuffer);

                // Draw the cube
                model.Render(context);

                // Present
                swapChain.Present(0, PresentFlags.None);
            });

            // Release all resources
            model.Dispose();
            vertexShaderByteCode.Dispose();
            vertexShader.Dispose();
            pixelShaderByteCode.Dispose();
            pixelShader.Dispose();
            renderView.Dispose();
            backBuffer.Dispose();
            context.ClearState();
            context.Flush();
            device.Dispose();
            context.Dispose();
            swapChain.Dispose();
            factory.Dispose();

        }
    }

}
