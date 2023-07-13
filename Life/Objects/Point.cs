using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    internal abstract class Point : IPoint
    {
        private int x;
        private int y;
        public int X
        {
            get => x;
            set => x = value;
        }
        public int Y
        {
            get => y;
            set => y = value;
        }

        public static void border(ref int X,ref int Y)
        {
            if (X > WorldInfo.map.GetLength(0) - 1) X = WorldInfo.map.GetLength(0) - 1;
            if (X < 0) X = 0;
            if (Y > WorldInfo.map.GetLength(0) - 1) Y = WorldInfo.map.GetLength(0) - 1;
            if (Y < 0) Y = 0;
        }
        
    }
}
