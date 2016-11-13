using System;
using System.Collections.Generic;
using System.IO;
#if OPENGL4
using OpenTK.Graphics.OpenGL4;
#else
using OpenTK.Graphics.OpenGL;
#endif

namespace NeptuneRenderEngine.Engine.Interface.Shaders
{
    public class ShaderProgram : GLO
    {
        public ShaderProgram() : base("ShaderProgram")
        {
        }

        /// <summary>
        /// Create a Shader Program with shaders compiled and attached. Needs to be linked before usage.
        /// </summary>
        /// <param name="vertexFile">Path to vertex shader file</param>
        /// <param name="fragmentFile">Path to fragment shader file</param>
        public ShaderProgram(string vertexFile, string fragmentFile)
            : base("ShaderProgram")
        {
            Attach(CreateShader(vertexFile, ShaderType.VertexShader));
            Attach(CreateShader(fragmentFile, ShaderType.FragmentShader));
        }

        /// <summary>
        /// Create a Shader Program with shaders compiled and attached. Needs to be linked before usage.
        /// </summary>
        /// <param name="vertexFile">Path to vertex shader file</param>
        /// <param name="fragmentFile">Path to fragment shader file</param>
        /// <param name="geometryFile">Path to geometry shader file</param>
        public ShaderProgram(string vertexFile, string fragmentFile, string geometryFile)
            : base("ShaderProgram")
        {
            Attach(CreateShader(vertexFile, ShaderType.VertexShader));
            Attach(CreateShader(fragmentFile, ShaderType.FragmentShader));
            Attach(CreateShader(geometryFile, ShaderType.GeometryShader));
        }

        /// <summary>
        /// Create a Shader Program with shaders compiled and attached. Needs to be linked before usage.
#if !OPENGL4
        /// Obsolete when not compiled for OpenGL 4.
#endif
        /// </summary>
        /// <param name="vertexFile">Path to vertex shader file</param>
        /// <param name="fragmentFile">Path to fragment shader file</param>
        /// <param name="geometryFile">Path to geometry shader file</param>
        /// <param name="tessEvalFile">Path to tesselation evaluation shader file</param>
        /// <param name="tessControlFile">Path to tesselation control shader file</param>
#if !OPENGL4
        [Obsolete]
#endif
        public ShaderProgram(string vertexFile, string fragmentFile, string geometryFile, string tessEvalFile, string tessControlFile)
            : base("ShaderProgram")
        {
            Attach(CreateShader(vertexFile, ShaderType.VertexShader));
            Attach(CreateShader(fragmentFile, ShaderType.FragmentShader));
            Attach(CreateShader(geometryFile, ShaderType.GeometryShader));
#if OPENGL4
            Attach(CreateShader(tessEvalFile, ShaderType.TessEvaluationShader));
            Attach(CreateShader(tessControlFile, ShaderType.TessControlShader));
#endif
        }

        public Shader CreateShader(string path, ShaderType type)
        {
            var shader = new Shader(type);
            shader.SetSource(File.ReadAllText(path));
            shader.Compile();
            var log = shader.Log;
            if (!string.IsNullOrWhiteSpace(log))
                Console.WriteLine("{0} error: \n{1}", type, log);
            return shader;
        }

        private bool _needsRelinking = true;

        protected override int Generate()
        {
            return GL.CreateProgram();
        }

        public override void Delete()
        {
            GL.DeleteProgram(ID);
        }

        public override void Bind(int id)
        {
            GL.UseProgram(id);
        }

        public string Log
        {
            get
            {
                return GL.GetProgramInfoLog(ID);
            }
        }

        public bool NeedsRelinking
        {
            get { return _needsRelinking; } 
        }

        public void Attach(Shader shader)
        {
            GL.AttachShader(ID, shader.ID);
            _needsRelinking = true;
        }
        public void Attach(params Shader[] shaders)
        {
            foreach (var shader in shaders)
                GL.AttachShader(ID, shader.ID);
            _needsRelinking = true;
        }

        public void Detach(Shader shader)
        {
            GL.DetachShader(ID, shader.ID);
            _needsRelinking = true;
        }
        public void Detach(params Shader[] shaders)
        {
            foreach (var shader in shaders)
                GL.DetachShader(ID, shader.ID);
            _needsRelinking = true;
        }

        public void BindAttribLocation(string name, int position)
        {
            GL.BindAttribLocation(ID, position, name);
            _needsRelinking = true;
        }

        public void BindFragDataLocation(string name, int color)
        {
            GL.BindFragDataLocation(ID, color, name);
            _needsRelinking = true;
        }

        public void Link()
        {
            GL.LinkProgram(ID);
            _needsRelinking = false;

            foreach (var uniformBinding in _boundUniforms)
            {
                uniformBinding.Update();
            }
        }

        public int GetAttribLocation(string name)
        {
            return GL.GetAttribLocation(ID, name);
        }

        private readonly List<UniformBinding> _boundUniforms = new List<UniformBinding>(); 
        public UniformBinding GetUniformBinding(string name)
        {
            UniformBinding binding;
            GetUniformBinding(name, out binding);
            return binding;
        }

        public bool GetUniformBinding(string name, out UniformBinding binding)
        {
            int pos = -1;
            binding = null;
            
            BindingHelper<ShaderProgram>.Use(this, program => { pos = GL.GetUniformLocation(program.ID, name); });

            binding = new UniformBinding(name, pos, this);
            _boundUniforms.Add(binding);
            return pos >= 0;
        }
    }
}
