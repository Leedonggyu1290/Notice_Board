
namespace Notice_Board
{
    partial class LoginUserControl
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.tbInputPassword = new DevExpress.XtraEditors.TextEdit();
            this.tbInputID = new DevExpress.XtraEditors.TextEdit();
            this.btnSearchPassword = new DevExpress.XtraEditors.SimpleButton();
            this.btnSearchID = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbInputPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInputID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("맑은 고딕", 25F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(155, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(102, 46);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "게시판";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 235);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(82, 23);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Password :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(73, 173);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 23);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "ID :";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(228, 336);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "회원가입";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(106, 336);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "로그인";
            // 
            // tbInputPassword
            // 
            this.tbInputPassword.EditValue = "";
            this.tbInputPassword.Location = new System.Drawing.Point(106, 232);
            this.tbInputPassword.Name = "tbInputPassword";
            this.tbInputPassword.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.tbInputPassword.Properties.Appearance.Options.UseFont = true;
            this.tbInputPassword.Size = new System.Drawing.Size(197, 30);
            this.tbInputPassword.TabIndex = 4;
            // 
            // tbInputID
            // 
            this.tbInputID.EditValue = "";
            this.tbInputID.Location = new System.Drawing.Point(106, 170);
            this.tbInputID.Name = "tbInputID";
            this.tbInputID.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.tbInputID.Properties.Appearance.Options.UseFont = true;
            this.tbInputID.Size = new System.Drawing.Size(197, 30);
            this.tbInputID.TabIndex = 5;
            // 
            // btnSearchPassword
            // 
            this.btnSearchPassword.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSearchPassword.Location = new System.Drawing.Point(207, 284);
            this.btnSearchPassword.Name = "btnSearchPassword";
            this.btnSearchPassword.Size = new System.Drawing.Size(83, 23);
            this.btnSearchPassword.TabIndex = 8;
            this.btnSearchPassword.Text = "비밀번호 찾기";
            // 
            // btnSearchID
            // 
            this.btnSearchID.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSearchID.Location = new System.Drawing.Point(118, 284);
            this.btnSearchID.Name = "btnSearchID";
            this.btnSearchID.Size = new System.Drawing.Size(83, 23);
            this.btnSearchID.TabIndex = 8;
            this.btnSearchID.Text = "아이디 찾기";
            // 
            // LoginUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnSearchID);
            this.Controls.Add(this.btnSearchPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbInputPassword);
            this.Controls.Add(this.tbInputID);
            this.Name = "LoginUserControl";
            this.Size = new System.Drawing.Size(420, 420);
            ((System.ComponentModel.ISupportInitialize)(this.tbInputPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbInputID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnRegister;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit tbInputPassword;
        private DevExpress.XtraEditors.TextEdit tbInputID;
        private DevExpress.XtraEditors.SimpleButton btnSearchPassword;
        private DevExpress.XtraEditors.SimpleButton btnSearchID;
    }
}
