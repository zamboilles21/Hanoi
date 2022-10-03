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
    public partial class Form1 : Form
    {
        
        public static int start;
        public static int end;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void start_btn_Click(object sender, EventArgs e)
        {
           
            Thenottwotowers uj = new Thenottwotowers();
            this.Hide();
           // uj.ab(start);
           // uj.ab(end);
            uj.Show();
            
        }

        private void rdbtn_start_3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_start_3.Checked==true)
            {
                rdbtn_end_3.Enabled = false;
                start = 3;
            }
            else
            {
                rdbtn_end_3.Enabled = true;
                
            }
        }

        private void rdbtn_start_2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_start_2.Checked == true)
            {
                rdbtn_end_2.Enabled = false;
                start = 2;
            }
            else
            {
                rdbtn_end_2.Enabled = true;
            }
        }

        private void rdbtn_start_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_start_1.Checked == true)
            {
                rdbtn_end_1.Enabled = false;
                start = 1;
            }
            else
            {
                rdbtn_end_1.Enabled = true;
            }
        }

        private void rdbtn_end_3_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_end_3.Checked == true)
            {
                rdbtn_start_3.Enabled = false;
                end = 3;
            }
            else
            {
                rdbtn_start_3.Enabled = true;
            }
        }

        private void rdbtn_end_2_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_end_2.Checked == true)
            {
                rdbtn_start_2.Enabled = false;
                end = 2;
            }
            else
            {
                rdbtn_start_2.Enabled = true;
            }
        }

        private void rdbtn_end_1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_end_1.Checked == true)
            {
                rdbtn_start_1.Enabled = false;
                end = 1;
            }
            else
            {
                rdbtn_start_1.Enabled = true;
            }
        }
    }
}
