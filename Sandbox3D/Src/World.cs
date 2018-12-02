using Proton;
using System;
using System.Collections.Generic;

public class World
{
    List<Chunk> chunks;
    WorldGenerator gen;
    Player player;

    public World()
    {
        chunks = new List<Chunk>();
        gen = new WorldGenerator();
        player = new Player(this);
        player.transform.position = new Vector3(100, 20, 100);

        for (int z = -4; z < 10; z++)
        {
            for (int x = -4; x < 10; x++)
            {
                Chunk chunk = new Chunk(x, 0, z);
                chunk.Generate(gen);
                chunks.Add(chunk);
            }
        }

        Camera.mainCamera.transform.position.x = 2.5f;
        Camera.mainCamera.transform.position.y = 0.5f;
        Camera.mainCamera.transform.position.z = 2.5f;
        Camera.mainCamera.transform.rotation.eulerAngles = new Vector3(30.0f, 0.0f, 0.0f);
    }

    public void Update()
    {
        player.Update();
    }

    public void Render()
    {
        for (int i = 0; i < chunks.Count; i++)
        {
            chunks[i].Render();
        }
    }

    public BlockData GetBlockAtWorldPos(int x, int y, int z)
    {
        Chunk chunk = GetChunkAtWorldPos(x, y, z);
        if (chunk != null)
        {
            x -= chunk.pos.x;
            y -= chunk.pos.y;
            z -= chunk.pos.z;
            return chunk.blocks[x, y, z];
        }
        return BlockData.EMPTY;
    }

    private Chunk GetChunkAtWorldPos(int x, int y, int z)
    {
        for (int i = 0; i < chunks.Count; i++)
        {
            if (x >= chunks[i].pos.x && x < chunks[i].pos.x + Chunk.SIZE
                && y >= chunks[i].pos.y && y < chunks[i].pos.y + Chunk.SIZE
                && z >= chunks[i].pos.z && z < chunks[i].pos.z + Chunk.SIZE)
            {
                return chunks[i];
            }
        }
        return null;
    }
}
