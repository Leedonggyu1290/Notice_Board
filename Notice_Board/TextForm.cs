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
        public TextForm(string id, string title)
        {
            InitializeComponent();

            TextInfo textInfo = new TextInfo();
            DataSet ds = textInfo.InputContents(id, title);
            tbTitle.Text = ds.Tables[0].Rows[0][0].ToString();
            tbContents.Text = ds.Tables[0].Rows[0][1].ToString();
        }

        
    }
}
