using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    
    public partial class Form1 : Form
    {
        public static int scale = 10;
        public static int Kollvo = (int)(550 / scale);
        Graphics graphics;
        public static Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
           
            
            Painter.Enabled = true;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            for (int i = 0; i < WorldInfo.map.GetLength(0); i++)
            {
                for (int j = 0; j < WorldInfo.map.GetLength(1); j++)
                {
                    WorldInfo.earths[i, j] = new Earth(i, j);
                    switch (rnd.Next(0,2))
                    {
                        case 0:
                            WorldInfo.plants[i, j] = new Grass(i, j, WorldInfo.grassquality[0], WorldInfo.grassquality[1], 1);                            
                            break;
                        case 1: break;
                    }
                             
                }
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void Spawner1_Click(object sender, EventArgs e)
        {
            Painter.Enabled = true;

            int a = 1;
            if (int.TryParse(Count1.Text, out a))
                for (int count = 1; count <= a; count++)
                {
                    
                    int x = rnd.Next(0, Kollvo);
                    int y = rnd.Next(0, Kollvo);
                    bool famel;
                    if (rnd.Next(2) == 1) famel = true;
                    else famel = false;
                    if (WorldInfo.animals[x, y] == null)
                    {
                        WorldInfo.animals[x, y] = new Herbivore(x, y, famel, WorldInfo.herbivore[0], WorldInfo.herbivore[1], WorldInfo.herbivore[2], WorldInfo.herbivore[3], WorldInfo.herbivore[4], WorldInfo.herbivore[5], WorldInfo.herbivore[6]);
                    }
                }
        }

        private void Generation_Tick(object sender, EventArgs e)
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            for (int i = 0; i < WorldInfo.map.GetLength(0); i++)
            {
                for (int j = 0; j < WorldInfo.map.GetLength(1); j++)
                {
                    WorldInfo.map[i, j] = (Object)WorldInfo.plants[i, j] ?? (Object)WorldInfo.earths[i, j];
                    WorldInfo.map[i, j] = WorldInfo.animals[i, j] ?? WorldInfo.map[i, j];
                    if (WorldInfo.plants[i, j] != null)
                    if(WorldInfo.plants[i, j].GetType()  == typeof(Tree))
                    {
                        WorldInfo.map[i, j] = (Object)WorldInfo.plants[i, j];
                    }
                }
            }
            for (int i = 0; i < WorldInfo.map.GetLength(0); i++)
            {
                for (int j = 0; j < WorldInfo.map.GetLength(1); j++)
                {
                    if (WorldInfo.map[i,j] != null)
                    WorldInfo.map[i, j].Paint(graphics);
                }
            }
            for (int i = 0; i < WorldInfo.map.GetLength(0) + 1; i++)
            {
                graphics.DrawLine(Pens.Black, i * scale - 1, 0, i * scale - 1, 550);
            }
            for (int i = 0; i < WorldInfo.map.GetLength(0); i++)
            {
                graphics.DrawLine(Pens.Black, 0, i * scale - 1, 550, i * scale - 1);
            }
            Painter.Enabled = false;
        }

        private void Generation_Tick_1(object sender, EventArgs e)
        {
            for (int j =0; j<WorldInfo.animals.GetLength(0);j++)
                for (int i = 0; i < WorldInfo.animals.GetLength(1); i++)
                {
                    if (WorldInfo.plants[j, i] != null)
                    WorldInfo.plants[j,i].GrowUp();
                    
                }
            for (int j = 0; j < WorldInfo.animals.GetLength(0); j++)
                for (int i = 0; i < WorldInfo.animals.GetLength(1); i++)
                {
                
                    if (WorldInfo.animals[j, i] != null)
                        WorldInfo.animals[j, i].Movi();
                }
            Painter.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Painter.Enabled = true;
            int a = 1;
            if (int.TryParse(Count1.Text, out a))
                for (int count = 1; count <= a; count++)
                {
                    int x = rnd.Next(0, Kollvo);
                    int y = rnd.Next(0, Kollvo);
                    bool famel;
                    if (rnd.Next(2) == 1) famel = true;
                    else famel = false;
                    if (WorldInfo.animals[x, y] == null)
                    {
                        WorldInfo.animals[x, y] = new Predator(x, y, famel, WorldInfo.predator[0], WorldInfo.predator[1], WorldInfo.predator[2], WorldInfo.predator[3], WorldInfo.predator[4], WorldInfo.predator[5], WorldInfo.predator[6]);
                    }
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Painter.Enabled = true;
            int a = 1;
            if (int.TryParse(Count1.Text, out a))
                for (int count = 1; count <= a; count++)
                {
                    int x = rnd.Next(0, Kollvo);
                    int y = rnd.Next(0, Kollvo);
                    bool famel;
                    if (rnd.Next(2) == 1) famel = true;
                    else famel = false;
                    if (WorldInfo.animals[x, y] == null)
                    {
                        WorldInfo.animals[x, y] = new Omnivorous(x, y, famel, WorldInfo.omnivorous[0], WorldInfo.omnivorous[1], WorldInfo.omnivorous[2], WorldInfo.omnivorous[3], WorldInfo.omnivorous[4], WorldInfo.omnivorous[5], WorldInfo.omnivorous[6]);
                    }
                }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int  a = 1;
            if (int.TryParse(SpeedTime.Text, out a) && a > 0)
                Generation.Interval = a;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Painter.Enabled = true;
            int a = 1;
            if (int.TryParse(Count1.Text, out a))
                for (int count = 1; count <= a; count++)
                {
                    int x = rnd.Next(0, Kollvo);
                    int y = rnd.Next(0, Kollvo);
                    
                    if (WorldInfo.plants[x, y] == null)
                    {
                        WorldInfo.plants[x, y] = new Tree(x, y, 50, 3);
                    }
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
                Form2 frm2 = new Form2();
                frm2.Show();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = 1;
            int y = 1;
            int x2 = 1;
            int y2 = 1;
            int.TryParse(X1.Text, out x);
            int.TryParse(Y1.Text, out y);
            int.TryParse(X2.Text, out x2);
            int.TryParse(Y2.Text, out y2);
            for (int i = x; i <= x2; i++)
            {
                for(int j = y; j <= y2; j++)
                {
                    if (i >= 0 && i <= WorldInfo.map.GetLength(0)-1 && j >= 0 && j <= WorldInfo.map.GetLength(0) -1)
                    {
                        if (WorldInfo.animals[i, j] != null)
                            WorldInfo.animals[i, j].Dead();
                        if (WorldInfo.plants[i, j] != null)
                            WorldInfo.plants[i, j].Dead();
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Generation.Enabled = false;
            Painter.Enabled = false;
            int.TryParse(scale1.Text,out scale);
            if (scale <= 1)
                scale = 2;
            Kollvo = 550 / scale;

            WorldInfo.Scale();
            for (int i = 0; i < Kollvo; i++)
            {
                for (int j = 0; j < Kollvo; j++)
                {
                    
                   WorldInfo.earths[i, j] = WorldInfo.earths[i, j] ?? new Earth(i, j);
                }
            }
            Painter.Enabled = true;
            Generation.Enabled = true;
        }
    }
}
