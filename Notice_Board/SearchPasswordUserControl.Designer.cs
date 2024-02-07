
namespace Notice_Board
{
    partial class SearchPasswordUserControl
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
            this.lbUserID = new DevExpress.XtraEditors.LabelControl();
            this.lbUserEmail = new DevExpress.XtraEditors.LabelControl();
            this.lbUserName = new DevExpress.XtraEditors.LabelControl();
            this.tbUserID = new DevExpress.XtraEditors.TextEdit();
            this.tbUserEmail = new DevExpress.XtraEditors.TextEdit();
            this.tbUserName = new DevExpress.XtraEditors.TextEdit();
            this.btnSearchPassword = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUserID
            // 
            this.lbUserID.Appearance.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.lbUserID.Appearance.Options.UseFont = true;
            this.lbUserID.Location = new System.Drawing.Point(21, 236);
            this.lbUserID.Name = "lbUserID";
            this.lbUserID.Size = new System.Drawing.Size(138, 28);
            this.lbUserID.TabIndex = 8;
            this.lbUserID.Text = "사용자 아이디 :";
            // 
            // lbUserEmail
            // 
            this.lbUserEmail.Appearance.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.lbUserEmail.Appearance.Options.UseFont = true;
            this.lbUserEmail.Location = new System.Drawing.Point(21, 166);
            this.lbUserEmail.Name = "lbUserEmail";
            this.lbUserEmail.Size = new System.Drawing.Size(138, 28);
            this.lbUserEmail.TabIndex = 9;
            this.lbUserEmail.Text = "사용자 이메일 :";
            // 
            // lbUserName
            // 
            this.lbUserName.Appearance.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.lbUserName.Appearance.Options.UseFont = true;
            this.lbUserName.Location = new System.Drawing.Point(41, 98);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(118, 28);
            this.lbUserName.TabIndex = 7;
            this.lbUserName.Text = "사용자 이름 :";
            // 
            // tbUserID
            // 
            this.tbUserID.Location = new System.Drawing.Point(165, 233);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.tbUserID.Properties.Appearance.Options.UseFont = true;
            this.tbUserID.Size = new System.Drawing.Size(157, 34);
            this.tbUserID.TabIndex = 5;
            // 
            // tbUserEmail
            // 
            this.tbUserEmail.Location = new System.Drawing.Point(165, 163);
            this.tbUserEmail.Name = "tbUserEmail";
            this.tbUserEmail.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.tbUserEmail.Properties.Appearance.Options.UseFont = true;
            this.tbUserEmail.Size = new System.Drawing.Size(157, 34);
            this.tbUserEmail.TabIndex = 6;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(165, 95);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.tbUserName.Properties.Appearance.Options.UseFont = true;
            this.tbUserName.Size = new System.Drawing.Size(157, 34);
            this.tbUserName.TabIndex = 4;
            // 
            // btnSearchPassword
            // 
            this.btnSearchPassword.Location = new System.Drawing.Point(122, 298);
            this.btnSearchPassword.Name = "btnSearchPassword";
            this.btnSearchPassword.Size = new System.Drawing.Size(85, 23);
            this.btnSearchPassword.TabIndex = 10;
            this.btnSearchPassword.Text = "비밀번호 찾기";
            // 
            // SearchPasswordUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearchPassword);
            this.Controls.Add(this.lbUserID);
            this.Controls.Add(this.lbUserEmail);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.tbUserID);
            this.Controls.Add(this.tbUserEmail);
            this.Controls.Add(this.tbUserName);
            this.Name = "SearchPasswordUserControl";
            this.Size = new System.Drawing.Size(342, 363);
            ((System.ComponentModel.ISupportInitialize)(this.tbUserID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbUserID;
        private DevExpress.XtraEditors.LabelControl lbUserEmail;
        private DevExpress.XtraEditors.LabelControl lbUserName;
        private DevExpress.XtraEditors.TextEdit tbUserID;
        private DevExpress.XtraEditors.TextEdit tbUserEmail;
        private DevExpress.XtraEditors.TextEdit tbUserName;
        private DevExpress.XtraEditors.SimpleButton btnSearchPassword;
    }
}
