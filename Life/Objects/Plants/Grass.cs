using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    internal sealed class Grass:Plant
    {
        public Grass(int x,int y,int growspeed, int kof,int @protected): base(Color.SeaGreen,x,y,growspeed, @protected)
        {
            if (growspeed <= 0 || Kof <= 0)
                base.Dead();
            Kof = kof;
            Fertility = 3;
            Kof = 2;
        }
        public override void GrowUp()
        {
            base.GrowUp();
        }
        protected override void Offspring(int x, int y)
        {
            base.Offspring(x, y);
            WorldInfo.plants[x, y] = new Grass(x, y, GrowSpeed + Form1.rnd.Next(-2, 2),Kof + Form1.rnd.Next(-1,2) ,Protected);
        }
        public override void Paint(Graphics graphics)
        {
            base.Paint(graphics);
            if (Growed && L > 2)
                graphics.FillEllipse(Brushes.Green, base.X * L, base.Y * L, L-2, L-2);

        }
    }
}
