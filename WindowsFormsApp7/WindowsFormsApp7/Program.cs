using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Reflection;

namespace WindowsFormsApp7
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool newForm = false;
            // 첫번째 인자를 true로 설정하면 뮤텍스의 초기 소유권을 갖도록 한다.
            // 두번째 인자는 뮤텍스의 이름 설정(string)
            // out 에서 나오는 bool값은 초기 소유권을 갖는데에 성공했으면 true, 실패했다면 false를 반환하는 return값이다.
            Mutex mutex = new Mutex(true, Assembly.GetEntryAssembly().FullName, out newForm);

            // 뮤텍스가 이미 생성이 되었는지 체크(초기 소유권을 갖는데에 성공했는지 체크)
            if (newForm == true)    // newForm이 true이면 뮤텍스의 초기소유권을 얻어서 뮤텍스를 생성했다는 뜻
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("이미 프로그램이 실행중입니다.");
            }

        }
    }
}
