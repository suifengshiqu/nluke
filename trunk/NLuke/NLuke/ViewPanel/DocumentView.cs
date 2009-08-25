using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NLuke.IndexWapper;

namespace NLuke.ViewPanel {
    public partial class DocumentView : UserControl, IUpdateUI {
        public DocumentView() {
            InitializeComponent();
        }

        private int docNum;

        #region IUpdateUI 成员

        public void UpdateUI() {
            if (CurrentIndex.IsIndexBeOpend()) {
                IndexOpen open = CurrentIndex.GetCurrentOpendIndex();
                docNum = open.Reader.MaxDoc();
                label1.Text = string.Format("共有文档{0}条", docNum);
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e) {
            int id = getDocumentID();
            if (id > 0)
                id--;
            textBox1.Text = id.ToString();
            FindDocuemnt(id);
        }

        private int getDocumentID() {
            int id = 0;
            int.TryParse(textBox1.Text, out id);
            return id;
        }

        private void button2_Click(object sender, EventArgs e) {
            int id = getDocumentID();
            if (id < docNum)
                id++;
            textBox1.Text = id.ToString();
            FindDocuemnt(id);
        }

        private void button3_Click(object sender, EventArgs e) {
            int id = getDocumentID();
            FindDocuemnt(id);
        }

        private void FindDocuemnt(int id) {
        }

        private void DocumentView_Load(object sender, EventArgs e) {

        }
    }
}
