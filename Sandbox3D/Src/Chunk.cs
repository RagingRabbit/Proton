using Proton;
using System;

public class Chunk
{
    public const int SIZE = 16;

    public Vector3i pos;
    public BlockData[,,] blocks;

    Random random;
    Model model;

    public Chunk(int x, int y, int z)
    {
        pos = new Vector3i(x * SIZE, y * SIZE, z * SIZE);
        blocks = new BlockData[SIZE, SIZE, SIZE];
        random = new Random();
        model = new Model();
        model.material.shader = ShaderRepo.BLOCK_SHADER;
    }

    public void Generate(WorldGenerator gen)
    {
        for (int z = 0; z < blocks.GetLength(2); z++)
        {
            for (int x = 0; x < blocks.GetLength(0); x++)
            {
                int height = gen.GetHeight(pos.x + x, pos.z + z);
                for (int y = 0; y < blocks.GetLength(1); y++)
                {
                    if (y < height)
                    {
                        blocks[x, y, z] = new BlockData { id = 1, transparent = false, solid = true };
                    }
                    else
                    {
                        blocks[x, y, z] = new BlockData { id = 0, transparent = false, solid = false };
                    }
                }
            }
        }
        model.data = ConstructModelData();
        model.material.texture = new Texture("../.../Res/image.png");
    }

    ModelData ConstructModelData()
    {
        ModelData data = new ModelData();

        for (int z = 0; z < blocks.GetLength(2); z++)
        {
            for (int y = 0; y < blocks.GetLength(1); y++)
            {
                for (int x = 0; x < blocks.GetLength(0); x++)
                {
                    if (blocks[x, y, z].id != 0)
                    {
                        if (y == blocks.GetLength(1) - 1 || blocks[x, y + 1, z].id == 0 || blocks[x, y + 1, z].transparent) AddTopFace(pos.x + x, pos.y + y, pos.z + z, data);
                        if (y == 0 || blocks[x, y - 1, z].id == 0 || blocks[x, y - 1, z].transparent) AddBottomFace(pos.x + x, pos.y + y, pos.z + z, data);
                        if (x == 0 || blocks[x - 1, y, z].id == 0 || blocks[x - 1, y, z].transparent) AddLeftFace(pos.x + x, pos.y + y, pos.z + z, data);
                        if (x == blocks.GetLength(0) - 1 || blocks[x + 1, y, z].id == 0 || blocks[x + 1, y, z].transparent) AddRightFace(pos.x + x, pos.y + y, pos.z + z, data);
                        if (z == 0 || blocks[x, y, z - 1].id == 0 || blocks[x, y, z - 1].transparent) AddFrontFace(pos.x + x, pos.y + y, pos.z + z, data);
                        if (z == blocks.GetLength(2) - 1 || blocks[x, y, z + 1].id == 0 || blocks[x, y, z + 1].transparent) AddBackFace(pos.x + x, pos.y + y, pos.z + z, data);
                    }
                }
            }
        }

        return data;
    }

    private void AddTopFace(int x, int y, int z, ModelData blocks)
    {
        Triangle t0 = new Triangle(blocks.vertexCount + 0, blocks.vertexCount + 1, blocks.vertexCount + 2);
        Triangle t1 = new Triangle(blocks.vertexCount + 2, blocks.vertexCount + 3, blocks.vertexCount + 0);

        blocks.PushVertex(new Vertex { position = new Vector3(x, y + 1.0f, z), uv = new Vector2(0.0f, 0.0f) });
        blocks.PushVertex(new Vertex { position = new Vector3(x, y + 1.0f, z + 1.0f), uv = new Vector2(0.0f, 1.0f) });
        blocks.PushVertex(new Vertex { position = new Vector3(x + 1.0f, y + 1.0f, z + 1.0f), uv = new Vector2(1.0f, 1.0f) });
        blocks.PushVertex(new Vertex { position = new Vector3(x + 1.0f, y + 1.0f, z), uv = new Vector2(1.0f, 0.0f) });

        blocks.PushTriangle(t0);
        blocks.PushTriangle(t1);
    }

    private void AddBottomFace(int x, int y, int z, ModelData blocks)
    {
        Triangle t0 = new Triangle(blocks.vertexCount + 0, blocks.vertexCount + 1, blocks.vertexCount + 2);
        Triangle t1 = new Triangle(blocks.vertexCount + 2, blocks.vertexCount + 3, blocks.vertexCount + 0);

        blocks.PushVertex(new Vertex { position = new Vector3(x, y, z), uv = new Vector2(0.0f, 0.0f) });
        blocks.PushVertex(new Vertex { position = new Vector3(x + 1.0f, y, z), uv = new Vector2(0.0f, 1.0f) });
        blocks.PushVertex(new Vertex { position = new Vector3(x + 1.0f, y, z + 1.0f), uv = new Vector2(1.0f, 1.0f) });
        blocks.PushVertex(new Vertex { position = new Vector3(x, y, z + 1.0f), uv = new Vector2(1.0f, 0.0f) });

        blocks.PushTriangle(t0);
        blocks.PushTriangle(t1);
    }

