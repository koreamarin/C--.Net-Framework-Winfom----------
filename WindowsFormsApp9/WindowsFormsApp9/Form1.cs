using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uc1.Label1Text = "asdf";
            string uc1Label = uc1.Label1Text;

            uc2.Label1Text = "asdfasdf";

            uc1.eventHandler += new EventHandler(myFunc1);
            uc1.eventHandler += new EventHandler(myFunc2);

        }

        private void myFunc1(object sender, EventArgs e)
        {
            MessageBox.Show("gd1");
        }

        private void myFunc2(object sender, EventArgs e)
        {
            MessageBox.Show("gd2");
        }

    }
}
