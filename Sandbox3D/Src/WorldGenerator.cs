using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WorldGenerator
{
    Simplex simplex;

    public WorldGenerator()
    {
        simplex = new Simplex();
    }

    public int GetHeight(int x, int z)
    {
        return (int)(8.0 + simplex.Noise2D(x / 50.0, z / 50.0) * 4.0);
    }
}
