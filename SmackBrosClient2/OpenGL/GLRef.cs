
namespace NeptuneRenderEngine.Engine
{
	// ReSharper disable InconsistentNaming
	// ReSharper disable CSharpWarnings::CS0618
	public static class GL
	{
		public static void FogCoordPointer(OpenTK.Graphics.OpenGL.FogPointerType type, System.Int32 stride, System.Int32 offset)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FogCoordPointer(type, stride, offset);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FogCoordPointer(type, stride, offset);
#endif
		}
		public static void EdgeFlagPointer(System.Int32 stride, System.Int32 offset)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EdgeFlagPointer(stride, offset);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EdgeFlagPointer(stride, offset);
#endif
		}
		public static void TexCoordPointer(System.Int32 size, OpenTK.Graphics.OpenGL.TexCoordPointerType type, System.Int32 stride, System.Int32 offset)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoordPointer(size, type, stride, offset);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoordPointer(size, type, stride, offset);
#endif
		}
		public static void VertexAttribPointer(System.Int32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribPointerType type, System.Boolean normalized, System.Int32 stride, System.Int32 offset)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, offset);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, offset);
#endif
		}
		public static void DrawElements(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, System.Int32 offset)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElements(mode, count, type, offset);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElements(mode, count, type, offset);
#endif
		}
		public static void GetFloat(OpenTK.Graphics.OpenGL.GetPName pname, out OpenTK.Vector2 vector)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetFloat(pname, out vector);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetFloat(pname, out vector);
#endif
		}
		public static void GetFloat(OpenTK.Graphics.OpenGL.GetPName pname, out OpenTK.Vector3 vector)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetFloat(pname, out vector);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetFloat(pname, out vector);
#endif
		}
		public static void GetFloat(OpenTK.Graphics.OpenGL.GetPName pname, out OpenTK.Vector4 vector)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetFloat(pname, out vector);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetFloat(pname, out vector);
#endif
		}
		public static void GetFloat(OpenTK.Graphics.OpenGL.GetPName pname, out OpenTK.Matrix4 matrix)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetFloat(pname, out matrix);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetFloat(pname, out matrix);
#endif
		}
		public static void GetDouble(OpenTK.Graphics.OpenGL.GetPName pname, out OpenTK.Vector2d vector)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetDouble(pname, out vector);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetDouble(pname, out vector);
#endif
		}
		public static void GetDouble(OpenTK.Graphics.OpenGL.GetPName pname, out OpenTK.Vector3d vector)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetDouble(pname, out vector);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetDouble(pname, out vector);
#endif
		}
		public static void GetDouble(OpenTK.Graphics.OpenGL.GetPName pname, out OpenTK.Vector4d vector)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetDouble(pname, out vector);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetDouble(pname, out vector);
#endif
		}
		public static void GetDouble(OpenTK.Graphics.OpenGL.GetPName pname, out OpenTK.Matrix4d matrix)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetDouble(pname, out matrix);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetDouble(pname, out matrix);
#endif
		}
		public static void Viewport(System.Drawing.Size size)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Viewport(size);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Viewport(size);
#endif
		}
		public static void Viewport(System.Drawing.Point location, System.Drawing.Size size)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Viewport(location, size);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Viewport(location, size);
#endif
		}
		public static void Viewport(System.Drawing.Rectangle rectangle)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Viewport(rectangle);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Viewport(rectangle);
#endif
		}
		public static void TexEnv(OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, System.Drawing.Color color)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexEnv(target, pname, color);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexEnv(target, pname, color);
#endif
		}
		public static void TexEnv(OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, OpenTK.Graphics.Color4 color)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexEnv(target, pname, color);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexEnv(target, pname, color);
#endif
		}
		public static void DisableClientState(OpenTK.Graphics.OpenGL.EnableCap array)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DisableClientState(array);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DisableClientState(array);
#endif
		}
		public static void EnableClientState(OpenTK.Graphics.OpenGL.EnableCap array)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EnableClientState(array);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EnableClientState(array);
#endif
		}
		public static void GetActiveUniforms(System.Int32 program, System.Int32 uniformCount, System.Int32[] uniformIndices, OpenTK.Graphics.OpenGL.ArbUniformBufferObject pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveUniforms(program, uniformCount, uniformIndices, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveUniforms(program, uniformCount, uniformIndices, pname, @params);
#endif
		}
		public static void GetActiveUniforms(System.Int32 program, System.Int32 uniformCount, ref System.Int32 uniformIndices, OpenTK.Graphics.OpenGL.ArbUniformBufferObject pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveUniforms(program, uniformCount, ref uniformIndices, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveUniforms(program, uniformCount, ref uniformIndices, pname, out @params);
#endif
		}
		public static void GetActiveUniforms(System.UInt32 program, System.Int32 uniformCount, System.UInt32[] uniformIndices, OpenTK.Graphics.OpenGL.ArbUniformBufferObject pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveUniforms(program, uniformCount, uniformIndices, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveUniforms(program, uniformCount, uniformIndices, pname, @params);
#endif
		}
		public static void GetActiveUniforms(System.UInt32 program, System.Int32 uniformCount, ref System.UInt32 uniformIndices, OpenTK.Graphics.OpenGL.ArbUniformBufferObject pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveUniforms(program, uniformCount, ref uniformIndices, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveUniforms(program, uniformCount, ref uniformIndices, pname, out @params);
#endif
		}
		public static void Material(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, OpenTK.Graphics.Color4 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Material(face, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Material(face, pname, @params);
#endif
		}
		public static void Light(OpenTK.Graphics.OpenGL.LightName name, OpenTK.Graphics.OpenGL.LightParameter pname, OpenTK.Vector4 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Light(name, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Light(name, pname, @params);
#endif
		}
		public static void Light(OpenTK.Graphics.OpenGL.LightName name, OpenTK.Graphics.OpenGL.LightParameter pname, OpenTK.Graphics.Color4 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Light(name, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Light(name, pname, @params);
#endif
		}
		public static void Normal3(OpenTK.Vector3 normal)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(normal);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(normal);
#endif
		}
		public static void RasterPos2(OpenTK.Vector2 pos)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos2(pos);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos2(pos);
#endif
		}
		public static void RasterPos3(OpenTK.Vector3 pos)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos3(pos);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos3(pos);
#endif
		}
		public static void RasterPos4(OpenTK.Vector4 pos)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos4(pos);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos4(pos);
#endif
		}
		public static void Vertex2(OpenTK.Vector2 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex2(v);
#endif
		}
		public static void Vertex3(OpenTK.Vector3 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex3(v);
#endif
		}
		public static void Vertex4(OpenTK.Vector4 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex4(v);
#endif
		}
		public static void TexCoord2(OpenTK.Vector2 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord2(v);
#endif
		}
		public static void TexCoord3(OpenTK.Vector3 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord3(v);
#endif
		}
		public static void TexCoord4(OpenTK.Vector4 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord4(v);
#endif
		}
		public static void Rotate(System.Single angle, OpenTK.Vector3 axis)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rotate(angle, axis);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rotate(angle, axis);
#endif
		}
		public static void Scale(OpenTK.Vector3 scale)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Scale(scale);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Scale(scale);
#endif
		}
		public static void Translate(OpenTK.Vector3 trans)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Translate(trans);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Translate(trans);
#endif
		}
		public static void MultMatrix(ref OpenTK.Matrix4 mat)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultMatrix(ref mat);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultMatrix(ref mat);
#endif
		}
		public static void LoadMatrix(ref OpenTK.Matrix4 mat)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LoadMatrix(ref mat);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LoadMatrix(ref mat);
#endif
		}
		public static void LoadTransposeMatrix(ref OpenTK.Matrix4 mat)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LoadTransposeMatrix(ref mat);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LoadTransposeMatrix(ref mat);
#endif
		}
		public static void MultTransposeMatrix(ref OpenTK.Matrix4 mat)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultTransposeMatrix(ref mat);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultTransposeMatrix(ref mat);
#endif
		}
		public static void UniformMatrix4(System.Int32 location, System.Boolean transpose, ref OpenTK.Matrix4 matrix)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformMatrix4(location, transpose, ref matrix);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformMatrix4(location, transpose, ref matrix);
#endif
		}
		public static void Normal3(OpenTK.Vector3d normal)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(normal);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(normal);
#endif
		}
		public static void RasterPos2(OpenTK.Vector2d pos)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos2(pos);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos2(pos);
#endif
		}
		public static void RasterPos3(OpenTK.Vector3d pos)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos3(pos);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos3(pos);
#endif
		}
		public static void RasterPos4(OpenTK.Vector4d pos)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos4(pos);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos4(pos);
#endif
		}
		public static void Vertex2(OpenTK.Vector2d v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex2(v);
#endif
		}
		public static void Vertex3(OpenTK.Vector3d v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex3(v);
#endif
		}
		public static void Vertex4(OpenTK.Vector4d v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex4(v);
#endif
		}
		public static void TexCoord2(OpenTK.Vector2d v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord2(v);
#endif
		}
		public static void TexCoord3(OpenTK.Vector3d v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord3(v);
#endif
		}
		public static void TexCoord4(OpenTK.Vector4d v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord4(v);
#endif
		}
		public static void Rotate(System.Double angle, OpenTK.Vector3d axis)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rotate(angle, axis);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rotate(angle, axis);
#endif
		}
		public static void Scale(OpenTK.Vector3d scale)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Scale(scale);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Scale(scale);
#endif
		}
		public static void Translate(OpenTK.Vector3d trans)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Translate(trans);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Translate(trans);
#endif
		}
		public static void MultMatrix(ref OpenTK.Matrix4d mat)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultMatrix(ref mat);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultMatrix(ref mat);
#endif
		}
		public static void LoadMatrix(ref OpenTK.Matrix4d mat)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LoadMatrix(ref mat);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LoadMatrix(ref mat);
#endif
		}
		public static void LoadTransposeMatrix(ref OpenTK.Matrix4d mat)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LoadTransposeMatrix(ref mat);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LoadTransposeMatrix(ref mat);
#endif
		}
		public static void MultTransposeMatrix(ref OpenTK.Matrix4d mat)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultTransposeMatrix(ref mat);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultTransposeMatrix(ref mat);
#endif
		}
		public static void Uniform2(System.Int32 location, ref OpenTK.Vector2 vector)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, ref vector);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, ref vector);
#endif
		}
		public static void Uniform3(System.Int32 location, ref OpenTK.Vector3 vector)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, ref vector);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, ref vector);
#endif
		}
		public static void Uniform4(System.Int32 location, ref OpenTK.Vector4 vector)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, ref vector);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, ref vector);
#endif
		}
		public static void Uniform2(System.Int32 location, OpenTK.Vector2 vector)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, vector);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, vector);
#endif
		}
		public static void Uniform3(System.Int32 location, OpenTK.Vector3 vector)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, vector);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, vector);
#endif
		}
		public static void Uniform4(System.Int32 location, OpenTK.Vector4 vector)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, vector);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, vector);
#endif
		}
		public static void Uniform4(System.Int32 location, OpenTK.Graphics.Color4 color)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, color);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, color);
#endif
		}
		public static void Uniform4(System.Int32 location, OpenTK.Quaternion quaternion)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, quaternion);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, quaternion);
#endif
		}
		public static System.String GetActiveAttrib(System.Int32 program, System.Int32 index, out System.Int32 size, out OpenTK.Graphics.OpenGL.ActiveAttribType type)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GetActiveAttrib(program, index, out size, out type);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GetActiveAttrib(program, index, out size, out type);
#endif
		}
		public static System.String GetActiveUniform(System.Int32 program, System.Int32 uniformIndex, out System.Int32 size, out OpenTK.Graphics.OpenGL.ActiveUniformType type)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GetActiveUniform(program, uniformIndex, out size, out type);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GetActiveUniform(program, uniformIndex, out size, out type);
#endif
		}
		public static System.String GetActiveUniformName(System.Int32 program, System.Int32 uniformIndex)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GetActiveUniformName(program, uniformIndex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GetActiveUniformName(program, uniformIndex);
#endif
		}
		public static System.String GetActiveUniformBlockName(System.Int32 program, System.Int32 uniformIndex)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GetActiveUniformBlockName(program, uniformIndex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GetActiveUniformBlockName(program, uniformIndex);
#endif
		}
		public static void ShaderSource(System.Int32 shader, System.String @string)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ShaderSource(shader, @string);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ShaderSource(shader, @string);
#endif
		}
		public static System.String GetShaderInfoLog(System.Int32 shader)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GetShaderInfoLog(shader);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GetShaderInfoLog(shader);
#endif
		}
		public static void GetShaderInfoLog(System.Int32 shader, out System.String info)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetShaderInfoLog(shader, out info);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetShaderInfoLog(shader, out info);
#endif
		}
		public static System.String GetProgramInfoLog(System.Int32 program)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GetProgramInfoLog(program);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GetProgramInfoLog(program);
#endif
		}
		public static void GetProgramInfoLog(System.Int32 program, out System.String info)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetProgramInfoLog(program, out info);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetProgramInfoLog(program, out info);
#endif
		}
		public static void PointParameter(OpenTK.Graphics.OpenGL.PointSpriteCoordOriginParameter param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PointParameter(param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PointParameter(param);
#endif
		}
		public static void VertexAttrib2(System.Int32 index, ref OpenTK.Vector2 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, ref v);
#endif
		}
		public static void VertexAttrib3(System.Int32 index, ref OpenTK.Vector3 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, ref v);
#endif
		}
		public static void VertexAttrib4(System.Int32 index, ref OpenTK.Vector4 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
#endif
		}
		public static void VertexAttrib2(System.Int32 index, OpenTK.Vector2 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, v);
#endif
		}
		public static void VertexAttrib3(System.Int32 index, OpenTK.Vector3 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, v);
#endif
		}
		public static void VertexAttrib4(System.Int32 index, OpenTK.Vector4 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
#endif
		}
		public static void MultiTexCoord2(OpenTK.Graphics.OpenGL.TextureUnit target, ref OpenTK.Vector2 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, ref v);
#endif
		}
		public static void MultiTexCoord3(OpenTK.Graphics.OpenGL.TextureUnit target, ref OpenTK.Vector3 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, ref v);
#endif
		}
		public static void MultiTexCoord4(OpenTK.Graphics.OpenGL.TextureUnit target, ref OpenTK.Vector4 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, ref v);
#endif
		}
		public static void VertexAttrib2(System.Int32 index, ref OpenTK.Vector2d v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, ref v);
#endif
		}
		public static void VertexAttrib3(System.Int32 index, ref OpenTK.Vector3d v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, ref v);
#endif
		}
		public static void VertexAttrib4(System.Int32 index, ref OpenTK.Vector4d v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
#endif
		}
		public static void VertexAttrib2(System.Int32 index, OpenTK.Vector2d v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, v);
#endif
		}
		public static void VertexAttrib3(System.Int32 index, OpenTK.Vector3d v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, v);
#endif
		}
		public static void VertexAttrib4(System.Int32 index, OpenTK.Vector4d v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
#endif
		}
		public static void MultiTexCoord2(OpenTK.Graphics.OpenGL.TextureUnit target, ref OpenTK.Vector2d v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, ref v);
#endif
		}
		public static void MultiTexCoord3(OpenTK.Graphics.OpenGL.TextureUnit target, ref OpenTK.Vector3d v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, ref v);
#endif
		}
		public static void MultiTexCoord4(OpenTK.Graphics.OpenGL.TextureUnit target, ref OpenTK.Vector4d v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, ref v);
#endif
		}
		public static void Rect(System.Drawing.RectangleF rect)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rect(rect);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rect(rect);
#endif
		}
		public static void Rect(System.Drawing.Rectangle rect)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rect(rect);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rect(rect);
#endif
		}
		public static void Rect(ref System.Drawing.RectangleF rect)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rect(ref rect);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rect(ref rect);
#endif
		}
		public static void Rect(ref System.Drawing.Rectangle rect)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rect(ref rect);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rect(ref rect);
#endif
		}
		public static System.Int32 GenTexture()
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GenTexture();
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GenTexture();
#endif
		}
		public static void DeleteTexture(System.Int32 id)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteTexture(id);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteTexture(id);
#endif
		}
		public static void DeleteTexture(System.UInt32 id)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteTexture(id);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteTexture(id);
#endif
		}
		public static void VertexPointer(System.Int32 size, OpenTK.Graphics.OpenGL.VertexPointerType type, System.Int32 stride, System.Int32 offset)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexPointer(size, type, stride, offset);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexPointer(size, type, stride, offset);
#endif
		}
		public static void NormalPointer(OpenTK.Graphics.OpenGL.NormalPointerType type, System.Int32 stride, System.Int32 offset)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.NormalPointer(type, stride, offset);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.NormalPointer(type, stride, offset);
#endif
		}
		public static void IndexPointer(OpenTK.Graphics.OpenGL.IndexPointerType type, System.Int32 stride, System.Int32 offset)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.IndexPointer(type, stride, offset);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.IndexPointer(type, stride, offset);
#endif
		}
		public static void ColorPointer(System.Int32 size, OpenTK.Graphics.OpenGL.ColorPointerType type, System.Int32 stride, System.Int32 offset)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorPointer(size, type, stride, offset);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorPointer(size, type, stride, offset);
#endif
		}
		public static void VertexAttribIPointer<T4>(System.Int32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribIPointerType type, System.Int32 stride, T4[] pointer) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, pointer);
#endif
		}
		public static void VertexAttribIPointer<T4>(System.Int32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribIPointerType type, System.Int32 stride, T4[,] pointer) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, pointer);
#endif
		}
		public static void VertexAttribIPointer<T4>(System.Int32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribIPointerType type, System.Int32 stride, T4[, ,] pointer) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, pointer);
#endif
		}
		public static void VertexAttribIPointer<T4>(System.Int32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribIPointerType type, System.Int32 stride, ref T4 pointer) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, ref pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, ref pointer);
#endif
		}
		public static void VertexAttribIPointer(System.UInt32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribIPointerType type, System.Int32 stride, System.IntPtr pointer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, pointer);
#endif
		}
		public static void VertexAttribIPointer<T4>(System.UInt32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribIPointerType type, System.Int32 stride, T4[] pointer) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, pointer);
#endif
		}
		public static void VertexAttribIPointer<T4>(System.UInt32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribIPointerType type, System.Int32 stride, T4[,] pointer) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, pointer);
#endif
		}
		public static void VertexAttribIPointer<T4>(System.UInt32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribIPointerType type, System.Int32 stride, T4[, ,] pointer) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, pointer);
#endif
		}
		public static void VertexAttribIPointer<T4>(System.UInt32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribIPointerType type, System.Int32 stride, ref T4 pointer) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, ref pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, ref pointer);
#endif
		}
		public static void VertexAttribPointer(System.Int32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribPointerType type, System.Boolean normalized, System.Int32 stride, System.IntPtr pointer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
#endif
		}
		public static void VertexAttribPointer<T5>(System.Int32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribPointerType type, System.Boolean normalized, System.Int32 stride, T5[] pointer) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
#endif
		}
		public static void VertexAttribPointer<T5>(System.Int32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribPointerType type, System.Boolean normalized, System.Int32 stride, T5[,] pointer) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
#endif
		}
		public static void VertexAttribPointer<T5>(System.Int32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribPointerType type, System.Boolean normalized, System.Int32 stride, T5[, ,] pointer) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
#endif
		}
		public static void VertexAttribPointer<T5>(System.Int32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribPointerType type, System.Boolean normalized, System.Int32 stride, ref T5 pointer) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, ref pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, ref pointer);
#endif
		}
		public static void VertexAttribPointer(System.UInt32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribPointerType type, System.Boolean normalized, System.Int32 stride, System.IntPtr pointer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
#endif
		}
		public static void VertexAttribPointer<T5>(System.UInt32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribPointerType type, System.Boolean normalized, System.Int32 stride, T5[] pointer) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
#endif
		}
		public static void VertexAttribPointer<T5>(System.UInt32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribPointerType type, System.Boolean normalized, System.Int32 stride, T5[,] pointer) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
#endif
		}
		public static void VertexAttribPointer<T5>(System.UInt32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribPointerType type, System.Boolean normalized, System.Int32 stride, T5[, ,] pointer) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, pointer);
#endif
		}
		public static void VertexAttribPointer<T5>(System.UInt32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribPointerType type, System.Boolean normalized, System.Int32 stride, ref T5 pointer) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, ref pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribPointer(index, size, type, normalized, stride, ref pointer);
#endif
		}
		public static void VertexPointer(System.Int32 size, OpenTK.Graphics.OpenGL.VertexPointerType type, System.Int32 stride, System.IntPtr pointer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexPointer(size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexPointer(size, type, stride, pointer);
#endif
		}
		public static void VertexPointer<T3>(System.Int32 size, OpenTK.Graphics.OpenGL.VertexPointerType type, System.Int32 stride, T3[] pointer) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexPointer(size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexPointer(size, type, stride, pointer);
#endif
		}
		public static void VertexPointer<T3>(System.Int32 size, OpenTK.Graphics.OpenGL.VertexPointerType type, System.Int32 stride, T3[,] pointer) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexPointer(size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexPointer(size, type, stride, pointer);
#endif
		}
		public static void VertexPointer<T3>(System.Int32 size, OpenTK.Graphics.OpenGL.VertexPointerType type, System.Int32 stride, T3[, ,] pointer) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexPointer(size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexPointer(size, type, stride, pointer);
#endif
		}
		public static void VertexPointer<T3>(System.Int32 size, OpenTK.Graphics.OpenGL.VertexPointerType type, System.Int32 stride, ref T3 pointer) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexPointer(size, type, stride, ref pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexPointer(size, type, stride, ref pointer);
#endif
		}
		public static void Viewport(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Viewport(x, y, width, height);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Viewport(x, y, width, height);
#endif
		}
		public static void WaitSync(System.IntPtr sync, System.Int32 flags, System.Int64 timeout)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WaitSync(sync, flags, timeout);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WaitSync(sync, flags, timeout);
#endif
		}
		public static void WaitSync(System.IntPtr sync, System.UInt32 flags, System.UInt64 timeout)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WaitSync(sync, flags, timeout);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WaitSync(sync, flags, timeout);
#endif
		}
		public static void WindowPos2(System.Double x, System.Double y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos2(x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos2(x, y);
#endif
		}
		public static void WindowPos2(System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos2(v);
#endif
		}
		public static void WindowPos2(ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos2(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos2(ref v);
#endif
		}
		public static void WindowPos2(System.Single x, System.Single y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos2(x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos2(x, y);
#endif
		}
		public static void WindowPos2(System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos2(v);
#endif
		}
		public static void WindowPos2(ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos2(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos2(ref v);
#endif
		}
		public static void WindowPos2(System.Int32 x, System.Int32 y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos2(x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos2(x, y);
#endif
		}
		public static void WindowPos2(System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos2(v);
#endif
		}
		public static void WindowPos2(ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos2(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos2(ref v);
#endif
		}
		public static void WindowPos2(System.Int16 x, System.Int16 y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos2(x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos2(x, y);
#endif
		}
		public static void WindowPos2(System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos2(v);
#endif
		}
		public static void WindowPos2(ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos2(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos2(ref v);
#endif
		}
		public static void WindowPos3(System.Double x, System.Double y, System.Double z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos3(x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos3(x, y, z);
#endif
		}
		public static void WindowPos3(System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos3(v);
#endif
		}
		public static void WindowPos3(ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos3(ref v);
#endif
		}
		public static void WindowPos3(System.Single x, System.Single y, System.Single z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos3(x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos3(x, y, z);
#endif
		}
		public static void WindowPos3(System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos3(v);
#endif
		}
		public static void WindowPos3(ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos3(ref v);
#endif
		}
		public static void WindowPos3(System.Int32 x, System.Int32 y, System.Int32 z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos3(x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos3(x, y, z);
#endif
		}
		public static void WindowPos3(System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos3(v);
#endif
		}
		public static void WindowPos3(ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos3(ref v);
#endif
		}
		public static void WindowPos3(System.Int16 x, System.Int16 y, System.Int16 z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos3(x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos3(x, y, z);
#endif
		}
		public static void WindowPos3(System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos3(v);
#endif
		}
		public static void WindowPos3(ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.WindowPos3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.WindowPos3(ref v);
#endif
		}
		public static void LoadAll()
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LoadAll();
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LoadAll();
#endif
		}
		public static void Color3(System.Drawing.Color color)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(color);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(color);
#endif
		}
		public static void Color4(System.Drawing.Color color)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(color);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(color);
#endif
		}
		public static void Color3(OpenTK.Vector3 color)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(color);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(color);
#endif
		}
		public static void Color4(OpenTK.Vector4 color)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(color);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(color);
#endif
		}
		public static void Color4(OpenTK.Graphics.Color4 color)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(color);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(color);
#endif
		}
		public static void ClearColor(System.Drawing.Color color)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ClearColor(color);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ClearColor(color);
#endif
		}
		public static void ClearColor(OpenTK.Graphics.Color4 color)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ClearColor(color);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ClearColor(color);
#endif
		}
		public static void BlendColor(System.Drawing.Color color)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BlendColor(color);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BlendColor(color);
#endif
		}
		public static void BlendColor(OpenTK.Graphics.Color4 color)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BlendColor(color);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BlendColor(color);
#endif
		}
		public static void Material(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, OpenTK.Vector4 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Material(face, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Material(face, pname, @params);
#endif
		}
		public static void VertexAttrib4N(System.UInt32 index, System.UInt16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, v);
#endif
		}
		public static void VertexAttrib4N(System.UInt32 index, ref System.UInt16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, ref v);
#endif
		}
		public static void VertexAttrib4(System.Int32 index, System.Int16 x, System.Int16 y, System.Int16 z, System.Int16 w)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, x, y, z, w);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, x, y, z, w);
#endif
		}
		public static void VertexAttrib4(System.UInt32 index, System.Int16 x, System.Int16 y, System.Int16 z, System.Int16 w)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, x, y, z, w);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, x, y, z, w);
#endif
		}
		public static void VertexAttrib4(System.Int32 index, System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
#endif
		}
		public static void VertexAttrib4(System.Int32 index, ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
#endif
		}
		public static void VertexAttrib4(System.UInt32 index, System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
#endif
		}
		public static void VertexAttrib4(System.UInt32 index, ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
#endif
		}
		public static void VertexAttrib4(System.Int32 index, System.Byte[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
#endif
		}
		public static void VertexAttrib4(System.Int32 index, ref System.Byte v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
#endif
		}
		public static void VertexAttrib4(System.UInt32 index, System.Byte[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
#endif
		}
		public static void VertexAttrib4(System.UInt32 index, ref System.Byte v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
#endif
		}
		public static void VertexAttrib4(System.UInt32 index, System.UInt32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
#endif
		}
		public static void VertexAttrib4(System.UInt32 index, ref System.UInt32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
#endif
		}
		public static void VertexAttrib4(System.UInt32 index, System.UInt16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
#endif
		}
		public static void VertexAttrib4(System.UInt32 index, ref System.UInt16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
#endif
		}
		public static void VertexAttribI1(System.Int32 index, System.Int32 x)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI1(index, x);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI1(index, x);
#endif
		}
		public static void VertexAttribI1(System.UInt32 index, System.Int32 x)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI1(index, x);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI1(index, x);
#endif
		}
		public static void VertexAttribI1(System.UInt32 index, System.UInt32 x)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI1(index, x);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI1(index, x);
#endif
		}
		public static void VertexAttribI2(System.Int32 index, System.Int32 x, System.Int32 y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI2(index, x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI2(index, x, y);
#endif
		}
		public static void VertexAttribI2(System.UInt32 index, System.Int32 x, System.Int32 y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI2(index, x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI2(index, x, y);
#endif
		}
		public static void VertexAttribI2(System.Int32 index, System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI2(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI2(index, v);
#endif
		}
		public static void VertexAttribI2(System.Int32 index, ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI2(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI2(index, ref v);
#endif
		}
		public static void VertexAttribI2(System.UInt32 index, System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI2(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI2(index, v);
#endif
		}
		public static void VertexAttribI2(System.UInt32 index, ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI2(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI2(index, ref v);
#endif
		}
		public static void VertexAttribI2(System.UInt32 index, System.UInt32 x, System.UInt32 y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI2(index, x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI2(index, x, y);
#endif
		}
		public static void VertexAttribI2(System.UInt32 index, System.UInt32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI2(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI2(index, v);
#endif
		}
		public static void VertexAttribI2(System.UInt32 index, ref System.UInt32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI2(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI2(index, ref v);
#endif
		}
		public static void VertexAttribI3(System.Int32 index, System.Int32 x, System.Int32 y, System.Int32 z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI3(index, x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI3(index, x, y, z);
#endif
		}
		public static void VertexAttribI3(System.UInt32 index, System.Int32 x, System.Int32 y, System.Int32 z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI3(index, x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI3(index, x, y, z);
#endif
		}
		public static void VertexAttribI3(System.Int32 index, System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI3(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI3(index, v);
#endif
		}
		public static void VertexAttribI3(System.Int32 index, ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI3(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI3(index, ref v);
#endif
		}
		public static void VertexAttribI3(System.UInt32 index, System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI3(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI3(index, v);
#endif
		}
		public static void VertexAttribI3(System.UInt32 index, ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI3(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI3(index, ref v);
#endif
		}
		public static void VertexAttribI3(System.UInt32 index, System.UInt32 x, System.UInt32 y, System.UInt32 z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI3(index, x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI3(index, x, y, z);
#endif
		}
		public static void VertexAttribI3(System.UInt32 index, System.UInt32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI3(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI3(index, v);
#endif
		}
		public static void VertexAttribI3(System.UInt32 index, ref System.UInt32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI3(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI3(index, ref v);
#endif
		}
		public static void VertexAttribI4(System.UInt32 index, System.SByte[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, v);
#endif
		}
		public static void VertexAttribI4(System.UInt32 index, ref System.SByte v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, ref v);
#endif
		}
		public static void VertexAttribI4(System.Int32 index, System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, x, y, z, w);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, x, y, z, w);
#endif
		}
		public static void VertexAttribI4(System.UInt32 index, System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, x, y, z, w);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, x, y, z, w);
#endif
		}
		public static void VertexAttribI4(System.Int32 index, System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, v);
#endif
		}
		public static void VertexAttribI4(System.Int32 index, ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, ref v);
#endif
		}
		public static void VertexAttribI4(System.UInt32 index, System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, v);
#endif
		}
		public static void VertexAttribI4(System.UInt32 index, ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, ref v);
#endif
		}
		public static void VertexAttribI4(System.Int32 index, System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, v);
#endif
		}
		public static void VertexAttribI4(System.Int32 index, ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, ref v);
#endif
		}
		public static void VertexAttribI4(System.UInt32 index, System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, v);
#endif
		}
		public static void VertexAttribI4(System.UInt32 index, ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, ref v);
#endif
		}
		public static void VertexAttribI4(System.Int32 index, System.Byte[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, v);
#endif
		}
		public static void VertexAttribI4(System.Int32 index, ref System.Byte v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, ref v);
#endif
		}
		public static void VertexAttribI4(System.UInt32 index, System.Byte[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, v);
#endif
		}
		public static void VertexAttribI4(System.UInt32 index, ref System.Byte v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, ref v);
#endif
		}
		public static void VertexAttribI4(System.UInt32 index, System.UInt32 x, System.UInt32 y, System.UInt32 z, System.UInt32 w)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, x, y, z, w);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, x, y, z, w);
#endif
		}
		public static void VertexAttribI4(System.UInt32 index, System.UInt32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, v);
