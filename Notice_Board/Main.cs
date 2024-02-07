using DevExpress.XtraEditors;
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
    public partial class Main : XtraForm
    {
        public bool checkDisposed { get; set; }

        public UserInfo user { get; set; }

        public Main()
        {
            InitializeComponent();

            this.user = new UserInfo();

            LoginUserControl login = new LoginUserControl(this.user);
            login.Dock = DockStyle.Fill;
            login.AfterDisposeLogin += LgUserControl_AfterDispose;

            this.Controls.Add(login);
        }

        private void LgUserControl_AfterDispose(object sender, EventArgs e)
        {
            NoticeBoardUserControl noticBoard = new NoticeBoardUserControl(this.user);
            noticBoard.AfterDisposeNoticeBoard += NUserControl_AfterDisposeNoticeBoard;
            this.Size = new Size(1000, 600);
            this.Controls.Add(noticBoard);
        }

        private void NUserControl_AfterDisposeNoticeBoard(object sender, EventArgs e)
        {
            LoginUserControl login2 = new LoginUserControl(this.user);
            login2.AfterDisposeLogin += LgUserControl_AfterDispose;
            this.Size = new Size(420, 520);
            this.Controls.Add(login2);
        }      
    }
}
