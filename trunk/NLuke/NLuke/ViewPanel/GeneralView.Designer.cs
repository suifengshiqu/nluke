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
            this.FieldNum_Ctl = new System.Windows.Forms.Label();
            this.DocumentNum_Ctl = new System.Windows.Forms.Label();
            this.IndexVer_Ctl = new System.Windows.Forms.Label();
            this.IndexOP_Ctl = new System.Windows.Forms.Label();
            this.UpdateTime_Ctl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IndexPath_Lab
            // 
            this.IndexPath_Lab.AutoSize = true;
            this.IndexPath_Lab.Location = new System.Drawing.Point(31, 10);
            this.IndexPath_Lab.Name = "IndexPath_Lab";
            this.IndexPath_Lab.Size = new System.Drawing.Size(65, 12);
            this.IndexPath_Lab.TabIndex = 0;
            this.IndexPath_Lab.Text = "索引目录：";
            // 
            // FieldNum_Ctl
            // 
            this.FieldNum_Ctl.AutoSize = true;
            this.FieldNum_Ctl.Location = new System.Drawing.Point(25, 31);
            this.FieldNum_Ctl.Name = "FieldNum_Ctl";
            this.FieldNum_Ctl.Size = new System.Drawing.Size(71, 12);
            this.FieldNum_Ctl.TabIndex = 1;
            this.FieldNum_Ctl.Text = "Field数量：";
            // 
            // DocumentNum_Ctl
            // 
            this.DocumentNum_Ctl.AutoSize = true;
            this.DocumentNum_Ctl.Location = new System.Drawing.Point(7, 55);
            this.DocumentNum_Ctl.Name = "DocumentNum_Ctl";
            this.DocumentNum_Ctl.Size = new System.Drawing.Size(89, 12);
            this.DocumentNum_Ctl.TabIndex = 2;
            this.DocumentNum_Ctl.Text = "Document数量：";
            // 
            // IndexVer_Ctl
            // 
            this.IndexVer_Ctl.AutoSize = true;
            this.IndexVer_Ctl.Location = new System.Drawing.Point(31, 101);
            this.IndexVer_Ctl.Name = "IndexVer_Ctl";
            this.IndexVer_Ctl.Size = new System.Drawing.Size(65, 12);
            this.IndexVer_Ctl.TabIndex = 3;
            this.IndexVer_Ctl.Text = "索引版本：";
            // 
            // IndexOP_Ctl
            // 
            this.IndexOP_Ctl.AutoSize = true;
            this.IndexOP_Ctl.Location = new System.Drawing.Point(31, 77);
            this.IndexOP_Ctl.Name = "IndexOP_Ctl";
            this.IndexOP_Ctl.Size = new System.Drawing.Size(65, 12);
            this.IndexOP_Ctl.TabIndex = 4;
            this.IndexOP_Ctl.Text = "索引优化：";
            // 
            // UpdateTime_Ctl
            // 
            this.UpdateTime_Ctl.AutoSize = true;
            this.UpdateTime_Ctl.Location = new System.Drawing.Point(31, 123);
            this.UpdateTime_Ctl.Name = "UpdateTime_Ctl";
            this.UpdateTime_Ctl.Size = new System.Drawing.Size(65, 12);
            this.UpdateTime_Ctl.TabIndex = 5;
            this.UpdateTime_Ctl.Text = "更新时间：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(9, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 253);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(177, 32);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(532, 215);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "频率";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Field";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "文本";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Field列表：";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(6, 32);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 206);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // GeneralView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UpdateTime_Ctl);
            this.Controls.Add(this.IndexOP_Ctl);
            this.Controls.Add(this.IndexVer_Ctl);
            this.Controls.Add(this.DocumentNum_Ctl);
            this.Controls.Add(this.FieldNum_Ctl);
            this.Controls.Add(this.IndexPath_Lab);
            this.Name = "GeneralView";
            this.Size = new System.Drawing.Size(735, 396);
            this.Load += new System.EventHandler(this.GeneralView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IndexPath_Lab;
        private System.Windows.Forms.Label FieldNum_Ctl;
        private System.Windows.Forms.Label DocumentNum_Ctl;
        private System.Windows.Forms.Label IndexVer_Ctl;
        private System.Windows.Forms.Label IndexOP_Ctl;
        private System.Windows.Forms.Label UpdateTime_Ctl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label2;
    }
}
