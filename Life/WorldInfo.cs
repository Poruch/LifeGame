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
        public static List<Object[,]> Layers = new List<Object[,]>();
        public static IHightObject[,] hightObjects = new IHightObject[Kollvo, Kollvo];
        public static Earth[,] earth = new Earth[Kollvo, Kollvo];

        private static Object[,] layer0 = new Object[Kollvo, Kollvo];
        private static Object[,] layer1 = new Object[Kollvo, Kollvo];
        private static Object[,] layer2 = new Object[Kollvo, Kollvo];
        private static Object[,] layer3 = new Object[Kollvo, Kollvo];

        public static int[] herbivore = new int[7] { 5, 5, 5, 100, 10, 2, 100 };
        public static int[] predator = new int[7] { 3, 6, 4, 200, 40, 4, 100 };
        public static int[] omnivorous = new int[7] { 2, 4, 2, 50, 30, 5, 100 };

        public static int[] grassquality = new int[2] { 3, 2 };
        public static void Start()
        {
            Layers.Add(layer0);
            Layers.Add(layer1);
            Layers.Add(layer2);
            Layers.Add(layer3);
        }
        public static void Scale()
        {
            int Count = Form1.Kollvo;
            ScalingMassive<Object>(ref map, Count);
            ScalingMassive<Animal>(ref animals, Count);
            ScalingMassive<Plant>(ref plants, Count);
            ScalingMassive<IHightObject>(ref hightObjects, Count);
            ScalingMassive<Earth>(ref earth, Count);
            ScalingMassive<Object>(ref layer0, Count);
            ScalingMassive<Object>(ref layer1, Count);
            ScalingMassive<Object>(ref layer2, Count);
            ScalingMassive<Object>(ref layer3, Count);
            WorldInfo.Kollvo = Count;
        }
        private static void ScalingMassive<T>(ref T[,] objects, int count)
        {
            T[,] values = new T[count,count];
            int c = objects.GetLength(0);
            if (c < count)
                for (int i = 0; i < c; i++)
                {
                    for (int j = 0; j < c; j++)
                    {
                        values[i,j] = objects[i, j];
                    }
                }
            else
                for (int i = 0; i < count; i++)
                {
                    for (int j = 0; j < count; j++)
                    {
                        values[i, j] = objects[i, j];
                    }
                }
            objects = values;
        }
    }  

}
