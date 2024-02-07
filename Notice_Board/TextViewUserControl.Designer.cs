
namespace Notice_Board
{
    partial class TextViewUserControl
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
            this.gridTextViewControl = new DevExpress.XtraGrid.GridControl();
            this.gridTextView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnWriteText = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridTextViewControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTextView)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTextViewControl
            // 
            this.gridTextViewControl.Location = new System.Drawing.Point(0, 0);
            this.gridTextViewControl.MainView = this.gridTextView;
            this.gridTextViewControl.Name = "gridTextViewControl";
            this.gridTextViewControl.Size = new System.Drawing.Size(925, 600);
            this.gridTextViewControl.TabIndex = 0;
            this.gridTextViewControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTextView});
            // 
            // gridTextView
            // 
            this.gridTextView.GridControl = this.gridTextViewControl;
            this.gridTextView.Name = "gridTextView";
            // 
            // btnWriteText
            // 
            this.btnWriteText.Location = new System.Drawing.Point(766, 3);
            this.btnWriteText.Name = "btnWriteText";
            this.btnWriteText.Size = new System.Drawing.Size(75, 23);
            this.btnWriteText.TabIndex = 2;
            this.btnWriteText.Text = "글쓰기";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(847, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "simpleButton2";
            // 
            // TextViewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnWriteText);
            this.Controls.Add(this.gridTextViewControl);
            this.Name = "TextViewUserControl";
            this.Size = new System.Drawing.Size(925, 600);
            ((System.ComponentModel.ISupportInitialize)(this.gridTextViewControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTextView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridTextViewControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTextView;
        private DevExpress.XtraEditors.SimpleButton btnWriteText;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
