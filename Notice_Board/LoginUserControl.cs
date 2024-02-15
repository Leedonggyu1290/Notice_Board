using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notice_Board
{
    public partial class LoginUserControl : UserControl
    {
        public event EventHandler AfterDisposeLogin;

        private UserInfo user { get; set; }

        public LoginUserControl(UserInfo user)
        {
            InitializeComponent();
            this.user = user;
            this.btnRegister.Click += BtnRegister_Click;
            this.btnLogin.Click += BtnLogin_Click;
            this.btnSearchPassword.Click += BtnSearchPassword_Click;
            this.btnSearchID.Click += BtnSearchID_Click;
        }

        private void BtnSearchID_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            SearchIDUserControl ucSearchID = new SearchIDUserControl();
            searchForm.Controls.Add(ucSearchID);
            searchForm.ShowDialog();
        }

        private void BtnSearchPassword_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();
            SearchPasswordUserControl ucSearchPassword = new SearchPasswordUserControl();
            searchForm.Controls.Add(ucSearchPassword);
            searchForm.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            bool isLogin = false;

            if(tbInputID.Text == "" || tbInputPassword.Text == "")
            {
                MessageBox.Show("아이디, 또는 비밀번호를 입력해주세요.");
            }
            else
            {
                isLogin = this.user.Login(tbInputID.Text, tbInputPassword.Text);
               

                if(isLogin == true)
                {
                    MessageBox.Show("성공적으로 로그인 되셨습니다.");
                    user.CheckCurrentMaster(tbInputID.Text);
                    AfterDisposeLogin(this, new EventArgs());
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("아이디, 또는 비밀번호가 일치하지 않습니다.");
                }
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            RegistForm form2 = new RegistForm();
            form2.ShowDialog();
        }
    }
}
