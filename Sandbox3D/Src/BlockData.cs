using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct BlockData
{
    public static readonly BlockData EMPTY = new BlockData();

    public int id;
    public bool transparent;
    public bool solid;
}