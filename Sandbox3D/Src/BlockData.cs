using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct BlockData
{
    public static readonly BlockData AIR = new BlockData { id = 0, transparent = false, solid = false };
    public static readonly BlockData GRASS = new BlockData { id = 1, transparent = false, solid = true };

    public int id;
    public bool transparent;
    public bool solid;

    public static bool operator ==(BlockData left, BlockData right)
    {
        return left.id == right.id;
    }

    public static bool operator !=(BlockData left, BlockData right)
    {
        return !(left.id == right.id);
    }
}