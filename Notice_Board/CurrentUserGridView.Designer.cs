
namespace Notice_Board
{
    partial class CurrentUserGridView
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridUserInfoControl = new DevExpress.XtraGrid.GridControl();
            this.gridUserInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnDeleteUserData = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearchUserData = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddUserData = new DevExpress.XtraEditors.SimpleButton();
            this.btnSaveUserData = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserInfoControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserInfo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridUserInfoControl
            // 
            this.gridUserInfoControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gridUserInfoControl.Location = new System.Drawing.Point(0, 0);
            this.gridUserInfoControl.MainView = this.gridUserInfo;
            this.gridUserInfoControl.Name = "gridUserInfoControl";
            this.gridUserInfoControl.Size = new System.Drawing.Size(925, 600);
            this.gridUserInfoControl.TabIndex = 0;
            this.gridUserInfoControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUserInfo});
            // 
            // gridUserInfo
            // 
            this.gridUserInfo.GridControl = this.gridUserInfoControl;
            this.gridUserInfo.Name = "gridUserInfo";
            // 
            // btnDeleteUserData
            // 
            this.btnDeleteUserData.Location = new System.Drawing.Point(246, 3);
            this.btnDeleteUserData.Name = "btnDeleteUserData";
            this.btnDeleteUserData.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteUserData.TabIndex = 1;
            this.btnDeleteUserData.Text = "삭제";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSearchUserData);
            this.flowLayoutPanel1.Controls.Add(this.btnAddUserData);
            this.flowLayoutPanel1.Controls.Add(this.btnSaveUserData);
            this.flowLayoutPanel1.Controls.Add(this.btnDeleteUserData);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(597, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(328, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnSearchUserData
            // 
            this.btnSearchUserData.Location = new System.Drawing.Point(3, 3);
            this.btnSearchUserData.Name = "btnSearchUserData";
            this.btnSearchUserData.Size = new System.Drawing.Size(75, 23);
            this.btnSearchUserData.TabIndex = 2;
            this.btnSearchUserData.Text = "조회";
            // 
            // btnAddUserData
            // 
            this.btnAddUserData.Location = new System.Drawing.Point(84, 3);
            this.btnAddUserData.Name = "btnAddUserData";
            this.btnAddUserData.Size = new System.Drawing.Size(75, 23);
            this.btnAddUserData.TabIndex = 3;
            this.btnAddUserData.Text = "추가";
            // 
            // btnSaveUserData
            // 
            this.btnSaveUserData.Location = new System.Drawing.Point(165, 3);
            this.btnSaveUserData.Name = "btnSaveUserData";
            this.btnSaveUserData.Size = new System.Drawing.Size(75, 23);
            this.btnSaveUserData.TabIndex = 4;
            this.btnSaveUserData.Text = "저장";
            // 
            // CurrentUserGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.gridUserInfoControl);
            this.Name = "CurrentUserGridView";
            this.Size = new System.Drawing.Size(925, 600);
            ((System.ComponentModel.ISupportInitialize)(this.gridUserInfoControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserInfo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridUserInfoControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUserInfo;
        private DevExpress.XtraEditors.SimpleButton btnDeleteUserData;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnSearchUserData;
        private DevExpress.XtraEditors.SimpleButton btnAddUserData;
        private DevExpress.XtraEditors.SimpleButton btnSaveUserData;
    }
}
