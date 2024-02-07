using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;
using DevExpress.XtraEditors;

namespace Notice_Board
{
    public partial class RegistForm : XtraForm
    {
        private bool checkDuplication = false;

        public RegistForm()
        {
            InitializeComponent();

            this.btnRegister.Click += BtnRegister_Click;
            this.btnCheckDuplication.Click += BtnCheckDuplication_Click;
        }

        private void BtnCheckDuplication_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            if(tbIdEdit.Text != "")
            {
                checkDuplication = userInfo.CheckDuplicationID(tbIdEdit.Text);

                if (checkDuplication == true)
                {
                    MessageBox.Show("사용 가능한 아이디입니다.");
                }
                else
                {
                    MessageBox.Show("중복된 아이디입니다.");
                }
            }
            else
            {
                MessageBox.Show("아이디를 입력해주세요");
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if(checkDuplication == false)
            {
                MessageBox.Show("중복확인을 먼저 해주세요.");
            }
            else
            {
                int rgCheckedIndex = rgCheckGender.SelectedIndex;
                var userInfo = new UserInfo();

                userInfo.InsertDB(tbIdEdit.Text, tbPasswordEdit.Text, tbNameEdit.Text,
                    birthEdit.Text, rgCheckGender.Properties.Items[rgCheckedIndex].Description,
                    tbEmailEdit.Text, tbPhoneNumberEdit.Text);
                MessageBox.Show("회원가입이 완료되었습니다.");
                this.Dispose();
            }
        }


    }
}
