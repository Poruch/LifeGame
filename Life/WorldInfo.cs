using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Life
{
    internal static class WorldInfo
    {
        public static int Kollvo = Form1.Kollvo;
        public static Object[,] map = new Object[Kollvo, Kollvo];
        public static Animal[,] animals = new Animal[Kollvo, Kollvo];
        public static Plant[,] plants = new Plant[Kollvo, Kollvo];
        public static IHightObject[,] hightObjects = new IHightObject[Kollvo, Kollvo];
        public static Earth[,] earths = new Earth[Kollvo, Kollvo];

        public static int[] herbivore = new int[7] { 5, 5, 5, 100, 10, 2, 100 };
        public static int[] predator = new int[7] { 3, 6, 4, 200, 40, 4, 100 };
        public static int[] omnivorous = new int[7] { 2, 4, 2, 50, 30, 5, 100 };

        public static int[] grassquality = new int[2] { 3, 2 };

        public static void Scale()
        {
         int Kollvo = Form1.Kollvo;
         Object[,] map1 = new Object[Kollvo, Kollvo];
         Animal[,] animals1 = new Animal[Kollvo, Kollvo];
         Plant[,] plants1 = new Plant[Kollvo, Kollvo];
         IHightObject[,] hightObjects1 = new IHightObject[Kollvo, Kollvo];
         Earth[,] earths1 = new Earth[Kollvo, Kollvo];
            if (WorldInfo.Kollvo < Kollvo )
            for (int i = 0; i < WorldInfo.Kollvo; i++)
            {
                for (int j = 0; j < WorldInfo.Kollvo; j++)
                {
                    map1[i, j] = map[i, j];
                    animals1[i, j] = animals[i,j];
                    plants1[i, j] = plants[i,j];
                    hightObjects1[i, j] = hightObjects[i, j];
                    earths1[i, j] = earths[i,j] ?? new Earth(i,j);                    
                }
            }
            else
                for (int i = 0; i < Kollvo; i++)
                {
                    for (int j = 0; j < Kollvo; j++)
                    {
                        map1[i, j] = map[i, j];
                        animals1[i, j] = animals[i, j];
                        plants1[i, j] = plants[i, j];
                        hightObjects1[i, j] = hightObjects[i, j];
                        earths1[i, j] = earths[i, j] ?? new Earth(i, j);
                    }
                }
            map = map1;
            animals = animals1;
            plants = plants1;
            hightObjects = hightObjects1;
            earths = earths1;
            WorldInfo.Kollvo = Kollvo;
        }    
    }  

}
