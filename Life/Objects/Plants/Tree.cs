using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    internal class Tree :Plant , IHightObject
    {
        public Tree(int x, int y, int growspeed, int @protected) : base(Color.DarkGreen, x, y, growspeed, @protected)
        {
            Fertility = 2;
            Kof = 1;
        }
        public override void GrowUp()
        {
            base.GrowUp();
        }
        protected override void Offspring(int x, int y)
        {
            base.Offspring(x, y);
            WorldInfo.plants[x, y] = new Tree(x, y, GrowSpeed, Protected);
        }
    }
}
