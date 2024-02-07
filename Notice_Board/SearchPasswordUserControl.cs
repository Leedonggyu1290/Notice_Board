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
    public partial class SearchPasswordUserControl : UserControl
    {
        public SearchPasswordUserControl()
        {
            InitializeComponent();

            this.btnSearchPassword.Click += BtnSearchPassword_Click;
        }

        private void BtnSearchPassword_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            string userPassword = userInfo.SearchUserInfo(tbUserName.Text, tbUserEmail.Text, tbUserID.Text);

            if (userPassword == null)
            {
                MessageBox.Show("존재하는 계정이 없습니다.");
            }
            else
            {
                MessageBox.Show("당신의 비밀번호는 " + userPassword + "입니다.");
            }
        }
    }
}
