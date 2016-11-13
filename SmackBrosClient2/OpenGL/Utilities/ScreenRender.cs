using System;
using OpenTK;
#if OPENGL4
using OpenTK.Graphics.OpenGL4;
#else
using OpenTK.Graphics.OpenGL;
#endif
using NeptuneRenderEngine.Engine.Interface;
using NeptuneRenderEngine.Engine.Interface.Buffers;
using NeptuneRenderEngine.Engine.Interface.Data;
using NeptuneRenderEngine.Engine.Interface.Drawing;
using NeptuneRenderEngine.Engine.Interface.Shaders;

namespace NeptuneRenderEngine.Engine.Utilities
{
    public class ScreenRender
    {
        private ShaderProgram _shaderProgram;
        public ShaderProgram ShaderProgram
        {
            private get { return _shaderProgram; }
            set
            {
                _shaderProgram = value;
                UpdateLayout();
                UpdateUniformBindings();
            }
        }

        private string _modelViewName;
        public string ModelViewName
        {
            get { return _modelViewName; }
            set
            {
                _modelViewName = value;
                UpdateUniformBindings();
            }
        }

        private string _projectionName;
        public string ProjectionName
        {
            get { return _projectionName; }
            set
            {
                _projectionName = value;
                UpdateUniformBindings();
            }
        }

        public Matrix4 ModelviewMatrix { get; set; }
        public Matrix4 ProjectionMatrix { get; set; }

        public UniformBinding ModelviewBinding { get; private set; }
        public UniformBinding ProjectionBinding { get; private set; }

        private string _positionBindingName;
        public string PositionBindingName
        {
            get { return _positionBindingName; }
            set
            {
                _positionBindingName = value;
                UpdateLayout();
            }
        }

        private string _texcoordBindingName;
        public string TexcoordBindingName
        {
            get { return _texcoordBindingName; }
            set
            {
                _texcoordBindingName = value;
                UpdateLayout();
            }
        }

        public readonly VertexArray VertexArray = new VertexArray();
        public readonly ArrayBuffer VertexBuffer = new ArrayBuffer();
        private float _x = -1f, _y = -1f, _z, _w = 2f, _h = 2f;
        private int _length;

        public ScreenRender(ShaderProgram shaderProgram)
        {
            _shaderProgram = shaderProgram;
            _positionBindingName = "position";
            _texcoordBindingName = "texcoord";

            _modelViewName = "modelview";
            _projectionName = "projection";

            ModelviewMatrix = Matrix4.Identity;
            ProjectionMatrix = Matrix4.Identity;

            Update();
        }

        
        public void SetPosition(float x = -1f, float y = -1f, float z = 0f)
        {
            _x = x;
            _y = y;
            _z = z;
            Update();
        }

        public void SetSize(float width = 2f, float height = 2f)
        {
            _w = width;
            _h = height;
            Update();
        }

        private void Update()
        {
            var verts = new []
                {
                    new Vertex3f2f(_x, _y, _z, 0f, 0f), 
                    new Vertex3f2f(_x, _y+_h, _z, 0f, 1f), 
                    new Vertex3f2f(_x+_w, _y, _z, 1f, 0f), 
                    new Vertex3f2f(_x+_w, _y+_h, _z, 1f, 1f)
                };
            _length = verts.Length;
            VertexBuffer.BufferData(verts);
            UpdateLayout();
            UpdateUniformBindings();
        }

        private void UpdateUniformBindings()
        {
            ModelviewBinding = ShaderProgram.GetUniformBinding(_modelViewName);
            ProjectionBinding = ShaderProgram.GetUniformBinding(_projectionName);
        }

        private void UpdateLayout()
        {
            VertexArray.SetLayout(ShaderProgram, VertexBuffer, Vertex3f2f.GetBindings(PositionBindingName, TexcoordBindingName));
        }

        public void Render(Action pre, Action post)
        {
            BindingHelper<ArrayBuffer>.Push(VertexBuffer);
            BindingHelper<VertexArray>.Push(VertexArray);
            BindingHelper<ShaderProgram>.Push(_shaderProgram);
            if (ModelviewBinding != null) ModelviewBinding.Set(ModelviewMatrix);
            if (ProjectionBinding != null) ProjectionBinding.Set(ProjectionMatrix);
            pre();
#if OPENGL4
            GL.DrawArrays(PrimitiveType.TriangleStrip, 0, _length);
#else
            GL.DrawArrays(BeginMode.TriangleStrip, 0, _length);
#endif
            post();
            BindingHelper<ShaderProgram>.Pop();
            BindingHelper<VertexArray>.Pop();
            BindingHelper<ArrayBuffer>.Pop();
        }
    }
}
