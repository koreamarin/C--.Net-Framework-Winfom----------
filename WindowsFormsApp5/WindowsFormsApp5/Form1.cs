using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {

        // DataSet
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // DataTable
            // 데이터를 행과 열로서 저장할 수 있는 형식을 제공합니다.
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();

            // 1번째 열 추가 및 형식 지정
            DataColumn dc1 = new DataColumn();
            dc1.ColumnName = "숫자타입";
            dc1.DataType = typeof(Int32);

            // 2번째 열 추가 및 형식 지정
            DataColumn dc2 = new DataColumn();
            dc2.ColumnName = "이름";
            dc2.DataType = typeof(string);

            // 데이터 테이블에 데이터 열을 연결
            dt1.Columns.Add(dc1);
            dt1.Columns.Add(dc2);

            // 데이터테이블 행 추가(데이터 추가 방법)
            dt1.Rows.Add(1, "홍길동");
            dt1.Rows.Add(98, "감길동");
            dt1.Rows.Add(199, "김길동");
            dt1.Rows.Add(201, "류길동");

            // DataSet
            ds = new DataSet("MyDataSet");
           
            // 데이터셋에 데이터 테이블을 저장 (데이터 셋은 여러 테이블을 저장하는데 활용함)
            ds.Tables.Add(dt1);
            ds.Tables.Add(dt2);


            // 데이터그리드뷰와 데이터테이블을 연결하여 표시
            //dataGridView1.DataSource = dt1;             // 1. dt를 바로 연결하는 방법
            dataGridView1.DataSource = ds.Tables[0];    // 2. DataSet에 저장된 dt를 꺼내와서 연결하는 방법. 첫번째 인덱스에서 dt를 꺼내와서 연결
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables[1];
        }
    }
}
