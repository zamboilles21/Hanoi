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
        static int START;
        static int END;
        static int DISKS;
        static int[,] field=new int[3,4];
        Panel[] panelek = new Panel[7];
        static int handlocation=0;
        static int[] tower1 = new int[7];
        static int[] tower2 = new int[7];
        static int[] tower3 = new int[7];
        
        public Thenottwotowers()
        {
            InitializeComponent();
            
        }
        public void abSTART(int start, int end,int discs)
        {
            START = start;
            END = end;
            DISKS = discs;
        }
        
        private void Thenottwotowers_Load_1(object sender, EventArgs e)
        {
           
            torony1.SendToBack();
            torony2.SendToBack();
            torony3.SendToBack();
            generatediscs(START);
            for (int i = 0; i < DISKS; i++)
            {
                torony1.SendToBack();
                torony2.SendToBack();
                torony3.SendToBack();
            }
        }


        private void generatediscs(int v)
        {
            int width=0;
            int x=1;
            int y=1;
            
            switch (v)
            {
                case 1:
                    x = panel_tower_1.Location.X;
                    y = panel_tower_1.Location.Y;
                    width = panel_tower_1.Width;
                    panel_tower_1_light.BackColor = Color.Red;
                    handlocation = 1;
                    for (int i = 0; i < DISKS; i++)
                    {
                        tower1[i] = i;
                        tower2[i] = 0;
                        tower3[i] = 0;
                    }
                    break;
                case 2:
                    x = panel_tower_2.Location.X;
                    y = panel_tower_2.Location.Y;
                    width = panel_tower_2.Width;
                    panel_tower_2_light.BackColor = Color.Red;
                    handlocation = 2;
                    for (int i = 0; i < DISKS; i++)
                    {
                        tower2[i] = i;
                        tower1[i] = 0;
                        tower3[i] = 0;
                    }
                    break;
                case 3:
                    x = panel_tower_3.Location.X;
                    y = panel_tower_3.Location.Y;
                    width = panel_tower_3.Width;
                    panel_tower_3_light.BackColor = Color.Red;
                    handlocation = 3;
                    for (int i = 0; i < DISKS; i++)
                    {
                        tower3[i] = i;
                        tower2[i] = 0;
                        tower1[i] = 0;
                    }
                    break;
            }
            
            for (int i = 0; i < DISKS; i++)
            {
                Panel uj2 = new Panel();
                uj2.Location = new Point(x+10,y-30);
                uj2.Size = new Size(width-20, 20);
                uj2.BackColor=Color.Gold;
                uj2.Name = $"{i}_disc";
                width = uj2.Width;
                x = uj2.Location.X;
                y = uj2.Location.Y;
                for (int j = 0; j < DISKS; j++)
                {
                    uj2.BringToFront();
                }
                
                this.Controls.Add(uj2);
                panelek[i] = uj2;
            }
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            
            switch (handlocation)
            {
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
            }
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            nyertunke(END);
        }

        private void nyertunke(int variable)
        {
            switch (variable)
            {
                case 1:
                    bool illik = false;
                    for (int i = 0; i < DISKS; i++)
                    {
                        if (tower1[i]!=i)
                        {
                            illik = true;
                            break;
                        }
                    }
                    if (!illik)
                    {
                        string message = "hurá hurá hurá jaj de nagyon jó, hogy nyertél. akarsz újra játszani?";
                        string title = "jéj nyertél";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.Yes)
                        {
                            Application.Exit();
                        }
                        else
                        {
                            DialogResult result2 = MessageBox.Show("Kezdjük előről? ", "Biztos?", MessageBoxButtons.YesNo);
                            if (result2 == DialogResult.Yes)
                            {
                                Application.Restart();
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                    }
                    break;
            }
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            switch (handlocation)
            {
                case 1:
                    panel_tower_2_light.BackColor = Color.Red;
                    panel_tower_1_light.BackColor = Color.Transparent;
                    panel_tower_3_light.BackColor = Color.Transparent;
                    handlocation = 2;
                    break;
                case 2:
                    panel_tower_3_light.BackColor = Color.Red;
                    panel_tower_1_light.BackColor = Color.Transparent;
                    panel_tower_2_light.BackColor = Color.Transparent;
                    handlocation = 3;
                    break;
                case 3:
                    MessageBox.Show("the retardált fasszopó cigány már teljesen jobbra vagy, szóval jobbfasz vagy");
                    break;
            }
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            switch (handlocation)
            {
                case 2:
                    panel_tower_1_light.BackColor = Color.Red;
                    panel_tower_2_light.BackColor = Color.Transparent;
                    panel_tower_3_light.BackColor = Color.Transparent;
                    handlocation = 1;
                    break;
                case 3:
                    panel_tower_2_light.BackColor = Color.Red;
                    panel_tower_1_light.BackColor = Color.Transparent;
                    panel_tower_3_light.BackColor = Color.Transparent;
                    handlocation = 2;
                    break;
                case 1:
                    MessageBox.Show("the retardált fasszopó cigány már teljesen balra vagy, szóval balfasz vagy");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
