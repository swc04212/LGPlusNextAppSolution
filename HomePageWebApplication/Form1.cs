using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//논리 참조 추가
using LGUPlusCommon;

namespace LGPlusWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //폼화면이 로딩완료되면 실행되는 이벤트
        private void Form1_Load(object sender, EventArgs e)
        {
            UserServices service = new UserServices();
            var user = service.GetUserData("youjin");

            this.textBox1.Text = user.UserName;
            this.textBox2.Text = user.UserEmail;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("저장 버튼이 클릭되었습니다.");
        }
    }
}
