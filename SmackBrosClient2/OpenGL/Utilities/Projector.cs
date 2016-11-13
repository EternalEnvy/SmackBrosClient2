using System;
using OpenTK;
#if OPENGL4
using OpenTK.Graphics.OpenGL4;
#else
using OpenTK.Graphics.OpenGL;
#endif
using NeptuneRenderEngine.Engine.Interface;
using NeptuneRenderEngine.Engine.Interface.Buffers;
using NeptuneRenderEngine.Engine.Interface.Shaders;

namespace NeptuneRenderEngine.Engine.Utilities
{
    public class Projector
    {
        public Matrix4 ModelViewMatrix = Matrix4.Identity;
        public Matrix4 ProjectionMatrix = Matrix4.Identity;
        public Matrix4 InverseModelViewMatrix = Matrix4.Identity;
        public Matrix4 InverseProjectionMatrix = Matrix4.Identity;
        public Matrix4 InverseModelViewProjectionMatrix = Matrix4.Identity;
        public Matrix4 ModelViewProjectionMatrix = Matrix4.Identity;

        public Framebuffer Framebuffer;

        public int Width;
        public int Height;
        public float NearZ;
        public float FarZ;

        private ShaderProgram _program;
        private UniformBinding _mvBinding;
        private UniformBinding _mvpBinding;
        private UniformBinding _projBinding;

        public void SetModelView(Matrix4 matrix)
        {
            ModelViewMatrix = matrix;
            Matrix4.Mult(ref ProjectionMatrix, ref ModelViewMatrix, out ModelViewProjectionMatrix);
#if OPENGL4
            Matrix4.Invert(ref ModelViewMatrix, out InverseModelViewMatrix);
            Matrix4.Invert(ref ModelViewProjectionMatrix, out InverseModelViewProjectionMatrix);
#else
            InverseModelViewMatrix = Matrix4.Invert(ModelViewMatrix);
            InverseModelViewProjectionMatrix = Matrix4.Invert(ModelViewProjectionMatrix);
#endif
        }

        public void SetModelView(Vector3 origin, float pitch, float yaw, float roll = 0f)
        {
            var lookat = new Vector3
            {
                X = (float)(Math.Sin(pitch) * Math.Cos(yaw)),
                Y = (float)Math.Sin(yaw),
                Z = (float)(Math.Cos(pitch) * Math.Cos(yaw))
            };
            SetModelView(origin, origin + lookat, roll);
        }

        public void SetModelView(Vector3 origin, Vector3 target, float roll = 0f)
        {
            var forward = origin - target;
            forward.Normalize();

            ModelViewMatrix = Matrix4.LookAt(origin, target, Vector3.Transform(Vector3.UnitY, Matrix4.CreateFromAxisAngle(forward, roll)));
            Matrix4.Mult(ref ModelViewMatrix, ref ProjectionMatrix, out ModelViewProjectionMatrix);
#if OPENGL4
            Matrix4.Invert(ref ModelViewMatrix, out InverseModelViewMatrix);
#else
            InverseModelViewMatrix = Matrix4.Invert(ModelViewMatrix);
#endif
            InverseModelViewProjectionMatrix = Matrix4.Mult(InverseProjectionMatrix, InverseModelViewMatrix);
        }

        public void SetProjection(float fov)
        {
            const float degtorad = (float)(Math.PI / 180.0);
            ProjectionMatrix = Matrix4.CreatePerspectiveFieldOfView(degtorad * fov, Width / (float)Height, NearZ, FarZ);
            Matrix4.Mult(ref ModelViewMatrix, ref ProjectionMatrix, out ModelViewProjectionMatrix);
#if OPENGL4
            Matrix4.Invert(ref ProjectionMatrix, out InverseProjectionMatrix);
#else
            InverseProjectionMatrix = Matrix4.Invert(ProjectionMatrix);
#endif
            InverseModelViewProjectionMatrix = Matrix4.Mult(InverseProjectionMatrix, InverseModelViewMatrix);
        }

        public void SetShader(ShaderProgram program, UniformBinding modelViewMatrixBinding, UniformBinding projectionMatrixBinding, UniformBinding modelviewProjectionMatrixBinding = null)
        {
            _program = program;
            _mvBinding = modelViewMatrixBinding;
            _projBinding = projectionMatrixBinding;
            _mvpBinding = modelviewProjectionMatrixBinding;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="action">Action to render.</param>
        public void Render(Action<ShaderProgram> action)
        {
            GL.Viewport(0, 0, Width, Height);
            BindingHelper<Framebuffer>.Push(Framebuffer);
            BindingHelper<ShaderProgram>.Push(_program);
            _mvBinding.Set(ref ModelViewMatrix);
            _projBinding.Set(ref ProjectionMatrix);
            if(_mvpBinding != null) _mvpBinding.Set(ModelViewProjectionMatrix);
            if(Framebuffer != null && Framebuffer.ID > 0) GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            action(_program);
            BindingHelper<ShaderProgram>.Pop();
            BindingHelper<Framebuffer>.Pop();
        }
    }
}