#endif
		}
		public static void VertexAttribI4(System.UInt32 index, ref System.UInt32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, ref v);
#endif
		}
		public static void VertexAttribI4(System.UInt32 index, System.UInt16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, v);
#endif
		}
		public static void VertexAttribI4(System.UInt32 index, ref System.UInt16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribI4(index, ref v);
#endif
		}
		public static void VertexAttribIPointer(System.Int32 index, System.Int32 size, OpenTK.Graphics.OpenGL.VertexAttribIPointerType type, System.Int32 stride, System.IntPtr pointer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttribIPointer(index, size, type, stride, pointer);
#endif
		}
		public static void VertexAttrib2(System.UInt32 index, ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, ref v);
#endif
		}
		public static void VertexAttrib2(System.Int32 index, System.Int16 x, System.Int16 y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, x, y);
#endif
		}
		public static void VertexAttrib2(System.UInt32 index, System.Int16 x, System.Int16 y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, x, y);
#endif
		}
		public static void VertexAttrib2(System.Int32 index, System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, v);
#endif
		}
		public static void VertexAttrib2(System.Int32 index, ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, ref v);
#endif
		}
		public static void VertexAttrib2(System.UInt32 index, System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, v);
#endif
		}
		public static void VertexAttrib2(System.UInt32 index, ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, ref v);
#endif
		}
		public static void VertexAttrib3(System.Int32 index, System.Double x, System.Double y, System.Double z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, x, y, z);
#endif
		}
		public static void VertexAttrib3(System.UInt32 index, System.Double x, System.Double y, System.Double z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, x, y, z);
#endif
		}
		public static void VertexAttrib3(System.Int32 index, System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, v);
#endif
		}
		public static void VertexAttrib3(System.Int32 index, ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, ref v);
#endif
		}
		public static void VertexAttrib3(System.UInt32 index, System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, v);
#endif
		}
		public static void VertexAttrib3(System.UInt32 index, ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, ref v);
#endif
		}
		public static void VertexAttrib3(System.Int32 index, System.Single x, System.Single y, System.Single z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, x, y, z);
#endif
		}
		public static void VertexAttrib3(System.UInt32 index, System.Single x, System.Single y, System.Single z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, x, y, z);
#endif
		}
		public static void VertexAttrib3(System.Int32 index, System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, v);
#endif
		}
		public static void VertexAttrib3(System.Int32 index, ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, ref v);
#endif
		}
		public static void VertexAttrib3(System.UInt32 index, System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, v);
#endif
		}
		public static void VertexAttrib3(System.UInt32 index, ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, ref v);
#endif
		}
		public static void VertexAttrib3(System.Int32 index, System.Int16 x, System.Int16 y, System.Int16 z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, x, y, z);
#endif
		}
		public static void VertexAttrib3(System.UInt32 index, System.Int16 x, System.Int16 y, System.Int16 z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, x, y, z);
#endif
		}
		public static void VertexAttrib3(System.Int32 index, System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, v);
#endif
		}
		public static void VertexAttrib3(System.Int32 index, ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, ref v);
#endif
		}
		public static void VertexAttrib3(System.UInt32 index, System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, v);
#endif
		}
		public static void VertexAttrib3(System.UInt32 index, ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib3(index, ref v);
#endif
		}
		public static void VertexAttrib4(System.UInt32 index, System.SByte[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
#endif
		}
		public static void VertexAttrib4(System.UInt32 index, ref System.SByte v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
#endif
		}
		public static void VertexAttrib4(System.Int32 index, System.Double x, System.Double y, System.Double z, System.Double w)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, x, y, z, w);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, x, y, z, w);
#endif
		}
		public static void VertexAttrib4(System.UInt32 index, System.Double x, System.Double y, System.Double z, System.Double w)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, x, y, z, w);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, x, y, z, w);
#endif
		}
		public static void VertexAttrib4(System.Int32 index, System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
#endif
		}
		public static void VertexAttrib4(System.Int32 index, ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
#endif
		}
		public static void VertexAttrib4(System.UInt32 index, System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
#endif
		}
		public static void VertexAttrib4(System.UInt32 index, ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
#endif
		}
		public static void VertexAttrib4(System.Int32 index, System.Single x, System.Single y, System.Single z, System.Single w)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, x, y, z, w);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, x, y, z, w);
#endif
		}
		public static void VertexAttrib4(System.UInt32 index, System.Single x, System.Single y, System.Single z, System.Single w)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, x, y, z, w);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, x, y, z, w);
#endif
		}
		public static void VertexAttrib4(System.Int32 index, System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
#endif
		}
		public static void VertexAttrib4(System.Int32 index, ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
#endif
		}
		public static void VertexAttrib4(System.UInt32 index, System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
#endif
		}
		public static void VertexAttrib4(System.UInt32 index, ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
#endif
		}
		public static void VertexAttrib4(System.Int32 index, System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
#endif
		}
		public static void VertexAttrib4(System.Int32 index, ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
#endif
		}
		public static void VertexAttrib4(System.UInt32 index, System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, v);
#endif
		}
		public static void VertexAttrib4(System.UInt32 index, ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4(index, ref v);
#endif
		}
		public static void VertexAttrib4N(System.UInt32 index, System.SByte[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, v);
#endif
		}
		public static void VertexAttrib4N(System.UInt32 index, ref System.SByte v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, ref v);
#endif
		}
		public static void VertexAttrib4N(System.Int32 index, System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, v);
#endif
		}
		public static void VertexAttrib4N(System.Int32 index, ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, ref v);
#endif
		}
		public static void VertexAttrib4N(System.UInt32 index, System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, v);
#endif
		}
		public static void VertexAttrib4N(System.UInt32 index, ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, ref v);
#endif
		}
		public static void VertexAttrib4N(System.Int32 index, System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, v);
#endif
		}
		public static void VertexAttrib4N(System.Int32 index, ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, ref v);
#endif
		}
		public static void VertexAttrib4N(System.UInt32 index, System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, v);
#endif
		}
		public static void VertexAttrib4N(System.UInt32 index, ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, ref v);
#endif
		}
		public static void VertexAttrib4N(System.Int32 index, System.Byte x, System.Byte y, System.Byte z, System.Byte w)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, x, y, z, w);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, x, y, z, w);
#endif
		}
		public static void VertexAttrib4N(System.UInt32 index, System.Byte x, System.Byte y, System.Byte z, System.Byte w)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, x, y, z, w);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, x, y, z, w);
#endif
		}
		public static void VertexAttrib4N(System.Int32 index, System.Byte[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, v);
#endif
		}
		public static void VertexAttrib4N(System.Int32 index, ref System.Byte v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, ref v);
#endif
		}
		public static void VertexAttrib4N(System.UInt32 index, System.Byte[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, v);
#endif
		}
		public static void VertexAttrib4N(System.UInt32 index, ref System.Byte v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, ref v);
#endif
		}
		public static void VertexAttrib4N(System.UInt32 index, System.UInt32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, v);
#endif
		}
		public static void VertexAttrib4N(System.UInt32 index, ref System.UInt32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib4N(index, ref v);
#endif
		}
		public static void UniformMatrix4x2(System.Int32 location, System.Int32 count, System.Boolean transpose, System.Single[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformMatrix4x2(location, count, transpose, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformMatrix4x2(location, count, transpose, value);
#endif
		}
		public static void UniformMatrix4x2(System.Int32 location, System.Int32 count, System.Boolean transpose, ref System.Single value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformMatrix4x2(location, count, transpose, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformMatrix4x2(location, count, transpose, ref value);
#endif
		}
		public static void UniformMatrix4x3(System.Int32 location, System.Int32 count, System.Boolean transpose, System.Single[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformMatrix4x3(location, count, transpose, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformMatrix4x3(location, count, transpose, value);
#endif
		}
		public static void UniformMatrix4x3(System.Int32 location, System.Int32 count, System.Boolean transpose, ref System.Single value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformMatrix4x3(location, count, transpose, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformMatrix4x3(location, count, transpose, ref value);
#endif
		}
		public static System.Boolean UnmapBuffer(OpenTK.Graphics.OpenGL.BufferTarget target)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.UnmapBuffer(target);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.UnmapBuffer(target);
#endif
		}
		public static void UseProgram(System.Int32 program)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UseProgram(program);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UseProgram(program);
#endif
		}
		public static void UseProgram(System.UInt32 program)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UseProgram(program);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UseProgram(program);
#endif
		}
		public static void ValidateProgram(System.Int32 program)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ValidateProgram(program);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ValidateProgram(program);
#endif
		}
		public static void ValidateProgram(System.UInt32 program)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ValidateProgram(program);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ValidateProgram(program);
#endif
		}
		public static void Vertex2(System.Double x, System.Double y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex2(x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex2(x, y);
#endif
		}
		public static void Vertex2(System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex2(v);
#endif
		}
		public static void Vertex2(ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex2(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex2(ref v);
#endif
		}
		public static void Vertex2(System.Single x, System.Single y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex2(x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex2(x, y);
#endif
		}
		public static void Vertex2(System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex2(v);
#endif
		}
		public static void Vertex2(ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex2(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex2(ref v);
#endif
		}
		public static void Vertex2(System.Int32 x, System.Int32 y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex2(x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex2(x, y);
#endif
		}
		public static void Vertex2(System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex2(v);
#endif
		}
		public static void Vertex2(ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex2(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex2(ref v);
#endif
		}
		public static void Vertex2(System.Int16 x, System.Int16 y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex2(x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex2(x, y);
#endif
		}
		public static void Vertex2(System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex2(v);
#endif
		}
		public static void Vertex2(ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex2(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex2(ref v);
#endif
		}
		public static void Vertex3(System.Double x, System.Double y, System.Double z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex3(x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex3(x, y, z);
#endif
		}
		public static void Vertex3(System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex3(v);
#endif
		}
		public static void Vertex3(ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex3(ref v);
#endif
		}
		public static void Vertex3(System.Single x, System.Single y, System.Single z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex3(x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex3(x, y, z);
#endif
		}
		public static void Vertex3(System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex3(v);
#endif
		}
		public static void Vertex3(ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex3(ref v);
#endif
		}
		public static void Vertex3(System.Int32 x, System.Int32 y, System.Int32 z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex3(x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex3(x, y, z);
#endif
		}
		public static void Vertex3(System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex3(v);
#endif
		}
		public static void Vertex3(ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex3(ref v);
#endif
		}
		public static void Vertex3(System.Int16 x, System.Int16 y, System.Int16 z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex3(x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex3(x, y, z);
#endif
		}
		public static void Vertex3(System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex3(v);
#endif
		}
		public static void Vertex3(ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex3(ref v);
#endif
		}
		public static void Vertex4(System.Double x, System.Double y, System.Double z, System.Double w)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex4(x, y, z, w);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex4(x, y, z, w);
#endif
		}
		public static void Vertex4(System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex4(v);
#endif
		}
		public static void Vertex4(ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex4(ref v);
#endif
		}
		public static void Vertex4(System.Single x, System.Single y, System.Single z, System.Single w)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex4(x, y, z, w);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex4(x, y, z, w);
#endif
		}
		public static void Vertex4(System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex4(v);
#endif
		}
		public static void Vertex4(ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex4(ref v);
#endif
		}
		public static void Vertex4(System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex4(x, y, z, w);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex4(x, y, z, w);
#endif
		}
		public static void Vertex4(System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex4(v);
#endif
		}
		public static void Vertex4(ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex4(ref v);
#endif
		}
		public static void Vertex4(System.Int16 x, System.Int16 y, System.Int16 z, System.Int16 w)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex4(x, y, z, w);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex4(x, y, z, w);
#endif
		}
		public static void Vertex4(System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex4(v);
#endif
		}
		public static void Vertex4(ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Vertex4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Vertex4(ref v);
#endif
		}
		public static void VertexAttrib1(System.Int32 index, System.Double x)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib1(index, x);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib1(index, x);
#endif
		}
		public static void VertexAttrib1(System.UInt32 index, System.Double x)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib1(index, x);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib1(index, x);
#endif
		}
		public static void VertexAttrib1(System.Int32 index, System.Single x)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib1(index, x);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib1(index, x);
#endif
		}
		public static void VertexAttrib1(System.UInt32 index, System.Single x)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib1(index, x);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib1(index, x);
#endif
		}
		public static void VertexAttrib1(System.Int32 index, System.Int16 x)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib1(index, x);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib1(index, x);
#endif
		}
		public static void VertexAttrib1(System.UInt32 index, System.Int16 x)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib1(index, x);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib1(index, x);
#endif
		}
		public static void VertexAttrib2(System.Int32 index, System.Double x, System.Double y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, x, y);
#endif
		}
		public static void VertexAttrib2(System.UInt32 index, System.Double x, System.Double y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, x, y);
#endif
		}
		public static void VertexAttrib2(System.Int32 index, System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, v);
#endif
		}
		public static void VertexAttrib2(System.Int32 index, ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, ref v);
#endif
		}
		public static void VertexAttrib2(System.UInt32 index, System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, v);
#endif
		}
		public static void VertexAttrib2(System.UInt32 index, ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, ref v);
#endif
		}
		public static void VertexAttrib2(System.Int32 index, System.Single x, System.Single y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, x, y);
#endif
		}
		public static void VertexAttrib2(System.UInt32 index, System.Single x, System.Single y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, x, y);
#endif
		}
		public static void VertexAttrib2(System.Int32 index, System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, v);
#endif
		}
		public static void VertexAttrib2(System.Int32 index, ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, ref v);
#endif
		}
		public static void VertexAttrib2(System.UInt32 index, System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.VertexAttrib2(index, v);
#endif
		}
		public static void TexSubImage2D<T8>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T8[, ,] pixels) where T8 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
#endif
		}
		public static void TexSubImage2D<T8>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, ref T8 pixels) where T8 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, ref pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, ref pixels);
#endif
		}
		public static void TexSubImage3D(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr pixels)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
#endif
		}
		public static void TexSubImage3D<T10>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T10[] pixels) where T10 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
#endif
		}
		public static void TexSubImage3D<T10>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T10[,] pixels) where T10 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
#endif
		}
		public static void TexSubImage3D<T10>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T10[, ,] pixels) where T10 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
#endif
		}
		public static void TexSubImage3D<T10>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, ref T10 pixels) where T10 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, ref pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, ref pixels);
#endif
		}
		public static void TransformFeedbackVaryings(System.Int32 program, System.Int32 count, System.String[] varyings, OpenTK.Graphics.OpenGL.TransformFeedbackMode bufferMode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TransformFeedbackVaryings(program, count, varyings, bufferMode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TransformFeedbackVaryings(program, count, varyings, bufferMode);
#endif
		}
		public static void TransformFeedbackVaryings(System.UInt32 program, System.Int32 count, System.String[] varyings, OpenTK.Graphics.OpenGL.TransformFeedbackMode bufferMode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TransformFeedbackVaryings(program, count, varyings, bufferMode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TransformFeedbackVaryings(program, count, varyings, bufferMode);
#endif
		}
		public static void Translate(System.Double x, System.Double y, System.Double z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Translate(x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Translate(x, y, z);
#endif
		}
		public static void Translate(System.Single x, System.Single y, System.Single z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Translate(x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Translate(x, y, z);
#endif
		}
		public static void Uniform1(System.Int32 location, System.Single v0)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform1(location, v0);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform1(location, v0);
#endif
		}
		public static void Uniform1(System.Int32 location, System.Int32 count, System.Single[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform1(location, count, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform1(location, count, value);
#endif
		}
		public static void Uniform1(System.Int32 location, System.Int32 count, ref System.Single value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform1(location, count, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform1(location, count, ref value);
#endif
		}
		public static void Uniform1(System.Int32 location, System.Int32 v0)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform1(location, v0);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform1(location, v0);
#endif
		}
		public static void Uniform1(System.Int32 location, System.Int32 count, System.Int32[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform1(location, count, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform1(location, count, value);
#endif
		}
		public static void Uniform1(System.Int32 location, System.Int32 count, ref System.Int32 value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform1(location, count, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform1(location, count, ref value);
#endif
		}
		public static void Uniform1(System.Int32 location, System.UInt32 v0)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform1(location, v0);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform1(location, v0);
#endif
		}
		public static void Uniform1(System.Int32 location, System.Int32 count, System.UInt32[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform1(location, count, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform1(location, count, value);
#endif
		}
		public static void Uniform1(System.Int32 location, System.Int32 count, ref System.UInt32 value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform1(location, count, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform1(location, count, ref value);
#endif
		}
		public static void Uniform2(System.Int32 location, System.Single v0, System.Single v1)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, v0, v1);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, v0, v1);
#endif
		}
		public static void Uniform2(System.Int32 location, System.Int32 count, System.Single[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, count, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, count, value);
#endif
		}
		public static void Uniform2(System.Int32 location, System.Int32 count, ref System.Single value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, count, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, count, ref value);
#endif
		}
		public static void Uniform2(System.Int32 location, System.Int32 v0, System.Int32 v1)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, v0, v1);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, v0, v1);
#endif
		}
		public static void Uniform2(System.Int32 location, System.Int32 count, System.Int32[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, count, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, count, value);
#endif
		}
		public static void Uniform2(System.Int32 location, System.UInt32 v0, System.UInt32 v1)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, v0, v1);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, v0, v1);
#endif
		}
		public static void Uniform2(System.Int32 location, System.Int32 count, System.UInt32[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, count, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, count, value);
#endif
		}
		public static void Uniform2(System.Int32 location, System.Int32 count, ref System.UInt32 value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, count, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform2(location, count, ref value);
#endif
		}
		public static void Uniform3(System.Int32 location, System.Single v0, System.Single v1, System.Single v2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, v0, v1, v2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, v0, v1, v2);
#endif
		}
		public static void Uniform3(System.Int32 location, System.Int32 count, System.Single[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, count, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, count, value);
#endif
		}
		public static void Uniform3(System.Int32 location, System.Int32 count, ref System.Single value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, count, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, count, ref value);
#endif
		}
		public static void Uniform3(System.Int32 location, System.Int32 v0, System.Int32 v1, System.Int32 v2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, v0, v1, v2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, v0, v1, v2);
#endif
		}
		public static void Uniform3(System.Int32 location, System.Int32 count, System.Int32[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, count, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, count, value);
#endif
		}
		public static void Uniform3(System.Int32 location, System.Int32 count, ref System.Int32 value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, count, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, count, ref value);
#endif
		}
		public static void Uniform3(System.Int32 location, System.UInt32 v0, System.UInt32 v1, System.UInt32 v2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, v0, v1, v2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, v0, v1, v2);
#endif
		}
		public static void Uniform3(System.Int32 location, System.Int32 count, System.UInt32[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, count, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, count, value);
#endif
		}
		public static void Uniform3(System.Int32 location, System.Int32 count, ref System.UInt32 value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, count, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform3(location, count, ref value);
#endif
		}
		public static void Uniform4(System.Int32 location, System.Single v0, System.Single v1, System.Single v2, System.Single v3)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, v0, v1, v2, v3);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, v0, v1, v2, v3);
#endif
		}
		public static void Uniform4(System.Int32 location, System.Int32 count, System.Single[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, count, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, count, value);
#endif
		}
		public static void Uniform4(System.Int32 location, System.Int32 count, ref System.Single value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, count, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, count, ref value);
#endif
		}
		public static void Uniform4(System.Int32 location, System.Int32 v0, System.Int32 v1, System.Int32 v2, System.Int32 v3)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, v0, v1, v2, v3);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, v0, v1, v2, v3);
#endif
		}
		public static void Uniform4(System.Int32 location, System.Int32 count, System.Int32[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, count, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, count, value);
#endif
		}
		public static void Uniform4(System.Int32 location, System.Int32 count, ref System.Int32 value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, count, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, count, ref value);
#endif
		}
		public static void Uniform4(System.Int32 location, System.UInt32 v0, System.UInt32 v1, System.UInt32 v2, System.UInt32 v3)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, v0, v1, v2, v3);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, v0, v1, v2, v3);
#endif
		}
		public static void Uniform4(System.Int32 location, System.Int32 count, System.UInt32[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, count, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, count, value);
#endif
		}
		public static void Uniform4(System.Int32 location, System.Int32 count, ref System.UInt32 value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, count, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Uniform4(location, count, ref value);
#endif
		}
		public static void UniformBlockBinding(System.Int32 program, System.Int32 uniformBlockIndex, System.Int32 uniformBlockBinding)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
#endif
		}
		public static void UniformBlockBinding(System.UInt32 program, System.UInt32 uniformBlockIndex, System.UInt32 uniformBlockBinding)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformBlockBinding(program, uniformBlockIndex, uniformBlockBinding);
#endif
		}
		public static void UniformMatrix2(System.Int32 location, System.Int32 count, System.Boolean transpose, System.Single[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformMatrix2(location, count, transpose, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformMatrix2(location, count, transpose, value);
#endif
		}
		public static void UniformMatrix2(System.Int32 location, System.Int32 count, System.Boolean transpose, ref System.Single value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformMatrix2(location, count, transpose, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformMatrix2(location, count, transpose, ref value);
#endif
		}
		public static void UniformMatrix2x3(System.Int32 location, System.Int32 count, System.Boolean transpose, System.Single[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformMatrix2x3(location, count, transpose, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformMatrix2x3(location, count, transpose, value);
#endif
		}
		public static void UniformMatrix2x3(System.Int32 location, System.Int32 count, System.Boolean transpose, ref System.Single value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformMatrix2x3(location, count, transpose, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformMatrix2x3(location, count, transpose, ref value);
#endif
		}
		public static void UniformMatrix2x4(System.Int32 location, System.Int32 count, System.Boolean transpose, System.Single[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformMatrix2x4(location, count, transpose, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformMatrix2x4(location, count, transpose, value);
#endif
		}
		public static void UniformMatrix2x4(System.Int32 location, System.Int32 count, System.Boolean transpose, ref System.Single value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformMatrix2x4(location, count, transpose, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformMatrix2x4(location, count, transpose, ref value);
#endif
		}
		public static void UniformMatrix3(System.Int32 location, System.Int32 count, System.Boolean transpose, System.Single[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformMatrix3(location, count, transpose, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformMatrix3(location, count, transpose, value);
#endif
		}
		public static void UniformMatrix3(System.Int32 location, System.Int32 count, System.Boolean transpose, ref System.Single value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformMatrix3(location, count, transpose, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformMatrix3(location, count, transpose, ref value);
#endif
		}
		public static void UniformMatrix3x2(System.Int32 location, System.Int32 count, System.Boolean transpose, System.Single[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformMatrix3x2(location, count, transpose, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformMatrix3x2(location, count, transpose, value);
#endif
		}
		public static void UniformMatrix3x2(System.Int32 location, System.Int32 count, System.Boolean transpose, ref System.Single value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformMatrix3x2(location, count, transpose, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformMatrix3x2(location, count, transpose, ref value);
#endif
		}
		public static void UniformMatrix3x4(System.Int32 location, System.Int32 count, System.Boolean transpose, System.Single[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformMatrix3x4(location, count, transpose, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformMatrix3x4(location, count, transpose, value);
#endif
		}
		public static void UniformMatrix3x4(System.Int32 location, System.Int32 count, System.Boolean transpose, ref System.Single value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformMatrix3x4(location, count, transpose, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformMatrix3x4(location, count, transpose, ref value);
#endif
		}
		public static void UniformMatrix4(System.Int32 location, System.Int32 count, System.Boolean transpose, System.Single[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformMatrix4(location, count, transpose, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformMatrix4(location, count, transpose, value);
#endif
		}
		public static void UniformMatrix4(System.Int32 location, System.Int32 count, System.Boolean transpose, ref System.Single value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.UniformMatrix4(location, count, transpose, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.UniformMatrix4(location, count, transpose, ref value);
#endif
		}
		public static void TexCoord4(System.Single s, System.Single t, System.Single r, System.Single q)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord4(s, t, r, q);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord4(s, t, r, q);
#endif
		}
		public static void TexCoord4(System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord4(v);
#endif
		}
		public static void TexCoord4(ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord4(ref v);
#endif
		}
		public static void TexCoord4(System.Int32 s, System.Int32 t, System.Int32 r, System.Int32 q)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord4(s, t, r, q);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord4(s, t, r, q);
#endif
		}
		public static void TexCoord4(System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord4(v);
#endif
		}
		public static void TexCoord4(ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord4(ref v);
#endif
		}
		public static void TexCoord4(System.Int16 s, System.Int16 t, System.Int16 r, System.Int16 q)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord4(s, t, r, q);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord4(s, t, r, q);
#endif
		}
		public static void TexCoord4(System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord4(v);
#endif
		}
		public static void TexCoord4(ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord4(ref v);
#endif
		}
		public static void TexCoordPointer(System.Int32 size, OpenTK.Graphics.OpenGL.TexCoordPointerType type, System.Int32 stride, System.IntPtr pointer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoordPointer(size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoordPointer(size, type, stride, pointer);
#endif
		}
		public static void TexCoordPointer<T3>(System.Int32 size, OpenTK.Graphics.OpenGL.TexCoordPointerType type, System.Int32 stride, T3[] pointer) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoordPointer(size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoordPointer(size, type, stride, pointer);
#endif
		}
		public static void TexCoordPointer<T3>(System.Int32 size, OpenTK.Graphics.OpenGL.TexCoordPointerType type, System.Int32 stride, T3[,] pointer) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoordPointer(size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoordPointer(size, type, stride, pointer);
#endif
		}
		public static void TexCoordPointer<T3>(System.Int32 size, OpenTK.Graphics.OpenGL.TexCoordPointerType type, System.Int32 stride, T3[, ,] pointer) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoordPointer(size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoordPointer(size, type, stride, pointer);
#endif
		}
		public static void TexCoordPointer<T3>(System.Int32 size, OpenTK.Graphics.OpenGL.TexCoordPointerType type, System.Int32 stride, ref T3 pointer) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoordPointer(size, type, stride, ref pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoordPointer(size, type, stride, ref pointer);
#endif
		}
		public static void TexEnv(OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, System.Single param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexEnv(target, pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexEnv(target, pname, param);
#endif
		}
		public static void TexEnv(OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexEnv(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexEnv(target, pname, @params);
#endif
		}
		public static void TexEnv(OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, System.Int32 param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexEnv(target, pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexEnv(target, pname, param);
#endif
		}
		public static void TexEnv(OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexEnv(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexEnv(target, pname, @params);
#endif
		}
		public static void TexGend(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, System.Double param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexGend(coord, pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexGend(coord, pname, param);
#endif
		}
		public static void TexGen(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, System.Double[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexGen(coord, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexGen(coord, pname, @params);
#endif
		}
		public static void TexGen(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, ref System.Double @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexGen(coord, pname, ref @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexGen(coord, pname, ref @params);
#endif
		}
		public static void TexGen(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, System.Single param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexGen(coord, pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexGen(coord, pname, param);
#endif
		}
		public static void TexGen(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexGen(coord, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexGen(coord, pname, @params);
#endif
		}
		public static void TexGen(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, System.Int32 param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexGen(coord, pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexGen(coord, pname, param);
#endif
		}
		public static void TexGen(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexGen(coord, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexGen(coord, pname, @params);
#endif
		}
		public static void TexImage1D(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr pixels)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexImage1D(target, level, internalformat, width, border, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexImage1D(target, level, internalformat, width, border, format, type, pixels);
#endif
		}
		public static void TexImage1D<T7>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T7[] pixels) where T7 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexImage1D(target, level, internalformat, width, border, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexImage1D(target, level, internalformat, width, border, format, type, pixels);
#endif
		}
		public static void TexImage1D<T7>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T7[,] pixels) where T7 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexImage1D(target, level, internalformat, width, border, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexImage1D(target, level, internalformat, width, border, format, type, pixels);
#endif
		}
		public static void TexImage1D<T7>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T7[, ,] pixels) where T7 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexImage1D(target, level, internalformat, width, border, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexImage1D(target, level, internalformat, width, border, format, type, pixels);
#endif
		}
		public static void TexImage1D<T7>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, ref T7 pixels) where T7 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexImage1D(target, level, internalformat, width, border, format, type, ref pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexImage1D(target, level, internalformat, width, border, format, type, ref pixels);
#endif
		}
		public static void TexImage2D(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr pixels)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
#endif
		}
		public static void TexImage2D<T8>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T8[] pixels) where T8 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
#endif
		}
		public static void TexImage2D<T8>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T8[,] pixels) where T8 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
#endif
		}
		public static void TexImage2D<T8>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T8[, ,] pixels) where T8 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
#endif
		}
		public static void TexImage2D<T8>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, ref T8 pixels) where T8 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexImage2D(target, level, internalformat, width, height, border, format, type, ref pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexImage2D(target, level, internalformat, width, height, border, format, type, ref pixels);
#endif
		}
		public static void TexImage2DMultisample(OpenTK.Graphics.OpenGL.TextureTargetMultisample target, System.Int32 samples, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Boolean fixedsamplelocations)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexImage2DMultisample(target, samples, internalformat, width, height, fixedsamplelocations);
#endif
		}
		public static void TexImage3D(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr pixels)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
#endif
		}
		public static void TexImage3D<T9>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T9[] pixels) where T9 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
#endif
		}
		public static void TexImage3D<T9>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T9[,] pixels) where T9 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
#endif
		}
		public static void TexImage3D<T9>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T9[, ,] pixels) where T9 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, pixels);
#endif
		}
		public static void TexImage3D<T9>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 border, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, ref T9 pixels) where T9 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, ref pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexImage3D(target, level, internalformat, width, height, depth, border, format, type, ref pixels);
#endif
		}
		public static void TexImage3DMultisample(OpenTK.Graphics.OpenGL.TextureTargetMultisample target, System.Int32 samples, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Boolean fixedsamplelocations)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexImage3DMultisample(target, samples, internalformat, width, height, depth, fixedsamplelocations);
#endif
		}
		public static void TexParameter(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, System.Single param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexParameter(target, pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexParameter(target, pname, param);
#endif
		}
		public static void TexParameter(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexParameter(target, pname, @params);
#endif
		}
		public static void TexParameter(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, System.Int32 param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexParameter(target, pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexParameter(target, pname, param);
#endif
		}
		public static void TexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexParameterI(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexParameterI(target, pname, @params);
#endif
		}
		public static void TexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, ref System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexParameterI(target, pname, ref @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexParameterI(target, pname, ref @params);
#endif
		}
		public static void TexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, System.UInt32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexParameterI(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexParameterI(target, pname, @params);
#endif
		}
		public static void TexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, ref System.UInt32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexParameterI(target, pname, ref @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexParameterI(target, pname, ref @params);
#endif
		}
		public static void TexParameter(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.TextureParameterName pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexParameter(target, pname, @params);
#endif
		}
		public static void TexSubImage1D(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr pixels)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexSubImage1D(target, level, xoffset, width, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexSubImage1D(target, level, xoffset, width, format, type, pixels);
#endif
		}
		public static void TexSubImage1D<T6>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T6[] pixels) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexSubImage1D(target, level, xoffset, width, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexSubImage1D(target, level, xoffset, width, format, type, pixels);
#endif
		}
		public static void TexSubImage1D<T6>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T6[,] pixels) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexSubImage1D(target, level, xoffset, width, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexSubImage1D(target, level, xoffset, width, format, type, pixels);
#endif
		}
		public static void TexSubImage1D<T6>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T6[, ,] pixels) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexSubImage1D(target, level, xoffset, width, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexSubImage1D(target, level, xoffset, width, format, type, pixels);
#endif
		}
		public static void TexSubImage1D<T6>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, ref T6 pixels) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexSubImage1D(target, level, xoffset, width, format, type, ref pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexSubImage1D(target, level, xoffset, width, format, type, ref pixels);
#endif
		}
		public static void TexSubImage2D(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr pixels)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
#endif
		}
		public static void TexSubImage2D<T8>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T8[] pixels) where T8 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
#endif
		}
		public static void TexSubImage2D<T8>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T8[,] pixels) where T8 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
#endif
		}
		public static void SecondaryColorPointer<T3>(System.Int32 size, OpenTK.Graphics.OpenGL.ColorPointerType type, System.Int32 stride, T3[, ,] pointer) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColorPointer(size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColorPointer(size, type, stride, pointer);
#endif
		}
		public static void SecondaryColorPointer<T3>(System.Int32 size, OpenTK.Graphics.OpenGL.ColorPointerType type, System.Int32 stride, ref T3 pointer) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColorPointer(size, type, stride, ref pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColorPointer(size, type, stride, ref pointer);
#endif
		}
		public static void SelectBuffer(System.Int32 size, System.Int32[] buffer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SelectBuffer(size, buffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SelectBuffer(size, buffer);
#endif
		}
		public static void SelectBuffer(System.Int32 size, out System.Int32 buffer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SelectBuffer(size, out buffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SelectBuffer(size, out buffer);
#endif
		}
		public static void SelectBuffer(System.Int32 size, System.UInt32[] buffer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SelectBuffer(size, buffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SelectBuffer(size, buffer);
#endif
		}
		public static void SelectBuffer(System.Int32 size, out System.UInt32 buffer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SelectBuffer(size, out buffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SelectBuffer(size, out buffer);
#endif
		}
		public static void SeparableFilter2D(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr row, System.IntPtr column)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
#endif
		}
		public static void SeparableFilter2D<T7>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr row, T7[] column) where T7 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
#endif
		}
		public static void SeparableFilter2D<T7>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr row, T7[,] column) where T7 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
