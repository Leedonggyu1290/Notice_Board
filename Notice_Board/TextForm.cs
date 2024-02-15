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
    public partial class TextForm : Form
    {
        private UserInfo user { get; set; }
        private TextInfo textInfo { get; set; }
        public TextForm(string id, string title, UserInfo user)
        {
            InitializeComponent();

            this.user = user;
            this.textInfo = new TextInfo();
            DataSet ds = textInfo.InputContents(id, title);
            tbTitle.Text = ds.Tables[0].Rows[0][0].ToString();
            tbContents.Text = ds.Tables[0].Rows[0][1].ToString();

            textInfo.pastTitle = tbTitle.Text;
            textInfo.pastText = tbContents.Text;

            if(id == user.currentUserID)
            {
                btnCorrection.Visible = true;
                btnSave.Visible = true;
            }

            btnCorrection.Click += BtnCorrection_Click;
            btnSave.Click += BtnSave_Click;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this.textInfo.UpdateText(user.currentUserID, tbTitle.Text, tbContents.Text);
            MessageBox.Show("저장되었습니다.");
            this.Dispose();
        }

        private void BtnCorrection_Click(object sender, EventArgs e)
        {
            tbTitle.ReadOnly = false;
            tbContents.ReadOnly = false;
        }

        public TextForm(string id, UserInfo user)
        {
            InitializeComponent();

            this.user = user;
            this.textInfo = new TextInfo();

            btnWriteText.Visible = true;
            tbTitle.ReadOnly = false;
            tbContents.ReadOnly = false;
            
            btnWriteText.Click += BtnWriteText_Click;
        }

        private void BtnWriteText_Click(object sender, EventArgs e)
        {
            textInfo.InsertText(this.user.currentUserID, tbTitle.Text, tbContents.Text);
            MessageBox.Show("저장되었습니다.");
            this.Dispose();
        }
    }
}
