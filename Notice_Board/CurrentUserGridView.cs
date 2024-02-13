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
    public partial class CurrentUserGridView : UserControl
    {
        private UserInfo userInfo { get; set; }
        private int pastGridRowCount { get; set; }

        private string[] userIDArray;
        public CurrentUserGridView(UserInfo userInfo)
        {
            this.userInfo = userInfo;
            InitializeComponent();

            btnSearchUserData.Click += BtnSearchUserData_Click;
            btnAddUserData.Click += BtnAddUserData_Click;
            btnSaveUserData.Click += BtnSaveUserData_Click;
            btnDeleteUserData.Click += BtnDeleteUserData_Click;

            this.gridUserInfo.OptionsSelection.MultiSelect = true;
            this.gridUserInfo.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;

            if (userInfo.currentMaster != 0)
            {
                DataSet ds = userInfo.GetCurrentUserInfo();
                gridUserInfoControl.DataSource = ds.Tables[0];
            }
            else
            {
                DataSet ds = userInfo.GetAllUserInfo();
                gridUserInfoControl.DataSource = ds.Tables[0];
            }
            pastGridRowCount = gridUserInfo.RowCount;
            userIDArray = new string[pastGridRowCount];

            for (int i = 0; i < pastGridRowCount; i++)
            {
                userIDArray[i] = ((DataTable)gridUserInfoControl.DataSource).Rows[i][0].ToString();
            }

            if (userInfo.currentMaster != 0)
            {
                btnAddUserData.Visible = false;
                btnDeleteUserData.Visible = false;
            }
        }

        private void BtnSearchUserData_Click(object sender, EventArgs e)
        {
            DataSet ds;

            if (userInfo.currentMaster != 0)
            {
                ds = userInfo.GetCurrentUserInfo();
            }
            else
            {
                ds = userInfo.GetAllUserInfo();
            }

            gridUserInfoControl.DataSource = ds.Tables[0];
        }

        private void BtnAddUserData_Click(object sender, EventArgs e)
        {
            gridUserInfo.AddNewRow();
        }

        private void BtnSaveUserData_Click(object sender, EventArgs e)
        {
            var userDataTable = (DataTable)gridUserInfoControl.DataSource;

            if (pastGridRowCount != gridUserInfo.RowCount)
            {
                for (int i = pastGridRowCount; i < gridUserInfo.RowCount; i++)
                {
                    userInfo.InsertDB(userDataTable.Rows[i][0].ToString(), userDataTable.Rows[i][1].ToString(),
                                      userDataTable.Rows[i][2].ToString(),
                                      Convert.ToDateTime(userDataTable.Rows[i][3]).ToString("yyyy-MM-dd"),
                                      userDataTable.Rows[i][4].ToString(), userDataTable.Rows[i][5].ToString(),
                                      userDataTable.Rows[i][6].ToString());
                }
                pastGridRowCount = gridUserInfo.RowCount;
            }
            else
            {
                for (int j = 0; j < gridUserInfo.RowCount; j++)
                {
                    if (userInfo.currentMaster != 0)
                    {
                        userInfo.UpdateData(userDataTable.Rows[j][0].ToString(), userDataTable.Rows[j][1].ToString(),
                        userDataTable.Rows[j][2].ToString(), (DateTime)userDataTable.Rows[j][3],
                        userDataTable.Rows[j][4].ToString(), userDataTable.Rows[j][5].ToString(),
                        userDataTable.Rows[j][6].ToString());
                    }
                    else
                    {
                        if (userDataTable.Rows[j][0].ToString() != userIDArray[j])
                        {
                            userInfo.UpdateDataWithIDMaster(userDataTable.Rows[j][0].ToString(),
                            userDataTable.Rows[j][1].ToString(), userDataTable.Rows[j][2].ToString(),
                            (DateTime)userDataTable.Rows[j][3], userDataTable.Rows[j][4].ToString(),
                            userDataTable.Rows[j][5].ToString(), userDataTable.Rows[j][6].ToString(),
                            userDataTable.Rows[j][7].ToString(), userIDArray[j]);
                        }
                        else
                        {
                            userInfo.UpdateDataMaster(userDataTable.Rows[j][1].ToString(), userDataTable.Rows[j][2].ToString(),
                            (DateTime)userDataTable.Rows[j][3], userDataTable.Rows[j][4].ToString(),
                            userDataTable.Rows[j][5].ToString(), userDataTable.Rows[j][6].ToString(),
                            userDataTable.Rows[j][7].ToString(), userIDArray[j]);
                        }
                    }
                }
            }
            MessageBox.Show("저장되었습니다.");
        }

        private void BtnDeleteUserData_Click(object sender, EventArgs e)
        {
            var deleteUserID = this.gridUserInfo.GetFocusedRowCellValue(this.gridUserInfo.Columns["USER_ID"]);

            if(MessageBox.Show("정말 삭제하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                userInfo.DeleteUser(deleteUserID.ToString());
                gridUserInfo.DeleteRow(gridUserInfo.FocusedRowHandle);
            }
        }
    }
}
