using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("알림1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("알림2");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += new System.EventHandler(button2_Click);
        }
    }
}
