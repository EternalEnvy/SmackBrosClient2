using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Assimp;
using NeptuneRenderEngine.Engine.Interface.Data;

namespace NeptuneRenderEngine.Engine.Utilities
{
    public class MeshLoader
    {
		public static Mesh LoadMesh(string path)
		{
			if( Platform.RunningPlatform() == Platform.PlatformEnum.Windows )
				return LoadMeshWithAssimp(path);
			else
				return LoadMeshUnix(path);
		}

		public static Mesh LoadMeshUnix(string path)
		{
			return new Mesh();
		}

		public static Mesh LoadMeshWithAssimp(string path)
        {
            var execAssembly = Assembly.GetExecutingAssembly();
            if (execAssembly == null) throw new NullReferenceException("THE ASSEMBLY YOU ARE CALLING FROM IS NULL. ITS THE END OF THE WORLD. SEEK SHELTER IMMEDIATELY.");
            if (execAssembly.Location == null) throw new NullReferenceException("No assembly location.");
            Assimp.Unmanaged.AssimpLibrary.Instance.LoadLibrary(Path.Combine(Path.GetDirectoryName(execAssembly.Location)??"/", Environment.Is64BitProcess ? "Assimp64.dll" : "Assimp32.dll"));
            
			var fileName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), path);
            var importer = new AssimpContext();
            var model = importer.ImportFile(fileName, PostProcessSteps.Triangulate | PostProcessSteps.GenerateNormals);
            importer.Dispose();

            var mesh = new Mesh();

            var vertices = new List<Vertex3f3f2f>();
            var meshData = new List<MeshSubData>();

            int start = 0;
            foreach (var m in model.Meshes)
            {
                if (!m.HasVertices) continue;
                if (!m.HasNormals) throw new Exception("Mesh does not have normals!");
                if (!m.HasFaces) throw new Exception("Mesh does not have faces!");
                
                for (int i = 0; i < m.FaceCount; i++)
                {
                    var face = m.Faces[i];
                    for (int j = 0; j < face.IndexCount; j++)
                    {
                        vertices.Add(ParseVertex(m, face.Indices[j]));
                    }
                }
                meshData.Add(new MeshSubData(){Start = start, End = vertices.Count});
                start = vertices.Count;
            }
            mesh.SetData(vertices.ToArray(), meshData.ToArray());

            return mesh;
        }

        public static Vertex3f3f2f ParseVertex(Assimp.Mesh mesh, int index)
        {
            var position = mesh.Vertices[index];
            var normal = mesh.Normals[index];

            var coord = mesh.HasTextureCoords(0) ? mesh.TextureCoordinateChannels[0][index] : new Vector3D(0f, 0f, 0f);

            return new Vertex3f3f2f()
            {
                x0 = position.X,
                y0 = position.Y,
                z0 = position.Z,
                x1 = normal.X,
                y1 = normal.Y,
                z1 = normal.Z,
                u0 = coord.X,
                v0 = coord.Y
            };
        }
    }
}
