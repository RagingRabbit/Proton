﻿using System;

namespace Proton
{
    public struct Vector3i
    {
        public int x, y, z;

        public Vector3i(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return x + " , " + y + " , " + z;
        }
    }
}
