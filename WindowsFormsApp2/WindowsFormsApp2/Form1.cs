using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult drsit = MessageBox.Show("로그인 하시겠습니까?", "로그인", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (DialogResult.OK == drsit)
            {

                if(txtBox1.Text.Equals("asdf"))
                {
                    MessageBox.Show("로그인을 하겠습니다.");
                }
                else
                {
                    MessageBox.Show("로그인에 실패했습니다.");
                }
                
            }

        }
    }
}
