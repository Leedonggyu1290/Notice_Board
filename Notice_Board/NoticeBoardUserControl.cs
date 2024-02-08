using DevExpress.XtraBars.Docking2010;
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
    public partial class NoticeBoardUserControl : UserControl
    {
        public event EventHandler AfterDisposeNoticeBoard;

        private UserInfo user { get; set; }

        public NoticeBoardUserControl(UserInfo userInfo)
        {
            InitializeComponent();

            this.user = userInfo;

            WindowsUIButton btnInfo = btnNoticeBoardPanel.Buttons[0] as WindowsUIButton;

            this.btnNoticeBoardPanel.ButtonClick += BtnNoticeBoardPanel_ButtonClick;
        }

        private void BtnNoticeBoardPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            string tag = ((WindowsUIButton)e.Button).Tag.ToString();

            if (tag == "btnInfo")
            {
                if(this.panelControl1.Controls.Count >= 1)
                {
                    this.panelControl1.Controls.Clear();
                }
                CurrentUserGridView currentUserGridView = new CurrentUserGridView(this.user);
                this.panelControl1.Controls.Add(currentUserGridView);
            }
            else if (tag == "btnTextView")
            {
                if (this.panelControl1.Controls.Count >= 1)
                {
                    this.panelControl1.Controls.Clear();
                }
                TextViewUserControl textViewUserControl = new TextViewUserControl(this.user);
                this.panelControl1.Controls.Add(textViewUserControl);
            }
            else if (tag == "btnLogout")
            {
                MessageBox.Show("로그아웃 되셨습니다.");
                AfterDisposeNoticeBoard(this, new EventArgs());
                this.Dispose();
            }
        }
    }
}