#endif
		}
		public static void SeparableFilter2D<T7>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr row, T7[, ,] column) where T7 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
#endif
		}
		public static void SeparableFilter2D<T7>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr row, ref T7 column) where T7 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, ref column);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, ref column);
#endif
		}
		public static void SeparableFilter2D<T6, T7>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T6[] row, T7[, ,] column)
			where T6 : struct
			where T7 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
#endif
		}
		public static void SeparableFilter2D<T6, T7>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T6[,] row, T7[, ,] column)
			where T6 : struct
			where T7 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
#endif
		}
		public static void SeparableFilter2D<T6, T7>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T6[, ,] row, T7[, ,] column)
			where T6 : struct
			where T7 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SeparableFilter2D(target, internalformat, width, height, format, type, row, column);
#endif
		}
		public static void SeparableFilter2D<T6, T7>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, ref T6 row, T7[, ,] column)
			where T6 : struct
			where T7 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SeparableFilter2D(target, internalformat, width, height, format, type, ref row, column);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SeparableFilter2D(target, internalformat, width, height, format, type, ref row, column);
#endif
		}
		public static void ShadeModel(OpenTK.Graphics.OpenGL.ShadingModel mode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ShadeModel(mode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ShadeModel(mode);
#endif
		}
		public static void ShaderSource(System.Int32 shader, System.Int32 count, System.String[] @string, ref System.Int32 length)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ShaderSource(shader, count, @string, ref length);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ShaderSource(shader, count, @string, ref length);
#endif
		}
		public static void ShaderSource(System.UInt32 shader, System.Int32 count, System.String[] @string, ref System.Int32 length)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ShaderSource(shader, count, @string, ref length);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ShaderSource(shader, count, @string, ref length);
#endif
		}
		public static void StencilFunc(OpenTK.Graphics.OpenGL.StencilFunction func, System.Int32 @ref, System.Int32 mask)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.StencilFunc(func, @ref, mask);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.StencilFunc(func, @ref, mask);
#endif
		}
		public static void StencilFunc(OpenTK.Graphics.OpenGL.StencilFunction func, System.Int32 @ref, System.UInt32 mask)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.StencilFunc(func, @ref, mask);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.StencilFunc(func, @ref, mask);
#endif
		}
		public static void StencilFuncSeparate(OpenTK.Graphics.OpenGL.StencilFace face, OpenTK.Graphics.OpenGL.StencilFunction func, System.Int32 @ref, System.Int32 mask)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.StencilFuncSeparate(face, func, @ref, mask);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.StencilFuncSeparate(face, func, @ref, mask);
#endif
		}
		public static void StencilFuncSeparate(OpenTK.Graphics.OpenGL.StencilFace face, OpenTK.Graphics.OpenGL.StencilFunction func, System.Int32 @ref, System.UInt32 mask)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.StencilFuncSeparate(face, func, @ref, mask);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.StencilFuncSeparate(face, func, @ref, mask);
#endif
		}
		public static void StencilMask(System.Int32 mask)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.StencilMask(mask);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.StencilMask(mask);
#endif
		}
		public static void StencilMask(System.UInt32 mask)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.StencilMask(mask);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.StencilMask(mask);
#endif
		}
		public static void StencilMaskSeparate(OpenTK.Graphics.OpenGL.StencilFace face, System.Int32 mask)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.StencilMaskSeparate(face, mask);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.StencilMaskSeparate(face, mask);
#endif
		}
		public static void StencilMaskSeparate(OpenTK.Graphics.OpenGL.StencilFace face, System.UInt32 mask)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.StencilMaskSeparate(face, mask);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.StencilMaskSeparate(face, mask);
#endif
		}
		public static void StencilOp(OpenTK.Graphics.OpenGL.StencilOp fail, OpenTK.Graphics.OpenGL.StencilOp zfail, OpenTK.Graphics.OpenGL.StencilOp zpass)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.StencilOp(fail, zfail, zpass);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.StencilOp(fail, zfail, zpass);
#endif
		}
		public static void StencilOpSeparate(OpenTK.Graphics.OpenGL.StencilFace face, OpenTK.Graphics.OpenGL.StencilOp sfail, OpenTK.Graphics.OpenGL.StencilOp dpfail, OpenTK.Graphics.OpenGL.StencilOp dppass)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.StencilOpSeparate(face, sfail, dpfail, dppass);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.StencilOpSeparate(face, sfail, dpfail, dppass);
#endif
		}
		public static void TexBuffer(OpenTK.Graphics.OpenGL.TextureBufferTarget target, OpenTK.Graphics.OpenGL.SizedInternalFormat internalformat, System.Int32 buffer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexBuffer(target, internalformat, buffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexBuffer(target, internalformat, buffer);
#endif
		}
		public static void TexBuffer(OpenTK.Graphics.OpenGL.TextureBufferTarget target, OpenTK.Graphics.OpenGL.SizedInternalFormat internalformat, System.UInt32 buffer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexBuffer(target, internalformat, buffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexBuffer(target, internalformat, buffer);
#endif
		}
		public static void TexCoord1(System.Double s)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord1(s);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord1(s);
#endif
		}
		public static void TexCoord1(System.Single s)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord1(s);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord1(s);
#endif
		}
		public static void TexCoord1(System.Int32 s)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord1(s);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord1(s);
#endif
		}
		public static void TexCoord1(System.Int16 s)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord1(s);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord1(s);
#endif
		}
		public static void TexCoord2(System.Double s, System.Double t)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord2(s, t);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord2(s, t);
#endif
		}
		public static void TexCoord2(System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord2(v);
#endif
		}
		public static void TexCoord2(ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord2(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord2(ref v);
#endif
		}
		public static void TexCoord2(System.Single s, System.Single t)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord2(s, t);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord2(s, t);
#endif
		}
		public static void TexCoord2(System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord2(v);
#endif
		}
		public static void TexCoord2(ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord2(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord2(ref v);
#endif
		}
		public static void TexCoord2(System.Int32 s, System.Int32 t)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord2(s, t);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord2(s, t);
#endif
		}
		public static void TexCoord2(System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord2(v);
#endif
		}
		public static void TexCoord2(ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord2(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord2(ref v);
#endif
		}
		public static void TexCoord2(System.Int16 s, System.Int16 t)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord2(s, t);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord2(s, t);
#endif
		}
		public static void TexCoord2(System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord2(v);
#endif
		}
		public static void TexCoord2(ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord2(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord2(ref v);
#endif
		}
		public static void TexCoord3(System.Double s, System.Double t, System.Double r)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord3(s, t, r);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord3(s, t, r);
#endif
		}
		public static void TexCoord3(System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord3(v);
#endif
		}
		public static void TexCoord3(ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord3(ref v);
#endif
		}
		public static void TexCoord3(System.Single s, System.Single t, System.Single r)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord3(s, t, r);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord3(s, t, r);
#endif
		}
		public static void TexCoord3(System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord3(v);
#endif
		}
		public static void TexCoord3(ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord3(ref v);
#endif
		}
		public static void TexCoord3(System.Int32 s, System.Int32 t, System.Int32 r)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord3(s, t, r);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord3(s, t, r);
#endif
		}
		public static void TexCoord3(System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord3(v);
#endif
		}
		public static void TexCoord3(ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord3(ref v);
#endif
		}
		public static void TexCoord3(System.Int16 s, System.Int16 t, System.Int16 r)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord3(s, t, r);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord3(s, t, r);
#endif
		}
		public static void TexCoord3(System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord3(v);
#endif
		}
		public static void TexCoord3(ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord3(ref v);
#endif
		}
		public static void TexCoord4(System.Double s, System.Double t, System.Double r, System.Double q)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord4(s, t, r, q);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord4(s, t, r, q);
#endif
		}
		public static void TexCoord4(System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord4(v);
#endif
		}
		public static void TexCoord4(ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.TexCoord4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.TexCoord4(ref v);
#endif
		}
		public static void RasterPos4(System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos4(v);
#endif
		}
		public static void RasterPos4(ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos4(ref v);
#endif
		}
		public static void RasterPos4(System.Int32 x, System.Int32 y, System.Int32 z, System.Int32 w)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos4(x, y, z, w);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos4(x, y, z, w);
#endif
		}
		public static void RasterPos4(System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos4(v);
#endif
		}
		public static void RasterPos4(ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos4(ref v);
#endif
		}
		public static void RasterPos4(System.Int16 x, System.Int16 y, System.Int16 z, System.Int16 w)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos4(x, y, z, w);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos4(x, y, z, w);
#endif
		}
		public static void RasterPos4(System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos4(v);
#endif
		}
		public static void RasterPos4(ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos4(ref v);
#endif
		}
		public static void ReadBuffer(OpenTK.Graphics.OpenGL.ReadBufferMode mode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ReadBuffer(mode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ReadBuffer(mode);
#endif
		}
		public static void ReadPixels(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr pixels)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ReadPixels(x, y, width, height, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ReadPixels(x, y, width, height, format, type, pixels);
#endif
		}
		public static void ReadPixels<T6>(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T6[] pixels) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ReadPixels(x, y, width, height, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ReadPixels(x, y, width, height, format, type, pixels);
#endif
		}
		public static void ReadPixels<T6>(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T6[,] pixels) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ReadPixels(x, y, width, height, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ReadPixels(x, y, width, height, format, type, pixels);
#endif
		}
		public static void ReadPixels<T6>(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T6[, ,] pixels) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ReadPixels(x, y, width, height, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ReadPixels(x, y, width, height, format, type, pixels);
#endif
		}
		public static void ReadPixels<T6>(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, ref T6 pixels) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ReadPixels(x, y, width, height, format, type, ref pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ReadPixels(x, y, width, height, format, type, ref pixels);
#endif
		}
		public static void Rect(System.Double x1, System.Double y1, System.Double x2, System.Double y2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rect(x1, y1, x2, y2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rect(x1, y1, x2, y2);
#endif
		}
		public static void Rect(System.Double[] v1, System.Double[] v2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rect(v1, v2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rect(v1, v2);
#endif
		}
		public static void Rect(ref System.Double v1, ref System.Double v2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rect(ref v1, ref v2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rect(ref v1, ref v2);
#endif
		}
		public static void Rect(System.Single x1, System.Single y1, System.Single x2, System.Single y2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rect(x1, y1, x2, y2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rect(x1, y1, x2, y2);
#endif
		}
		public static void Rect(System.Single[] v1, System.Single[] v2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rect(v1, v2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rect(v1, v2);
#endif
		}
		public static void Rect(ref System.Single v1, ref System.Single v2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rect(ref v1, ref v2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rect(ref v1, ref v2);
#endif
		}
		public static void Rect(System.Int32 x1, System.Int32 y1, System.Int32 x2, System.Int32 y2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rect(x1, y1, x2, y2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rect(x1, y1, x2, y2);
#endif
		}
		public static void Rect(System.Int32[] v1, System.Int32[] v2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rect(v1, v2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rect(v1, v2);
#endif
		}
		public static void Rect(ref System.Int32 v1, ref System.Int32 v2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rect(ref v1, ref v2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rect(ref v1, ref v2);
#endif
		}
		public static void Rects(System.Int16 x1, System.Int16 y1, System.Int16 x2, System.Int16 y2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rects(x1, y1, x2, y2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rects(x1, y1, x2, y2);
#endif
		}
		public static void Rect(System.Int16[] v1, System.Int16[] v2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rect(v1, v2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rect(v1, v2);
#endif
		}
		public static void Rect(ref System.Int16 v1, ref System.Int16 v2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rect(ref v1, ref v2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rect(ref v1, ref v2);
#endif
		}
		public static void RenderbufferStorage(OpenTK.Graphics.OpenGL.RenderbufferTarget target, OpenTK.Graphics.OpenGL.RenderbufferStorage internalformat, System.Int32 width, System.Int32 height)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RenderbufferStorage(target, internalformat, width, height);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RenderbufferStorage(target, internalformat, width, height);
#endif
		}
		public static void RenderbufferStorageMultisample(OpenTK.Graphics.OpenGL.RenderbufferTarget target, System.Int32 samples, OpenTK.Graphics.OpenGL.RenderbufferStorage internalformat, System.Int32 width, System.Int32 height)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RenderbufferStorageMultisample(target, samples, internalformat, width, height);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RenderbufferStorageMultisample(target, samples, internalformat, width, height);
#endif
		}
		public static System.Int32 RenderMode(OpenTK.Graphics.OpenGL.RenderingMode mode)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.RenderMode(mode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.RenderMode(mode);
#endif
		}
		public static void ResetHistogram(OpenTK.Graphics.OpenGL.HistogramTarget target)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ResetHistogram(target);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ResetHistogram(target);
#endif
		}
		public static void ResetMinmax(OpenTK.Graphics.OpenGL.MinmaxTarget target)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ResetMinmax(target);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ResetMinmax(target);
#endif
		}
		public static void Rotate(System.Double angle, System.Double x, System.Double y, System.Double z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rotate(angle, x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rotate(angle, x, y, z);
#endif
		}
		public static void Rotate(System.Single angle, System.Single x, System.Single y, System.Single z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Rotate(angle, x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Rotate(angle, x, y, z);
#endif
		}
		public static void SampleCoverage(System.Single value, System.Boolean invert)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SampleCoverage(value, invert);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SampleCoverage(value, invert);
#endif
		}
		public static void SampleMask(System.Int32 index, System.Int32 mask)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SampleMask(index, mask);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SampleMask(index, mask);
#endif
		}
		public static void SampleMask(System.UInt32 index, System.UInt32 mask)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SampleMask(index, mask);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SampleMask(index, mask);
#endif
		}
		public static void Scale(System.Double x, System.Double y, System.Double z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Scale(x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Scale(x, y, z);
#endif
		}
		public static void Scale(System.Single x, System.Single y, System.Single z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Scale(x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Scale(x, y, z);
#endif
		}
		public static void Scissor(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Scissor(x, y, width, height);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Scissor(x, y, width, height);
#endif
		}
		public static void SecondaryColor3(System.SByte red, System.SByte green, System.SByte blue)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(red, green, blue);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(red, green, blue);
#endif
		}
		public static void SecondaryColor3(System.SByte[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(v);
#endif
		}
		public static void SecondaryColor3(ref System.SByte v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(ref v);
#endif
		}
		public static void SecondaryColor3(System.Double red, System.Double green, System.Double blue)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(red, green, blue);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(red, green, blue);
#endif
		}
		public static void SecondaryColor3(System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(v);
#endif
		}
		public static void SecondaryColor3(ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(ref v);
#endif
		}
		public static void SecondaryColor3(System.Single red, System.Single green, System.Single blue)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(red, green, blue);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(red, green, blue);
#endif
		}
		public static void SecondaryColor3(System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(v);
#endif
		}
		public static void SecondaryColor3(ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(ref v);
#endif
		}
		public static void SecondaryColor3(System.Int32 red, System.Int32 green, System.Int32 blue)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(red, green, blue);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(red, green, blue);
#endif
		}
		public static void SecondaryColor3(System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(v);
#endif
		}
		public static void SecondaryColor3(ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(ref v);
#endif
		}
		public static void SecondaryColor3(System.Int16 red, System.Int16 green, System.Int16 blue)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(red, green, blue);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(red, green, blue);
#endif
		}
		public static void SecondaryColor3(System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(v);
#endif
		}
		public static void SecondaryColor3(ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(ref v);
#endif
		}
		public static void SecondaryColor3(System.Byte red, System.Byte green, System.Byte blue)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(red, green, blue);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(red, green, blue);
#endif
		}
		public static void SecondaryColor3(System.Byte[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(v);
#endif
		}
		public static void SecondaryColor3(ref System.Byte v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(ref v);
#endif
		}
		public static void SecondaryColor3(System.UInt32 red, System.UInt32 green, System.UInt32 blue)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(red, green, blue);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(red, green, blue);
#endif
		}
		public static void SecondaryColor3(System.UInt32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(v);
#endif
		}
		public static void SecondaryColor3(ref System.UInt32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(ref v);
#endif
		}
		public static void SecondaryColor3(System.UInt16 red, System.UInt16 green, System.UInt16 blue)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(red, green, blue);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(red, green, blue);
#endif
		}
		public static void SecondaryColor3(System.UInt16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(v);
#endif
		}
		public static void SecondaryColor3(ref System.UInt16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColor3(ref v);
#endif
		}
		public static void SecondaryColorPointer(System.Int32 size, OpenTK.Graphics.OpenGL.ColorPointerType type, System.Int32 stride, System.IntPtr pointer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColorPointer(size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColorPointer(size, type, stride, pointer);
#endif
		}
		public static void SecondaryColorPointer<T3>(System.Int32 size, OpenTK.Graphics.OpenGL.ColorPointerType type, System.Int32 stride, T3[] pointer) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColorPointer(size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColorPointer(size, type, stride, pointer);
#endif
		}
		public static void SecondaryColorPointer<T3>(System.Int32 size, OpenTK.Graphics.OpenGL.ColorPointerType type, System.Int32 stride, T3[,] pointer) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.SecondaryColorPointer(size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.SecondaryColorPointer(size, type, stride, pointer);
#endif
		}
		public static void PixelMap(OpenTK.Graphics.OpenGL.PixelMap map, System.Int32 mapsize, ref System.Int32 values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, ref values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, ref values);
#endif
		}
		public static void PixelMap(OpenTK.Graphics.OpenGL.PixelMap map, System.Int32 mapsize, System.UInt32[] values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, values);
#endif
		}
		public static void PixelMap(OpenTK.Graphics.OpenGL.PixelMap map, System.Int32 mapsize, ref System.UInt32 values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, ref values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, ref values);
#endif
		}
		public static void PixelMap(OpenTK.Graphics.OpenGL.PixelMap map, System.Int32 mapsize, System.Int16[] values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, values);
#endif
		}
		public static void PixelMap(OpenTK.Graphics.OpenGL.PixelMap map, System.Int32 mapsize, ref System.Int16 values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, ref values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, ref values);
#endif
		}
		public static void PixelMap(OpenTK.Graphics.OpenGL.PixelMap map, System.Int32 mapsize, System.UInt16[] values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, values);
#endif
		}
		public static void PixelMap(OpenTK.Graphics.OpenGL.PixelMap map, System.Int32 mapsize, ref System.UInt16 values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, ref values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, ref values);
#endif
		}
		public static void PixelStore(OpenTK.Graphics.OpenGL.PixelStoreParameter pname, System.Single param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PixelStore(pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PixelStore(pname, param);
#endif
		}
		public static void PixelStore(OpenTK.Graphics.OpenGL.PixelStoreParameter pname, System.Int32 param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PixelStore(pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PixelStore(pname, param);
#endif
		}
		public static void PixelTransfer(OpenTK.Graphics.OpenGL.PixelTransferParameter pname, System.Single param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PixelTransfer(pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PixelTransfer(pname, param);
#endif
		}
		public static void PixelTransfer(OpenTK.Graphics.OpenGL.PixelTransferParameter pname, System.Int32 param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PixelTransfer(pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PixelTransfer(pname, param);
#endif
		}
		public static void PixelZoom(System.Single xfactor, System.Single yfactor)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PixelZoom(xfactor, yfactor);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PixelZoom(xfactor, yfactor);
#endif
		}
		public static void PointParameter(OpenTK.Graphics.OpenGL.PointParameterName pname, System.Single param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PointParameter(pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PointParameter(pname, param);
#endif
		}
		public static void PointParameter(OpenTK.Graphics.OpenGL.PointParameterName pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PointParameter(pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PointParameter(pname, @params);
#endif
		}
		public static void PointParameter(OpenTK.Graphics.OpenGL.PointParameterName pname, System.Int32 param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PointParameter(pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PointParameter(pname, param);
#endif
		}
		public static void PointParameter(OpenTK.Graphics.OpenGL.PointParameterName pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PointParameter(pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PointParameter(pname, @params);
#endif
		}
		public static void PointSize(System.Single size)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PointSize(size);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PointSize(size);
#endif
		}
		public static void PolygonMode(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.PolygonMode mode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PolygonMode(face, mode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PolygonMode(face, mode);
#endif
		}
		public static void PolygonOffset(System.Single factor, System.Single units)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PolygonOffset(factor, units);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PolygonOffset(factor, units);
#endif
		}
		public static void PolygonStipple(System.Byte[] mask)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PolygonStipple(mask);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PolygonStipple(mask);
#endif
		}
		public static void PolygonStipple(ref System.Byte mask)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PolygonStipple(ref mask);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PolygonStipple(ref mask);
#endif
		}
		public static void PopAttrib()
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PopAttrib();
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PopAttrib();
#endif
		}
		public static void PopClientAttrib()
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PopClientAttrib();
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PopClientAttrib();
#endif
		}
		public static void PopMatrix()
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PopMatrix();
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PopMatrix();
#endif
		}
		public static void PopName()
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PopName();
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PopName();
#endif
		}
		public static void PrimitiveRestartIndex(System.Int32 index)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PrimitiveRestartIndex(index);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PrimitiveRestartIndex(index);
#endif
		}
		public static void PrimitiveRestartIndex(System.UInt32 index)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PrimitiveRestartIndex(index);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PrimitiveRestartIndex(index);
#endif
		}
		public static void PrioritizeTextures(System.Int32 n, System.Int32[] textures, System.Single[] priorities)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PrioritizeTextures(n, textures, priorities);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PrioritizeTextures(n, textures, priorities);
#endif
		}
		public static void PrioritizeTextures(System.Int32 n, ref System.Int32 textures, ref System.Single priorities)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PrioritizeTextures(n, ref textures, ref priorities);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PrioritizeTextures(n, ref textures, ref priorities);
#endif
		}
		public static void PrioritizeTextures(System.Int32 n, System.UInt32[] textures, System.Single[] priorities)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PrioritizeTextures(n, textures, priorities);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PrioritizeTextures(n, textures, priorities);
#endif
		}
		public static void PrioritizeTextures(System.Int32 n, ref System.UInt32 textures, ref System.Single priorities)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PrioritizeTextures(n, ref textures, ref priorities);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PrioritizeTextures(n, ref textures, ref priorities);
#endif
		}
		public static void ProgramParameter(System.Int32 program, OpenTK.Graphics.OpenGL.Version32 pname, System.Int32 value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ProgramParameter(program, pname, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ProgramParameter(program, pname, value);
#endif
		}
		public static void ProgramParameter(System.UInt32 program, OpenTK.Graphics.OpenGL.Version32 pname, System.Int32 value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ProgramParameter(program, pname, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ProgramParameter(program, pname, value);
#endif
		}
		public static void ProvokingVertex(OpenTK.Graphics.OpenGL.ProvokingVertexMode mode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ProvokingVertex(mode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ProvokingVertex(mode);
#endif
		}
		public static void PushAttrib(OpenTK.Graphics.OpenGL.AttribMask mask)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PushAttrib(mask);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PushAttrib(mask);
#endif
		}
		public static void PushClientAttrib(OpenTK.Graphics.OpenGL.ClientAttribMask mask)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PushClientAttrib(mask);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PushClientAttrib(mask);
#endif
		}
		public static void PushMatrix()
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PushMatrix();
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PushMatrix();
#endif
		}
		public static void PushName(System.Int32 name)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PushName(name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PushName(name);
#endif
		}
		public static void PushName(System.UInt32 name)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PushName(name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PushName(name);
#endif
		}
		public static void RasterPos2(System.Double x, System.Double y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos2(x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos2(x, y);
#endif
		}
		public static void RasterPos2(System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos2(v);
#endif
		}
		public static void RasterPos2(ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos2(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos2(ref v);
#endif
		}
		public static void RasterPos2(System.Single x, System.Single y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos2(x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos2(x, y);
#endif
		}
		public static void RasterPos2(System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos2(v);
#endif
		}
		public static void RasterPos2(ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos2(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos2(ref v);
#endif
		}
		public static void RasterPos2(System.Int32 x, System.Int32 y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos2(x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos2(x, y);
#endif
		}
		public static void RasterPos2(System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos2(v);
#endif
		}
		public static void RasterPos2(ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos2(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos2(ref v);
#endif
		}
		public static void RasterPos2(System.Int16 x, System.Int16 y)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos2(x, y);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos2(x, y);
#endif
		}
		public static void RasterPos2(System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos2(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos2(v);
#endif
		}
		public static void RasterPos2(ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos2(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos2(ref v);
#endif
		}
		public static void RasterPos3(System.Double x, System.Double y, System.Double z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos3(x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos3(x, y, z);
#endif
		}
		public static void RasterPos3(System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos3(v);
#endif
		}
		public static void RasterPos3(ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos3(ref v);
#endif
		}
		public static void RasterPos3(System.Single x, System.Single y, System.Single z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos3(x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos3(x, y, z);
#endif
		}
		public static void RasterPos3(System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos3(v);
#endif
		}
		public static void RasterPos3(ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos3(ref v);
#endif
		}
		public static void RasterPos3(System.Int32 x, System.Int32 y, System.Int32 z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos3(x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos3(x, y, z);
#endif
		}
		public static void RasterPos3(System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos3(v);
#endif
		}
		public static void RasterPos3(ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos3(ref v);
#endif
		}
		public static void RasterPos3(System.Int16 x, System.Int16 y, System.Int16 z)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos3(x, y, z);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos3(x, y, z);
#endif
		}
		public static void RasterPos3(System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos3(v);
#endif
		}
		public static void RasterPos3(ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos3(ref v);
#endif
		}
		public static void RasterPos4(System.Double x, System.Double y, System.Double z, System.Double w)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos4(x, y, z, w);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos4(x, y, z, w);
#endif
		}
		public static void RasterPos4(System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos4(v);
#endif
		}
		public static void RasterPos4(ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos4(ref v);
#endif
		}
		public static void RasterPos4(System.Single x, System.Single y, System.Single z, System.Single w)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.RasterPos4(x, y, z, w);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.RasterPos4(x, y, z, w);
#endif
		}
		public static void MultiTexCoord3(OpenTK.Graphics.OpenGL.TextureUnit target, System.Double s, System.Double t, System.Double r)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, s, t, r);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, s, t, r);
#endif
		}
		public static void MultiTexCoord3(OpenTK.Graphics.OpenGL.TextureUnit target, System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, v);
#endif
		}
		public static void MultiTexCoord3(OpenTK.Graphics.OpenGL.TextureUnit target, ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, ref v);
#endif
		}
		public static void MultiTexCoord3(OpenTK.Graphics.OpenGL.TextureUnit target, System.Single s, System.Single t, System.Single r)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, s, t, r);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, s, t, r);
#endif
		}
		public static void MultiTexCoord3(OpenTK.Graphics.OpenGL.TextureUnit target, System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, v);
#endif
		}
		public static void MultiTexCoord3(OpenTK.Graphics.OpenGL.TextureUnit target, ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, ref v);