    private void AddLeftFace(int x, int y, int z, ModelData blocks)
    {
        Triangle t0 = new Triangle(blocks.vertexCount + 0, blocks.vertexCount + 1, blocks.vertexCount + 2);
        Triangle t1 = new Triangle(blocks.vertexCount + 2, blocks.vertexCount + 3, blocks.vertexCount + 0);

        blocks.PushVertex(new Vertex { position = new Vector3(x, y, z), uv = new Vector2(0.0f, 0.0f) });
        blocks.PushVertex(new Vertex { position = new Vector3(x, y, z + 1.0f), uv = new Vector2(0.0f, 1.0f) });
        blocks.PushVertex(new Vertex { position = new Vector3(x, y + 1.0f, z + 1.0f), uv = new Vector2(1.0f, 1.0f) });
        blocks.PushVertex(new Vertex { position = new Vector3(x, y + 1.0f, z), uv = new Vector2(1.0f, 0.0f) });

        blocks.PushTriangle(t0);
        blocks.PushTriangle(t1);
    }

    private void AddRightFace(int x, int y, int z, ModelData blocks)
    {
        Triangle t0 = new Triangle(blocks.vertexCount + 0, blocks.vertexCount + 1, blocks.vertexCount + 2);
        Triangle t1 = new Triangle(blocks.vertexCount + 2, blocks.vertexCount + 3, blocks.vertexCount + 0);

        blocks.PushVertex(new Vertex { position = new Vector3(x + 1.0f, y, z), uv = new Vector2(0.0f, 0.0f) });
        blocks.PushVertex(new Vertex { position = new Vector3(x + 1.0f, y + 1.0f, z), uv = new Vector2(0.0f, 1.0f) });
        blocks.PushVertex(new Vertex { position = new Vector3(x + 1.0f, y + 1.0f, z + 1.0f), uv = new Vector2(1.0f, 1.0f) });
        blocks.PushVertex(new Vertex { position = new Vector3(x + 1.0f, y, z + 1.0f), uv = new Vector2(1.0f, 0.0f) });

        blocks.PushTriangle(t0);
        blocks.PushTriangle(t1);
    }

    private void AddBackFace(int x, int y, int z, ModelData blocks)
    {
        Triangle t0 = new Triangle(blocks.vertexCount + 0, blocks.vertexCount + 1, blocks.vertexCount + 2);
        Triangle t1 = new Triangle(blocks.vertexCount + 2, blocks.vertexCount + 3, blocks.vertexCount + 0);

        blocks.PushVertex(new Vertex { position = new Vector3(x, y, z + 1.0f), uv = new Vector2(0.0f, 0.0f) });
        blocks.PushVertex(new Vertex { position = new Vector3(x + 1.0f, y, z + 1.0f), uv = new Vector2(0.0f, 1.0f) });
        blocks.PushVertex(new Vertex { position = new Vector3(x + 1.0f, y + 1.0f, z + 1.0f), uv = new Vector2(1.0f, 1.0f) });
        blocks.PushVertex(new Vertex { position = new Vector3(x, y + 1.0f, z + 1.0f), uv = new Vector2(1.0f, 0.0f) });

        blocks.PushTriangle(t0);
        blocks.PushTriangle(t1);
    }

    private void AddFrontFace(int x, int y, int z, ModelData blocks)
    {
        Triangle t0 = new Triangle(blocks.vertexCount + 0, blocks.vertexCount + 1, blocks.vertexCount + 2);
        Triangle t1 = new Triangle(blocks.vertexCount + 2, blocks.vertexCount + 3, blocks.vertexCount + 0);

        blocks.PushVertex(new Vertex { position = new Vector3(x, y, z), uv = new Vector2(0.0f, 0.0f) });
        blocks.PushVertex(new Vertex { position = new Vector3(x, y + 1.0f, z), uv = new Vector2(0.0f, 1.0f) });
        blocks.PushVertex(new Vertex { position = new Vector3(x + 1.0f, y + 1.0f, z), uv = new Vector2(1.0f, 1.0f) });
        blocks.PushVertex(new Vertex { position = new Vector3(x + 1.0f, y, z), uv = new Vector2(1.0f, 0.0f) });

        blocks.PushTriangle(t0);
        blocks.PushTriangle(t1);
    }

    public void Render()
    {
        Renderer3D.RenderModel(model);
    }
}
