﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl1.Text = "글자입니까?";
            lbl2.Text = "글자2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbl3.Text = "글자3";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // 알림메세지 띄움
            MessageBox.Show("알림메세지");
        }
    }
}