#endif
		}
		public static void MultiTexCoord3(OpenTK.Graphics.OpenGL.TextureUnit target, System.Int32 s, System.Int32 t, System.Int32 r)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, s, t, r);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, s, t, r);
#endif
		}
		public static void MultiTexCoord3(OpenTK.Graphics.OpenGL.TextureUnit target, System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, v);
#endif
		}
		public static void MultiTexCoord3(OpenTK.Graphics.OpenGL.TextureUnit target, ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, ref v);
#endif
		}
		public static void MultiTexCoord3(OpenTK.Graphics.OpenGL.TextureUnit target, System.Int16 s, System.Int16 t, System.Int16 r)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, s, t, r);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, s, t, r);
#endif
		}
		public static void MultiTexCoord3(OpenTK.Graphics.OpenGL.TextureUnit target, System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, v);
#endif
		}
		public static void MultiTexCoord3(OpenTK.Graphics.OpenGL.TextureUnit target, ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord3(target, ref v);
#endif
		}
		public static void MultiTexCoord4(OpenTK.Graphics.OpenGL.TextureUnit target, System.Double s, System.Double t, System.Double r, System.Double q)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, s, t, r, q);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, s, t, r, q);
#endif
		}
		public static void MultiTexCoord4(OpenTK.Graphics.OpenGL.TextureUnit target, System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, v);
#endif
		}
		public static void MultiTexCoord4(OpenTK.Graphics.OpenGL.TextureUnit target, ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, ref v);
#endif
		}
		public static void MultiTexCoord4(OpenTK.Graphics.OpenGL.TextureUnit target, System.Single s, System.Single t, System.Single r, System.Single q)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, s, t, r, q);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, s, t, r, q);
#endif
		}
		public static void MultiTexCoord4(OpenTK.Graphics.OpenGL.TextureUnit target, System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, v);
#endif
		}
		public static void MultiTexCoord4(OpenTK.Graphics.OpenGL.TextureUnit target, ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, ref v);
#endif
		}
		public static void MultiTexCoord4(OpenTK.Graphics.OpenGL.TextureUnit target, System.Int32 s, System.Int32 t, System.Int32 r, System.Int32 q)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, s, t, r, q);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, s, t, r, q);
#endif
		}
		public static void MultiTexCoord4(OpenTK.Graphics.OpenGL.TextureUnit target, System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, v);
#endif
		}
		public static void MultiTexCoord4(OpenTK.Graphics.OpenGL.TextureUnit target, ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, ref v);
#endif
		}
		public static void MultiTexCoord4(OpenTK.Graphics.OpenGL.TextureUnit target, System.Int16 s, System.Int16 t, System.Int16 r, System.Int16 q)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, s, t, r, q);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, s, t, r, q);
#endif
		}
		public static void MultiTexCoord4(OpenTK.Graphics.OpenGL.TextureUnit target, System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, v);
#endif
		}
		public static void MultiTexCoord4(OpenTK.Graphics.OpenGL.TextureUnit target, ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord4(target, ref v);
#endif
		}
		public static void MultMatrix(System.Double[] m)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultMatrix(m);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultMatrix(m);
#endif
		}
		public static void MultMatrix(ref System.Double m)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultMatrix(ref m);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultMatrix(ref m);
#endif
		}
		public static void MultMatrix(System.Single[] m)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultMatrix(m);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultMatrix(m);
#endif
		}
		public static void MultMatrix(ref System.Single m)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultMatrix(ref m);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultMatrix(ref m);
#endif
		}
		public static void MultTransposeMatrix(System.Double[] m)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultTransposeMatrix(m);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultTransposeMatrix(m);
#endif
		}
		public static void MultTransposeMatrix(ref System.Double m)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultTransposeMatrix(ref m);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultTransposeMatrix(ref m);
#endif
		}
		public static void MultTransposeMatrix(System.Single[] m)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultTransposeMatrix(m);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultTransposeMatrix(m);
#endif
		}
		public static void MultTransposeMatrix(ref System.Single m)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultTransposeMatrix(ref m);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultTransposeMatrix(ref m);
#endif
		}
		public static void NewList(System.Int32 list, OpenTK.Graphics.OpenGL.ListMode mode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.NewList(list, mode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.NewList(list, mode);
#endif
		}
		public static void NewList(System.UInt32 list, OpenTK.Graphics.OpenGL.ListMode mode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.NewList(list, mode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.NewList(list, mode);
#endif
		}
		public static void Normal3(System.Byte nx, System.Byte ny, System.Byte nz)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(nx, ny, nz);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(nx, ny, nz);
#endif
		}
		public static void Normal3(System.SByte nx, System.SByte ny, System.SByte nz)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(nx, ny, nz);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(nx, ny, nz);
#endif
		}
		public static void Normal3(System.Byte[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(v);
#endif
		}
		public static void Normal3(ref System.Byte v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(ref v);
#endif
		}
		public static void Normal3(System.SByte[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(v);
#endif
		}
		public static void Normal3(ref System.SByte v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(ref v);
#endif
		}
		public static void Normal3(System.Double nx, System.Double ny, System.Double nz)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(nx, ny, nz);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(nx, ny, nz);
#endif
		}
		public static void Normal3(System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(v);
#endif
		}
		public static void Normal3(ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(ref v);
#endif
		}
		public static void Normal3(System.Single nx, System.Single ny, System.Single nz)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(nx, ny, nz);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(nx, ny, nz);
#endif
		}
		public static void Normal3(System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(v);
#endif
		}
		public static void Normal3(ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(ref v);
#endif
		}
		public static void Normal3(System.Int32 nx, System.Int32 ny, System.Int32 nz)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(nx, ny, nz);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(nx, ny, nz);
#endif
		}
		public static void Normal3(System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(v);
#endif
		}
		public static void Normal3(ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(ref v);
#endif
		}
		public static void Normal3(System.Int16 nx, System.Int16 ny, System.Int16 nz)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(nx, ny, nz);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(nx, ny, nz);
#endif
		}
		public static void Normal3(System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(v);
#endif
		}
		public static void Normal3(ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Normal3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Normal3(ref v);
#endif
		}
		public static void NormalPointer(OpenTK.Graphics.OpenGL.NormalPointerType type, System.Int32 stride, System.IntPtr pointer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.NormalPointer(type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.NormalPointer(type, stride, pointer);
#endif
		}
		public static void NormalPointer<T2>(OpenTK.Graphics.OpenGL.NormalPointerType type, System.Int32 stride, T2[] pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.NormalPointer(type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.NormalPointer(type, stride, pointer);
#endif
		}
		public static void NormalPointer<T2>(OpenTK.Graphics.OpenGL.NormalPointerType type, System.Int32 stride, T2[,] pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.NormalPointer(type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.NormalPointer(type, stride, pointer);
#endif
		}
		public static void NormalPointer<T2>(OpenTK.Graphics.OpenGL.NormalPointerType type, System.Int32 stride, T2[, ,] pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.NormalPointer(type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.NormalPointer(type, stride, pointer);
#endif
		}
		public static void NormalPointer<T2>(OpenTK.Graphics.OpenGL.NormalPointerType type, System.Int32 stride, ref T2 pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.NormalPointer(type, stride, ref pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.NormalPointer(type, stride, ref pointer);
#endif
		}
		public static void Ortho(System.Double left, System.Double right, System.Double bottom, System.Double top, System.Double zNear, System.Double zFar)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Ortho(left, right, bottom, top, zNear, zFar);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Ortho(left, right, bottom, top, zNear, zFar);
#endif
		}
		public static void PassThrough(System.Single token)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PassThrough(token);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PassThrough(token);
#endif
		}
		public static void PixelMap(OpenTK.Graphics.OpenGL.PixelMap map, System.Int32 mapsize, System.Single[] values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, values);
#endif
		}
		public static void PixelMap(OpenTK.Graphics.OpenGL.PixelMap map, System.Int32 mapsize, ref System.Single values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, ref values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, ref values);
#endif
		}
		public static void PixelMap(OpenTK.Graphics.OpenGL.PixelMap map, System.Int32 mapsize, System.Int32[] values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.PixelMap(map, mapsize, values);
#endif
		}
		public static void MapGrid1(System.Int32 un, System.Double u1, System.Double u2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MapGrid1(un, u1, u2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MapGrid1(un, u1, u2);
#endif
		}
		public static void MapGrid1(System.Int32 un, System.Single u1, System.Single u2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MapGrid1(un, u1, u2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MapGrid1(un, u1, u2);
#endif
		}
		public static void MapGrid2(System.Int32 un, System.Double u1, System.Double u2, System.Int32 vn, System.Double v1, System.Double v2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MapGrid2(un, u1, u2, vn, v1, v2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MapGrid2(un, u1, u2, vn, v1, v2);
#endif
		}
		public static void MapGrid2(System.Int32 un, System.Single u1, System.Single u2, System.Int32 vn, System.Single v1, System.Single v2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MapGrid2(un, u1, u2, vn, v1, v2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MapGrid2(un, u1, u2, vn, v1, v2);
#endif
		}
		public static void Material(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, System.Single param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Material(face, pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Material(face, pname, param);
#endif
		}
		public static void Material(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Material(face, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Material(face, pname, @params);
#endif
		}
		public static void Material(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, System.Int32 param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Material(face, pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Material(face, pname, param);
#endif
		}
		public static void Material(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Material(face, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Material(face, pname, @params);
#endif
		}
		public static void MatrixMode(OpenTK.Graphics.OpenGL.MatrixMode mode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MatrixMode(mode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MatrixMode(mode);
#endif
		}
		public static void Minmax(OpenTK.Graphics.OpenGL.MinmaxTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Boolean sink)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Minmax(target, internalformat, sink);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Minmax(target, internalformat, sink);
#endif
		}
		public static void MinSampleShading(System.Single value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MinSampleShading(value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MinSampleShading(value);
#endif
		}
		public static void MultiDrawArrays(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32[] first, System.Int32[] count, System.Int32 primcount)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawArrays(mode, first, count, primcount);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawArrays(mode, first, count, primcount);
#endif
		}
		public static void MultiDrawArrays(OpenTK.Graphics.OpenGL.BeginMode mode, out System.Int32 first, out System.Int32 count, System.Int32 primcount)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawArrays(mode, out first, out count, primcount);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawArrays(mode, out first, out count, primcount);
#endif
		}
		public static void MultiDrawElements(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32[] count, OpenTK.Graphics.OpenGL.DrawElementsType type, System.IntPtr indices, System.Int32 primcount)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, count, type, indices, primcount);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, count, type, indices, primcount);
#endif
		}
		public static void MultiDrawElements<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32[] count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[] indices, System.Int32 primcount) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, count, type, indices, primcount);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, count, type, indices, primcount);
#endif
		}
		public static void MultiDrawElements<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32[] count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[,] indices, System.Int32 primcount) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, count, type, indices, primcount);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, count, type, indices, primcount);
#endif
		}
		public static void MultiDrawElements<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32[] count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[, ,] indices, System.Int32 primcount) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, count, type, indices, primcount);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, count, type, indices, primcount);
#endif
		}
		public static void MultiDrawElements<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32[] count, OpenTK.Graphics.OpenGL.DrawElementsType type, ref T3 indices, System.Int32 primcount) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, count, type, ref indices, primcount);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, count, type, ref indices, primcount);
#endif
		}
		public static void MultiDrawElements(OpenTK.Graphics.OpenGL.BeginMode mode, ref System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, System.IntPtr indices, System.Int32 primcount)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, ref count, type, indices, primcount);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, ref count, type, indices, primcount);
#endif
		}
		public static void MultiDrawElements<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, ref System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[] indices, System.Int32 primcount) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, ref count, type, indices, primcount);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, ref count, type, indices, primcount);
#endif
		}
		public static void MultiDrawElements<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, ref System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[,] indices, System.Int32 primcount) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, ref count, type, indices, primcount);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, ref count, type, indices, primcount);
#endif
		}
		public static void MultiDrawElements<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, ref System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[, ,] indices, System.Int32 primcount) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, ref count, type, indices, primcount);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, ref count, type, indices, primcount);
#endif
		}
		public static void MultiDrawElements<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, ref System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, ref T3 indices, System.Int32 primcount) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, ref count, type, ref indices, primcount);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElements(mode, ref count, type, ref indices, primcount);
#endif
		}
		public static void MultiDrawElementsBaseVertex(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32[] count, OpenTK.Graphics.OpenGL.DrawElementsType type, System.IntPtr indices, System.Int32 primcount, System.Int32[] basevertex)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, count, type, indices, primcount, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, count, type, indices, primcount, basevertex);
#endif
		}
		public static void MultiDrawElementsBaseVertex<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32[] count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[] indices, System.Int32 primcount, System.Int32[] basevertex) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, count, type, indices, primcount, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, count, type, indices, primcount, basevertex);
#endif
		}
		public static void MultiDrawElementsBaseVertex<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32[] count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[,] indices, System.Int32 primcount, System.Int32[] basevertex) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, count, type, indices, primcount, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, count, type, indices, primcount, basevertex);
#endif
		}
		public static void MultiDrawElementsBaseVertex<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32[] count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[, ,] indices, System.Int32 primcount, System.Int32[] basevertex) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, count, type, indices, primcount, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, count, type, indices, primcount, basevertex);
#endif
		}
		public static void MultiDrawElementsBaseVertex<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32[] count, OpenTK.Graphics.OpenGL.DrawElementsType type, ref T3 indices, System.Int32 primcount, System.Int32[] basevertex) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, count, type, ref indices, primcount, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, count, type, ref indices, primcount, basevertex);
#endif
		}
		public static void MultiDrawElementsBaseVertex(OpenTK.Graphics.OpenGL.BeginMode mode, ref System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, System.IntPtr indices, System.Int32 primcount, ref System.Int32 basevertex)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, ref count, type, indices, primcount, ref basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, ref count, type, indices, primcount, ref basevertex);
#endif
		}
		public static void MultiDrawElementsBaseVertex<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, ref System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[] indices, System.Int32 primcount, ref System.Int32 basevertex) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, ref count, type, indices, primcount, ref basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, ref count, type, indices, primcount, ref basevertex);
#endif
		}
		public static void MultiDrawElementsBaseVertex<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, ref System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[,] indices, System.Int32 primcount, ref System.Int32 basevertex) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, ref count, type, indices, primcount, ref basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, ref count, type, indices, primcount, ref basevertex);
#endif
		}
		public static void MultiDrawElementsBaseVertex<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, ref System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[, ,] indices, System.Int32 primcount, ref System.Int32 basevertex) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, ref count, type, indices, primcount, ref basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, ref count, type, indices, primcount, ref basevertex);
#endif
		}
		public static void MultiDrawElementsBaseVertex<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, ref System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, ref T3 indices, System.Int32 primcount, ref System.Int32 basevertex) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, ref count, type, ref indices, primcount, ref basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiDrawElementsBaseVertex(mode, ref count, type, ref indices, primcount, ref basevertex);
#endif
		}
		public static void MultiTexCoord1(OpenTK.Graphics.OpenGL.TextureUnit target, System.Double s)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord1(target, s);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord1(target, s);
#endif
		}
		public static void MultiTexCoord1(OpenTK.Graphics.OpenGL.TextureUnit target, System.Single s)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord1(target, s);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord1(target, s);
#endif
		}
		public static void MultiTexCoord1(OpenTK.Graphics.OpenGL.TextureUnit target, System.Int32 s)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord1(target, s);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord1(target, s);
#endif
		}
		public static void MultiTexCoord1(OpenTK.Graphics.OpenGL.TextureUnit target, System.Int16 s)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord1(target, s);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord1(target, s);
#endif
		}
		public static void MultiTexCoord2(OpenTK.Graphics.OpenGL.TextureUnit target, System.Double s, System.Double t)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, s, t);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, s, t);
#endif
		}
		public static void MultiTexCoord2(OpenTK.Graphics.OpenGL.TextureUnit target, System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, v);
#endif
		}
		public static void MultiTexCoord2(OpenTK.Graphics.OpenGL.TextureUnit target, ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, ref v);
#endif
		}
		public static void MultiTexCoord2(OpenTK.Graphics.OpenGL.TextureUnit target, System.Single s, System.Single t)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, s, t);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, s, t);
#endif
		}
		public static void MultiTexCoord2(OpenTK.Graphics.OpenGL.TextureUnit target, System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, v);
#endif
		}
		public static void MultiTexCoord2(OpenTK.Graphics.OpenGL.TextureUnit target, ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, ref v);
#endif
		}
		public static void MultiTexCoord2(OpenTK.Graphics.OpenGL.TextureUnit target, System.Int32 s, System.Int32 t)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, s, t);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, s, t);
#endif
		}
		public static void MultiTexCoord2(OpenTK.Graphics.OpenGL.TextureUnit target, System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, v);
#endif
		}
		public static void MultiTexCoord2(OpenTK.Graphics.OpenGL.TextureUnit target, ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, ref v);
#endif
		}
		public static void MultiTexCoord2(OpenTK.Graphics.OpenGL.TextureUnit target, System.Int16 s, System.Int16 t)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, s, t);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, s, t);
#endif
		}
		public static void MultiTexCoord2(OpenTK.Graphics.OpenGL.TextureUnit target, System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, v);
#endif
		}
		public static void MultiTexCoord2(OpenTK.Graphics.OpenGL.TextureUnit target, ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.MultiTexCoord2(target, ref v);
#endif
		}
		public static void IndexPointer<T2>(OpenTK.Graphics.OpenGL.IndexPointerType type, System.Int32 stride, ref T2 pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.IndexPointer(type, stride, ref pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.IndexPointer(type, stride, ref pointer);
#endif
		}
		public static void Index(System.Int16 c)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Index(c);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Index(c);
#endif
		}
		public static void Index(System.Byte c)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Index(c);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Index(c);
#endif
		}
		public static void InitNames()
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.InitNames();
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.InitNames();
#endif
		}
		public static void InterleavedArrays(OpenTK.Graphics.OpenGL.InterleavedArrayFormat format, System.Int32 stride, System.IntPtr pointer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.InterleavedArrays(format, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.InterleavedArrays(format, stride, pointer);
#endif
		}
		public static void InterleavedArrays<T2>(OpenTK.Graphics.OpenGL.InterleavedArrayFormat format, System.Int32 stride, T2[] pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.InterleavedArrays(format, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.InterleavedArrays(format, stride, pointer);
#endif
		}
		public static void InterleavedArrays<T2>(OpenTK.Graphics.OpenGL.InterleavedArrayFormat format, System.Int32 stride, T2[,] pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.InterleavedArrays(format, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.InterleavedArrays(format, stride, pointer);
#endif
		}
		public static void InterleavedArrays<T2>(OpenTK.Graphics.OpenGL.InterleavedArrayFormat format, System.Int32 stride, T2[, ,] pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.InterleavedArrays(format, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.InterleavedArrays(format, stride, pointer);
#endif
		}
		public static void InterleavedArrays<T2>(OpenTK.Graphics.OpenGL.InterleavedArrayFormat format, System.Int32 stride, ref T2 pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.InterleavedArrays(format, stride, ref pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.InterleavedArrays(format, stride, ref pointer);
#endif
		}
		public static System.Boolean IsBuffer(System.Int32 buffer)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsBuffer(buffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsBuffer(buffer);
#endif
		}
		public static System.Boolean IsBuffer(System.UInt32 buffer)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsBuffer(buffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsBuffer(buffer);
#endif
		}
		public static System.Boolean IsEnabled(OpenTK.Graphics.OpenGL.EnableCap cap)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsEnabled(cap);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsEnabled(cap);
#endif
		}
		public static System.Boolean IsEnabled(OpenTK.Graphics.OpenGL.IndexedEnableCap target, System.Int32 index)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsEnabled(target, index);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsEnabled(target, index);
#endif
		}
		public static System.Boolean IsEnabled(OpenTK.Graphics.OpenGL.IndexedEnableCap target, System.UInt32 index)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsEnabled(target, index);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsEnabled(target, index);
#endif
		}
		public static System.Boolean IsFramebuffer(System.Int32 framebuffer)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsFramebuffer(framebuffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsFramebuffer(framebuffer);
#endif
		}
		public static System.Boolean IsFramebuffer(System.UInt32 framebuffer)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsFramebuffer(framebuffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsFramebuffer(framebuffer);
#endif
		}
		public static System.Boolean IsList(System.Int32 list)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsList(list);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsList(list);
#endif
		}
		public static System.Boolean IsList(System.UInt32 list)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsList(list);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsList(list);
#endif
		}
		public static System.Boolean IsProgram(System.Int32 program)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsProgram(program);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsProgram(program);
#endif
		}
		public static System.Boolean IsProgram(System.UInt32 program)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsProgram(program);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsProgram(program);
#endif
		}
		public static System.Boolean IsQuery(System.Int32 id)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsQuery(id);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsQuery(id);
#endif
		}
		public static System.Boolean IsQuery(System.UInt32 id)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsQuery(id);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsQuery(id);
#endif
		}
		public static System.Boolean IsRenderbuffer(System.Int32 renderbuffer)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsRenderbuffer(renderbuffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsRenderbuffer(renderbuffer);
#endif
		}
		public static System.Boolean IsRenderbuffer(System.UInt32 renderbuffer)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsRenderbuffer(renderbuffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsRenderbuffer(renderbuffer);
#endif
		}
		public static System.Boolean IsShader(System.Int32 shader)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsShader(shader);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsShader(shader);
#endif
		}
		public static System.Boolean IsShader(System.UInt32 shader)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsShader(shader);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsShader(shader);
#endif
		}
		public static System.Boolean IsSync(System.IntPtr sync)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsSync(sync);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsSync(sync);
#endif
		}
		public static System.Boolean IsTexture(System.Int32 texture)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsTexture(texture);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsTexture(texture);
#endif
		}
		public static System.Boolean IsTexture(System.UInt32 texture)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsTexture(texture);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsTexture(texture);
#endif
		}
		public static System.Boolean IsVertexArray(System.Int32 array)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsVertexArray(array);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsVertexArray(array);
#endif
		}
		public static System.Boolean IsVertexArray(System.UInt32 array)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.IsVertexArray(array);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.IsVertexArray(array);
#endif
		}
		public static void Light(OpenTK.Graphics.OpenGL.LightName light, OpenTK.Graphics.OpenGL.LightParameter pname, System.Single param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Light(light, pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Light(light, pname, param);
#endif
		}
		public static void Light(OpenTK.Graphics.OpenGL.LightName light, OpenTK.Graphics.OpenGL.LightParameter pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Light(light, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Light(light, pname, @params);
#endif
		}
		public static void Light(OpenTK.Graphics.OpenGL.LightName light, OpenTK.Graphics.OpenGL.LightParameter pname, System.Int32 param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Light(light, pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Light(light, pname, param);
#endif
		}
		public static void Light(OpenTK.Graphics.OpenGL.LightName light, OpenTK.Graphics.OpenGL.LightParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Light(light, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Light(light, pname, @params);
#endif
		}
		public static void LightModel(OpenTK.Graphics.OpenGL.LightModelParameter pname, System.Single param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LightModel(pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LightModel(pname, param);
#endif
		}
		public static void LightModel(OpenTK.Graphics.OpenGL.LightModelParameter pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LightModel(pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LightModel(pname, @params);
#endif
		}
		public static void LightModel(OpenTK.Graphics.OpenGL.LightModelParameter pname, System.Int32 param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LightModel(pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LightModel(pname, param);
#endif
		}
		public static void LightModel(OpenTK.Graphics.OpenGL.LightModelParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LightModel(pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LightModel(pname, @params);
#endif
		}
		public static void LineStipple(System.Int32 factor, System.Int16 pattern)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LineStipple(factor, pattern);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LineStipple(factor, pattern);
#endif
		}
		public static void LineStipple(System.Int32 factor, System.UInt16 pattern)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LineStipple(factor, pattern);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LineStipple(factor, pattern);
#endif
		}
		public static void LineWidth(System.Single width)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LineWidth(width);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LineWidth(width);
#endif
		}
		public static void LinkProgram(System.Int32 program)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LinkProgram(program);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LinkProgram(program);
#endif
		}
		public static void LinkProgram(System.UInt32 program)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LinkProgram(program);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LinkProgram(program);
#endif
		}
		public static void ListBase(System.Int32 @base)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ListBase(@base);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ListBase(@base);
#endif
		}
		public static void ListBase(System.UInt32 @base)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ListBase(@base);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ListBase(@base);
#endif
		}
		public static void LoadIdentity()
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LoadIdentity();
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LoadIdentity();
#endif
		}
		public static void LoadMatrix(System.Double[] m)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LoadMatrix(m);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LoadMatrix(m);
#endif
		}
		public static void LoadMatrix(ref System.Double m)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LoadMatrix(ref m);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LoadMatrix(ref m);
#endif
		}
		public static void LoadMatrix(System.Single[] m)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LoadMatrix(m);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LoadMatrix(m);
#endif
		}
		public static void LoadMatrix(ref System.Single m)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LoadMatrix(ref m);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LoadMatrix(ref m);
#endif
		}
		public static void LoadName(System.Int32 name)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LoadName(name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LoadName(name);
#endif
		}
		public static void LoadName(System.UInt32 name)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LoadName(name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LoadName(name);
#endif
		}
		public static void LoadTransposeMatrix(System.Double[] m)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LoadTransposeMatrix(m);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LoadTransposeMatrix(m);
#endif
		}
		public static void LoadTransposeMatrix(ref System.Double m)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LoadTransposeMatrix(ref m);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LoadTransposeMatrix(ref m);
#endif
		}
		public static void LoadTransposeMatrix(System.Single[] m)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LoadTransposeMatrix(m);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LoadTransposeMatrix(m);
#endif
		}
		public static void LoadTransposeMatrix(ref System.Single m)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LoadTransposeMatrix(ref m);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LoadTransposeMatrix(ref m);
#endif
		}
		public static void LogicOp(OpenTK.Graphics.OpenGL.LogicOp opcode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.LogicOp(opcode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.LogicOp(opcode);
#endif
		}
		public static void Map1(OpenTK.Graphics.OpenGL.MapTarget target, System.Double u1, System.Double u2, System.Int32 stride, System.Int32 order, System.Double[] points)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Map1(target, u1, u2, stride, order, points);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Map1(target, u1, u2, stride, order, points);
#endif
		}
		public static void Map1(OpenTK.Graphics.OpenGL.MapTarget target, System.Double u1, System.Double u2, System.Int32 stride, System.Int32 order, ref System.Double points)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Map1(target, u1, u2, stride, order, ref points);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Map1(target, u1, u2, stride, order, ref points);
#endif
		}
		public static void Map1(OpenTK.Graphics.OpenGL.MapTarget target, System.Single u1, System.Single u2, System.Int32 stride, System.Int32 order, System.Single[] points)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Map1(target, u1, u2, stride, order, points);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Map1(target, u1, u2, stride, order, points);
#endif
		}
		public static void Map1(OpenTK.Graphics.OpenGL.MapTarget target, System.Single u1, System.Single u2, System.Int32 stride, System.Int32 order, ref System.Single points)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Map1(target, u1, u2, stride, order, ref points);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Map1(target, u1, u2, stride, order, ref points);
#endif
		}
		public static void Map2(OpenTK.Graphics.OpenGL.MapTarget target, System.Double u1, System.Double u2, System.Int32 ustride, System.Int32 uorder, System.Double v1, System.Double v2, System.Int32 vstride, System.Int32 vorder, System.Double[] points)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Map2(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Map2(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
#endif
		}
		public static void Map2(OpenTK.Graphics.OpenGL.MapTarget target, System.Double u1, System.Double u2, System.Int32 ustride, System.Int32 uorder, System.Double v1, System.Double v2, System.Int32 vstride, System.Int32 vorder, ref System.Double points)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Map2(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, ref points);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Map2(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, ref points);
#endif
		}
		public static void Map2(OpenTK.Graphics.OpenGL.MapTarget target, System.Single u1, System.Single u2, System.Int32 ustride, System.Int32 uorder, System.Single v1, System.Single v2, System.Int32 vstride, System.Int32 vorder, System.Single[] points)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Map2(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Map2(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, points);
#endif
		}
		public static void Map2(OpenTK.Graphics.OpenGL.MapTarget target, System.Single u1, System.Single u2, System.Int32 ustride, System.Int32 uorder, System.Single v1, System.Single v2, System.Int32 vstride, System.Int32 vorder, ref System.Single points)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Map2(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, ref points);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Map2(target, u1, u2, ustride, uorder, v1, v2, vstride, vorder, ref points);
#endif
		}
		public static System.IntPtr MapBuffer(OpenTK.Graphics.OpenGL.BufferTarget target, OpenTK.Graphics.OpenGL.BufferAccess access)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.MapBuffer(target, access);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.MapBuffer(target, access);
#endif
		}
		public static System.IntPtr MapBufferRange(OpenTK.Graphics.OpenGL.BufferTarget target, System.IntPtr offset, System.IntPtr length, OpenTK.Graphics.OpenGL.BufferAccessMask access)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.MapBufferRange(target, offset, length, access);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.MapBufferRange(target, offset, length, access);
#endif
		}
		public static void GetTransformFeedbackVarying(System.Int32 program, System.Int32 index, System.Int32 bufSize, out System.Int32 length, out System.Int32 size, out OpenTK.Graphics.OpenGL.ActiveAttribType type, System.Text.StringBuilder name)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTransformFeedbackVarying(program, index, bufSize, out length, out size, out type, name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTransformFeedbackVarying(program, index, bufSize, out length, out size, out type, name);
#endif
		}
		public static void GetTransformFeedbackVarying(System.UInt32 program, System.UInt32 index, System.Int32 bufSize, out System.Int32 length, out System.Int32 size, out OpenTK.Graphics.OpenGL.ActiveAttribType type, System.Text.StringBuilder name)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTransformFeedbackVarying(program, index, bufSize, out length, out size, out type, name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTransformFeedbackVarying(program, index, bufSize, out length, out size, out type, name);
#endif
		}
		public static System.Int32 GetUniformBlockIndex(System.Int32 program, System.String uniformBlockName)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GetUniformBlockIndex(program, uniformBlockName);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GetUniformBlockIndex(program, uniformBlockName);
#endif
		}
		public static System.Int32 GetUniformBlockIndex(System.UInt32 program, System.String uniformBlockName)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GetUniformBlockIndex(program, uniformBlockName);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GetUniformBlockIndex(program, uniformBlockName);
#endif
		}
		public static void GetUniform(System.Int32 program, System.Int32 location, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, @params);
#endif
		}
		public static void GetUniform(System.Int32 program, System.Int32 location, out System.Single @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, out @params);
#endif
		}
		public static void GetUniform(System.UInt32 program, System.Int32 location, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, @params);
