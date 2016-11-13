using System;
using System.IO;
#if OPENGL4
using OpenTK.Graphics.OpenGL4;
#else
using OpenTK.Graphics.OpenGL;
#endif
using NeptuneRenderEngine.Engine.Interface.Shaders;
using NeptuneRenderEngine.Engine.Utilities.IO;

namespace NeptuneRenderEngine.Engine.Abstraction
{
    public class DynamicShader : ShaderProgram
    {
        private Tuple<FileListener, Shader>[] _shaders;

        public DynamicShader()
        {
        }

        public DynamicShader(string vertexFile, string fragmentFile)
        {
            _shaders = new[]
                    {
                        new Tuple<FileListener, Shader>(new FileListener(vertexFile), CreateShader(vertexFile, ShaderType.VertexShader)), 
                        new Tuple<FileListener, Shader>(new FileListener(fragmentFile), CreateShader(fragmentFile, ShaderType.FragmentShader))
                    };
            foreach (var shd in _shaders)
                Attach(shd.Item2);
        }

        public DynamicShader(string vertexFile, string fragmentFile, string geometryFile)
        {
            _shaders = new[]
                    {
                        new Tuple<FileListener, Shader>(new FileListener(vertexFile), CreateShader(vertexFile, ShaderType.VertexShader)), 
                        new Tuple<FileListener, Shader>(new FileListener(fragmentFile), CreateShader(fragmentFile, ShaderType.FragmentShader)), 
                        new Tuple<FileListener, Shader>(new FileListener(geometryFile), CreateShader(geometryFile, ShaderType.GeometryShader))
                    };
            foreach (var shd in _shaders)
                Attach(shd.Item2);
        }
        
#if !OPENGL4
        /// <summary>
        /// Obsolete when not compiled for OpenGL 4.
        /// </summary>
        /// <param name="vertexFile">Path to vertex shader file</param>
        /// <param name="fragmentFile">Path to fragment shader file</param>
        /// <param name="geometryFile">Path to geometry shader file</param>
        /// <param name="tessEvalFile">Path to tesselation evaluation shader file</param>
        /// <param name="tessControlFile">Path to tesselation control shader file</param>
        [Obsolete]
#endif
        public DynamicShader(string vertexFile, string fragmentFile, string geometryFile, string tessEvalFile, string tessControlFile)
        {
#if OPENGL4
            _shaders = new[]
                    {
                        new Tuple<FileListener, Shader>(new FileListener(vertexFile), CreateShader(vertexFile, ShaderType.VertexShader)), 
                        new Tuple<FileListener, Shader>(new FileListener(fragmentFile), CreateShader(fragmentFile, ShaderType.FragmentShader)), 
                        new Tuple<FileListener, Shader>(new FileListener(geometryFile), CreateShader(geometryFile, ShaderType.GeometryShader)), 
                        new Tuple<FileListener, Shader>(new FileListener(tessEvalFile), CreateShader(tessEvalFile, ShaderType.TessEvaluationShader)), 
                        new Tuple<FileListener, Shader>(new FileListener(tessControlFile), CreateShader(tessControlFile, ShaderType.TessControlShader))
                    };
#else
            _shaders = new[]
                    {
                        new Tuple<FileListener, Shader>(new FileListener(vertexFile), CreateShader(vertexFile, ShaderType.VertexShader)), 
                        new Tuple<FileListener, Shader>(new FileListener(fragmentFile), CreateShader(fragmentFile, ShaderType.FragmentShader)), 
                        new Tuple<FileListener, Shader>(new FileListener(geometryFile), CreateShader(geometryFile, ShaderType.GeometryShader))
                    };
#endif
            foreach (var shd in _shaders)
                Attach(shd.Item2);
        }

        public bool CheckUpdate()
        {
            bool updated = false;
            foreach (var tuple in _shaders)
            {
                if (tuple.Item1 == null) continue;
                if (!tuple.Item1.Check()) continue;
                tuple.Item1.Reset();
                Detach(tuple.Item2);
                tuple.Item2.Regenerate();
                tuple.Item2.SetSource(File.ReadAllText(tuple.Item1.FullPath));
                tuple.Item2.Compile();
                Attach(tuple.Item2);
                var log = tuple.Item2.Log;
                if (!string.IsNullOrWhiteSpace(log))
                    Console.WriteLine("{0} error: \n{1}", tuple.Item2.ShaderType, log);
                updated = true;
            }
            if (updated)
            {
                Link();
                var log = Log;
                if (!string.IsNullOrWhiteSpace(log)) Console.WriteLine("Program relink error: {0}", log);
            }
            return updated;
        }
    }
}
