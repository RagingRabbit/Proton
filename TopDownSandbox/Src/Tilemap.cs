using System;
using Proton;

namespace TopDownSandbox
{
	public class Tilemap
	{
		Tile[,] tiles;

		Model model;

		public Tilemap()
		{
			tiles = new Tile[5, 5];
			for (int y = 0; y < 5; y++)
			{
				for (int x = 0; x < 5; x++)
				{
					tiles[x, y] = new Tile();
				}
			}

			model = new Model();
			model.data = ConstructModelData();
			model.material.texture = new Texture("../.../Res/image.png");
		}

		ModelData ConstructModelData()
		{
			ModelData data = new ModelData();

			for (int z = 0; z < tiles.GetLength(1); z++)
			{
				for (int x = 0; x < tiles.GetLength(0); x++)
				{
					Vertex v0 = new Vertex
					{
						position = new Vector3(x, 0, z),
						uv = new Vector2(0.0f, 0.0f)
					};
					Vertex v1 = new Vertex
					{
						position = new Vector3(x, 0, z + 1.0f),
						uv = new Vector2(0.0f, 1.0f)
					};
					Vertex v2 = new Vertex
					{
						position = new Vector3(x + 1.0f, 0, z + 1.0f),
						uv = new Vector2(1.0f, 1.0f)
					};
					Vertex v3 = new Vertex
					{
						position = new Vector3(x + 1.0f, 0, z),
						uv = new Vector2(1.0f, 0.0f)
					};
					Triangle t0 = new Triangle(data.vertexCount + 0, data.vertexCount + 1, data.vertexCount + 2);
					Triangle t1 = new Triangle(data.vertexCount + 2, data.vertexCount + 3, data.vertexCount + 0);

					data.PushVertex(v0);
					data.PushVertex(v1);
					data.PushVertex(v2);
					data.PushVertex(v3);

					data.PushTriangle(t0);
					data.PushTriangle(t1);
				}
			}

			return data;
		}

		public void Render()
		{
			Renderer3D.RenderModel(model);
		}
	}

	public class Tile
	{
	}
}