#endif
		}
		public static void GetUniform(System.UInt32 program, System.Int32 location, out System.Single @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, out @params);
#endif
		}
		public static void GetUniformIndices(System.Int32 program, System.Int32 uniformCount, System.String[] uniformNames, System.Int32[] uniformIndices)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
#endif
		}
		public static void GetUniformIndices(System.Int32 program, System.Int32 uniformCount, System.String[] uniformNames, out System.Int32 uniformIndices)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetUniformIndices(program, uniformCount, uniformNames, out uniformIndices);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetUniformIndices(program, uniformCount, uniformNames, out uniformIndices);
#endif
		}
		public static void GetUniformIndices(System.UInt32 program, System.Int32 uniformCount, System.String[] uniformNames, System.UInt32[] uniformIndices)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetUniformIndices(program, uniformCount, uniformNames, uniformIndices);
#endif
		}
		public static void GetUniformIndices(System.UInt32 program, System.Int32 uniformCount, System.String[] uniformNames, out System.UInt32 uniformIndices)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetUniformIndices(program, uniformCount, uniformNames, out uniformIndices);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetUniformIndices(program, uniformCount, uniformNames, out uniformIndices);
#endif
		}
		public static void GetUniform(System.Int32 program, System.Int32 location, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, @params);
#endif
		}
		public static void GetUniform(System.Int32 program, System.Int32 location, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, out @params);
#endif
		}
		public static void GetUniform(System.UInt32 program, System.Int32 location, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, @params);
#endif
		}
		public static void GetUniform(System.UInt32 program, System.Int32 location, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, out @params);
#endif
		}
		public static System.Int32 GetUniformLocation(System.Int32 program, System.String name)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GetUniformLocation(program, name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GetUniformLocation(program, name);
#endif
		}
		public static System.Int32 GetUniformLocation(System.UInt32 program, System.String name)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GetUniformLocation(program, name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GetUniformLocation(program, name);
#endif
		}
		public static void GetUniform(System.UInt32 program, System.Int32 location, System.UInt32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, @params);
#endif
		}
		public static void GetUniform(System.UInt32 program, System.Int32 location, out System.UInt32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetUniform(program, location, out @params);
#endif
		}
		public static void GetVertexAttrib(System.Int32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, System.Double[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, @params);
#endif
		}
		public static void GetVertexAttrib(System.Int32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, out System.Double @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, out @params);
#endif
		}
		public static void GetVertexAttrib(System.UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, System.Double[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, @params);
#endif
		}
		public static void GetVertexAttrib(System.UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, out System.Double @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, out @params);
#endif
		}
		public static void GetVertexAttrib(System.Int32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, @params);
#endif
		}
		public static void GetVertexAttrib(System.Int32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, out System.Single @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, out @params);
#endif
		}
		public static void GetVertexAttrib(System.UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, @params);
#endif
		}
		public static void GetVertexAttrib(System.UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, out System.Single @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, out @params);
#endif
		}
		public static void GetVertexAttribI(System.Int32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribI(index, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribI(index, pname, out @params);
#endif
		}
		public static void GetVertexAttribI(System.UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribI(index, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribI(index, pname, out @params);
#endif
		}
		public static void GetVertexAttribI(System.UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, out System.UInt32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribI(index, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribI(index, pname, out @params);
#endif
		}
		public static void GetVertexAttrib(System.Int32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, @params);
#endif
		}
		public static void GetVertexAttrib(System.Int32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, out @params);
#endif
		}
		public static void GetVertexAttrib(System.UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, @params);
#endif
		}
		public static void GetVertexAttrib(System.UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribParameter pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttrib(index, pname, out @params);
#endif
		}
		public static void GetVertexAttribPointer(System.Int32 index, OpenTK.Graphics.OpenGL.VertexAttribPointerParameter pname, System.IntPtr pointer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, pointer);
#endif
		}
		public static void GetVertexAttribPointer<T2>(System.Int32 index, OpenTK.Graphics.OpenGL.VertexAttribPointerParameter pname, T2[] pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, pointer);
#endif
		}
		public static void GetVertexAttribPointer<T2>(System.Int32 index, OpenTK.Graphics.OpenGL.VertexAttribPointerParameter pname, T2[,] pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, pointer);
#endif
		}
		public static void GetVertexAttribPointer<T2>(System.Int32 index, OpenTK.Graphics.OpenGL.VertexAttribPointerParameter pname, T2[, ,] pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, pointer);
#endif
		}
		public static void GetVertexAttribPointer<T2>(System.Int32 index, OpenTK.Graphics.OpenGL.VertexAttribPointerParameter pname, ref T2 pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, ref pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, ref pointer);
#endif
		}
		public static void GetVertexAttribPointer(System.UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribPointerParameter pname, System.IntPtr pointer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, pointer);
#endif
		}
		public static void GetVertexAttribPointer<T2>(System.UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribPointerParameter pname, T2[] pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, pointer);
#endif
		}
		public static void GetVertexAttribPointer<T2>(System.UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribPointerParameter pname, T2[,] pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, pointer);
#endif
		}
		public static void GetVertexAttribPointer<T2>(System.UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribPointerParameter pname, T2[, ,] pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, pointer);
#endif
		}
		public static void GetVertexAttribPointer<T2>(System.UInt32 index, OpenTK.Graphics.OpenGL.VertexAttribPointerParameter pname, ref T2 pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, ref pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetVertexAttribPointer(index, pname, ref pointer);
#endif
		}
		public static void Hint(OpenTK.Graphics.OpenGL.HintTarget target, OpenTK.Graphics.OpenGL.HintMode mode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Hint(target, mode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Hint(target, mode);
#endif
		}
		public static void Histogram(OpenTK.Graphics.OpenGL.HistogramTarget target, System.Int32 width, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Boolean sink)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Histogram(target, width, internalformat, sink);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Histogram(target, width, internalformat, sink);
#endif
		}
		public static void Index(System.Double c)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Index(c);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Index(c);
#endif
		}
		public static void Index(System.Single c)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Index(c);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Index(c);
#endif
		}
		public static void Index(System.Int32 c)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Index(c);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Index(c);
#endif
		}
		public static void IndexMask(System.Int32 mask)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.IndexMask(mask);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.IndexMask(mask);
#endif
		}
		public static void IndexMask(System.UInt32 mask)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.IndexMask(mask);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.IndexMask(mask);
#endif
		}
		public static void IndexPointer(OpenTK.Graphics.OpenGL.IndexPointerType type, System.Int32 stride, System.IntPtr pointer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.IndexPointer(type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.IndexPointer(type, stride, pointer);
#endif
		}
		public static void IndexPointer<T2>(OpenTK.Graphics.OpenGL.IndexPointerType type, System.Int32 stride, T2[] pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.IndexPointer(type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.IndexPointer(type, stride, pointer);
#endif
		}
		public static void IndexPointer<T2>(OpenTK.Graphics.OpenGL.IndexPointerType type, System.Int32 stride, T2[,] pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.IndexPointer(type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.IndexPointer(type, stride, pointer);
#endif
		}
		public static void IndexPointer<T2>(OpenTK.Graphics.OpenGL.IndexPointerType type, System.Int32 stride, T2[, ,] pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.IndexPointer(type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.IndexPointer(type, stride, pointer);
#endif
		}
		public static void GetRenderbufferParameter(OpenTK.Graphics.OpenGL.RenderbufferTarget target, OpenTK.Graphics.OpenGL.RenderbufferParameterName pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetRenderbufferParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetRenderbufferParameter(target, pname, @params);
#endif
		}
		public static void GetRenderbufferParameter(OpenTK.Graphics.OpenGL.RenderbufferTarget target, OpenTK.Graphics.OpenGL.RenderbufferParameterName pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetRenderbufferParameter(target, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetRenderbufferParameter(target, pname, out @params);
#endif
		}
		public static void GetSeparableFilter(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr row, System.IntPtr column, System.IntPtr span)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
#endif
		}
		public static void GetSeparableFilter<T5>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr row, System.IntPtr column, T5[] span) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
#endif
		}
		public static void GetSeparableFilter<T5>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr row, System.IntPtr column, T5[,] span) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
#endif
		}
		public static void GetSeparableFilter<T5>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr row, System.IntPtr column, T5[, ,] span) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
#endif
		}
		public static void GetSeparableFilter<T5>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr row, System.IntPtr column, ref T5 span) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, ref span);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, ref span);
#endif
		}
		public static void GetSeparableFilter<T4, T5>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr row, T4[] column, T5[, ,] span)
			where T4 : struct
			where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
#endif
		}
		public static void GetSeparableFilter<T4, T5>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr row, T4[,] column, T5[, ,] span)
			where T4 : struct
			where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
#endif
		}
		public static void GetSeparableFilter<T4, T5>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr row, T4[, ,] column, T5[, ,] span)
			where T4 : struct
			where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
#endif
		}
		public static void GetSeparableFilter<T4, T5>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr row, ref T4 column, T5[, ,] span)
			where T4 : struct
			where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, ref column, span);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, ref column, span);
#endif
		}
		public static void GetSeparableFilter<T3, T4, T5>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T3[] row, T4[, ,] column, T5[, ,] span)
			where T3 : struct
			where T4 : struct
			where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
#endif
		}
		public static void GetSeparableFilter<T3, T4, T5>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T3[,] row, T4[, ,] column, T5[, ,] span)
			where T3 : struct
			where T4 : struct
			where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
#endif
		}
		public static void GetSeparableFilter<T3, T4, T5>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T3[, ,] row, T4[, ,] column, T5[, ,] span)
			where T3 : struct
			where T4 : struct
			where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, row, column, span);
#endif
		}
		public static void GetSeparableFilter<T3, T4, T5>(OpenTK.Graphics.OpenGL.SeparableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, ref T3 row, T4[, ,] column, T5[, ,] span)
			where T3 : struct
			where T4 : struct
			where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, ref row, column, span);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetSeparableFilter(target, format, type, ref row, column, span);
#endif
		}
		public static void GetShaderInfoLog(System.Int32 shader, System.Int32 bufSize, out System.Int32 length, System.Text.StringBuilder infoLog)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetShaderInfoLog(shader, bufSize, out length, infoLog);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetShaderInfoLog(shader, bufSize, out length, infoLog);
#endif
		}
		public static void GetShaderInfoLog(System.UInt32 shader, System.Int32 bufSize, out System.Int32 length, System.Text.StringBuilder infoLog)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetShaderInfoLog(shader, bufSize, out length, infoLog);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetShaderInfoLog(shader, bufSize, out length, infoLog);
