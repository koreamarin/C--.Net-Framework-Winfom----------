using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 예외를 던져주는 함수
        /// </summary>
        private void myFunction1()
        {
            throw new Exception();
        }

        /// <summary>
        /// 덧셈함수
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int myFunction2(int a, int b)
        {
            return a + b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 5;
            int b = 7;
            int c = 0;

            // 덧셈 함수
            c = myFunction2(a, b);

            MessageBox.Show("덧셈결과 : " + c);

            // 예외를 발생시키는 함수
            myFunction1();

            MessageBox.Show("덧셈결과 : " + c);

        }
    }
}
