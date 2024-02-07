
namespace Notice_Board
{
    partial class NoticeBoardUserControl
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
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions5 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoticeBoardUserControl));
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions6 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions7 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions8 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
            this.btnNoticeBoardPanel = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNoticeBoardPanel
            // 
            this.btnNoticeBoardPanel.AppearanceButton.Hovered.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNoticeBoardPanel.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnNoticeBoardPanel.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.btnNoticeBoardPanel.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.btnNoticeBoardPanel.AppearanceButton.Normal.BackColor = System.Drawing.Color.Snow;
            this.btnNoticeBoardPanel.AppearanceButton.Normal.BackColor2 = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNoticeBoardPanel.AppearanceButton.Normal.BorderColor = System.Drawing.Color.Black;
            this.btnNoticeBoardPanel.AppearanceButton.Normal.ForeColor = System.Drawing.Color.Black;
            this.btnNoticeBoardPanel.AppearanceButton.Normal.Options.UseBackColor = true;
            this.btnNoticeBoardPanel.AppearanceButton.Normal.Options.UseBorderColor = true;
            this.btnNoticeBoardPanel.AppearanceButton.Normal.Options.UseForeColor = true;
            this.btnNoticeBoardPanel.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnNoticeBoardPanel.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.btnNoticeBoardPanel.BackColor = System.Drawing.Color.Ivory;
            windowsUIButtonImageOptions5.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions5.Image")));
            windowsUIButtonImageOptions6.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions6.Image")));
            windowsUIButtonImageOptions7.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions7.Image")));
            windowsUIButtonImageOptions8.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonImageOptions8.Image")));
            this.btnNoticeBoardPanel.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("내 정보", true, windowsUIButtonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "btnInfo", 0, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("게시글 조회", true, windowsUIButtonImageOptions6, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "btnTextView", 1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("관리자 설정", true, windowsUIButtonImageOptions7, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, 2, false),
            new DevExpress.XtraBars.Docking2010.WindowsUISeparator(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("로그아웃", true, windowsUIButtonImageOptions8, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, "btnLogout", 3, false)});
            this.btnNoticeBoardPanel.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.btnNoticeBoardPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNoticeBoardPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNoticeBoardPanel.Location = new System.Drawing.Point(0, 0);
            this.btnNoticeBoardPanel.Name = "btnNoticeBoardPanel";
            this.btnNoticeBoardPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.btnNoticeBoardPanel.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.btnNoticeBoardPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNoticeBoardPanel.Size = new System.Drawing.Size(75, 600);
            this.btnNoticeBoardPanel.TabIndex = 0;
            this.btnNoticeBoardPanel.Text = "windowsUIButtonPanel1";
            // 
            // panelControl1
            // 
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(75, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(925, 600);
            this.panelControl1.TabIndex = 1;
            // 
            // NoticeBoardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.btnNoticeBoardPanel);
            this.Name = "NoticeBoardUserControl";
            this.Size = new System.Drawing.Size(1000, 600);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel btnNoticeBoardPanel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}