#endif
		}
		public static void GetShader(System.Int32 shader, OpenTK.Graphics.OpenGL.ShaderParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetShader(shader, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetShader(shader, pname, @params);
#endif
		}
		public static void GetShader(System.Int32 shader, OpenTK.Graphics.OpenGL.ShaderParameter pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetShader(shader, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetShader(shader, pname, out @params);
#endif
		}
		public static void GetShader(System.UInt32 shader, OpenTK.Graphics.OpenGL.ShaderParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetShader(shader, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetShader(shader, pname, @params);
#endif
		}
		public static void GetShader(System.UInt32 shader, OpenTK.Graphics.OpenGL.ShaderParameter pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetShader(shader, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetShader(shader, pname, out @params);
#endif
		}
		public static void GetShaderSource(System.Int32 shader, System.Int32 bufSize, out System.Int32 length, System.Text.StringBuilder source)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetShaderSource(shader, bufSize, out length, source);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetShaderSource(shader, bufSize, out length, source);
#endif
		}
		public static void GetShaderSource(System.UInt32 shader, System.Int32 bufSize, out System.Int32 length, System.Text.StringBuilder source)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetShaderSource(shader, bufSize, out length, source);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetShaderSource(shader, bufSize, out length, source);
#endif
		}
		public static System.String GetString(OpenTK.Graphics.OpenGL.StringName name)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GetString(name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GetString(name);
#endif
		}
		public static System.String GetString(OpenTK.Graphics.OpenGL.StringName name, System.Int32 index)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GetString(name, index);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GetString(name, index);
#endif
		}
		public static System.String GetString(OpenTK.Graphics.OpenGL.StringName name, System.UInt32 index)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GetString(name, index);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GetString(name, index);
#endif
		}
		public static void GetSync(System.IntPtr sync, OpenTK.Graphics.OpenGL.ArbSync pname, System.Int32 bufSize, out System.Int32 length, out System.Int32 values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetSync(sync, pname, bufSize, out length, out values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetSync(sync, pname, bufSize, out length, out values);
#endif
		}
		public static void GetTexEnv(OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexEnv(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexEnv(target, pname, @params);
#endif
		}
		public static void GetTexEnv(OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, out System.Single @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexEnv(target, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexEnv(target, pname, out @params);
#endif
		}
		public static void GetTexEnv(OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexEnv(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexEnv(target, pname, @params);
#endif
		}
		public static void GetTexEnv(OpenTK.Graphics.OpenGL.TextureEnvTarget target, OpenTK.Graphics.OpenGL.TextureEnvParameter pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexEnv(target, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexEnv(target, pname, out @params);
#endif
		}
		public static void GetTexGen(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, System.Double[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexGen(coord, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexGen(coord, pname, @params);
#endif
		}
		public static void GetTexGen(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, out System.Double @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexGen(coord, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexGen(coord, pname, out @params);
#endif
		}
		public static void GetTexGen(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexGen(coord, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexGen(coord, pname, @params);
#endif
		}
		public static void GetTexGen(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, out System.Single @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexGen(coord, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexGen(coord, pname, out @params);
#endif
		}
		public static void GetTexGen(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexGen(coord, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexGen(coord, pname, @params);
#endif
		}
		public static void GetTexGen(OpenTK.Graphics.OpenGL.TextureCoordName coord, OpenTK.Graphics.OpenGL.TextureGenParameter pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexGen(coord, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexGen(coord, pname, out @params);
#endif
		}
		public static void GetTexImage(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr pixels)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexImage(target, level, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexImage(target, level, format, type, pixels);
#endif
		}
		public static void GetTexImage<T4>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T4[] pixels) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexImage(target, level, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexImage(target, level, format, type, pixels);
#endif
		}
		public static void GetTexImage<T4>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T4[,] pixels) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexImage(target, level, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexImage(target, level, format, type, pixels);
#endif
		}
		public static void GetTexImage<T4>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T4[, ,] pixels) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexImage(target, level, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexImage(target, level, format, type, pixels);
#endif
		}
		public static void GetTexImage<T4>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, ref T4 pixels) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexImage(target, level, format, type, ref pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexImage(target, level, format, type, ref pixels);
#endif
		}
		public static void GetTexLevelParameter(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.GetTextureParameter pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexLevelParameter(target, level, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexLevelParameter(target, level, pname, @params);
#endif
		}
		public static void GetTexLevelParameter(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.GetTextureParameter pname, out System.Single @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexLevelParameter(target, level, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexLevelParameter(target, level, pname, out @params);
#endif
		}
		public static void GetTexLevelParameter(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.GetTextureParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexLevelParameter(target, level, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexLevelParameter(target, level, pname, @params);
#endif
		}
		public static void GetTexLevelParameter(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.GetTextureParameter pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexLevelParameter(target, level, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexLevelParameter(target, level, pname, out @params);
#endif
		}
		public static void GetTexParameter(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexParameter(target, pname, @params);
#endif
		}
		public static void GetTexParameter(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, out System.Single @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexParameter(target, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexParameter(target, pname, out @params);
#endif
		}
		public static void GetTexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexParameterI(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexParameterI(target, pname, @params);
#endif
		}
		public static void GetTexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexParameterI(target, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexParameterI(target, pname, out @params);
#endif
		}
		public static void GetTexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, System.UInt32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexParameterI(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexParameterI(target, pname, @params);
#endif
		}
		public static void GetTexParameterI(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, out System.UInt32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexParameterI(target, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexParameterI(target, pname, out @params);
#endif
		}
		public static void GetTexParameter(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexParameter(target, pname, @params);
#endif
		}
		public static void GetTexParameter(OpenTK.Graphics.OpenGL.TextureTarget target, OpenTK.Graphics.OpenGL.GetTextureParameter pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetTexParameter(target, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetTexParameter(target, pname, out @params);
#endif
		}
		public static void GetLight(OpenTK.Graphics.OpenGL.LightName light, OpenTK.Graphics.OpenGL.LightParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetLight(light, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetLight(light, pname, @params);
#endif
		}
		public static void GetLight(OpenTK.Graphics.OpenGL.LightName light, OpenTK.Graphics.OpenGL.LightParameter pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetLight(light, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetLight(light, pname, out @params);
#endif
		}
		public static void GetMap(OpenTK.Graphics.OpenGL.MapTarget target, OpenTK.Graphics.OpenGL.GetMapQuery query, System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMap(target, query, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMap(target, query, v);
#endif
		}
		public static void GetMap(OpenTK.Graphics.OpenGL.MapTarget target, OpenTK.Graphics.OpenGL.GetMapQuery query, out System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMap(target, query, out v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMap(target, query, out v);
#endif
		}
		public static void GetMap(OpenTK.Graphics.OpenGL.MapTarget target, OpenTK.Graphics.OpenGL.GetMapQuery query, System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMap(target, query, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMap(target, query, v);
#endif
		}
		public static void GetMap(OpenTK.Graphics.OpenGL.MapTarget target, OpenTK.Graphics.OpenGL.GetMapQuery query, out System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMap(target, query, out v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMap(target, query, out v);
#endif
		}
		public static void GetMap(OpenTK.Graphics.OpenGL.MapTarget target, OpenTK.Graphics.OpenGL.GetMapQuery query, System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMap(target, query, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMap(target, query, v);
#endif
		}
		public static void GetMap(OpenTK.Graphics.OpenGL.MapTarget target, OpenTK.Graphics.OpenGL.GetMapQuery query, out System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMap(target, query, out v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMap(target, query, out v);
#endif
		}
		public static void GetMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMaterial(face, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMaterial(face, pname, @params);
#endif
		}
		public static void GetMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, out System.Single @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMaterial(face, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMaterial(face, pname, out @params);
#endif
		}
		public static void GetMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMaterial(face, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMaterial(face, pname, @params);
#endif
		}
		public static void GetMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.MaterialParameter pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMaterial(face, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMaterial(face, pname, out @params);
#endif
		}
		public static void GetMinmax(OpenTK.Graphics.OpenGL.MinmaxTarget target, System.Boolean reset, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMinmax(target, reset, format, type, values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMinmax(target, reset, format, type, values);
#endif
		}
		public static void GetMinmax<T4>(OpenTK.Graphics.OpenGL.MinmaxTarget target, System.Boolean reset, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T4[] values) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMinmax(target, reset, format, type, values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMinmax(target, reset, format, type, values);
#endif
		}
		public static void GetMinmax<T4>(OpenTK.Graphics.OpenGL.MinmaxTarget target, System.Boolean reset, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T4[,] values) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMinmax(target, reset, format, type, values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMinmax(target, reset, format, type, values);
#endif
		}
		public static void GetMinmax<T4>(OpenTK.Graphics.OpenGL.MinmaxTarget target, System.Boolean reset, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T4[, ,] values) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMinmax(target, reset, format, type, values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMinmax(target, reset, format, type, values);
#endif
		}
		public static void GetMinmax<T4>(OpenTK.Graphics.OpenGL.MinmaxTarget target, System.Boolean reset, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, ref T4 values) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMinmax(target, reset, format, type, ref values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMinmax(target, reset, format, type, ref values);
#endif
		}
		public static void GetMinmaxParameter(OpenTK.Graphics.OpenGL.MinmaxTarget target, OpenTK.Graphics.OpenGL.GetMinmaxParameterPName pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMinmaxParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMinmaxParameter(target, pname, @params);
#endif
		}
		public static void GetMinmaxParameter(OpenTK.Graphics.OpenGL.MinmaxTarget target, OpenTK.Graphics.OpenGL.GetMinmaxParameterPName pname, out System.Single @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMinmaxParameter(target, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMinmaxParameter(target, pname, out @params);
#endif
		}
		public static void GetMinmaxParameter(OpenTK.Graphics.OpenGL.MinmaxTarget target, OpenTK.Graphics.OpenGL.GetMinmaxParameterPName pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMinmaxParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMinmaxParameter(target, pname, @params);
#endif
		}
		public static void GetMinmaxParameter(OpenTK.Graphics.OpenGL.MinmaxTarget target, OpenTK.Graphics.OpenGL.GetMinmaxParameterPName pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMinmaxParameter(target, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMinmaxParameter(target, pname, out @params);
#endif
		}
		public static void GetMultisample(OpenTK.Graphics.OpenGL.GetMultisamplePName pname, System.Int32 index, System.Single[] val)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMultisample(pname, index, val);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMultisample(pname, index, val);
#endif
		}
		public static void GetMultisample(OpenTK.Graphics.OpenGL.GetMultisamplePName pname, System.Int32 index, out System.Single val)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMultisample(pname, index, out val);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMultisample(pname, index, out val);
#endif
		}
		public static void GetMultisample(OpenTK.Graphics.OpenGL.GetMultisamplePName pname, System.UInt32 index, System.Single[] val)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMultisample(pname, index, val);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMultisample(pname, index, val);
#endif
		}
		public static void GetMultisample(OpenTK.Graphics.OpenGL.GetMultisamplePName pname, System.UInt32 index, out System.Single val)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetMultisample(pname, index, out val);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetMultisample(pname, index, out val);
#endif
		}
		public static void GetPixelMap(OpenTK.Graphics.OpenGL.PixelMap map, System.Single[] values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, values);
#endif
		}
		public static void GetPixelMap(OpenTK.Graphics.OpenGL.PixelMap map, out System.Single values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, out values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, out values);
#endif
		}
		public static void GetPixelMap(OpenTK.Graphics.OpenGL.PixelMap map, System.Int32[] values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, values);
#endif
		}
		public static void GetPixelMap(OpenTK.Graphics.OpenGL.PixelMap map, out System.Int32 values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, out values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, out values);
#endif
		}
		public static void GetPixelMap(OpenTK.Graphics.OpenGL.PixelMap map, System.UInt32[] values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, values);
#endif
		}
		public static void GetPixelMap(OpenTK.Graphics.OpenGL.PixelMap map, out System.UInt32 values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, out values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, out values);
#endif
		}
		public static void GetPixelMap(OpenTK.Graphics.OpenGL.PixelMap map, System.Int16[] values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, values);
#endif
		}
		public static void GetPixelMap(OpenTK.Graphics.OpenGL.PixelMap map, out System.Int16 values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, out values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, out values);
#endif
		}
		public static void GetPixelMap(OpenTK.Graphics.OpenGL.PixelMap map, System.UInt16[] values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, values);
#endif
		}
		public static void GetPixelMap(OpenTK.Graphics.OpenGL.PixelMap map, out System.UInt16 values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, out values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetPixelMap(map, out values);
#endif
		}
		public static void GetPointer(OpenTK.Graphics.OpenGL.GetPointervPName pname, System.IntPtr @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetPointer(pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetPointer(pname, @params);
#endif
		}
		public static void GetPointer<T1>(OpenTK.Graphics.OpenGL.GetPointervPName pname, T1[] @params) where T1 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetPointer(pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetPointer(pname, @params);
#endif
		}
		public static void GetPointer<T1>(OpenTK.Graphics.OpenGL.GetPointervPName pname, T1[,] @params) where T1 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetPointer(pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetPointer(pname, @params);
#endif
		}
		public static void GetPointer<T1>(OpenTK.Graphics.OpenGL.GetPointervPName pname, T1[, ,] @params) where T1 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetPointer(pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetPointer(pname, @params);
#endif
		}
		public static void GetPointer<T1>(OpenTK.Graphics.OpenGL.GetPointervPName pname, ref T1 @params) where T1 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetPointer(pname, ref @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetPointer(pname, ref @params);
#endif
		}
		public static void GetPolygonStipple(System.Byte[] mask)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetPolygonStipple(mask);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetPolygonStipple(mask);
#endif
		}
		public static void GetPolygonStipple(out System.Byte mask)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetPolygonStipple(out mask);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetPolygonStipple(out mask);
#endif
		}
		public static void GetProgramInfoLog(System.Int32 program, System.Int32 bufSize, out System.Int32 length, System.Text.StringBuilder infoLog)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetProgramInfoLog(program, bufSize, out length, infoLog);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetProgramInfoLog(program, bufSize, out length, infoLog);
#endif
		}
		public static void GetProgramInfoLog(System.UInt32 program, System.Int32 bufSize, out System.Int32 length, System.Text.StringBuilder infoLog)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetProgramInfoLog(program, bufSize, out length, infoLog);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetProgramInfoLog(program, bufSize, out length, infoLog);
#endif
		}
		public static void GetProgram(System.Int32 program, OpenTK.Graphics.OpenGL.ProgramParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetProgram(program, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetProgram(program, pname, @params);
#endif
		}
		public static void GetProgram(System.Int32 program, OpenTK.Graphics.OpenGL.ProgramParameter pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetProgram(program, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetProgram(program, pname, out @params);
#endif
		}
		public static void GetProgram(System.UInt32 program, OpenTK.Graphics.OpenGL.ProgramParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetProgram(program, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetProgram(program, pname, @params);
#endif
		}
		public static void GetProgram(System.UInt32 program, OpenTK.Graphics.OpenGL.ProgramParameter pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetProgram(program, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetProgram(program, pname, out @params);
#endif
		}
		public static void GetQuery(OpenTK.Graphics.OpenGL.QueryTarget target, OpenTK.Graphics.OpenGL.GetQueryParam pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetQuery(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetQuery(target, pname, @params);
#endif
		}
		public static void GetQuery(OpenTK.Graphics.OpenGL.QueryTarget target, OpenTK.Graphics.OpenGL.GetQueryParam pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetQuery(target, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetQuery(target, pname, out @params);
#endif
		}
		public static void GetQueryObject(System.Int32 id, OpenTK.Graphics.OpenGL.GetQueryObjectParam pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetQueryObject(id, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetQueryObject(id, pname, @params);
#endif
		}
		public static void GetQueryObject(System.Int32 id, OpenTK.Graphics.OpenGL.GetQueryObjectParam pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetQueryObject(id, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetQueryObject(id, pname, out @params);
#endif
		}
		public static void GetQueryObject(System.UInt32 id, OpenTK.Graphics.OpenGL.GetQueryObjectParam pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetQueryObject(id, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetQueryObject(id, pname, @params);
#endif
		}
		public static void GetQueryObject(System.UInt32 id, OpenTK.Graphics.OpenGL.GetQueryObjectParam pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetQueryObject(id, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetQueryObject(id, pname, out @params);
#endif
		}
		public static void GetQueryObject(System.UInt32 id, OpenTK.Graphics.OpenGL.GetQueryObjectParam pname, System.UInt32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetQueryObject(id, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetQueryObject(id, pname, @params);
#endif
		}
		public static void GetQueryObject(System.UInt32 id, OpenTK.Graphics.OpenGL.GetQueryObjectParam pname, out System.UInt32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetQueryObject(id, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetQueryObject(id, pname, out @params);
#endif
		}
		public static void GetClipPlane(OpenTK.Graphics.OpenGL.ClipPlaneName plane, System.Double[] equation)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetClipPlane(plane, equation);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetClipPlane(plane, equation);
#endif
		}
		public static void GetClipPlane(OpenTK.Graphics.OpenGL.ClipPlaneName plane, out System.Double equation)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetClipPlane(plane, out equation);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetClipPlane(plane, out equation);
#endif
		}
		public static void GetColorTable(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr table)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetColorTable(target, format, type, table);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetColorTable(target, format, type, table);
#endif
		}
		public static void GetColorTable<T3>(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T3[] table) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetColorTable(target, format, type, table);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetColorTable(target, format, type, table);
#endif
		}
		public static void GetColorTable<T3>(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T3[,] table) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetColorTable(target, format, type, table);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetColorTable(target, format, type, table);
#endif
		}
		public static void GetColorTable<T3>(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T3[, ,] table) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetColorTable(target, format, type, table);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetColorTable(target, format, type, table);
#endif
		}
		public static void GetColorTable<T3>(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, ref T3 table) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetColorTable(target, format, type, ref table);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetColorTable(target, format, type, ref table);
#endif
		}
		public static void GetColorTableParameter(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.GetColorTableParameterPName pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetColorTableParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetColorTableParameter(target, pname, @params);
#endif
		}
		public static void GetColorTableParameter(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.GetColorTableParameterPName pname, out System.Single @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetColorTableParameter(target, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetColorTableParameter(target, pname, out @params);
#endif
		}
		public static void GetColorTableParameter(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.GetColorTableParameterPName pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetColorTableParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetColorTableParameter(target, pname, @params);
#endif
		}
		public static void GetColorTableParameter(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.GetColorTableParameterPName pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetColorTableParameter(target, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetColorTableParameter(target, pname, out @params);
#endif
		}
		public static void GetCompressedTexImage(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.IntPtr img)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetCompressedTexImage(target, level, img);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetCompressedTexImage(target, level, img);
#endif
		}
		public static void GetCompressedTexImage<T2>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, T2[] img) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetCompressedTexImage(target, level, img);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetCompressedTexImage(target, level, img);
#endif
		}
		public static void GetCompressedTexImage<T2>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, T2[,] img) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetCompressedTexImage(target, level, img);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetCompressedTexImage(target, level, img);
#endif
		}
		public static void GetCompressedTexImage<T2>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, T2[, ,] img) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetCompressedTexImage(target, level, img);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetCompressedTexImage(target, level, img);
#endif
		}
		public static void GetCompressedTexImage<T2>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, ref T2 img) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetCompressedTexImage(target, level, ref img);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetCompressedTexImage(target, level, ref img);
#endif
		}
		public static void GetConvolutionFilter(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr image)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetConvolutionFilter(target, format, type, image);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetConvolutionFilter(target, format, type, image);
#endif
		}
		public static void GetConvolutionFilter<T3>(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T3[] image) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetConvolutionFilter(target, format, type, image);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetConvolutionFilter(target, format, type, image);
#endif
		}
		public static void GetConvolutionFilter<T3>(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T3[,] image) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetConvolutionFilter(target, format, type, image);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetConvolutionFilter(target, format, type, image);
#endif
		}
		public static void GetConvolutionFilter<T3>(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T3[, ,] image) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetConvolutionFilter(target, format, type, image);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetConvolutionFilter(target, format, type, image);
#endif
		}
		public static void GetConvolutionFilter<T3>(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, ref T3 image) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetConvolutionFilter(target, format, type, ref image);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetConvolutionFilter(target, format, type, ref image);
#endif
		}
		public static void GetConvolutionParameter(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.GetConvolutionParameterPName pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetConvolutionParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetConvolutionParameter(target, pname, @params);
#endif
		}
		public static void GetConvolutionParameter(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.GetConvolutionParameterPName pname, out System.Single @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetConvolutionParameter(target, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetConvolutionParameter(target, pname, out @params);
#endif
		}
		public static void GetConvolutionParameter(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.GetConvolutionParameterPName pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetConvolutionParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetConvolutionParameter(target, pname, @params);
#endif
		}
		public static void GetConvolutionParameter(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.GetConvolutionParameterPName pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetConvolutionParameter(target, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetConvolutionParameter(target, pname, out @params);
#endif
		}
		public static void GetDouble(OpenTK.Graphics.OpenGL.GetPName pname, System.Double[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetDouble(pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetDouble(pname, @params);
#endif
		}
		public static void GetDouble(OpenTK.Graphics.OpenGL.GetPName pname, out System.Double @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetDouble(pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetDouble(pname, out @params);
#endif
		}
		public static OpenTK.Graphics.OpenGL.ErrorCode GetError()
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GetError();
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GetError();
#endif
		}
		public static void GetFloat(OpenTK.Graphics.OpenGL.GetPName pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetFloat(pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetFloat(pname, @params);
#endif
		}
		public static void GetFloat(OpenTK.Graphics.OpenGL.GetPName pname, out System.Single @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetFloat(pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetFloat(pname, out @params);
#endif
		}
		public static System.Int32 GetFragDataLocation(System.Int32 program, System.String name)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GetFragDataLocation(program, name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GetFragDataLocation(program, name);
#endif
		}
		public static System.Int32 GetFragDataLocation(System.UInt32 program, System.String name)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GetFragDataLocation(program, name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GetFragDataLocation(program, name);
#endif
		}
		public static void GetFramebufferAttachmentParameter(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.FramebufferParameterName pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetFramebufferAttachmentParameter(target, attachment, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetFramebufferAttachmentParameter(target, attachment, pname, @params);
#endif
		}
		public static void GetFramebufferAttachmentParameter(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.FramebufferParameterName pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetFramebufferAttachmentParameter(target, attachment, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetFramebufferAttachmentParameter(target, attachment, pname, out @params);
#endif
		}
		public static void GetHistogram(OpenTK.Graphics.OpenGL.HistogramTarget target, System.Boolean reset, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr values)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetHistogram(target, reset, format, type, values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetHistogram(target, reset, format, type, values);
#endif
		}
		public static void GetHistogram<T4>(OpenTK.Graphics.OpenGL.HistogramTarget target, System.Boolean reset, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T4[] values) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetHistogram(target, reset, format, type, values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetHistogram(target, reset, format, type, values);
#endif
		}
		public static void GetHistogram<T4>(OpenTK.Graphics.OpenGL.HistogramTarget target, System.Boolean reset, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T4[,] values) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetHistogram(target, reset, format, type, values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetHistogram(target, reset, format, type, values);
#endif
		}
		public static void GetHistogram<T4>(OpenTK.Graphics.OpenGL.HistogramTarget target, System.Boolean reset, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T4[, ,] values) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetHistogram(target, reset, format, type, values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetHistogram(target, reset, format, type, values);
#endif
		}
		public static void GetHistogram<T4>(OpenTK.Graphics.OpenGL.HistogramTarget target, System.Boolean reset, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, ref T4 values) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetHistogram(target, reset, format, type, ref values);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetHistogram(target, reset, format, type, ref values);
#endif
		}
		public static void GetHistogramParameter(OpenTK.Graphics.OpenGL.HistogramTarget target, OpenTK.Graphics.OpenGL.GetHistogramParameterPName pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetHistogramParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetHistogramParameter(target, pname, @params);
#endif
		}
		public static void GetHistogramParameter(OpenTK.Graphics.OpenGL.HistogramTarget target, OpenTK.Graphics.OpenGL.GetHistogramParameterPName pname, out System.Single @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetHistogramParameter(target, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetHistogramParameter(target, pname, out @params);
#endif
		}
		public static void GetHistogramParameter(OpenTK.Graphics.OpenGL.HistogramTarget target, OpenTK.Graphics.OpenGL.GetHistogramParameterPName pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetHistogramParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetHistogramParameter(target, pname, @params);
#endif
		}
		public static void GetHistogramParameter(OpenTK.Graphics.OpenGL.HistogramTarget target, OpenTK.Graphics.OpenGL.GetHistogramParameterPName pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetHistogramParameter(target, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetHistogramParameter(target, pname, out @params);
#endif
		}
		public static void GetInteger64(OpenTK.Graphics.OpenGL.Version32 target, System.Int32 index, System.Int64[] data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetInteger64(target, index, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetInteger64(target, index, data);
#endif
		}
		public static void GetInteger64(OpenTK.Graphics.OpenGL.Version32 target, System.Int32 index, out System.Int64 data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetInteger64(target, index, out data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetInteger64(target, index, out data);
#endif
		}
		public static void GetInteger64(OpenTK.Graphics.OpenGL.Version32 target, System.UInt32 index, System.Int64[] data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetInteger64(target, index, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetInteger64(target, index, data);
#endif
		}
		public static void GetInteger64(OpenTK.Graphics.OpenGL.Version32 target, System.UInt32 index, out System.Int64 data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetInteger64(target, index, out data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetInteger64(target, index, out data);
#endif
		}
		public static void GetInteger64(OpenTK.Graphics.OpenGL.ArbSync pname, System.Int64[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetInteger64(pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetInteger64(pname, @params);
#endif
		}
		public static void GetInteger64(OpenTK.Graphics.OpenGL.ArbSync pname, out System.Int64 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetInteger64(pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetInteger64(pname, out @params);
#endif
		}
		public static void GetInteger(OpenTK.Graphics.OpenGL.GetIndexedPName target, System.Int32 index, System.Int32[] data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetInteger(target, index, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetInteger(target, index, data);
#endif
		}
		public static void GetInteger(OpenTK.Graphics.OpenGL.GetIndexedPName target, System.Int32 index, out System.Int32 data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetInteger(target, index, out data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetInteger(target, index, out data);
#endif
		}
		public static void GetInteger(OpenTK.Graphics.OpenGL.GetIndexedPName target, System.UInt32 index, System.Int32[] data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetInteger(target, index, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetInteger(target, index, data);
#endif
		}
		public static void GetInteger(OpenTK.Graphics.OpenGL.GetIndexedPName target, System.UInt32 index, out System.Int32 data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetInteger(target, index, out data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetInteger(target, index, out data);
#endif
		}
		public static void GetInteger(OpenTK.Graphics.OpenGL.GetPName pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetInteger(pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetInteger(pname, @params);
#endif
		}
		public static void GetInteger(OpenTK.Graphics.OpenGL.GetPName pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetInteger(pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetInteger(pname, out @params);
#endif
		}
		public static void GetLight(OpenTK.Graphics.OpenGL.LightName light, OpenTK.Graphics.OpenGL.LightParameter pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetLight(light, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetLight(light, pname, @params);
#endif
		}
		public static void GetLight(OpenTK.Graphics.OpenGL.LightName light, OpenTK.Graphics.OpenGL.LightParameter pname, out System.Single @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetLight(light, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetLight(light, pname, out @params);
#endif
		}
		public static void GenRenderbuffers(System.Int32 n, System.Int32[] renderbuffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenRenderbuffers(n, renderbuffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenRenderbuffers(n, renderbuffers);
#endif
		}
		public static void GenRenderbuffers(System.Int32 n, out System.Int32 renderbuffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenRenderbuffers(n, out renderbuffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenRenderbuffers(n, out renderbuffers);
#endif
		}
		public static void GenRenderbuffers(System.Int32 n, System.UInt32[] renderbuffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenRenderbuffers(n, renderbuffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenRenderbuffers(n, renderbuffers);
#endif
		}
		public static void GenRenderbuffers(System.Int32 n, out System.UInt32 renderbuffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenRenderbuffers(n, out renderbuffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenRenderbuffers(n, out renderbuffers);
#endif
		}
		public static void GenTextures(System.Int32 n, System.Int32[] textures)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenTextures(n, textures);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenTextures(n, textures);
#endif
		}
		public static void GenTextures(System.Int32 n, out System.Int32 textures)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenTextures(n, out textures);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenTextures(n, out textures);
#endif
		}
		public static void GenTextures(System.Int32 n, System.UInt32[] textures)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenTextures(n, textures);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenTextures(n, textures);
#endif
		}
		public static void GenTextures(System.Int32 n, out System.UInt32 textures)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenTextures(n, out textures);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenTextures(n, out textures);
#endif
		}
		public static void GenVertexArrays(System.Int32 n, System.Int32[] arrays)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenVertexArrays(n, arrays);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenVertexArrays(n, arrays);
#endif
		}
		public static void GenVertexArrays(System.Int32 n, out System.Int32 arrays)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenVertexArrays(n, out arrays);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenVertexArrays(n, out arrays);
#endif
		}
		public static void GenVertexArrays(System.Int32 n, System.UInt32[] arrays)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenVertexArrays(n, arrays);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenVertexArrays(n, arrays);
#endif
		}
		public static void GenVertexArrays(System.Int32 n, out System.UInt32 arrays)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenVertexArrays(n, out arrays);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenVertexArrays(n, out arrays);
#endif
		}
		public static void GetActiveAttrib(System.Int32 program, System.Int32 index, System.Int32 bufSize, out System.Int32 length, out System.Int32 size, out OpenTK.Graphics.OpenGL.ActiveAttribType type, System.Text.StringBuilder name)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveAttrib(program, index, bufSize, out length, out size, out type, name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveAttrib(program, index, bufSize, out length, out size, out type, name);
#endif
		}
		public static void GetActiveAttrib(System.UInt32 program, System.UInt32 index, System.Int32 bufSize, out System.Int32 length, out System.Int32 size, out OpenTK.Graphics.OpenGL.ActiveAttribType type, System.Text.StringBuilder name)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveAttrib(program, index, bufSize, out length, out size, out type, name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveAttrib(program, index, bufSize, out length, out size, out type, name);
#endif
		}
		public static void GetActiveUniform(System.Int32 program, System.Int32 index, System.Int32 bufSize, out System.Int32 length, out System.Int32 size, out OpenTK.Graphics.OpenGL.ActiveUniformType type, System.Text.StringBuilder name)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveUniform(program, index, bufSize, out length, out size, out type, name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveUniform(program, index, bufSize, out length, out size, out type, name);
#endif
		}
		public static void GetActiveUniform(System.UInt32 program, System.UInt32 index, System.Int32 bufSize, out System.Int32 length, out System.Int32 size, out OpenTK.Graphics.OpenGL.ActiveUniformType type, System.Text.StringBuilder name)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveUniform(program, index, bufSize, out length, out size, out type, name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveUniform(program, index, bufSize, out length, out size, out type, name);
#endif
		}
		public static void GetActiveUniformBlock(System.Int32 program, System.Int32 uniformBlockIndex, OpenTK.Graphics.OpenGL.ActiveUniformBlockParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveUniformBlock(program, uniformBlockIndex, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveUniformBlock(program, uniformBlockIndex, pname, @params);
#endif
		}
		public static void GetActiveUniformBlock(System.Int32 program, System.Int32 uniformBlockIndex, OpenTK.Graphics.OpenGL.ActiveUniformBlockParameter pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveUniformBlock(program, uniformBlockIndex, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveUniformBlock(program, uniformBlockIndex, pname, out @params);
#endif
		}
		public static void GetActiveUniformBlock(System.UInt32 program, System.UInt32 uniformBlockIndex, OpenTK.Graphics.OpenGL.ActiveUniformBlockParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveUniformBlock(program, uniformBlockIndex, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveUniformBlock(program, uniformBlockIndex, pname, @params);
#endif
		}
		public static void GetActiveUniformBlock(System.UInt32 program, System.UInt32 uniformBlockIndex, OpenTK.Graphics.OpenGL.ActiveUniformBlockParameter pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveUniformBlock(program, uniformBlockIndex, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveUniformBlock(program, uniformBlockIndex, pname, out @params);
#endif
		}
		public static void GetActiveUniformBlockName(System.Int32 program, System.Int32 uniformBlockIndex, System.Int32 bufSize, out System.Int32 length, System.Text.StringBuilder uniformBlockName)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, out length, uniformBlockName);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, out length, uniformBlockName);
#endif
		}
		public static void GetActiveUniformBlockName(System.UInt32 program, System.UInt32 uniformBlockIndex, System.Int32 bufSize, out System.Int32 length, System.Text.StringBuilder uniformBlockName)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, out length, uniformBlockName);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveUniformBlockName(program, uniformBlockIndex, bufSize, out length, uniformBlockName);
#endif
		}
		public static void GetActiveUniformName(System.Int32 program, System.Int32 uniformIndex, System.Int32 bufSize, out System.Int32 length, System.Text.StringBuilder uniformName)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveUniformName(program, uniformIndex, bufSize, out length, uniformName);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveUniformName(program, uniformIndex, bufSize, out length, uniformName);
#endif
		}
		public static void GetActiveUniformName(System.UInt32 program, System.UInt32 uniformIndex, System.Int32 bufSize, out System.Int32 length, System.Text.StringBuilder uniformName)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveUniformName(program, uniformIndex, bufSize, out length, uniformName);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveUniformName(program, uniformIndex, bufSize, out length, uniformName);
#endif
		}
		public static void GetActiveUniforms(System.Int32 program, System.Int32 uniformCount, System.Int32[] uniformIndices, OpenTK.Graphics.OpenGL.ActiveUniformParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveUniforms(program, uniformCount, uniformIndices, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveUniforms(program, uniformCount, uniformIndices, pname, @params);
#endif
		}
		public static void GetActiveUniforms(System.Int32 program, System.Int32 uniformCount, ref System.Int32 uniformIndices, OpenTK.Graphics.OpenGL.ActiveUniformParameter pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveUniforms(program, uniformCount, ref uniformIndices, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveUniforms(program, uniformCount, ref uniformIndices, pname, out @params);
#endif
		}
		public static void GetActiveUniforms(System.UInt32 program, System.Int32 uniformCount, System.UInt32[] uniformIndices, OpenTK.Graphics.OpenGL.ActiveUniformParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveUniforms(program, uniformCount, uniformIndices, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveUniforms(program, uniformCount, uniformIndices, pname, @params);
#endif
		}
		public static void GetActiveUniforms(System.UInt32 program, System.Int32 uniformCount, ref System.UInt32 uniformIndices, OpenTK.Graphics.OpenGL.ActiveUniformParameter pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetActiveUniforms(program, uniformCount, ref uniformIndices, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetActiveUniforms(program, uniformCount, ref uniformIndices, pname, out @params);
#endif
		}
		public static void GetAttachedShaders(System.Int32 program, System.Int32 maxCount, out System.Int32 count, out System.Int32 obj)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetAttachedShaders(program, maxCount, out count, out obj);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetAttachedShaders(program, maxCount, out count, out obj);
#endif
		}
		public static void GetAttachedShaders(System.UInt32 program, System.Int32 maxCount, out System.Int32 count, out System.UInt32 obj)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetAttachedShaders(program, maxCount, out count, out obj);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetAttachedShaders(program, maxCount, out count, out obj);
#endif
		}
		public static System.Int32 GetAttribLocation(System.Int32 program, System.String name)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GetAttribLocation(program, name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GetAttribLocation(program, name);
#endif
		}
		public static System.Int32 GetAttribLocation(System.UInt32 program, System.String name)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GetAttribLocation(program, name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GetAttribLocation(program, name);
#endif
		}
		public static void GetBoolean(OpenTK.Graphics.OpenGL.GetIndexedPName target, System.Int32 index, System.Boolean[] data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBoolean(target, index, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBoolean(target, index, data);
#endif
		}
		public static void GetBoolean(OpenTK.Graphics.OpenGL.GetIndexedPName target, System.Int32 index, out System.Boolean data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBoolean(target, index, out data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBoolean(target, index, out data);
#endif
		}
		public static void GetBoolean(OpenTK.Graphics.OpenGL.GetIndexedPName target, System.UInt32 index, System.Boolean[] data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBoolean(target, index, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBoolean(target, index, data);
#endif
		}
		public static void GetBoolean(OpenTK.Graphics.OpenGL.GetIndexedPName target, System.UInt32 index, out System.Boolean data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBoolean(target, index, out data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBoolean(target, index, out data);
#endif
		}
		public static void GetBoolean(OpenTK.Graphics.OpenGL.GetPName pname, System.Boolean[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBoolean(pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBoolean(pname, @params);
#endif
		}
		public static void GetBoolean(OpenTK.Graphics.OpenGL.GetPName pname, out System.Boolean @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBoolean(pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBoolean(pname, out @params);
#endif
		}
		public static void GetBufferParameteri64(OpenTK.Graphics.OpenGL.Version32 target, OpenTK.Graphics.OpenGL.Version32 pname, System.Int64[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBufferParameteri64(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBufferParameteri64(target, pname, @params);
#endif
		}
		public static void GetBufferParameteri64(OpenTK.Graphics.OpenGL.Version32 target, OpenTK.Graphics.OpenGL.Version32 pname, out System.Int64 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBufferParameteri64(target, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBufferParameteri64(target, pname, out @params);
#endif
		}
		public static void GetBufferParameter(OpenTK.Graphics.OpenGL.BufferTarget target, OpenTK.Graphics.OpenGL.BufferParameterName pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBufferParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBufferParameter(target, pname, @params);
#endif
		}
		public static void GetBufferParameter(OpenTK.Graphics.OpenGL.BufferTarget target, OpenTK.Graphics.OpenGL.BufferParameterName pname, out System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBufferParameter(target, pname, out @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBufferParameter(target, pname, out @params);
#endif
		}
		public static void GetBufferPointer(OpenTK.Graphics.OpenGL.BufferTarget target, OpenTK.Graphics.OpenGL.BufferPointer pname, System.IntPtr @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBufferPointer(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBufferPointer(target, pname, @params);
#endif
		}
		public static void GetBufferPointer<T2>(OpenTK.Graphics.OpenGL.BufferTarget target, OpenTK.Graphics.OpenGL.BufferPointer pname, T2[] @params) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBufferPointer(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBufferPointer(target, pname, @params);
#endif
		}
		public static void GetBufferPointer<T2>(OpenTK.Graphics.OpenGL.BufferTarget target, OpenTK.Graphics.OpenGL.BufferPointer pname, T2[,] @params) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBufferPointer(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBufferPointer(target, pname, @params);
#endif
		}
		public static void GetBufferPointer<T2>(OpenTK.Graphics.OpenGL.BufferTarget target, OpenTK.Graphics.OpenGL.BufferPointer pname, T2[, ,] @params) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBufferPointer(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBufferPointer(target, pname, @params);
#endif
		}
		public static void GetBufferPointer<T2>(OpenTK.Graphics.OpenGL.BufferTarget target, OpenTK.Graphics.OpenGL.BufferPointer pname, ref T2 @params) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBufferPointer(target, pname, ref @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBufferPointer(target, pname, ref @params);
#endif
		}
		public static void GetBufferSubData(OpenTK.Graphics.OpenGL.BufferTarget target, System.IntPtr offset, System.IntPtr size, System.IntPtr data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBufferSubData(target, offset, size, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBufferSubData(target, offset, size, data);
#endif
		}
		public static void GetBufferSubData<T3>(OpenTK.Graphics.OpenGL.BufferTarget target, System.IntPtr offset, System.IntPtr size, T3[] data) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBufferSubData(target, offset, size, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBufferSubData(target, offset, size, data);
#endif
		}
		public static void GetBufferSubData<T3>(OpenTK.Graphics.OpenGL.BufferTarget target, System.IntPtr offset, System.IntPtr size, T3[,] data) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBufferSubData(target, offset, size, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBufferSubData(target, offset, size, data);
#endif
		}
		public static void GetBufferSubData<T3>(OpenTK.Graphics.OpenGL.BufferTarget target, System.IntPtr offset, System.IntPtr size, T3[, ,] data) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBufferSubData(target, offset, size, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBufferSubData(target, offset, size, data);
#endif
		}
		public static void GetBufferSubData<T3>(OpenTK.Graphics.OpenGL.BufferTarget target, System.IntPtr offset, System.IntPtr size, ref T3 data) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GetBufferSubData(target, offset, size, ref data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GetBufferSubData(target, offset, size, ref data);
#endif
		}
		public static void Enable(OpenTK.Graphics.OpenGL.IndexedEnableCap target, System.UInt32 index)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Enable(target, index);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Enable(target, index);
#endif
		}
		public static void EnableVertexAttribArray(System.Int32 index)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EnableVertexAttribArray(index);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EnableVertexAttribArray(index);
#endif
		}
		public static void EnableVertexAttribArray(System.UInt32 index)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EnableVertexAttribArray(index);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EnableVertexAttribArray(index);
#endif
		}
		public static void End()
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.End();
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.End();
#endif
		}
		public static void EndConditionalRender()
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EndConditionalRender();
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EndConditionalRender();
#endif
		}
		public static void EndList()
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EndList();
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EndList();
#endif
		}
		public static void EndQuery(OpenTK.Graphics.OpenGL.QueryTarget target)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EndQuery(target);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EndQuery(target);
#endif
		}
		public static void EndTransformFeedback()
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EndTransformFeedback();
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EndTransformFeedback();
#endif
		}
		public static void EvalCoord1(System.Double u)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EvalCoord1(u);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EvalCoord1(u);
#endif
		}
		public static void EvalCoord1(System.Single u)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EvalCoord1(u);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EvalCoord1(u);
#endif
		}
		public static void EvalCoord2(System.Double u, System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EvalCoord2(u, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EvalCoord2(u, v);
#endif
		}
		public static void EvalCoord2(System.Double[] u)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EvalCoord2(u);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EvalCoord2(u);
#endif
		}
		public static void EvalCoord2(ref System.Double u)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EvalCoord2(ref u);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EvalCoord2(ref u);
#endif
		}
		public static void EvalCoord2(System.Single u, System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EvalCoord2(u, v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EvalCoord2(u, v);
#endif
		}
		public static void EvalCoord2(System.Single[] u)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EvalCoord2(u);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EvalCoord2(u);
#endif
		}
		public static void EvalCoord2(ref System.Single u)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EvalCoord2(ref u);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EvalCoord2(ref u);
#endif
		}
		public static void EvalMesh1(OpenTK.Graphics.OpenGL.MeshMode1 mode, System.Int32 i1, System.Int32 i2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EvalMesh1(mode, i1, i2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EvalMesh1(mode, i1, i2);
#endif
		}
		public static void EvalMesh2(OpenTK.Graphics.OpenGL.MeshMode2 mode, System.Int32 i1, System.Int32 i2, System.Int32 j1, System.Int32 j2)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EvalMesh2(mode, i1, i2, j1, j2);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EvalMesh2(mode, i1, i2, j1, j2);
#endif
		}
		public static void EvalPoint1(System.Int32 i)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EvalPoint1(i);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EvalPoint1(i);
#endif
		}
		public static void EvalPoint2(System.Int32 i, System.Int32 j)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EvalPoint2(i, j);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EvalPoint2(i, j);
#endif
		}
		public static void FeedbackBuffer(System.Int32 size, OpenTK.Graphics.OpenGL.FeedbackType type, System.Single[] buffer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FeedbackBuffer(size, type, buffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FeedbackBuffer(size, type, buffer);
#endif
		}
		public static void FeedbackBuffer(System.Int32 size, OpenTK.Graphics.OpenGL.FeedbackType type, out System.Single buffer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FeedbackBuffer(size, type, out buffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FeedbackBuffer(size, type, out buffer);
#endif
		}
		public static System.IntPtr FenceSync(OpenTK.Graphics.OpenGL.ArbSync condition, System.Int32 flags)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.FenceSync(condition, flags);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.FenceSync(condition, flags);
#endif
		}
		public static System.IntPtr FenceSync(OpenTK.Graphics.OpenGL.ArbSync condition, System.UInt32 flags)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.FenceSync(condition, flags);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.FenceSync(condition, flags);
#endif
		}
		public static void Finish()
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Finish();
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Finish();
#endif
		}
		public static void Flush()
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Flush();
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Flush();
#endif
		}
		public static void FlushMappedBufferRange(OpenTK.Graphics.OpenGL.BufferTarget target, System.IntPtr offset, System.IntPtr length)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FlushMappedBufferRange(target, offset, length);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FlushMappedBufferRange(target, offset, length);
#endif
		}
		public static void FogCoord(System.Double coord)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FogCoord(coord);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FogCoord(coord);
#endif
		}
		public static void FogCoord(System.Single coord)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FogCoord(coord);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FogCoord(coord);
#endif
		}
		public static void FogCoordPointer(OpenTK.Graphics.OpenGL.FogPointerType type, System.Int32 stride, System.IntPtr pointer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FogCoordPointer(type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FogCoordPointer(type, stride, pointer);
#endif
		}
		public static void FogCoordPointer<T2>(OpenTK.Graphics.OpenGL.FogPointerType type, System.Int32 stride, T2[] pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FogCoordPointer(type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FogCoordPointer(type, stride, pointer);
#endif
		}
		public static void FogCoordPointer<T2>(OpenTK.Graphics.OpenGL.FogPointerType type, System.Int32 stride, T2[,] pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FogCoordPointer(type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FogCoordPointer(type, stride, pointer);
#endif
		}
		public static void FogCoordPointer<T2>(OpenTK.Graphics.OpenGL.FogPointerType type, System.Int32 stride, T2[, ,] pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FogCoordPointer(type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FogCoordPointer(type, stride, pointer);
#endif
		}
		public static void FogCoordPointer<T2>(OpenTK.Graphics.OpenGL.FogPointerType type, System.Int32 stride, ref T2 pointer) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FogCoordPointer(type, stride, ref pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FogCoordPointer(type, stride, ref pointer);
#endif
		}
		public static void Fog(OpenTK.Graphics.OpenGL.FogParameter pname, System.Single param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Fog(pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Fog(pname, param);
#endif
		}
		public static void Fog(OpenTK.Graphics.OpenGL.FogParameter pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Fog(pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Fog(pname, @params);
#endif
		}
		public static void Fog(OpenTK.Graphics.OpenGL.FogParameter pname, System.Int32 param)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Fog(pname, param);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Fog(pname, param);
#endif
		}
		public static void Fog(OpenTK.Graphics.OpenGL.FogParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Fog(pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Fog(pname, @params);
#endif
		}
		public static void FramebufferRenderbuffer(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.RenderbufferTarget renderbuffertarget, System.Int32 renderbuffer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
#endif
		}
		public static void FramebufferRenderbuffer(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.RenderbufferTarget renderbuffertarget, System.UInt32 renderbuffer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FramebufferRenderbuffer(target, attachment, renderbuffertarget, renderbuffer);
#endif
		}
		public static void FramebufferTexture(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, System.Int32 texture, System.Int32 level)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FramebufferTexture(target, attachment, texture, level);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FramebufferTexture(target, attachment, texture, level);
#endif
		}
		public static void FramebufferTexture(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, System.UInt32 texture, System.Int32 level)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FramebufferTexture(target, attachment, texture, level);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FramebufferTexture(target, attachment, texture, level);
#endif
		}
		public static void FramebufferTexture1D(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.TextureTarget textarget, System.Int32 texture, System.Int32 level)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FramebufferTexture1D(target, attachment, textarget, texture, level);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FramebufferTexture1D(target, attachment, textarget, texture, level);
#endif
		}
		public static void FramebufferTexture1D(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.TextureTarget textarget, System.UInt32 texture, System.Int32 level)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FramebufferTexture1D(target, attachment, textarget, texture, level);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FramebufferTexture1D(target, attachment, textarget, texture, level);
#endif
		}
		public static void FramebufferTexture2D(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.TextureTarget textarget, System.Int32 texture, System.Int32 level)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FramebufferTexture2D(target, attachment, textarget, texture, level);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FramebufferTexture2D(target, attachment, textarget, texture, level);
#endif
		}
		public static void FramebufferTexture2D(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.TextureTarget textarget, System.UInt32 texture, System.Int32 level)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FramebufferTexture2D(target, attachment, textarget, texture, level);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FramebufferTexture2D(target, attachment, textarget, texture, level);
#endif
		}
		public static void FramebufferTexture3D(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.TextureTarget textarget, System.Int32 texture, System.Int32 level, System.Int32 zoffset)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
#endif
		}
		public static void FramebufferTexture3D(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, OpenTK.Graphics.OpenGL.TextureTarget textarget, System.UInt32 texture, System.Int32 level, System.Int32 zoffset)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FramebufferTexture3D(target, attachment, textarget, texture, level, zoffset);
#endif
		}
		public static void FramebufferTextureFace(OpenTK.Graphics.OpenGL.Version32 target, OpenTK.Graphics.OpenGL.Version32 attachment, System.Int32 texture, System.Int32 level, OpenTK.Graphics.OpenGL.Version32 face)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FramebufferTextureFace(target, attachment, texture, level, face);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FramebufferTextureFace(target, attachment, texture, level, face);
#endif
		}
		public static void FramebufferTextureFace(OpenTK.Graphics.OpenGL.Version32 target, OpenTK.Graphics.OpenGL.Version32 attachment, System.UInt32 texture, System.Int32 level, OpenTK.Graphics.OpenGL.Version32 face)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FramebufferTextureFace(target, attachment, texture, level, face);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FramebufferTextureFace(target, attachment, texture, level, face);
#endif
		}
		public static void FramebufferTextureLayer(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, System.Int32 texture, System.Int32 level, System.Int32 layer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FramebufferTextureLayer(target, attachment, texture, level, layer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FramebufferTextureLayer(target, attachment, texture, level, layer);
#endif
		}
		public static void FramebufferTextureLayer(OpenTK.Graphics.OpenGL.FramebufferTarget target, OpenTK.Graphics.OpenGL.FramebufferAttachment attachment, System.UInt32 texture, System.Int32 level, System.Int32 layer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FramebufferTextureLayer(target, attachment, texture, level, layer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FramebufferTextureLayer(target, attachment, texture, level, layer);
#endif
		}
		public static void FrontFace(OpenTK.Graphics.OpenGL.FrontFaceDirection mode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.FrontFace(mode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.FrontFace(mode);
#endif
		}
		public static void Frustum(System.Double left, System.Double right, System.Double bottom, System.Double top, System.Double zNear, System.Double zFar)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Frustum(left, right, bottom, top, zNear, zFar);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Frustum(left, right, bottom, top, zNear, zFar);
#endif
		}
		public static void GenBuffers(System.Int32 n, System.Int32[] buffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenBuffers(n, buffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenBuffers(n, buffers);
#endif
		}
		public static void GenBuffers(System.Int32 n, out System.Int32 buffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenBuffers(n, out buffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenBuffers(n, out buffers);
#endif
		}
		public static void GenBuffers(System.Int32 n, System.UInt32[] buffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenBuffers(n, buffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenBuffers(n, buffers);
#endif
		}
		public static void GenBuffers(System.Int32 n, out System.UInt32 buffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenBuffers(n, out buffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenBuffers(n, out buffers);
#endif
		}
		public static void GenerateMipmap(OpenTK.Graphics.OpenGL.GenerateMipmapTarget target)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenerateMipmap(target);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenerateMipmap(target);
#endif
		}
		public static void GenFramebuffers(System.Int32 n, System.Int32[] framebuffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenFramebuffers(n, framebuffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenFramebuffers(n, framebuffers);
#endif
		}
		public static void GenFramebuffers(System.Int32 n, out System.Int32 framebuffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenFramebuffers(n, out framebuffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenFramebuffers(n, out framebuffers);
#endif
		}
		public static void GenFramebuffers(System.Int32 n, System.UInt32[] framebuffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenFramebuffers(n, framebuffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenFramebuffers(n, framebuffers);
#endif
		}
		public static void GenFramebuffers(System.Int32 n, out System.UInt32 framebuffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenFramebuffers(n, out framebuffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenFramebuffers(n, out framebuffers);
#endif
		}
		public static System.Int32 GenLists(System.Int32 range)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.GenLists(range);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.GenLists(range);
#endif
		}
		public static void GenQueries(System.Int32 n, System.Int32[] ids)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenQueries(n, ids);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenQueries(n, ids);
#endif
		}
		public static void GenQueries(System.Int32 n, out System.Int32 ids)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenQueries(n, out ids);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenQueries(n, out ids);
#endif
		}
		public static void GenQueries(System.Int32 n, System.UInt32[] ids)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenQueries(n, ids);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenQueries(n, ids);
#endif
		}
		public static void GenQueries(System.Int32 n, out System.UInt32 ids)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.GenQueries(n, out ids);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.GenQueries(n, out ids);
#endif
		}
		public static void DrawBuffers(System.Int32 n, OpenTK.Graphics.OpenGL.DrawBuffersEnum[] bufs)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawBuffers(n, bufs);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawBuffers(n, bufs);
#endif
		}
		public static void DrawBuffers(System.Int32 n, ref OpenTK.Graphics.OpenGL.DrawBuffersEnum bufs)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawBuffers(n, ref bufs);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawBuffers(n, ref bufs);
#endif
		}
		public static void DrawElements(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, System.IntPtr indices)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElements(mode, count, type, indices);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElements(mode, count, type, indices);
#endif
		}
		public static void DrawElements<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[] indices) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElements(mode, count, type, indices);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElements(mode, count, type, indices);
#endif
		}
		public static void DrawElements<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[,] indices) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElements(mode, count, type, indices);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElements(mode, count, type, indices);
#endif
		}
		public static void DrawElements<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[, ,] indices) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElements(mode, count, type, indices);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElements(mode, count, type, indices);
#endif
		}
		public static void DrawElements<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, ref T3 indices) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElements(mode, count, type, ref indices);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElements(mode, count, type, ref indices);
#endif
		}
		public static void DrawElementsBaseVertex(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, System.IntPtr indices, System.Int32 basevertex)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElementsBaseVertex(mode, count, type, indices, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElementsBaseVertex(mode, count, type, indices, basevertex);
#endif
		}
		public static void DrawElementsBaseVertex<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[] indices, System.Int32 basevertex) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElementsBaseVertex(mode, count, type, indices, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElementsBaseVertex(mode, count, type, indices, basevertex);
#endif
		}
		public static void DrawElementsBaseVertex<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[,] indices, System.Int32 basevertex) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElementsBaseVertex(mode, count, type, indices, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElementsBaseVertex(mode, count, type, indices, basevertex);
#endif
		}
		public static void DrawElementsBaseVertex<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[, ,] indices, System.Int32 basevertex) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElementsBaseVertex(mode, count, type, indices, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElementsBaseVertex(mode, count, type, indices, basevertex);
#endif
		}
		public static void DrawElementsBaseVertex<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, ref T3 indices, System.Int32 basevertex) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElementsBaseVertex(mode, count, type, ref indices, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElementsBaseVertex(mode, count, type, ref indices, basevertex);
#endif
		}
		public static void DrawElementsInstanced(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, System.IntPtr indices, System.Int32 primcount)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstanced(mode, count, type, indices, primcount);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstanced(mode, count, type, indices, primcount);
#endif
		}
		public static void DrawElementsInstanced<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[] indices, System.Int32 primcount) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstanced(mode, count, type, indices, primcount);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstanced(mode, count, type, indices, primcount);
