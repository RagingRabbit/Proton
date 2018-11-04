using System;
using System.Collections.Generic;

namespace Proton
{
	public class Model
	{
		internal VertexArray vao;

		public Model()
		{
			vao = new VertexArray();
		}

		public ModelData data
		{
			set
			{
				float[] positions = new float[value.vertices.Count * 3];
				float[] normals = new float[value.vertices.Count * 3];
				float[] uvs = new float[value.vertices.Count * 2];
				int[] indices = new int[value.triangles.Count * 3];

				for (int i = 0; i < value.vertices.Count; i++)
				{
					positions[i * 3 + 0] = value.vertices[i].position.x;
					positions[i * 3 + 1] = value.vertices[i].position.y;
					positions[i * 3 + 2] = value.vertices[i].position.z;

					normals[i * 3 + 0] = value.vertices[i].normal.x;
					normals[i * 3 + 1] = value.vertices[i].normal.y;
					normals[i * 3 + 2] = value.vertices[i].normal.z;

					uvs[i * 2 + 0] = value.vertices[i].uv.x;
					uvs[i * 2 + 1] = value.vertices[i].uv.y;
				}

				for (int i = 0; i < value.triangles.Count; i++)
				{
					indices[i * 3 + 0] = value.triangles[i].vertex0;
					indices[i * 3 + 1] = value.triangles[i].vertex1;
					indices[i * 3 + 2] = value.triangles[i].vertex2;
				}

				vao.Bind();
				vao.AddBuffer(0, 3, positions, BufferUsage.StaticDraw);
				vao.AddBuffer(1, 3, normals, BufferUsage.StaticDraw);
				vao.AddBuffer(2, 2, uvs, BufferUsage.StaticDraw);
				vao.AddElementBuffer(indices, BufferUsage.StaticDraw);
				vao.Unbind();
			}
		}
	}

	public class ModelData
	{
		internal List<Vertex> vertices;
		internal List<Triangle> triangles;

		public ModelData()
		{
			vertices = new List<Vertex>();
			triangles = new List<Triangle>();
		}
	}

	public struct Vertex
	{
		public Vector3 position;
		public Vector3 normal;
		public Vector2 uv;
	}

	public struct Triangle
	{
		public int vertex0;
		public int vertex1;
		public int vertex2;

		public Triangle(int vertex0, int vertex1, int vertex2)
		{
			this.vertex0 = vertex0;
			this.vertex1 = vertex1;
			this.vertex2 = vertex2;
		}
	}
}
