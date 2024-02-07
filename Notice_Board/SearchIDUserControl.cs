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
    public partial class SearchIDUserControl : UserControl
    {
        public SearchIDUserControl()
        {
            InitializeComponent();

            this.btnSearchID.Click += BtnSearchID_Click;
        }

        private void BtnSearchID_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            string userID = userInfo.SearchUserInfo(tbUserName.Text, tbUserEmail.Text);

            if(userID == null)
            {
                MessageBox.Show("존재하는 계정이 없습니다.");
            }
            else
            {
                MessageBox.Show("당신의 아이디는 " + userID + "입니다.");
            }
        }
    }
}
