using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Life
{
    internal sealed class Generator
    {
        private static Random rnd = new Random();
        static List<Object[,]> maps = new List<Object[,]>();
        private static int koll = 0;
        public static void Start()
        {
            for (int i = 0; i < WorldInfo.map.GetLength(0); i++)
            {
                for (int j = 0; j < WorldInfo.map.GetLength(1); j++)
                {
                    WorldInfo.earths[i, j] = new Earth(i, j);
                    switch (rnd.Next(0, 2))
                    {
                        case 0:
                            WorldInfo.plants[i, j] = new Grass(i, j, WorldInfo.grassquality[0], WorldInfo.grassquality[1], 1);
                            break;
                        case 1: break;
                    }

                }
            }
        }
        public static void Paint(Graphics graphics, int scale) {
            if (koll > 1)
            {
                for (int i = 0; i < maps[1].GetLength(0); i++)
                {
                    for (int j = 0; j < maps[1].GetLength(1); j++)
                    {
                        if (maps[1][i, j] != null)
                            maps[1][i, j].Paint(graphics);
                    }
                }
                for (int i = 0; i < maps[1].GetLength(0) + 1; i++)
                {
                    graphics.DrawLine(Pens.Black, i * scale - 1, 0, i * scale - 1, 550);
                }
                for (int i = 0; i < maps[1].GetLength(0); i++)
                {
                    graphics.DrawLine(Pens.Black, 0, i * scale - 1, 550, i * scale - 1);
                }
                for (int i = 0; i < maps.Count - 1; i++)
                    maps[i] = maps[i + 1];
                koll--;
            }
        }
        private static void GenerateMap()
        {
            
            for (int i = 0; i < WorldInfo.map.GetLength(0); i++)
            {
                for (int j = 0; j < WorldInfo.map.GetLength(1); j++)
                {
                    WorldInfo.map[i, j] = (Object)WorldInfo.plants[i, j] ?? (Object)WorldInfo.earths[i, j];
                    WorldInfo.map[i, j] = WorldInfo.animals[i, j] ?? WorldInfo.map[i, j];
                    if (WorldInfo.plants[i, j] != null)
                        if (WorldInfo.plants[i, j].GetType() == typeof(Tree))
                        {
                            WorldInfo.map[i, j] = (Object)WorldInfo.plants[i, j];
                        }
                }
            }            
            maps.Add(WorldInfo.map);
        }
        public static void WorldTick()
        {
            if (koll < maps.Count)
            {
                for (int j = 0; j < WorldInfo.map.GetLength(0); j++)
                    for (int i = 0; i < WorldInfo.map.GetLength(1); i++)
                    {
                        if (WorldInfo.plants[j, i] != null)
                            WorldInfo.plants[j, i].GrowUp();
                        if (WorldInfo.animals[j, i] != null)
                            WorldInfo.animals[j, i].Movi();
                    }
                GenerateMap();
                maps.Add(WorldInfo.map);
                koll++;
            }
        }
    }
}
