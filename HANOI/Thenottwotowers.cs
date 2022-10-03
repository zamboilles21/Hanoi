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
        static int placeholder = 0;

        public static Thenottwotowers instance;
        public Thenottwotowers()
        {
            InitializeComponent();
            instance = this;
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
