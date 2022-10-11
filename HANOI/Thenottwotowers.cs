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
        
        //static int handlocation=0;
        static Panel floatingdisk;
        static List<Panel> tower1 = new List<Panel>();
        static List<Panel> tower2 = new List<Panel>();
        static List<Panel> tower3 =new List<Panel>();
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
           
            
            picturetower1.SendToBack();
            generatediscs(START);
            
            for (int i = 0; i < DISKS; i++)
            {
                
                picturetower1.SendToBack();
                picturetower2.SendToBack();
                picturetower3.SendToBack();
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

                    for (int i = 0; i < DISKS; i++)
                    {
                        Panel uj2 = new Panel();
                        uj2.Location = new Point(x + 10, y - 30);
                        uj2.Size = new Size(width - 20, 20);
                        uj2.BackColor = Color.Gold;
                        uj2.Name = $"{i}_disc";
                        width = uj2.Width;
                        x = uj2.Location.X;
                        y = uj2.Location.Y;
                        for (int j = 0; j < DISKS; j++)
                        {
                            uj2.BringToFront();
                        }

                        this.Controls.Add(uj2);
                        tower1.Add(uj2);
                    }
                    
                    
                    break;
                case 2:
                    x = panel_tower_2.Location.X;
                    y = panel_tower_2.Location.Y;
                    width = panel_tower_2.Width;
                    panel_tower_2_light.BackColor = Color.Red;

                    for (int i = 0; i < DISKS; i++)
                    {
                        Panel uj2 = new Panel();
                        uj2.Location = new Point(x + 10, y - 30);
                        uj2.Size = new Size(width - 20, 20);
                        uj2.BackColor = Color.Gold;
                        uj2.Name = $"{i}_disc";
                        width = uj2.Width;
                        x = uj2.Location.X;
                        y = uj2.Location.Y;
                        for (int j = 0; j < DISKS; j++)
                        {
                            uj2.BringToFront();
                        }

                        this.Controls.Add(uj2);
                        tower2.Add(uj2);
                    }

                    
                    break;
                case 3:
                    x = panel_tower_3.Location.X;
                    y = panel_tower_3.Location.Y;
                    width = panel_tower_3.Width;
                    panel_tower_3_light.BackColor = Color.Red;

                    for (int i = 0; i < DISKS; i++)
                    {
                        Panel uj2 = new Panel();
                        uj2.Location = new Point(x + 10, y - 30);
                        uj2.Size = new Size(width - 20, 20);
                        uj2.BackColor = Color.Gold;
                        uj2.Name = $"{i}_disc";
                        width = uj2.Width;
                        x = uj2.Location.X;
                        y = uj2.Location.Y;
                        for (int j = 0; j < DISKS; j++)
                        {
                            uj2.BringToFront();
                        }

                        this.Controls.Add(uj2);
                        tower3.Add(uj2);
                    }

                    
                    break;
            }
            
            
        }

        private void picturetower1_Click(object sender, EventArgs e)
        {
            
            if (tower1.Count() > 0&&floatingdisk==null)
            {
                floatingdisk = tower1[tower1.Count() - 1];
                tower1.RemoveAt(tower1.Count() - 1);
                panel_tower_1_light.BackColor = Color.Red;
                panel_tower_3_light.BackColor = Color.Transparent;
                panel_tower_2_light.BackColor = Color.Transparent;

            }
            else if (floatingdisk != null&& tower1.Count()==0)
            {
                tower1.Add(floatingdisk);
                mozgat(floatingdisk,panel_tower_1,1);
                dimthelights();
                floatingdisk = null;
            }
            else if (floatingdisk != null && tower1.Count() > 0)
            {
                if (floatingdisk.Width<tower1[tower1.Count() - 1].Width)
                {
                    tower1.Add(floatingdisk);
                    mozgat(floatingdisk, panel_tower_1, tower1.Count);
                    dimthelights();
                    floatingdisk = null;
                }
                
            }
            nyertunke();
        }

        private void dimthelights()
        {
            panel_tower_3_light.BackColor = Color.Transparent;
            panel_tower_2_light.BackColor = Color.Transparent;
            panel_tower_1_light.BackColor = Color.Transparent;
        }

        private void mozgat(Panel floatingdisk, Panel towerpos,int disccount)
        {
            floatingdisk.Location = new Point(towerpos.Location.X+( (towerpos.Width-floatingdisk.Width)/2),towerpos.Location.Y- (disccount*30));

        }

        private void picturetower2_Click(object sender, EventArgs e)
        {

            
            if (tower2.Count() > 0 && floatingdisk == null)
            {
                floatingdisk = tower2[tower2.Count() - 1];
                tower2.RemoveAt(tower2.Count() - 1);
                panel_tower_2_light.BackColor = Color.Red;
                panel_tower_1_light.BackColor = Color.Transparent;
                panel_tower_3_light.BackColor = Color.Transparent;
            }
            else if (floatingdisk != null && tower2.Count() == 0)
            {
                tower2.Add(floatingdisk);
                mozgat(floatingdisk, panel_tower_2, 1);
                dimthelights();

                floatingdisk = null;
            }
            else if (floatingdisk != null && tower2.Count() > 0)
            {
                if (floatingdisk.Width < tower2[tower2.Count() - 1].Width)
                {
                    tower2.Add(floatingdisk);
                    mozgat(floatingdisk, panel_tower_2, tower2.Count);
                    dimthelights();
                    floatingdisk = null;
                }
            }
            nyertunke();
        }

        private void picturetower3_Click(object sender, EventArgs e)
        {
            
            if (tower3.Count()>0 && floatingdisk == null)
            {
                floatingdisk = tower3[tower3.Count() - 1];
                tower3.RemoveAt(tower3.Count() - 1);
                panel_tower_3_light.BackColor = Color.Red;
                panel_tower_1_light.BackColor = Color.Transparent;
                panel_tower_2_light.BackColor = Color.Transparent;
            }
            else if (floatingdisk != null && tower3.Count() == 0)
            {
                tower3.Add(floatingdisk);
                mozgat(floatingdisk, panel_tower_3, 1);
                dimthelights();
                floatingdisk = null;
            }
            else if (floatingdisk != null && tower3.Count() > 0)
            {
                if (floatingdisk.Width < tower3[tower3.Count() - 1].Width)
                {
                    tower3.Add(floatingdisk);
                    mozgat(floatingdisk, panel_tower_3, tower3.Count);
                    dimthelights();
                    floatingdisk = null;

                }
            }
            nyertunke();
        }




        private void btn_up_Click(object sender, EventArgs e)
        {
            
            

            
        }

        private bool emptytower()
        {
            bool empty = false ;
            
                
                    if (!empty)
                    {
                        MessageBox.Show("Ezen a tornyon nincs korong");
                    }

                    
            return empty;
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            
        }

        private void nyertunke()
        {
            switch (END)
            {
                case 1:
                    if (tower1.Count==DISKS)
                    {
                        string message = "hurá hurá hurá jaj de nagyon jó, hogy nyertél. akarsz újra játszani?";
                        string title = "jéj nyertél";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.No)
                        {
                            Application.Exit();
                        }
                        else
                        {
                            
                                Application.Restart();
                            
                        }

                    }
                    break;
                case 2:
                    if (tower2.Count == DISKS)
                    {
                        string message = "hurá hurá hurá jaj de nagyon jó, hogy nyertél. akarsz újra játszani?";
                        string title = "jéj nyertél";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.No)
                        {
                            Application.Exit();
                        }
                        else
                        {

                            Application.Restart();

                        }

                    }
                    break;
                case 3:
                    if (tower3.Count == DISKS)
                    {
                        string message = "hurá hurá hurá jaj de nagyon jó, hogy nyertél. akarsz újra játszani?";
                        string title = "jéj nyertél";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show(message, title, buttons);
                        if (result == DialogResult.No)
                        {
                            Application.Exit();
                        }
                        else
                        {

                            Application.Restart();

                        }

                    }
                    break;
            }

        }
        
        private void btn_right_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
