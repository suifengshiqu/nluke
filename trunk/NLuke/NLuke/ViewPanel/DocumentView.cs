using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NLuke.IndexWapper;
using NLuke.LuceneAPI;
using Lucene.Net.Index;
using Lucene.Net.Documents;
using System.Collections;
using NLuke.Helpers;

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

                FieldTermsRelation rela = FieldTermsRelation.getInstance();
                for (int i = 0; i < rela.Fields.Length; i++) {
                    comboBox1.Items.Add(rela.Fields[i]);
                }
                if (comboBox1.Items.Count > 0)
                    comboBox1.SelectedIndex = 0;
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
            if (id < docNum - 1)
                id++;
            textBox1.Text = id.ToString();
            FindDocuemnt(id);
        }

        private void button3_Click(object sender, EventArgs e) {
            int id = getDocumentID();
            FindDocuemnt(id);
        }

        private void FindDocuemnt(int id) {
            ShowDocument(id);
        }

        private void DocumentView_Load(object sender, EventArgs e) {

        }

        private void button4_Click(object sender, EventArgs e) {
            BindFieldTermFirst();
        }

        private void button5_Click(object sender, EventArgs e) {
            FieldTermsRelation rela = FieldTermsRelation.getInstance();
            TermModel model = rela.FindTerm(comboBox1.Text, textBox2.Text, false);
            if (model != null) {
                textBox2.Text = model.Term.Text();

                label3.Text = string.Format("当前词频：{0}", model.Count);

                BindTermDocs(model.Term);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
            BindFieldTermFirst();
        }

        private int termDocPtr = 0;
        private IList<TermDocumentsRelation.TermDoc> docs;

        private void BindTermDocs(Term term) {
            if (CurrentIndex.IsIndexBeOpend()) {
                IOpen open = CurrentIndex.GetCurrentOpendIndex();
                TermDocumentsRelation tdr = new TermDocumentsRelation(open);
                docs = tdr.DocumentCount(term);

                label6.Text = string.Format("文档数：{0}", docs.Count);
            }
        }

        private void BindFieldTermFirst() {
            FieldTermsRelation rela = FieldTermsRelation.getInstance();
            TermModel model = rela.FindTerm(comboBox1.Text, null, true);
            if (model != null) {
                textBox2.Text = model.Term.Text();

                label3.Text = string.Format("当前词频：{0}", model.Count);

                BindTermDocs(model.Term);
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            termDocPtr = 0;
            ShowCurrentDocument();
        }

        private void button7_Click(object sender, EventArgs e) {
            if (termDocPtr < docs.Count - 1) {
                termDocPtr++;
            } 
            ShowCurrentDocument();
        }

        private void ShowCurrentDocument() {
            if (docs.Count > 0) {
                TermDocumentsRelation.TermDoc doc = docs[termDocPtr];
                label8.Text = string.Format(label8.Text, doc.Freq);
                ShowDocument(doc.Doc);
            }
        }

        private void ShowDocument(int docId) {
            listView1.Clear();
            listView1.Columns.Add("Field", 120);
            listView1.Columns.Add("Norm", 120);
            listView1.Columns.Add("Text", 400);
            IOpen open = CurrentIndex.GetCurrentOpendIndex();
            if (docId >= open.Reader.NumDocs()) {
                MessageHelper.ShowErrorMessage("当前Id超出文档最大Id。");
                return;
            }

            Document doc = open.Reader.Document(docId);
            
            IList list = doc.GetFields();
            for (int i = 0; i < list.Count; i++) {
                Field f = list[i] as Field;
                listView1.Items.Add(new ListViewItem(new string[] { f.Name(), TermDocumentsRelation.GetNorm(CurrentIndex.GetCurrentOpendIndex().Reader, f.Name(), docId).ToString(), f.StringValue() }));
            }
        }
    }
}
