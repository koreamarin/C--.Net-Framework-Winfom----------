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
    public partial class UserControl1 : UserControl
    {
        public EventHandler eventHandler;

        public UserControl1()
        {
            InitializeComponent();
        }

        // private 변수 외부에 공유하는 방법
        // 함수를 만들어서 접근가능하도록 만듦
        public string Label1Text 
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackgroundImage = Properties.Resources._1;
        }

        private void button1_Click(object sender, EventArgs e)  // 아래 button2_Click과 같은 코드
        {
            EventHandler handler = this.eventHandler;

            if (this.eventHandler != null)
            {
                handler(sender, e);
            }
        }

        private void button2_Click(object sender, EventArgs e)  // 위 button1_Click과 같은 코드
        {
            eventHandler?.Invoke(sender, e);
        }
    }
}
