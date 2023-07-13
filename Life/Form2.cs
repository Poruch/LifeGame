using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(SpeedH.Text, out a) && int.TryParse(HangryH.Text, out a) && int.TryParse(PregnancyH.Text, out a) && int.TryParse(HealsH.Text, out a) && int.TryParse(DMGH.Text, out a) && int.TryParse(RVisionH.Text,out a) && int.TryParse(DeadAgeH.Text, out a))
            WorldInfo.herbivore = new int[] {int.Parse(SpeedH.Text), int.Parse(HangryH.Text), int.Parse(PregnancyH.Text), int.Parse(HealsH.Text), int.Parse(DMGH.Text), int.Parse(RVisionH.Text), int.Parse(DeadAgeH.Text) };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(SpeedP.Text, out a) && int.TryParse(HangryP.Text, out a) && int.TryParse(PregnancyP.Text, out a) && int.TryParse(HealsP.Text, out a) && int.TryParse(DMGP.Text, out a) && int.TryParse(RVisionP.Text, out a) && int.TryParse(DeadAgeP.Text, out a))
                WorldInfo.predator = new int[] { int.Parse(SpeedP.Text), int.Parse(HangryP.Text), int.Parse(PregnancyP.Text), int.Parse(HealsP.Text), int.Parse(DMGP.Text), int.Parse(RVisionP.Text), int.Parse(DeadAgeP.Text) };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(SpeedO.Text, out a) && int.TryParse(HangryO.Text, out a) && int.TryParse(PregnancyO.Text, out a) && int.TryParse(HealsO.Text, out a) && int.TryParse(DMGO.Text, out a) && int.TryParse(RVisionO.Text, out a) && int.TryParse(DeadAgeO.Text, out a))
                WorldInfo.omnivorous = new int[] { int.Parse(SpeedO.Text), int.Parse(HangryO.Text), int.Parse(PregnancyO.Text), int.Parse(HealsO.Text), int.Parse(DMGO.Text), int.Parse(RVisionO.Text), int.Parse(DeadAgeO.Text) };
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 2;
            if (int.TryParse(t1.Text, out a) && int.TryParse(t2.Text, out b))
                WorldInfo.grassquality = new int[] { a, b };
        }
    }
}
