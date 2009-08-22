using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NLuke.IndexWapper;
using NLuke.Helpers;

namespace NLuke.Forms {
    public partial class OpenerForm : Form {
        public OpenerForm() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            folderBrowserDialog1.Description = "请选择索引所在的目录。";
            folderBrowserDialog1.ShowNewFolderButton = false;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK) {
                this.comboBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            IndexOpen open = new IndexOpen(this.comboBox1.Text, false);
            if (open.IndexExists()) {
                bool isOpend = open.Open();
                if (isOpend) {
                    CurrentIndex.SetCurrentOpendIndex(open);
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                } else {
                    MessageHelper.ShowErrorMessage("打开索引文件失败，有可能是索引文件损坏引起。");
                }
            } else {
                MessageHelper.ShowErrorMessage("索引文件不存在！");
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void OpenerForm_FormClosing(object sender, FormClosingEventArgs e) {
            folderBrowserDialog1.Dispose();
        }
    }
}
