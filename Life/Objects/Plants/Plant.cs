using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Cache;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    internal abstract class Plant :Object , IFood
    {
        protected int Kof = 3;
        protected int Age = 0;
        protected int Fertility = 3;
        private bool Grow;
        public bool Growed
        {
            get { return Grow; }
        }
        protected int GrowSpeed;
        protected int GrowTime;
        protected int Protected;
        public Plant(Color color,int x, int y, int growSpeed, int @protected) : base(color, x, y)
        {
            GrowSpeed = growSpeed;
            GrowTime = growSpeed;
            Protected = @protected;
        }
        public virtual void Eated()
        {
            
            if (X < WorldInfo.map.GetLength(0) && Y < WorldInfo.map.GetLength(0) && WorldInfo.plants[X, Y] != null)
            WorldInfo.plants[X, Y].Grow = false;
        }
        public void Dead()
        {           
            WorldInfo.plants[X, Y] = null;
            Grow = false;

        }
        public virtual void GrowUp()
        {
            if (WorldInfo.plants != null) {
                GrowTime -= 1;
                if (GrowTime == 0)
                {
                    if (Grow)
                    {
                        for (int i = 0; i < Form1.rnd.Next(1, Fertility); i++)
                        {
                            bool b = true;
                            bool a = false;
                            Grow = false;
                            do
                            {

                                int x = X + Form1.rnd.Next(-2, 3);
                                int y = Y + Form1.rnd.Next(-2, 3);
                                border(ref x, ref y);
                                if (WorldInfo.plants[x, y] == null)
                                {
                                    Offspring(x, y);
                                    a = false;
                                }
                                else
                                {
                                    a = true;
                                    switch (Form1.rnd.Next(0, 6))
                                    {
                                        case 0:
                                            b = false;
                                            break;
                                        case 1:
                                            b = false;
                                            break;
                                        case 2:
                                            b = false;
                                            break;
                                    }
                                }

                            } while (a & b);
                        }
                    }
                    else
                    {
                        switch (Form1.rnd.Next(0, 2))
                        {
                            case 0:
                                break;
                            case 1:
                                Grow = true;
                                break;
                        }
                    }
                    Age += 1;
                    GrowTime = GrowSpeed;
                }

                if ((Age >= GrowSpeed * Kof  + 2)|| GrowSpeed < 0)
                {
                    WorldInfo.plants[X, Y] = null;
                }
            }
        }
        protected virtual void Offspring(int x,int y) 
        {
          
        }
       
       
    }
}
