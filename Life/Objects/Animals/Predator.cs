using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    internal class Predator :Animal
    {
        
        protected bool Agressive = false;
        public Predator(int x, int y, bool famel, int speed, int Hangrytime, int pregnancy, int hp, int dmg, int vision,int deadAge) : base(Color.Red, x, y, speed, famel, hp,deadAge)
        {
            if (dmg <=0 || Hangrytime <=0 || speed <0 || vision < 0 || pregnancy <= 0) { base.Dead(); }
            DMG = dmg;
            HangryTime = Hangrytime;
            SpeedTime = speed;
            Vision = vision;
            PregnancyTime = pregnancy;
        }
        public override void Movi()
        {
           
            if (pregnancytime == PregnancyTime && Pregnancy)
            {
                pregnancytime = 0;
                Birth();
                Pair = null;
            }         
            if (Eat != null)
            {
                if (Eat.X < WorldInfo.map.GetLength(0) && Eat.Y < WorldInfo.map.GetLength(0) &&  Eat.GetType() == typeof(Animal) && WorldInfo.animals[Eat.X, Eat.Y] != null)
                    Eat = WorldInfo.animals[Eat.X, Eat.Y];
            }
            if (Eat == null )
                EatLocation<Predator>(WorldInfo.animals);
            if (Pair == null && !Hangry)
                PairLocation<Predator>(WorldInfo.animals);
            if (hangrtime > HangryTime * 10)
            {
                base.Dead();
            }
            if (!Hangry && hangrtime > HangryTime)
            {
                Hangry = true;
                Agressive = false;
            }
            SpeedTime -= 1;
            if (Eat == null || !Hangry)
            {
                if (SpeedTime == 0 && !Hangry && Pair != null && !Pregnancy)
                {
                    if (Pregnancy)
                        pregnancytime += 1;
                    if (!pair)
                        pair = Follow(Pair);
                    else
                    {
                        Sex(Pair);
                        Hangry = true;
                        pair = false;
                        hangrtime = 0;
                    }
                    SpeedTime = base.Speed;
                    Age += 1;
                    
                    hangrtime += 1;
                    if (Age > Heals * Math.Sin(Math.PI * Age / DeadAge) + 20)
                    {
                        base.Dead();
                    }
                }
                else if (SpeedTime == 0)
                {
                    base.Movi();
                    SpeedTime = base.Speed;
                    Age += 1;
                    if (Pregnancy)
                        pregnancytime += 1;
                    hangrtime += 1;
                    if (Age > Heals * Math.Sin(Math.PI * Age / DeadAge) + 20)
                    {
                        base.Dead();
                    }
                }
            }
            else
            {
                if (SpeedTime == 0)
                {
                    if (!food)
                        food = Follow(Eat);
                    else
                    {
                        Eating((IFood)Eat);
                        Hangry = false;
                        food = false;
                        hangrtime = 0;
                    }
                    SpeedTime = base.Speed;
                    Age += 1;
                    if (Pregnancy)
                        pregnancytime += 1;
                    hangrtime += 1;
                    if (Age > Heals * Math.Sin(Math.PI * Age / DeadAge) + 20)
                    {
                        base.Dead();
                    }
                }
            }
        }
        protected override void Offspring(int x, int y)
        {
            base.Offspring(x, y);
            bool famel;
            if (Form1.rnd.Next(2) == 1) famel = true;
            else famel = false;
            WorldInfo.animals[x, y] = new Predator(x, y, famel,  Form1.rnd.Next(2, 8), HangryTime + Form1.rnd.Next(-1, 2), PregnancyTime + Form1.rnd.Next(-2, 3), Heals + Form1.rnd.Next(-20, 20), DMG + Form1.rnd.Next(-2, 3), Vision , DeadAge + Form1.rnd.Next(-5,5));
        }
        protected override void Eating(IFood food)
        {
            base.Eating(food);
        }
    }

}
