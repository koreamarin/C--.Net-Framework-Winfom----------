using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.화면_캡처_2024_10_17_082345;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image = null;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.화면_캡처_2024_10_17_082345;
            }
        }
    }
}
