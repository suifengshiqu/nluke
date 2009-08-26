using System;
using System.Collections.Generic;
using System.Text;
using Lucene.Net.Index;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Documents;

namespace NLuke.CreateIndex {
    class Program {
        static void Main(string[] args) {
            IndexWriter writer = new IndexWriter("d:/index", new StandardAnalyzer(), true);
            AddDocument(1, "我是谁", writer);
            AddDocument(2, "来自哪里", writer);
            writer.Optimize();
            writer.Close();
        }

        static void AddDocument(int id, string title, IndexWriter writer) {
            Document doc = new Document();
            doc.Add(new Field("id", id.ToString(), Field.Store.YES, Field.Index.UN_TOKENIZED));
            doc.Add(new Field("title", title, Field.Store.YES, Field.Index.TOKENIZED));
            writer.AddDocument(doc);
        }
    }
}