#endif
		}
		public static void DrawElementsInstanced<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[,] indices, System.Int32 primcount) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstanced(mode, count, type, indices, primcount);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstanced(mode, count, type, indices, primcount);
#endif
		}
		public static void DrawElementsInstanced<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[, ,] indices, System.Int32 primcount) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstanced(mode, count, type, indices, primcount);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstanced(mode, count, type, indices, primcount);
#endif
		}
		public static void DrawElementsInstanced<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, ref T3 indices, System.Int32 primcount) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstanced(mode, count, type, ref indices, primcount);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstanced(mode, count, type, ref indices, primcount);
#endif
		}
		public static void DrawElementsInstancedBaseVertex(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, System.IntPtr indices, System.Int32 primcount, System.Int32 basevertex)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstancedBaseVertex(mode, count, type, indices, primcount, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstancedBaseVertex(mode, count, type, indices, primcount, basevertex);
#endif
		}
		public static void DrawElementsInstancedBaseVertex<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[] indices, System.Int32 primcount, System.Int32 basevertex) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstancedBaseVertex(mode, count, type, indices, primcount, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstancedBaseVertex(mode, count, type, indices, primcount, basevertex);
#endif
		}
		public static void DrawElementsInstancedBaseVertex<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[,] indices, System.Int32 primcount, System.Int32 basevertex) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstancedBaseVertex(mode, count, type, indices, primcount, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstancedBaseVertex(mode, count, type, indices, primcount, basevertex);
#endif
		}
		public static void DrawElementsInstancedBaseVertex<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T3[, ,] indices, System.Int32 primcount, System.Int32 basevertex) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstancedBaseVertex(mode, count, type, indices, primcount, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstancedBaseVertex(mode, count, type, indices, primcount, basevertex);
#endif
		}
		public static void DrawElementsInstancedBaseVertex<T3>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, ref T3 indices, System.Int32 primcount, System.Int32 basevertex) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstancedBaseVertex(mode, count, type, ref indices, primcount, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawElementsInstancedBaseVertex(mode, count, type, ref indices, primcount, basevertex);
#endif
		}
		public static void DrawPixels(System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr pixels)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawPixels(width, height, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawPixels(width, height, format, type, pixels);
#endif
		}
		public static void DrawPixels<T4>(System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T4[] pixels) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawPixels(width, height, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawPixels(width, height, format, type, pixels);
#endif
		}
		public static void DrawPixels<T4>(System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T4[,] pixels) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawPixels(width, height, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawPixels(width, height, format, type, pixels);
#endif
		}
		public static void DrawPixels<T4>(System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T4[, ,] pixels) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawPixels(width, height, format, type, pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawPixels(width, height, format, type, pixels);
#endif
		}
		public static void DrawPixels<T4>(System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, ref T4 pixels) where T4 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawPixels(width, height, format, type, ref pixels);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawPixels(width, height, format, type, ref pixels);
#endif
		}
		public static void DrawRangeElements(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 start, System.Int32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, System.IntPtr indices)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, indices);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, indices);
#endif
		}
		public static void DrawRangeElements<T5>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 start, System.Int32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T5[] indices) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, indices);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, indices);
#endif
		}
		public static void DrawRangeElements<T5>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 start, System.Int32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T5[,] indices) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, indices);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, indices);
#endif
		}
		public static void DrawRangeElements<T5>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 start, System.Int32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T5[, ,] indices) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, indices);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, indices);
#endif
		}
		public static void DrawRangeElements<T5>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 start, System.Int32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, ref T5 indices) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, ref indices);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, ref indices);
#endif
		}
		public static void DrawRangeElements(OpenTK.Graphics.OpenGL.BeginMode mode, System.UInt32 start, System.UInt32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, System.IntPtr indices)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, indices);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, indices);
#endif
		}
		public static void DrawRangeElements<T5>(OpenTK.Graphics.OpenGL.BeginMode mode, System.UInt32 start, System.UInt32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T5[] indices) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, indices);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, indices);
#endif
		}
		public static void DrawRangeElements<T5>(OpenTK.Graphics.OpenGL.BeginMode mode, System.UInt32 start, System.UInt32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T5[,] indices) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, indices);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, indices);
#endif
		}
		public static void DrawRangeElements<T5>(OpenTK.Graphics.OpenGL.BeginMode mode, System.UInt32 start, System.UInt32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T5[, ,] indices) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, indices);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, indices);
#endif
		}
		public static void DrawRangeElements<T5>(OpenTK.Graphics.OpenGL.BeginMode mode, System.UInt32 start, System.UInt32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, ref T5 indices) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, ref indices);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElements(mode, start, end, count, type, ref indices);
#endif
		}
		public static void DrawRangeElementsBaseVertex(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 start, System.Int32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, System.IntPtr indices, System.Int32 basevertex)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
#endif
		}
		public static void DrawRangeElementsBaseVertex<T5>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 start, System.Int32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T5[] indices, System.Int32 basevertex) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
#endif
		}
		public static void DrawRangeElementsBaseVertex<T5>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 start, System.Int32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T5[,] indices, System.Int32 basevertex) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
#endif
		}
		public static void DrawRangeElementsBaseVertex<T5>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 start, System.Int32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T5[, ,] indices, System.Int32 basevertex) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
#endif
		}
		public static void DrawRangeElementsBaseVertex<T5>(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 start, System.Int32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, ref T5 indices, System.Int32 basevertex) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, ref indices, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, ref indices, basevertex);
#endif
		}
		public static void DrawRangeElementsBaseVertex(OpenTK.Graphics.OpenGL.BeginMode mode, System.UInt32 start, System.UInt32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, System.IntPtr indices, System.Int32 basevertex)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
#endif
		}
		public static void DrawRangeElementsBaseVertex<T5>(OpenTK.Graphics.OpenGL.BeginMode mode, System.UInt32 start, System.UInt32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T5[] indices, System.Int32 basevertex) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
#endif
		}
		public static void DrawRangeElementsBaseVertex<T5>(OpenTK.Graphics.OpenGL.BeginMode mode, System.UInt32 start, System.UInt32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T5[,] indices, System.Int32 basevertex) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
#endif
		}
		public static void DrawRangeElementsBaseVertex<T5>(OpenTK.Graphics.OpenGL.BeginMode mode, System.UInt32 start, System.UInt32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, T5[, ,] indices, System.Int32 basevertex) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, indices, basevertex);
#endif
		}
		public static void DrawRangeElementsBaseVertex<T5>(OpenTK.Graphics.OpenGL.BeginMode mode, System.UInt32 start, System.UInt32 end, System.Int32 count, OpenTK.Graphics.OpenGL.DrawElementsType type, ref T5 indices, System.Int32 basevertex) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, ref indices, basevertex);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawRangeElementsBaseVertex(mode, start, end, count, type, ref indices, basevertex);
#endif
		}
		public static void EdgeFlag(System.Boolean flag)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EdgeFlag(flag);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EdgeFlag(flag);
#endif
		}
		public static void EdgeFlagPointer(System.Int32 stride, System.IntPtr pointer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EdgeFlagPointer(stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EdgeFlagPointer(stride, pointer);
#endif
		}
		public static void EdgeFlagPointer<T1>(System.Int32 stride, T1[] pointer) where T1 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EdgeFlagPointer(stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EdgeFlagPointer(stride, pointer);
#endif
		}
		public static void EdgeFlagPointer<T1>(System.Int32 stride, T1[,] pointer) where T1 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EdgeFlagPointer(stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EdgeFlagPointer(stride, pointer);
#endif
		}
		public static void EdgeFlagPointer<T1>(System.Int32 stride, T1[, ,] pointer) where T1 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EdgeFlagPointer(stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EdgeFlagPointer(stride, pointer);
#endif
		}
		public static void EdgeFlagPointer<T1>(System.Int32 stride, ref T1 pointer) where T1 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EdgeFlagPointer(stride, ref pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EdgeFlagPointer(stride, ref pointer);
#endif
		}
		public static void Enable(OpenTK.Graphics.OpenGL.EnableCap cap)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Enable(cap);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Enable(cap);
#endif
		}
		public static void EnableClientState(OpenTK.Graphics.OpenGL.ArrayCap array)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.EnableClientState(array);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.EnableClientState(array);
#endif
		}
		public static void Enable(OpenTK.Graphics.OpenGL.IndexedEnableCap target, System.Int32 index)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Enable(target, index);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Enable(target, index);
#endif
		}
		public static void ConvolutionFilter2D(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr image)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter2D(target, internalformat, width, height, format, type, image);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter2D(target, internalformat, width, height, format, type, image);
#endif
		}
		public static void ConvolutionFilter2D<T6>(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T6[] image) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter2D(target, internalformat, width, height, format, type, image);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter2D(target, internalformat, width, height, format, type, image);
#endif
		}
		public static void ConvolutionFilter2D<T6>(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T6[,] image) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter2D(target, internalformat, width, height, format, type, image);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter2D(target, internalformat, width, height, format, type, image);
#endif
		}
		public static void ConvolutionFilter2D<T6>(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T6[, ,] image) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter2D(target, internalformat, width, height, format, type, image);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter2D(target, internalformat, width, height, format, type, image);
#endif
		}
		public static void ConvolutionFilter2D<T6>(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, ref T6 image) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter2D(target, internalformat, width, height, format, type, ref image);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter2D(target, internalformat, width, height, format, type, ref image);
#endif
		}
		public static void ConvolutionParameter(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.ConvolutionParameter pname, System.Single @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ConvolutionParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ConvolutionParameter(target, pname, @params);
#endif
		}
		public static void ConvolutionParameter(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.ConvolutionParameter pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ConvolutionParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ConvolutionParameter(target, pname, @params);
#endif
		}
		public static void ConvolutionParameter(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.ConvolutionParameter pname, System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ConvolutionParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ConvolutionParameter(target, pname, @params);
#endif
		}
		public static void ConvolutionParameter(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.ConvolutionParameter pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ConvolutionParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ConvolutionParameter(target, pname, @params);
#endif
		}
		public static void CopyBufferSubData(OpenTK.Graphics.OpenGL.BufferTarget readTarget, OpenTK.Graphics.OpenGL.BufferTarget writeTarget, System.IntPtr readOffset, System.IntPtr writeOffset, System.IntPtr size)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CopyBufferSubData(readTarget, writeTarget, readOffset, writeOffset, size);
#endif
		}
		public static void CopyColorSubTable(OpenTK.Graphics.OpenGL.ColorTableTarget target, System.Int32 start, System.Int32 x, System.Int32 y, System.Int32 width)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CopyColorSubTable(target, start, x, y, width);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CopyColorSubTable(target, start, x, y, width);
#endif
		}
		public static void CopyColorTable(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 x, System.Int32 y, System.Int32 width)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CopyColorTable(target, internalformat, x, y, width);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CopyColorTable(target, internalformat, x, y, width);
#endif
		}
		public static void CopyConvolutionFilter1D(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 x, System.Int32 y, System.Int32 width)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CopyConvolutionFilter1D(target, internalformat, x, y, width);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CopyConvolutionFilter1D(target, internalformat, x, y, width);
#endif
		}
		public static void CopyConvolutionFilter2D(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CopyConvolutionFilter2D(target, internalformat, x, y, width, height);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CopyConvolutionFilter2D(target, internalformat, x, y, width, height);
#endif
		}
		public static void CopyPixels(System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelCopyType type)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CopyPixels(x, y, width, height, type);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CopyPixels(x, y, width, height, type);
#endif
		}
		public static void CopyTexImage1D(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 border)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CopyTexImage1D(target, level, internalformat, x, y, width, border);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CopyTexImage1D(target, level, internalformat, x, y, width, border);
#endif
		}
		public static void CopyTexImage2D(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height, System.Int32 border)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CopyTexImage2D(target, level, internalformat, x, y, width, height, border);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CopyTexImage2D(target, level, internalformat, x, y, width, height, border);
#endif
		}
		public static void CopyTexSubImage1D(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 x, System.Int32 y, System.Int32 width)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CopyTexSubImage1D(target, level, xoffset, x, y, width);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CopyTexSubImage1D(target, level, xoffset, x, y, width);
#endif
		}
		public static void CopyTexSubImage2D(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CopyTexSubImage2D(target, level, xoffset, yoffset, x, y, width, height);
#endif
		}
		public static void CopyTexSubImage3D(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 x, System.Int32 y, System.Int32 width, System.Int32 height)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CopyTexSubImage3D(target, level, xoffset, yoffset, zoffset, x, y, width, height);
#endif
		}
		public static System.Int32 CreateProgram()
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.CreateProgram();
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.CreateProgram();
#endif
		}
		public static System.Int32 CreateShader(OpenTK.Graphics.OpenGL.ShaderType type)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.CreateShader(type);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.CreateShader(type);
#endif
		}
		public static void CullFace(OpenTK.Graphics.OpenGL.CullFaceMode mode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CullFace(mode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CullFace(mode);
#endif
		}
		public static void DeleteBuffers(System.Int32 n, System.Int32[] buffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteBuffers(n, buffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteBuffers(n, buffers);
#endif
		}
		public static void DeleteBuffers(System.Int32 n, ref System.Int32 buffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteBuffers(n, ref buffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteBuffers(n, ref buffers);
#endif
		}
		public static void DeleteBuffers(System.Int32 n, System.UInt32[] buffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteBuffers(n, buffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteBuffers(n, buffers);
#endif
		}
		public static void DeleteBuffers(System.Int32 n, ref System.UInt32 buffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteBuffers(n, ref buffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteBuffers(n, ref buffers);
#endif
		}
		public static void DeleteFramebuffers(System.Int32 n, System.Int32[] framebuffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteFramebuffers(n, framebuffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteFramebuffers(n, framebuffers);
#endif
		}
		public static void DeleteFramebuffers(System.Int32 n, ref System.Int32 framebuffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteFramebuffers(n, ref framebuffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteFramebuffers(n, ref framebuffers);
#endif
		}
		public static void DeleteFramebuffers(System.Int32 n, System.UInt32[] framebuffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteFramebuffers(n, framebuffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteFramebuffers(n, framebuffers);
#endif
		}
		public static void DeleteFramebuffers(System.Int32 n, ref System.UInt32 framebuffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteFramebuffers(n, ref framebuffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteFramebuffers(n, ref framebuffers);
#endif
		}
		public static void DeleteLists(System.Int32 list, System.Int32 range)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteLists(list, range);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteLists(list, range);
#endif
		}
		public static void DeleteLists(System.UInt32 list, System.Int32 range)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteLists(list, range);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteLists(list, range);
#endif
		}
		public static void DeleteProgram(System.Int32 program)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteProgram(program);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteProgram(program);
#endif
		}
		public static void DeleteProgram(System.UInt32 program)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteProgram(program);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteProgram(program);
#endif
		}
		public static void DeleteQueries(System.Int32 n, System.Int32[] ids)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteQueries(n, ids);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteQueries(n, ids);
#endif
		}
		public static void DeleteQueries(System.Int32 n, ref System.Int32 ids)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteQueries(n, ref ids);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteQueries(n, ref ids);
#endif
		}
		public static void DeleteQueries(System.Int32 n, System.UInt32[] ids)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteQueries(n, ids);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteQueries(n, ids);
#endif
		}
		public static void DeleteQueries(System.Int32 n, ref System.UInt32 ids)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteQueries(n, ref ids);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteQueries(n, ref ids);
#endif
		}
		public static void DeleteRenderbuffers(System.Int32 n, System.Int32[] renderbuffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteRenderbuffers(n, renderbuffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteRenderbuffers(n, renderbuffers);
#endif
		}
		public static void DeleteRenderbuffers(System.Int32 n, ref System.Int32 renderbuffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteRenderbuffers(n, ref renderbuffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteRenderbuffers(n, ref renderbuffers);
#endif
		}
		public static void DeleteRenderbuffers(System.Int32 n, System.UInt32[] renderbuffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteRenderbuffers(n, renderbuffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteRenderbuffers(n, renderbuffers);
#endif
		}
		public static void DeleteRenderbuffers(System.Int32 n, ref System.UInt32 renderbuffers)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteRenderbuffers(n, ref renderbuffers);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteRenderbuffers(n, ref renderbuffers);
#endif
		}
		public static void DeleteShader(System.Int32 shader)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteShader(shader);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteShader(shader);
#endif
		}
		public static void DeleteShader(System.UInt32 shader)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteShader(shader);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteShader(shader);
#endif
		}
		public static void DeleteSync(System.IntPtr sync)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteSync(sync);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteSync(sync);
#endif
		}
		public static void DeleteTextures(System.Int32 n, System.Int32[] textures)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteTextures(n, textures);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteTextures(n, textures);
#endif
		}
		public static void DeleteTextures(System.Int32 n, ref System.Int32 textures)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteTextures(n, ref textures);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteTextures(n, ref textures);
#endif
		}
		public static void DeleteTextures(System.Int32 n, System.UInt32[] textures)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteTextures(n, textures);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteTextures(n, textures);
#endif
		}
		public static void DeleteTextures(System.Int32 n, ref System.UInt32 textures)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteTextures(n, ref textures);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteTextures(n, ref textures);
#endif
		}
		public static void DeleteVertexArrays(System.Int32 n, System.Int32[] arrays)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteVertexArrays(n, arrays);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteVertexArrays(n, arrays);
#endif
		}
		public static void DeleteVertexArrays(System.Int32 n, ref System.Int32 arrays)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteVertexArrays(n, ref arrays);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteVertexArrays(n, ref arrays);
#endif
		}
		public static void DeleteVertexArrays(System.Int32 n, System.UInt32[] arrays)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteVertexArrays(n, arrays);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteVertexArrays(n, arrays);
#endif
		}
		public static void DeleteVertexArrays(System.Int32 n, ref System.UInt32 arrays)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DeleteVertexArrays(n, ref arrays);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DeleteVertexArrays(n, ref arrays);
#endif
		}
		public static void DepthFunc(OpenTK.Graphics.OpenGL.DepthFunction func)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DepthFunc(func);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DepthFunc(func);
#endif
		}
		public static void DepthMask(System.Boolean flag)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DepthMask(flag);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DepthMask(flag);
#endif
		}
		public static void DepthRange(System.Double near, System.Double far)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DepthRange(near, far);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DepthRange(near, far);
#endif
		}
		public static void DetachShader(System.Int32 program, System.Int32 shader)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DetachShader(program, shader);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DetachShader(program, shader);
#endif
		}
		public static void DetachShader(System.UInt32 program, System.UInt32 shader)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DetachShader(program, shader);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DetachShader(program, shader);
#endif
		}
		public static void Disable(OpenTK.Graphics.OpenGL.EnableCap cap)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Disable(cap);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Disable(cap);
#endif
		}
		public static void DisableClientState(OpenTK.Graphics.OpenGL.ArrayCap array)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DisableClientState(array);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DisableClientState(array);
#endif
		}
		public static void Disable(OpenTK.Graphics.OpenGL.IndexedEnableCap target, System.Int32 index)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Disable(target, index);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Disable(target, index);
#endif
		}
		public static void Disable(OpenTK.Graphics.OpenGL.IndexedEnableCap target, System.UInt32 index)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Disable(target, index);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Disable(target, index);
#endif
		}
		public static void DisableVertexAttribArray(System.Int32 index)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DisableVertexAttribArray(index);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DisableVertexAttribArray(index);
#endif
		}
		public static void DisableVertexAttribArray(System.UInt32 index)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DisableVertexAttribArray(index);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DisableVertexAttribArray(index);
#endif
		}
		public static void DrawArrays(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 first, System.Int32 count)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawArrays(mode, first, count);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawArrays(mode, first, count);
#endif
		}
		public static void DrawArraysInstanced(OpenTK.Graphics.OpenGL.BeginMode mode, System.Int32 first, System.Int32 count, System.Int32 primcount)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawArraysInstanced(mode, first, count, primcount);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawArraysInstanced(mode, first, count, primcount);
#endif
		}
		public static void DrawBuffer(OpenTK.Graphics.OpenGL.DrawBufferMode mode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.DrawBuffer(mode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.DrawBuffer(mode);
#endif
		}
		public static void ColorPointer(System.Int32 size, OpenTK.Graphics.OpenGL.ColorPointerType type, System.Int32 stride, System.IntPtr pointer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorPointer(size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorPointer(size, type, stride, pointer);
#endif
		}
		public static void ColorPointer<T3>(System.Int32 size, OpenTK.Graphics.OpenGL.ColorPointerType type, System.Int32 stride, T3[] pointer) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorPointer(size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorPointer(size, type, stride, pointer);
#endif
		}
		public static void ColorPointer<T3>(System.Int32 size, OpenTK.Graphics.OpenGL.ColorPointerType type, System.Int32 stride, T3[,] pointer) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorPointer(size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorPointer(size, type, stride, pointer);
#endif
		}
		public static void ColorPointer<T3>(System.Int32 size, OpenTK.Graphics.OpenGL.ColorPointerType type, System.Int32 stride, T3[, ,] pointer) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorPointer(size, type, stride, pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorPointer(size, type, stride, pointer);
#endif
		}
		public static void ColorPointer<T3>(System.Int32 size, OpenTK.Graphics.OpenGL.ColorPointerType type, System.Int32 stride, ref T3 pointer) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorPointer(size, type, stride, ref pointer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorPointer(size, type, stride, ref pointer);
#endif
		}
		public static void ColorSubTable(OpenTK.Graphics.OpenGL.ColorTableTarget target, System.Int32 start, System.Int32 count, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorSubTable(target, start, count, format, type, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorSubTable(target, start, count, format, type, data);
#endif
		}
		public static void ColorSubTable<T5>(OpenTK.Graphics.OpenGL.ColorTableTarget target, System.Int32 start, System.Int32 count, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T5[] data) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorSubTable(target, start, count, format, type, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorSubTable(target, start, count, format, type, data);
#endif
		}
		public static void ColorSubTable<T5>(OpenTK.Graphics.OpenGL.ColorTableTarget target, System.Int32 start, System.Int32 count, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T5[,] data) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorSubTable(target, start, count, format, type, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorSubTable(target, start, count, format, type, data);
#endif
		}
		public static void ColorSubTable<T5>(OpenTK.Graphics.OpenGL.ColorTableTarget target, System.Int32 start, System.Int32 count, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T5[, ,] data) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorSubTable(target, start, count, format, type, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorSubTable(target, start, count, format, type, data);
#endif
		}
		public static void ColorSubTable<T5>(OpenTK.Graphics.OpenGL.ColorTableTarget target, System.Int32 start, System.Int32 count, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, ref T5 data) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorSubTable(target, start, count, format, type, ref data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorSubTable(target, start, count, format, type, ref data);
#endif
		}
		public static void ColorTable(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr table)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorTable(target, internalformat, width, format, type, table);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorTable(target, internalformat, width, format, type, table);
#endif
		}
		public static void ColorTable<T5>(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T5[] table) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorTable(target, internalformat, width, format, type, table);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorTable(target, internalformat, width, format, type, table);
#endif
		}
		public static void ColorTable<T5>(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T5[,] table) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorTable(target, internalformat, width, format, type, table);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorTable(target, internalformat, width, format, type, table);
#endif
		}
		public static void ColorTable<T5>(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T5[, ,] table) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorTable(target, internalformat, width, format, type, table);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorTable(target, internalformat, width, format, type, table);
#endif
		}
		public static void ColorTable<T5>(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, ref T5 table) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorTable(target, internalformat, width, format, type, ref table);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorTable(target, internalformat, width, format, type, ref table);
#endif
		}
		public static void ColorTableParameter(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.ColorTableParameterPName pname, System.Single[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorTableParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorTableParameter(target, pname, @params);
#endif
		}
		public static void ColorTableParameter(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.ColorTableParameterPName pname, ref System.Single @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorTableParameter(target, pname, ref @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorTableParameter(target, pname, ref @params);
#endif
		}
		public static void ColorTableParameter(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.ColorTableParameterPName pname, System.Int32[] @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorTableParameter(target, pname, @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorTableParameter(target, pname, @params);
#endif
		}
		public static void ColorTableParameter(OpenTK.Graphics.OpenGL.ColorTableTarget target, OpenTK.Graphics.OpenGL.ColorTableParameterPName pname, ref System.Int32 @params)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorTableParameter(target, pname, ref @params);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorTableParameter(target, pname, ref @params);
#endif
		}
		public static void CompileShader(System.Int32 shader)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompileShader(shader);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompileShader(shader);
#endif
		}
		public static void CompileShader(System.UInt32 shader)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompileShader(shader);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompileShader(shader);
#endif
		}
		public static void CompressedTexImage1D(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 border, System.Int32 imageSize, System.IntPtr data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
#endif
		}
		public static void CompressedTexImage1D<T6>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 border, System.Int32 imageSize, T6[] data) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
#endif
		}
		public static void CompressedTexImage1D<T6>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 border, System.Int32 imageSize, T6[,] data) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
#endif
		}
		public static void CompressedTexImage1D<T6>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 border, System.Int32 imageSize, T6[, ,] data) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, data);
#endif
		}
		public static void CompressedTexImage1D<T6>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 border, System.Int32 imageSize, ref T6 data) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, ref data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage1D(target, level, internalformat, width, border, imageSize, ref data);
#endif
		}
		public static void CompressedTexImage2D(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 border, System.Int32 imageSize, System.IntPtr data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
#endif
		}
		public static void CompressedTexImage2D<T7>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 border, System.Int32 imageSize, T7[] data) where T7 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
#endif
		}
		public static void CompressedTexImage2D<T7>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 border, System.Int32 imageSize, T7[,] data) where T7 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
#endif
		}
		public static void CompressedTexImage2D<T7>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 border, System.Int32 imageSize, T7[, ,] data) where T7 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, data);
#endif
		}
		public static void CompressedTexImage2D<T7>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 border, System.Int32 imageSize, ref T7 data) where T7 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, ref data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage2D(target, level, internalformat, width, height, border, imageSize, ref data);
