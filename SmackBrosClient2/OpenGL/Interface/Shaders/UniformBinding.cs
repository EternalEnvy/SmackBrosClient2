
using System.Collections.Generic;
using OpenTK;
#if OPENGL4
using OpenTK.Graphics.OpenGL4;
#else
using OpenTK.Graphics.OpenGL;
#endif


namespace NeptuneRenderEngine.Engine.Interface.Shaders
{
	public class UniformBinding
	{
		public readonly string Name;
		public int Position { get; private set; }
		private readonly ShaderProgram _program;

		public UniformBinding(string name, int pos, ShaderProgram program)
		{
			Name = name;
			Position = pos;
			_program = program;
		}

        public void Update()
        {
            BindingHelper<ShaderProgram>.Use(_program, program => { Position = GL.GetUniformLocation(program.ID, Name); });
        }

		public void Set(int int0)
		{
			if(Position < 0) return;
			BindingHelper<ShaderProgram>.Use(_program, program => GL.Uniform1(Position, int0));
		}

		public void Set(uint uint0)
		{
			if(Position < 0) return;
			BindingHelper<ShaderProgram>.Use(_program, program => GL.Uniform1(Position, uint0));
		}

		public void Set(float float0)
		{
			if(Position < 0) return;
			BindingHelper<ShaderProgram>.Use(_program, program => GL.Uniform1(Position, float0));
		}

		public void Set(int int0, int int1)
		{
			if(Position < 0) return;
			BindingHelper<ShaderProgram>.Use(_program, program => GL.Uniform2(Position, int0, int1));
		}

		public void Set(uint uint0, uint uint1)
		{
			if(Position < 0) return;
			BindingHelper<ShaderProgram>.Use(_program, program => GL.Uniform2(Position, uint0, uint1));
		}

		public void Set(float float0, float float1)
		{
			if(Position < 0) return;
			BindingHelper<ShaderProgram>.Use(_program, program => GL.Uniform2(Position, float0, float1));
		}

		public void Set(Vector2 vector2)
		{
			if(Position < 0) return;
			BindingHelper<ShaderProgram>.Use(_program, program => GL.Uniform2(Position, vector2));
		}

		public void Set(int int0, int int1, int int2)
		{
			if(Position < 0) return;
			BindingHelper<ShaderProgram>.Use(_program, program => GL.Uniform3(Position, int0, int1, int2));
		}

		public void Set(uint uint0, uint uint1, uint uint2)
		{
			if(Position < 0) return;
			BindingHelper<ShaderProgram>.Use(_program, program => GL.Uniform3(Position, uint0, uint1, uint2));
		}

		public void Set(float float0, float float1, float float2)
		{
			if(Position < 0) return;
			BindingHelper<ShaderProgram>.Use(_program, program => GL.Uniform3(Position, float0, float1, float2));
		}

		public void Set(Vector3 vector3)
		{
			if(Position < 0) return;
			BindingHelper<ShaderProgram>.Use(_program, program => GL.Uniform3(Position, vector3));
		}

		public void Set(int int0, int int1, int int2, int int3)
		{
			if(Position < 0) return;
			BindingHelper<ShaderProgram>.Use(_program, program => GL.Uniform4(Position, int0, int1, int2, int3));
		}

		public void Set(uint uint0, uint uint1, uint uint2, uint uint3)
		{
			if(Position < 0) return;
			BindingHelper<ShaderProgram>.Use(_program, program => GL.Uniform4(Position, uint0, uint1, uint2, uint3));
		}

		public void Set(float float0, float float1, float float2, float float3)
		{
			if(Position < 0) return;
			BindingHelper<ShaderProgram>.Use(_program, program => GL.Uniform4(Position, float0, float1, float2, float3));
		}

		public void Set(Vector4 vector4)
		{
			if(Position < 0) return;
			BindingHelper<ShaderProgram>.Use(_program, program => GL.Uniform4(Position, vector4));
		}

		public void Set(Matrix4 matrix, bool transpose = false)
		{
			Set(ref matrix, transpose);
		}

		public void Set(ref Matrix4 matrix, bool transpose = false)
		{
			if(Position < 0) return;
			BindingHelper<ShaderProgram>.Push(_program); 
			GL.UniformMatrix4(Position, transpose, ref matrix);
			BindingHelper<ShaderProgram>.Pop(); 
		}
	}
}

