
namespace Notice_Board
{
    partial class SearchIDUserControl
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
            this.tbUserName = new DevExpress.XtraEditors.TextEdit();
            this.tbUserEmail = new DevExpress.XtraEditors.TextEdit();
            this.lbUserName = new DevExpress.XtraEditors.LabelControl();
            this.lbUserEmail = new DevExpress.XtraEditors.LabelControl();
            this.btnSearchID = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserEmail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(188, 145);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.tbUserName.Properties.Appearance.Options.UseFont = true;
            this.tbUserName.Size = new System.Drawing.Size(157, 34);
            this.tbUserName.TabIndex = 0;
            // 
            // tbUserEmail
            // 
            this.tbUserEmail.Location = new System.Drawing.Point(188, 213);
            this.tbUserEmail.Name = "tbUserEmail";
            this.tbUserEmail.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.tbUserEmail.Properties.Appearance.Options.UseFont = true;
            this.tbUserEmail.Size = new System.Drawing.Size(157, 34);
            this.tbUserEmail.TabIndex = 1;
            // 
            // lbUserName
            // 
            this.lbUserName.Appearance.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.lbUserName.Appearance.Options.UseFont = true;
            this.lbUserName.Location = new System.Drawing.Point(64, 148);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(118, 28);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "사용자 이름 :";
            // 
            // lbUserEmail
            // 
            this.lbUserEmail.Appearance.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.lbUserEmail.Appearance.Options.UseFont = true;
            this.lbUserEmail.Location = new System.Drawing.Point(44, 216);
            this.lbUserEmail.Name = "lbUserEmail";
            this.lbUserEmail.Size = new System.Drawing.Size(138, 28);
            this.lbUserEmail.TabIndex = 3;
            this.lbUserEmail.Text = "사용자 이메일 :";
            // 
            // btnSearchID
            // 
            this.btnSearchID.Location = new System.Drawing.Point(157, 299);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(75, 23);
            this.btnSearchID.TabIndex = 4;
            this.btnSearchID.Text = "아이디 찾기";
            // 
            // SearchIDUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearchID);
            this.Controls.Add(this.lbUserEmail);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.tbUserEmail);
            this.Controls.Add(this.tbUserName);
            this.Name = "SearchIDUserControl";
            this.Size = new System.Drawing.Size(400, 400);
            ((System.ComponentModel.ISupportInitialize)(this.tbUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbUserEmail.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tbUserName;
        private DevExpress.XtraEditors.TextEdit tbUserEmail;
        private DevExpress.XtraEditors.LabelControl lbUserName;
        private DevExpress.XtraEditors.LabelControl lbUserEmail;
        private DevExpress.XtraEditors.SimpleButton btnSearchID;
    }
}