#endif
		}
		public static void CompressedTexImage3D(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 border, System.Int32 imageSize, System.IntPtr data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
#endif
		}
		public static void CompressedTexImage3D<T8>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 border, System.Int32 imageSize, T8[] data) where T8 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
#endif
		}
		public static void CompressedTexImage3D<T8>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 border, System.Int32 imageSize, T8[,] data) where T8 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
#endif
		}
		public static void CompressedTexImage3D<T8>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 border, System.Int32 imageSize, T8[, ,] data) where T8 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, data);
#endif
		}
		public static void CompressedTexImage3D<T8>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, System.Int32 height, System.Int32 depth, System.Int32 border, System.Int32 imageSize, ref T8 data) where T8 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, ref data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexImage3D(target, level, internalformat, width, height, depth, border, imageSize, ref data);
#endif
		}
		public static void CompressedTexSubImage1D(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, System.Int32 imageSize, System.IntPtr data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
#endif
		}
		public static void CompressedTexSubImage1D<T6>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, System.Int32 imageSize, T6[] data) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
#endif
		}
		public static void CompressedTexSubImage1D<T6>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, System.Int32 imageSize, T6[,] data) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
#endif
		}
		public static void CompressedTexSubImage1D<T6>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, System.Int32 imageSize, T6[, ,] data) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, data);
#endif
		}
		public static void CompressedTexSubImage1D<T6>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, System.Int32 imageSize, ref T6 data) where T6 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, ref data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage1D(target, level, xoffset, width, format, imageSize, ref data);
#endif
		}
		public static void CompressedTexSubImage2D(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, System.Int32 imageSize, System.IntPtr data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
#endif
		}
		public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, System.Int32 imageSize, T8[] data) where T8 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
#endif
		}
		public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, System.Int32 imageSize, T8[,] data) where T8 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
#endif
		}
		public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, System.Int32 imageSize, T8[, ,] data) where T8 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, data);
#endif
		}
		public static void CompressedTexSubImage2D<T8>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 width, System.Int32 height, OpenTK.Graphics.OpenGL.PixelFormat format, System.Int32 imageSize, ref T8 data) where T8 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, ref data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage2D(target, level, xoffset, yoffset, width, height, format, imageSize, ref data);
#endif
		}
		public static void CompressedTexSubImage3D(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, OpenTK.Graphics.OpenGL.PixelFormat format, System.Int32 imageSize, System.IntPtr data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
#endif
		}
		public static void CompressedTexSubImage3D<T10>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, OpenTK.Graphics.OpenGL.PixelFormat format, System.Int32 imageSize, T10[] data) where T10 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
#endif
		}
		public static void CompressedTexSubImage3D<T10>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, OpenTK.Graphics.OpenGL.PixelFormat format, System.Int32 imageSize, T10[,] data) where T10 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
#endif
		}
		public static void CompressedTexSubImage3D<T10>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, OpenTK.Graphics.OpenGL.PixelFormat format, System.Int32 imageSize, T10[, ,] data) where T10 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
#endif
		}
		public static void CompressedTexSubImage3D<T10>(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 level, System.Int32 xoffset, System.Int32 yoffset, System.Int32 zoffset, System.Int32 width, System.Int32 height, System.Int32 depth, OpenTK.Graphics.OpenGL.PixelFormat format, System.Int32 imageSize, ref T10 data) where T10 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, ref data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CompressedTexSubImage3D(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, ref data);
#endif
		}
		public static void ConvolutionFilter1D(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, System.IntPtr image)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter1D(target, internalformat, width, format, type, image);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter1D(target, internalformat, width, format, type, image);
#endif
		}
		public static void ConvolutionFilter1D<T5>(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T5[] image) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter1D(target, internalformat, width, format, type, image);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter1D(target, internalformat, width, format, type, image);
#endif
		}
		public static void ConvolutionFilter1D<T5>(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T5[,] image) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter1D(target, internalformat, width, format, type, image);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter1D(target, internalformat, width, format, type, image);
#endif
		}
		public static void ConvolutionFilter1D<T5>(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, T5[, ,] image) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter1D(target, internalformat, width, format, type, image);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter1D(target, internalformat, width, format, type, image);
#endif
		}
		public static void ConvolutionFilter1D<T5>(OpenTK.Graphics.OpenGL.ConvolutionTarget target, OpenTK.Graphics.OpenGL.PixelInternalFormat internalformat, System.Int32 width, OpenTK.Graphics.OpenGL.PixelFormat format, OpenTK.Graphics.OpenGL.PixelType type, ref T5 image) where T5 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter1D(target, internalformat, width, format, type, ref image);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ConvolutionFilter1D(target, internalformat, width, format, type, ref image);
#endif
		}
		public static void ClearBuffer(OpenTK.Graphics.OpenGL.ClearBuffer buffer, System.Int32 drawbuffer, System.Int32[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ClearBuffer(buffer, drawbuffer, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ClearBuffer(buffer, drawbuffer, value);
#endif
		}
		public static void ClearBuffer(OpenTK.Graphics.OpenGL.ClearBuffer buffer, System.Int32 drawbuffer, ref System.Int32 value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ClearBuffer(buffer, drawbuffer, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ClearBuffer(buffer, drawbuffer, ref value);
#endif
		}
		public static void ClearBuffer(OpenTK.Graphics.OpenGL.ClearBuffer buffer, System.Int32 drawbuffer, System.UInt32[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ClearBuffer(buffer, drawbuffer, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ClearBuffer(buffer, drawbuffer, value);
#endif
		}
		public static void ClearBuffer(OpenTK.Graphics.OpenGL.ClearBuffer buffer, System.Int32 drawbuffer, ref System.UInt32 value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ClearBuffer(buffer, drawbuffer, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ClearBuffer(buffer, drawbuffer, ref value);
#endif
		}
		public static void ClearColor(System.Single red, System.Single green, System.Single blue, System.Single alpha)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ClearColor(red, green, blue, alpha);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ClearColor(red, green, blue, alpha);
#endif
		}
		public static void ClearDepth(System.Double depth)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ClearDepth(depth);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ClearDepth(depth);
#endif
		}
		public static void ClearIndex(System.Single c)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ClearIndex(c);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ClearIndex(c);
#endif
		}
		public static void ClearStencil(System.Int32 s)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ClearStencil(s);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ClearStencil(s);
#endif
		}
		public static void ClientActiveTexture(OpenTK.Graphics.OpenGL.TextureUnit texture)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ClientActiveTexture(texture);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ClientActiveTexture(texture);
#endif
		}
		public static OpenTK.Graphics.OpenGL.ArbSync ClientWaitSync(System.IntPtr sync, System.Int32 flags, System.Int64 timeout)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.ClientWaitSync(sync, flags, timeout);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.ClientWaitSync(sync, flags, timeout);
#endif
		}
		public static OpenTK.Graphics.OpenGL.ArbSync ClientWaitSync(System.IntPtr sync, System.UInt32 flags, System.UInt64 timeout)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.ClientWaitSync(sync, flags, timeout);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.ClientWaitSync(sync, flags, timeout);
#endif
		}
		public static void ClipPlane(OpenTK.Graphics.OpenGL.ClipPlaneName plane, System.Double[] equation)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ClipPlane(plane, equation);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ClipPlane(plane, equation);
#endif
		}
		public static void ClipPlane(OpenTK.Graphics.OpenGL.ClipPlaneName plane, ref System.Double equation)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ClipPlane(plane, ref equation);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ClipPlane(plane, ref equation);
#endif
		}
		public static void Color3(System.SByte red, System.SByte green, System.SByte blue)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(red, green, blue);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(red, green, blue);
#endif
		}
		public static void Color3(System.SByte[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(v);
#endif
		}
		public static void Color3(ref System.SByte v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(ref v);
#endif
		}
		public static void Color3(System.Double red, System.Double green, System.Double blue)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(red, green, blue);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(red, green, blue);
#endif
		}
		public static void Color3(System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(v);
#endif
		}
		public static void Color3(ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(ref v);
#endif
		}
		public static void Color3(System.Single red, System.Single green, System.Single blue)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(red, green, blue);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(red, green, blue);
#endif
		}
		public static void Color3(System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(v);
#endif
		}
		public static void Color3(ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(ref v);
#endif
		}
		public static void Color3(System.Int32 red, System.Int32 green, System.Int32 blue)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(red, green, blue);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(red, green, blue);
#endif
		}
		public static void Color3(System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(v);
#endif
		}
		public static void Color3(ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(ref v);
#endif
		}
		public static void Color3(System.Int16 red, System.Int16 green, System.Int16 blue)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(red, green, blue);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(red, green, blue);
#endif
		}
		public static void Color3(System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(v);
#endif
		}
		public static void Color3(ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(ref v);
#endif
		}
		public static void Color3(System.Byte red, System.Byte green, System.Byte blue)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(red, green, blue);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(red, green, blue);
#endif
		}
		public static void Color3(System.Byte[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(v);
#endif
		}
		public static void Color3(ref System.Byte v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(ref v);
#endif
		}
		public static void Color3(System.UInt32 red, System.UInt32 green, System.UInt32 blue)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(red, green, blue);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(red, green, blue);
#endif
		}
		public static void Color3(System.UInt32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(v);
#endif
		}
		public static void Color3(ref System.UInt32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(ref v);
#endif
		}
		public static void Color3(System.UInt16 red, System.UInt16 green, System.UInt16 blue)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(red, green, blue);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(red, green, blue);
#endif
		}
		public static void Color3(System.UInt16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(v);
#endif
		}
		public static void Color3(ref System.UInt16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color3(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color3(ref v);
#endif
		}
		public static void Color4(System.SByte red, System.SByte green, System.SByte blue, System.SByte alpha)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(red, green, blue, alpha);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(red, green, blue, alpha);
#endif
		}
		public static void Color4(System.SByte[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(v);
#endif
		}
		public static void Color4(ref System.SByte v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(ref v);
#endif
		}
		public static void Color4(System.Double red, System.Double green, System.Double blue, System.Double alpha)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(red, green, blue, alpha);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(red, green, blue, alpha);
#endif
		}
		public static void Color4(System.Double[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(v);
#endif
		}
		public static void Color4(ref System.Double v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(ref v);
#endif
		}
		public static void Color4(System.Single red, System.Single green, System.Single blue, System.Single alpha)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(red, green, blue, alpha);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(red, green, blue, alpha);
#endif
		}
		public static void Color4(System.Single[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(v);
#endif
		}
		public static void Color4(ref System.Single v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(ref v);
#endif
		}
		public static void Color4(System.Int32 red, System.Int32 green, System.Int32 blue, System.Int32 alpha)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(red, green, blue, alpha);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(red, green, blue, alpha);
#endif
		}
		public static void Color4(System.Int32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(v);
#endif
		}
		public static void Color4(ref System.Int32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(ref v);
#endif
		}
		public static void Color4(System.Int16 red, System.Int16 green, System.Int16 blue, System.Int16 alpha)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(red, green, blue, alpha);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(red, green, blue, alpha);
#endif
		}
		public static void Color4(System.Int16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(v);
#endif
		}
		public static void Color4(ref System.Int16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(ref v);
#endif
		}
		public static void Color4(System.Byte red, System.Byte green, System.Byte blue, System.Byte alpha)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(red, green, blue, alpha);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(red, green, blue, alpha);
#endif
		}
		public static void Color4(System.Byte[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(v);
#endif
		}
		public static void Color4(ref System.Byte v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(ref v);
#endif
		}
		public static void Color4(System.UInt32 red, System.UInt32 green, System.UInt32 blue, System.UInt32 alpha)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(red, green, blue, alpha);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(red, green, blue, alpha);
#endif
		}
		public static void Color4(System.UInt32[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(v);
#endif
		}
		public static void Color4(ref System.UInt32 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(ref v);
#endif
		}
		public static void Color4(System.UInt16 red, System.UInt16 green, System.UInt16 blue, System.UInt16 alpha)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(red, green, blue, alpha);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(red, green, blue, alpha);
#endif
		}
		public static void Color4(System.UInt16[] v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(v);
#endif
		}
		public static void Color4(ref System.UInt16 v)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Color4(ref v);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Color4(ref v);
#endif
		}
		public static void ColorMask(System.Boolean red, System.Boolean green, System.Boolean blue, System.Boolean alpha)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorMask(red, green, blue, alpha);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorMask(red, green, blue, alpha);
#endif
		}
		public static void ColorMask(System.Int32 index, System.Boolean r, System.Boolean g, System.Boolean b, System.Boolean a)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorMask(index, r, g, b, a);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorMask(index, r, g, b, a);
#endif
		}
		public static void ColorMask(System.UInt32 index, System.Boolean r, System.Boolean g, System.Boolean b, System.Boolean a)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorMask(index, r, g, b, a);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorMask(index, r, g, b, a);
#endif
		}
		public static void ColorMaterial(OpenTK.Graphics.OpenGL.MaterialFace face, OpenTK.Graphics.OpenGL.ColorMaterialParameter mode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ColorMaterial(face, mode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ColorMaterial(face, mode);
#endif
		}
		public static void Accum(OpenTK.Graphics.OpenGL.AccumOp op, System.Single value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Accum(op, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Accum(op, value);
#endif
		}
		public static void ActiveTexture(OpenTK.Graphics.OpenGL.TextureUnit texture)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ActiveTexture(texture);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ActiveTexture(texture);
#endif
		}
		public static void AlphaFunc(OpenTK.Graphics.OpenGL.AlphaFunction func, System.Single @ref)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.AlphaFunc(func, @ref);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.AlphaFunc(func, @ref);
#endif
		}
		public static System.Boolean AreTexturesResident(System.Int32 n, System.Int32[] textures, System.Boolean[] residences)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.AreTexturesResident(n, textures, residences);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.AreTexturesResident(n, textures, residences);
#endif
		}
		public static System.Boolean AreTexturesResident(System.Int32 n, ref System.Int32 textures, out System.Boolean residences)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.AreTexturesResident(n, ref textures, out residences);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.AreTexturesResident(n, ref textures, out residences);
#endif
		}
		public static System.Boolean AreTexturesResident(System.Int32 n, System.UInt32[] textures, System.Boolean[] residences)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.AreTexturesResident(n, textures, residences);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.AreTexturesResident(n, textures, residences);
#endif
		}
		public static System.Boolean AreTexturesResident(System.Int32 n, ref System.UInt32 textures, out System.Boolean residences)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.AreTexturesResident(n, ref textures, out residences);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.AreTexturesResident(n, ref textures, out residences);
#endif
		}
		public static void ArrayElement(System.Int32 i)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ArrayElement(i);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ArrayElement(i);
#endif
		}
		public static void AttachShader(System.Int32 program, System.Int32 shader)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.AttachShader(program, shader);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.AttachShader(program, shader);
#endif
		}
		public static void AttachShader(System.UInt32 program, System.UInt32 shader)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.AttachShader(program, shader);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.AttachShader(program, shader);
#endif
		}
		public static void Begin(OpenTK.Graphics.OpenGL.BeginMode mode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Begin(mode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Begin(mode);
#endif
		}
		public static void BeginConditionalRender(System.Int32 id, OpenTK.Graphics.OpenGL.ConditionalRenderType mode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BeginConditionalRender(id, mode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BeginConditionalRender(id, mode);
#endif
		}
		public static void BeginConditionalRender(System.UInt32 id, OpenTK.Graphics.OpenGL.ConditionalRenderType mode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BeginConditionalRender(id, mode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BeginConditionalRender(id, mode);
#endif
		}
		public static void BeginQuery(OpenTK.Graphics.OpenGL.QueryTarget target, System.Int32 id)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BeginQuery(target, id);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BeginQuery(target, id);
#endif
		}
		public static void BeginQuery(OpenTK.Graphics.OpenGL.QueryTarget target, System.UInt32 id)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BeginQuery(target, id);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BeginQuery(target, id);
#endif
		}
		public static void BeginTransformFeedback(OpenTK.Graphics.OpenGL.BeginFeedbackMode primitiveMode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BeginTransformFeedback(primitiveMode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BeginTransformFeedback(primitiveMode);
#endif
		}
		public static void BindAttribLocation(System.Int32 program, System.Int32 index, System.String name)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BindAttribLocation(program, index, name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BindAttribLocation(program, index, name);
#endif
		}
		public static void BindAttribLocation(System.UInt32 program, System.UInt32 index, System.String name)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BindAttribLocation(program, index, name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BindAttribLocation(program, index, name);
#endif
		}
		public static void BindBuffer(OpenTK.Graphics.OpenGL.BufferTarget target, System.Int32 buffer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BindBuffer(target, buffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BindBuffer(target, buffer);
#endif
		}
		public static void BindBuffer(OpenTK.Graphics.OpenGL.BufferTarget target, System.UInt32 buffer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BindBuffer(target, buffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BindBuffer(target, buffer);
#endif
		}
		public static void BindBufferBase(OpenTK.Graphics.OpenGL.BufferTarget target, System.Int32 index, System.Int32 buffer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BindBufferBase(target, index, buffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BindBufferBase(target, index, buffer);
#endif
		}
		public static void BindBufferBase(OpenTK.Graphics.OpenGL.BufferTarget target, System.UInt32 index, System.UInt32 buffer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BindBufferBase(target, index, buffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BindBufferBase(target, index, buffer);
#endif
		}
		public static void BindBufferRange(OpenTK.Graphics.OpenGL.BufferTarget target, System.Int32 index, System.Int32 buffer, System.IntPtr offset, System.IntPtr size)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BindBufferRange(target, index, buffer, offset, size);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BindBufferRange(target, index, buffer, offset, size);
#endif
		}
		public static void BindBufferRange(OpenTK.Graphics.OpenGL.BufferTarget target, System.UInt32 index, System.UInt32 buffer, System.IntPtr offset, System.IntPtr size)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BindBufferRange(target, index, buffer, offset, size);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BindBufferRange(target, index, buffer, offset, size);
#endif
		}
		public static void BindFragDataLocation(System.Int32 program, System.Int32 color, System.String name)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BindFragDataLocation(program, color, name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BindFragDataLocation(program, color, name);
#endif
		}
		public static void BindFragDataLocation(System.UInt32 program, System.UInt32 color, System.String name)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BindFragDataLocation(program, color, name);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BindFragDataLocation(program, color, name);
#endif
		}
		public static void BindFramebuffer(OpenTK.Graphics.OpenGL.FramebufferTarget target, System.Int32 framebuffer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BindFramebuffer(target, framebuffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BindFramebuffer(target, framebuffer);
#endif
		}
		public static void BindFramebuffer(OpenTK.Graphics.OpenGL.FramebufferTarget target, System.UInt32 framebuffer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BindFramebuffer(target, framebuffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BindFramebuffer(target, framebuffer);
#endif
		}
		public static void BindRenderbuffer(OpenTK.Graphics.OpenGL.RenderbufferTarget target, System.Int32 renderbuffer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BindRenderbuffer(target, renderbuffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BindRenderbuffer(target, renderbuffer);
#endif
		}
		public static void BindRenderbuffer(OpenTK.Graphics.OpenGL.RenderbufferTarget target, System.UInt32 renderbuffer)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BindRenderbuffer(target, renderbuffer);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BindRenderbuffer(target, renderbuffer);
#endif
		}
		public static void BindTexture(OpenTK.Graphics.OpenGL.TextureTarget target, System.Int32 texture)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BindTexture(target, texture);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BindTexture(target, texture);
#endif
		}
		public static void BindTexture(OpenTK.Graphics.OpenGL.TextureTarget target, System.UInt32 texture)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BindTexture(target, texture);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BindTexture(target, texture);
#endif
		}
		public static void BindVertexArray(System.Int32 array)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BindVertexArray(array);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BindVertexArray(array);
#endif
		}
		public static void BindVertexArray(System.UInt32 array)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BindVertexArray(array);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BindVertexArray(array);
#endif
		}
		public static void Bitmap(System.Int32 width, System.Int32 height, System.Single xorig, System.Single yorig, System.Single xmove, System.Single ymove, System.Byte[] bitmap)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Bitmap(width, height, xorig, yorig, xmove, ymove, bitmap);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Bitmap(width, height, xorig, yorig, xmove, ymove, bitmap);
#endif
		}
		public static void Bitmap(System.Int32 width, System.Int32 height, System.Single xorig, System.Single yorig, System.Single xmove, System.Single ymove, ref System.Byte bitmap)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Bitmap(width, height, xorig, yorig, xmove, ymove, ref bitmap);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Bitmap(width, height, xorig, yorig, xmove, ymove, ref bitmap);
#endif
		}
		public static void BlendColor(System.Single red, System.Single green, System.Single blue, System.Single alpha)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BlendColor(red, green, blue, alpha);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BlendColor(red, green, blue, alpha);
#endif
		}
		public static void BlendEquation(OpenTK.Graphics.OpenGL.BlendEquationMode mode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BlendEquation(mode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BlendEquation(mode);
#endif
		}
		public static void BlendEquation(System.Int32 buf, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend mode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BlendEquation(buf, mode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BlendEquation(buf, mode);
#endif
		}
		public static void BlendEquation(System.UInt32 buf, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend mode)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BlendEquation(buf, mode);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BlendEquation(buf, mode);
#endif
		}
		public static void BlendEquationSeparate(OpenTK.Graphics.OpenGL.BlendEquationMode modeRGB, OpenTK.Graphics.OpenGL.BlendEquationMode modeAlpha)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BlendEquationSeparate(modeRGB, modeAlpha);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BlendEquationSeparate(modeRGB, modeAlpha);
#endif
		}
		public static void BlendEquationSeparate(System.Int32 buf, OpenTK.Graphics.OpenGL.BlendEquationMode modeRGB, OpenTK.Graphics.OpenGL.BlendEquationMode modeAlpha)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BlendEquationSeparate(buf, modeRGB, modeAlpha);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BlendEquationSeparate(buf, modeRGB, modeAlpha);
#endif
		}
		public static void BlendEquationSeparate(System.UInt32 buf, OpenTK.Graphics.OpenGL.BlendEquationMode modeRGB, OpenTK.Graphics.OpenGL.BlendEquationMode modeAlpha)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BlendEquationSeparate(buf, modeRGB, modeAlpha);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BlendEquationSeparate(buf, modeRGB, modeAlpha);
#endif
		}
		public static void BlendFunc(OpenTK.Graphics.OpenGL.BlendingFactorSrc sfactor, OpenTK.Graphics.OpenGL.BlendingFactorDest dfactor)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BlendFunc(sfactor, dfactor);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BlendFunc(sfactor, dfactor);
#endif
		}
		public static void BlendFunc(System.Int32 buf, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend src, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend dst)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BlendFunc(buf, src, dst);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BlendFunc(buf, src, dst);
#endif
		}
		public static void BlendFunc(System.UInt32 buf, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend src, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend dst)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BlendFunc(buf, src, dst);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BlendFunc(buf, src, dst);
#endif
		}
		public static void BlendFuncSeparate(OpenTK.Graphics.OpenGL.BlendingFactorSrc sfactorRGB, OpenTK.Graphics.OpenGL.BlendingFactorDest dfactorRGB, OpenTK.Graphics.OpenGL.BlendingFactorSrc sfactorAlpha, OpenTK.Graphics.OpenGL.BlendingFactorDest dfactorAlpha)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BlendFuncSeparate(sfactorRGB, dfactorRGB, sfactorAlpha, dfactorAlpha);
#endif
		}
		public static void BlendFuncSeparate(System.Int32 buf, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend srcRGB, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend dstRGB, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend srcAlpha, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend dstAlpha)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BlendFuncSeparate(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BlendFuncSeparate(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
#endif
		}
		public static void BlendFuncSeparate(System.UInt32 buf, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend srcRGB, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend dstRGB, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend srcAlpha, OpenTK.Graphics.OpenGL.ArbDrawBuffersBlend dstAlpha)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BlendFuncSeparate(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BlendFuncSeparate(buf, srcRGB, dstRGB, srcAlpha, dstAlpha);
#endif
		}
		public static void BlitFramebuffer(System.Int32 srcX0, System.Int32 srcY0, System.Int32 srcX1, System.Int32 srcY1, System.Int32 dstX0, System.Int32 dstY0, System.Int32 dstX1, System.Int32 dstY1, OpenTK.Graphics.OpenGL.ClearBufferMask mask, OpenTK.Graphics.OpenGL.BlitFramebufferFilter filter)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BlitFramebuffer(srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);
#endif
		}
		public static void BufferData(OpenTK.Graphics.OpenGL.BufferTarget target, System.IntPtr size, System.IntPtr data, OpenTK.Graphics.OpenGL.BufferUsageHint usage)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BufferData(target, size, data, usage);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BufferData(target, size, data, usage);
#endif
		}
		public static void BufferData<T2>(OpenTK.Graphics.OpenGL.BufferTarget target, System.IntPtr size, T2[] data, OpenTK.Graphics.OpenGL.BufferUsageHint usage) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BufferData(target, size, data, usage);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BufferData(target, size, data, usage);
#endif
		}
		public static void BufferData<T2>(OpenTK.Graphics.OpenGL.BufferTarget target, System.IntPtr size, T2[,] data, OpenTK.Graphics.OpenGL.BufferUsageHint usage) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BufferData(target, size, data, usage);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BufferData(target, size, data, usage);
#endif
		}
		public static void BufferData<T2>(OpenTK.Graphics.OpenGL.BufferTarget target, System.IntPtr size, T2[, ,] data, OpenTK.Graphics.OpenGL.BufferUsageHint usage) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BufferData(target, size, data, usage);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BufferData(target, size, data, usage);
#endif
		}
		public static void BufferData<T2>(OpenTK.Graphics.OpenGL.BufferTarget target, System.IntPtr size, ref T2 data, OpenTK.Graphics.OpenGL.BufferUsageHint usage) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BufferData(target, size, ref data, usage);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BufferData(target, size, ref data, usage);
#endif
		}
		public static void BufferSubData(OpenTK.Graphics.OpenGL.BufferTarget target, System.IntPtr offset, System.IntPtr size, System.IntPtr data)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BufferSubData(target, offset, size, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BufferSubData(target, offset, size, data);
#endif
		}
		public static void BufferSubData<T3>(OpenTK.Graphics.OpenGL.BufferTarget target, System.IntPtr offset, System.IntPtr size, T3[] data) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BufferSubData(target, offset, size, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BufferSubData(target, offset, size, data);
#endif
		}
		public static void BufferSubData<T3>(OpenTK.Graphics.OpenGL.BufferTarget target, System.IntPtr offset, System.IntPtr size, T3[,] data) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BufferSubData(target, offset, size, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BufferSubData(target, offset, size, data);
#endif
		}
		public static void BufferSubData<T3>(OpenTK.Graphics.OpenGL.BufferTarget target, System.IntPtr offset, System.IntPtr size, T3[, ,] data) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BufferSubData(target, offset, size, data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BufferSubData(target, offset, size, data);
#endif
		}
		public static void BufferSubData<T3>(OpenTK.Graphics.OpenGL.BufferTarget target, System.IntPtr offset, System.IntPtr size, ref T3 data) where T3 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.BufferSubData(target, offset, size, ref data);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.BufferSubData(target, offset, size, ref data);
#endif
		}
		public static void CallList(System.Int32 list)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CallList(list);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CallList(list);
#endif
		}
		public static void CallList(System.UInt32 list)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CallList(list);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CallList(list);
#endif
		}
		public static void CallLists(System.Int32 n, OpenTK.Graphics.OpenGL.ListNameType type, System.IntPtr lists)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CallLists(n, type, lists);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CallLists(n, type, lists);
#endif
		}
		public static void CallLists<T2>(System.Int32 n, OpenTK.Graphics.OpenGL.ListNameType type, T2[] lists) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CallLists(n, type, lists);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CallLists(n, type, lists);
#endif
		}
		public static void CallLists<T2>(System.Int32 n, OpenTK.Graphics.OpenGL.ListNameType type, T2[,] lists) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CallLists(n, type, lists);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CallLists(n, type, lists);
#endif
		}
		public static void CallLists<T2>(System.Int32 n, OpenTK.Graphics.OpenGL.ListNameType type, T2[, ,] lists) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CallLists(n, type, lists);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CallLists(n, type, lists);
#endif
		}
		public static void CallLists<T2>(System.Int32 n, OpenTK.Graphics.OpenGL.ListNameType type, ref T2 lists) where T2 : struct
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.CallLists(n, type, ref lists);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.CallLists(n, type, ref lists);
#endif
		}
		public static OpenTK.Graphics.OpenGL.FramebufferErrorCode CheckFramebufferStatus(OpenTK.Graphics.OpenGL.FramebufferTarget target)
		{
#if DEBUG
			var retValOut = OpenTK.Graphics.OpenGL.GL.CheckFramebufferStatus(target);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); return retValOut;
#else
			return retValOut; OpenTK.Graphics.OpenGL.GL.CheckFramebufferStatus(target);
#endif
		}
		public static void ClampColor(OpenTK.Graphics.OpenGL.ClampColorTarget target, OpenTK.Graphics.OpenGL.ClampColorMode clamp)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ClampColor(target, clamp);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ClampColor(target, clamp);
#endif
		}
		public static void Clear(OpenTK.Graphics.OpenGL.ClearBufferMask mask)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.Clear(mask);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.Clear(mask);
#endif
		}
		public static void ClearAccum(System.Single red, System.Single green, System.Single blue, System.Single alpha)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ClearAccum(red, green, blue, alpha);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ClearAccum(red, green, blue, alpha);
#endif
		}
		public static void ClearBuffer(OpenTK.Graphics.OpenGL.ClearBuffer buffer, System.Int32 drawbuffer, System.Single depth, System.Int32 stencil)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ClearBuffer(buffer, drawbuffer, depth, stencil);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ClearBuffer(buffer, drawbuffer, depth, stencil);
#endif
		}
		public static void ClearBuffer(OpenTK.Graphics.OpenGL.ClearBuffer buffer, System.Int32 drawbuffer, System.Single[] value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ClearBuffer(buffer, drawbuffer, value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ClearBuffer(buffer, drawbuffer, value);
#endif
		}
		public static void ClearBuffer(OpenTK.Graphics.OpenGL.ClearBuffer buffer, System.Int32 drawbuffer, ref System.Single value)
		{
#if DEBUG
			OpenTK.Graphics.OpenGL.GL.ClearBuffer(buffer, drawbuffer, ref value);
			var error = OpenTK.Graphics.OpenGL.GL.GetError(); 
			if(error != OpenTK.Graphics.OpenGL.ErrorCode.NoError) throw new GLException("You have an error (" + error + ")"); 
#else
			OpenTK.Graphics.OpenGL.GL.ClearBuffer(buffer, drawbuffer, ref value);
#endif
		}
	}
	// ReSharper restore InconsistentNaming
	// ReSharper restore CSharpWarnings::CS0618
}
