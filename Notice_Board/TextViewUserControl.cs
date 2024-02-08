using DevExpress.Utils;
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
    public partial class TextViewUserControl : UserControl
    {
        const string titleColumnName = "제목";
        const string idColumnName = "게시자 아이디";
        
        private UserInfo user { get; set; }

        private TextInfo textInfo { get; set; }

        public TextViewUserControl(UserInfo user)
        {
            InitializeComponent();

            this.user = user;
            this.textInfo = new TextInfo();

            DataSet ds = textInfo.GetTextInfo();
            gridTextViewControl.DataSource = ds.Tables[0];

            this.gridTextView.OptionsSelection.MultiSelect = true;
            this.gridTextView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

            gridTextView.Columns[titleColumnName].View.OptionsBehavior.EditorShowMode = EditorShowMode.MouseUp;
            gridTextView.RowCellClick += GridTextView_RowCellClick;

            btnWriteText.Click += BtnWriteText_Click;
            btnDeleteText.Click += BtnDeleteText_Click;
            btnRefresh.Click += BtnRefresh_Click;
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            this.textInfo = new TextInfo();

            DataSet ds = textInfo.GetTextInfo();
            gridTextViewControl.DataSource = ds.Tables[0];
        }

        private void BtnWriteText_Click(object sender, EventArgs e)
        {
            TextForm textForm = new TextForm(this.user.currentUserID, this.user);
            textForm.ShowDialog();
        }

        private void BtnDeleteText_Click(object sender, EventArgs e)
        {
            var deleteTextUserID = this.gridTextView.GetFocusedRowCellValue(this.gridTextView.Columns["게시자 아이디"]);
            var deleteTextTitle = this.gridTextView.GetFocusedRowCellValue(this.gridTextView.Columns["제목"]);

            if(deleteTextUserID.ToString() != user.currentUserID && user.currentMaster != 0)
            {
                MessageBox.Show("아이디가 일치하지 않으므로 삭제할 수 없습니다.");
            }
            else
            {
                if (MessageBox.Show("정말 삭제하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.textInfo.DeleteText(deleteTextUserID.ToString(), deleteTextTitle.ToString());
                    gridTextView.DeleteRow(gridTextView.FocusedRowHandle);
                }
            }
        }

        private void GridTextView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string saveTitle = gridTextView.GetFocusedRowCellValue(titleColumnName).ToString();
            string saveID = gridTextView.GetFocusedRowCellDisplayText(idColumnName).ToString();

            if (e.X > 90)
            {
                TextForm textForm = new TextForm(saveID, saveTitle, this.user);
                textForm.ShowDialog(); 
            }
        }
    }
}
