using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NLuke.IndexWapper;
using System.Collections;
using NLuke.LuceneAPI;

namespace NLuke.ViewPanel {
    public partial class GeneralView : UserControl, IUpdateUI {
        public GeneralView() {
            InitializeComponent();
        }

        private void GeneralView_Load(object sender, EventArgs e) {
           
        }

        #region IUpdateUI 成员

        public void UpdateUI() {
            if (CurrentIndex.IsIndexBeOpend()) {
                IndexOpen open = CurrentIndex.GetCurrentOpendIndex();
                GeneralBind bind = new GeneralBind(open);
                GeneralBind.ViewData data = bind.Execute();
                IndexPath_Lab.Text += data.IndexPath;
                FieldNum_Ctl.Text += data.FieldNum;
                DocumentNum_Ctl.Text += data.DocumentNum;
                IndexOP_Ctl.Text += data.IsOptimized ? "已经优化" : "没有优化";
                IndexVer_Ctl.Text += data.Version.ToString();
                UpdateTime_Ctl.Text += data.UpdateTime.ToString();
                listBox1.Items.Clear();
                FieldTermsRelation rela = FieldTermsRelation.getInstance();
                for (int i = 0; i < rela.Fields.Length; i++) {
                    listBox1.Items.Add(rela.Fields[i]);                    
                }
                listBox1.Items.Insert(0, "所有Fields");
                listBox1.SelectedIndex = 0;
            }
        }

        #endregion

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBox1.SelectedIndex > -1) {
                int index = listBox1.SelectedIndex;
                string currentField = null;
                if (index > 0)
                    currentField = listBox1.Items[index].ToString();
                label2.Text = string.Format("高频词汇：（当前字段[{0}],前100个）", currentField == null ? "所有Fields" : currentField);
                FieldTermsRelation rela = FieldTermsRelation.getInstance();
                rela.CurrentFieldChanged(currentField);
                TermModel[] models = rela.FindTerms(100);
                listView1.Clear();
                listView1.Columns.Add("编号", 80);
                listView1.Columns.Add("频率", 80);
                listView1.Columns.Add("Field", 120);
                listView1.Columns.Add("文本", 200);
                for (int i = 0; i < models.Length; i++) {
                    TermModel model = models[i];
                    ListViewItem item = new ListViewItem(new string[] { (i + 1).ToString(), model.Count.ToString(), model.Term.Field(), model.Term.Text() });
                    listView1.Items.Add(item);
                }
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e) {
            TabControl tab = Parent.Parent as TabControl;
            tab.SelectTab(1);
        }
    }
}
