using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HANOI
{
    public partial class Thenottwotowers : Form
    {


        // y+30 x+10
        static int placeholder = 7;
        static int placeholder2 = 1;
        static int handlocation=0;
        static int[,] field=new int[3,4];
        Panel[] panelek = new Panel[7];
        static int[] tower1 = new int[7];
        static int[] tower2 = new int[7];
        static int[] tower3 = new int[7];

        public Thenottwotowers()
        {
            InitializeComponent();
            
        }

        private void Thenottwotowers_Load_1(object sender, EventArgs e)
        {
            generatediscs(placeholder, placeholder2);
        }

        private void generatediscs(int placeholder, int placeholder2)
        {
            int width=0;
            int x=1;
            int y=1;
            switch (placeholder2)
            {
                case 1:
                    x = panel_tower_1.Location.X;
                    y = panel_tower_1.Location.Y;
                    width = panel_tower_1.Width;
                    handlocation = 1;
                    for (int i = 0; i < 7; i++)
                    {
                        tower1[i] = i;
                    }
                    break;
                case 2:
                    x = panel_tower_2.Location.X;
                    y = panel_tower_2.Location.Y;
                    width = panel_tower_2.Width;
                    handlocation = 1;
                    for (int i = 0; i < 7; i++)
                    {
                        tower2[i] = i;
                    }
                    break;
                case 3:
                    x = panel_tower_3.Location.X;
                    y = panel_tower_3.Location.Y;
                    width = panel_tower_3.Width;
                    handlocation = 1;
                    for (int i = 0; i < 7; i++)
                    {
                        tower3[i] = i;
                    }
                    break;
            }
            
            for (int i = 0; i < placeholder; i++)
            {
                Panel uj = new Panel();
                uj.Location = new Point(x+10,y-30);
                uj.Size = new Size(width-20, 20);
                uj.BackColor=Color.Gold;
                uj.Name = $"{i}_disc";
                width = uj.Width;
                x = uj.Location.X;
                y = uj.Location.Y;
                this.Controls.Add(uj);
                panelek[i] = uj;
            }
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_down_Click(object sender, EventArgs e)
        {

        }

        private void btn_right_Click(object sender, EventArgs e)
        {

        }

        private void btn_left_Click(object sender, EventArgs e)
        {

        }

        
    }
}
