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

        public TextViewUserControl(UserInfo user)
        {
            InitializeComponent();
            TextInfo textInfo = new TextInfo();

            DataSet ds = textInfo.GetTextInfo();
            gridTextViewControl.DataSource = ds.Tables[0];

            gridTextView.Columns[titleColumnName].View.OptionsBehavior.EditorShowMode = EditorShowMode.MouseUp;
            gridTextView.RowClick += GridTextView_RowClick;
        }

        private void GridTextView_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            string saveTitle = gridTextView.GetFocusedRowCellValue(titleColumnName).ToString();
            string saveID = gridTextView.GetFocusedRowCellDisplayText(idColumnName).ToString();

            TextForm textForm = new TextForm(saveID, saveTitle);
            textForm.ShowDialog();
        }
    }
}
