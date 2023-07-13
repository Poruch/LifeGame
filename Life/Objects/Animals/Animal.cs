using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Life
{
    internal abstract class Animal :Object, IFood
    {
        protected int Vision = 2;
        
        protected bool Grow = true;
        public bool Growed
        {
            get => Grow;
        }
        public void Eated()
        {
            Heals -= DMG;
            Heat();
        }
        protected int DeadAge = 100;
        protected int HangryTime = 3;
        protected int hangrtime = 0;
        protected bool Hangry = true;
        protected bool food = false;
        protected int DMG = 30;
        protected int SpeedTime;
        protected readonly int Speed;

        protected Animal Pair;
        protected bool pair = false;

        protected int PregnancyTime = 9;
        protected int pregnancytime = 0;
        protected bool Gender;
        protected bool Pregnancy = false;

        protected Object Eat;
        
        protected int Age = 0;
        
        protected int Heals;
        protected Animal(Color color, int x, int y, int speed, bool famel, int heals, int deadAge) : base(color, x, y)
        {
            Speed = speed;
            Gender = famel;
            Heals = heals;
            DeadAge = deadAge;
        }
        public virtual void Dead()
        {
            WorldInfo.animals[X, Y] = null;
            Eat = null;
            SpeedTime = -100;
        }
        protected virtual void Offspring(int x, int y)
        {

        }
        public void Sex(Animal pair)
        {
            if (!pair.Gender)
            {
                pair.Pregnancy = true;
            }
            else Pregnancy = true;
        }
        protected void Birth()
        {
            Pregnancy = false;
            Hangry = true;
            for (int i = 0; i < Form1.rnd.Next(1, 3); i++)
            {
                bool b = true;
                bool a = false;                
                do
                {
                    int x = X + Form1.rnd.Next(-2, 3);
                    int y = Y + Form1.rnd.Next(-2, 3);
                    border(ref x, ref y);
                    if (WorldInfo.animals[x, y] == null)
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
        
        void MoviUp()
        {
            if (base.Y < WorldInfo.map.GetLength(0) -1 && WorldInfo.animals[base.X, base.Y + 1] == null)
            {
                (WorldInfo.animals[base.X, base.Y + 1], WorldInfo.animals[base.X, base.Y]) = (WorldInfo.animals[base.X, base.Y], WorldInfo.animals[base.X, base.Y + 1]);
                base.Y += 1;
            }
        }
        void MoviDown()
        {
            if (base.Y > 0 && WorldInfo.animals[base.X, base.Y - 1] == null)
            {
                (WorldInfo.animals[base.X, base.Y - 1], WorldInfo.animals[base.X, base.Y]) = (WorldInfo.animals[base.X, base.Y], WorldInfo.animals[base.X, base.Y - 1]);
                base.Y -= 1;
            }
        }
        void MoviLeft()
        {
            if (base.X > 0 && WorldInfo.animals[base.X - 1, base.Y] == null)
            {
                (WorldInfo.animals[base.X - 1, base.Y], WorldInfo.animals[base.X, base.Y]) = (WorldInfo.animals[base.X, base.Y], WorldInfo.animals[base.X - 1, base.Y]);
                base.X -= 1;
            }
        }
        void MoviRight()
        {
            if (base.X < WorldInfo.map.GetLength(0) - 1 && WorldInfo.animals[base.X + 1, base.Y] == null)
            {
                (WorldInfo.animals[base.X + 1, base.Y], WorldInfo.animals[base.X, base.Y]) = (WorldInfo.animals[base.X, base.Y], WorldInfo.animals[base.X + 1, base.Y]);
                base.X += 1;
            }
        }

        public virtual void  Movi ()
        {
            
            switch (Form1.rnd.Next(0, 4))
            {
                case 0:
                    MoviDown();
                    break;
                case 1:
                    MoviLeft();
                    break;
                case 2:
                    MoviRight();
                    break;
                case 3:
                    MoviUp();
                    break;
            }            
        }
        public virtual void Heat()
        {

        }
        protected virtual void Eating( IFood Eats)
        {
            Eats.Eated();
            Eat = null;
        }
        protected bool Follow(Object Who)
        {
            if (X - Who.X > 1)
            {
                MoviLeft();
                return false;
            }
            else if(X - Who.X < -1)
            {
                MoviRight();
                return false;
            }
            else if (Y - Who.Y > 1)
            {
                MoviDown();
                return false;
            }
            else if (Y - Who.Y < -1)
            {
                MoviUp();
                return false;
            }
            else if((X - Who.X == 1 || X - Who.X == -1 || X - Who.X == 0) &&(Y - Who.Y == 1 || Y - Who.Y == -1 || Y - Who.Y == 0))
            {
                return true;
            }
            else
            return false;
        }

        public override void Paint(Graphics graphics)
        {
            base.Paint(graphics);
            if (Pregnancy && L > 2)
            {
                graphics.FillEllipse(Brushes.Beige, base.X * L, base.Y * L, L-2, L-2);
            }
        }
        protected void EatLocation<T>(IFood[,] Eats)
        {
            int row_limit = Eats.GetLength(0);
            if (row_limit > 0)
            {
                int column_limit = Eats.GetLength(1);
                for (int i = 1; i <= Vision; i++)
                {
                    for (int x = Math.Max(0, X - i); x <= Math.Min(X + i, row_limit); x++)
                    {
                        for (int y = Math.Max(0, Y - i); y <= Math.Min(Y + i, column_limit); y++)
                        {                            
                            if (((x <= WorldInfo.map.GetLength(0) - 1) && (x >= 0)) && ((y <= WorldInfo.map.GetLength(0) - 1) && (y >= 0)))
                            {
                                if (Eats[x, y] != null && Eat != null )
                                {
                                    if (Math.Abs(Eat.X - X + Eat.Y - Y) > Math.Abs(x - X + x - Y))
                                    {
                                        if (Eats[x, y].GetType() == typeof(T))
                                            Eat = (Object)Eats[x, y];
                                    }
                                }
                                else if (Eats[x, y] != null && Eat == null && Eats[x, y].Growed && Eats[x, y].GetType() != typeof(T))
                                {
                                    Eat = (Object)Eats[x, y];
                                }
                            }                            
                        }
                    }
                }
            }               
        }

        protected void PairLocation<T>(Animal[,] animal)
        {
            int row_limit = animal.GetLength(0);
            if (row_limit > 0)
            {
                int column_limit = animal.GetLength(1);
                for (int i = 1; i <= Vision; i++)
                {
                    for (int x = Math.Max(0, X - i); x <= Math.Min(X + i, row_limit); x++)
                    {
                        for (int y = Math.Max(0, Y - i); y <= Math.Min(Y + i, column_limit); y++)
                        {
                            if (x != X || y != Y)
                            {
                                if (((x <=  WorldInfo.map.GetLength(0) - 1) && (x >= 0)) && ((y <= WorldInfo.map.GetLength(0) - 1) && (y >= 0)))
                                {
                                    if (animal[x, y] != null && Pair != null && (animal[x, y].Gender != Gender))
                                    {
                                        if (Math.Abs(Pair.X - X + Pair.Y - Y) > Math.Abs(animal[x, y].X - X + animal[x, y].Y - Y))
                                        {
                                            if (animal[x, y].GetType() == typeof(T))
                                                Pair = animal[x, y];
                                        }
                                    }
                                    else if (animal[x, y] != null && Pair == null && (animal[x, y].Gender != Gender))
                                    {
                                        if (animal[x, y].GetType() == typeof(T))
                                            Pair = animal[x, y];
                                    }
                                }
                            }
                        }
                    }
                }
            }           
                
        }
    }
}
