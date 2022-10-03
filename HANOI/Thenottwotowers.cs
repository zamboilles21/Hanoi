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
        static int placeholder = 3;
        static int placeholder2 = 1;
        static int handlocation=0;
        static int[,] field=new int[3,4];

        public Thenottwotowers()
        {
            InitializeComponent();
            
        }

        private void Thenottwotowers_Load(object sender, EventArgs e)
        {
            generatediscs(placeholder);

            

        }

        private void generatediscs(int v)
        {
            
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
