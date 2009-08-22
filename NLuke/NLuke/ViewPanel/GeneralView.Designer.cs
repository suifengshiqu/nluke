namespace NLuke.ViewPanel {
    partial class GeneralView {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.IndexPath_Lab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IndexPath_Lab
            // 
            this.IndexPath_Lab.AutoSize = true;
            this.IndexPath_Lab.Location = new System.Drawing.Point(16, 15);
            this.IndexPath_Lab.Name = "IndexPath_Lab";
            this.IndexPath_Lab.Size = new System.Drawing.Size(65, 12);
            this.IndexPath_Lab.TabIndex = 0;
            this.IndexPath_Lab.Text = "索引目录：";
            // 
            // GeneralView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IndexPath_Lab);
            this.Name = "GeneralView";
            this.Size = new System.Drawing.Size(603, 325);
            this.Load += new System.EventHandler(this.GeneralView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IndexPath_Lab;
    }
}
