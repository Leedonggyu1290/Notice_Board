
namespace Notice_Board
{
    partial class TextForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCorrection = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.tbTitle = new DevExpress.XtraEditors.TextEdit();
            this.tbContents = new DevExpress.XtraEditors.TextEdit();
            this.btnWriteText = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContents.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCorrection
            // 
            this.btnCorrection.Location = new System.Drawing.Point(12, 614);
            this.btnCorrection.Name = "btnCorrection";
            this.btnCorrection.Size = new System.Drawing.Size(80, 23);
            this.btnCorrection.TabIndex = 0;
            this.btnCorrection.Text = "수정";
            this.btnCorrection.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(397, 614);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "저장";
            this.btnSave.Visible = false;
            // 
            // tbTitle
            // 
            this.tbTitle.EditValue = "";
            this.tbTitle.Location = new System.Drawing.Point(12, 97);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.tbTitle.Properties.Appearance.Options.UseFont = true;
            this.tbTitle.Properties.ReadOnly = true;
            this.tbTitle.Size = new System.Drawing.Size(460, 38);
            this.tbTitle.TabIndex = 1;
            // 
            // tbContents
            // 
            this.tbContents.Location = new System.Drawing.Point(12, 178);
            this.tbContents.Name = "tbContents";
            this.tbContents.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 13F);
            this.tbContents.Properties.Appearance.Options.UseFont = true;
            this.tbContents.Properties.AutoHeight = false;
            this.tbContents.Properties.ReadOnly = true;
            this.tbContents.Size = new System.Drawing.Size(460, 370);
            this.tbContents.TabIndex = 1;
            // 
            // btnWriteText
            // 
            this.btnWriteText.Location = new System.Drawing.Point(210, 614);
            this.btnWriteText.Name = "btnWriteText";
            this.btnWriteText.Size = new System.Drawing.Size(80, 23);
            this.btnWriteText.TabIndex = 2;
            this.btnWriteText.Text = "작성";
            this.btnWriteText.Visible = false;
            // 
            // TextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 661);
            this.Controls.Add(this.btnWriteText);
            this.Controls.Add(this.tbContents);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCorrection);
            this.Name = "TextForm";
            this.Text = "게시글";
            ((System.ComponentModel.ISupportInitialize)(this.tbTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbContents.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCorrection;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.TextEdit tbTitle;
        private DevExpress.XtraEditors.TextEdit tbContents;
        private DevExpress.XtraEditors.SimpleButton btnWriteText;
    }
}