/**
 * author : yurow
 *      http://birdshover.cnblogs.com
 * description:
 *      
 * history : created by yurow 2009-8-26 9:43:45 
 */

using System;
using System.Collections.Generic;
using System.Text;
using Lucene.Net.Index;
using Lucene.Net.Util;

namespace NLuke.IndexWapper {
    /// <summary>
    /// 
    /// </summary>
    public class TermDocumentsRelation {
        private IOpen open;

        public TermDocumentsRelation(IOpen open) {
            this.open = open;
        }

        public IList<TermDoc> DocumentCount(Term term) {
            TermDocs docs = open.Reader.TermDocs(term);
            List<TermDoc> list = new List<TermDoc>();
            while (docs.Next()) {
                TermDoc doc2 = new TermDoc();
                doc2.Freq = docs.Freq();
                doc2.Doc = docs.Doc();
                doc2.Term = term;
                doc2.Norm = SmallFloat.Byte315ToFloat(open.Reader.Norms(term.Field())[doc2.Doc]);
                TermDoc item = doc2;
                list.Add(item);
            }
            docs.Close();
            return list;

        }

        public class TermDoc {
            public int Doc { get; set; }
            public int Freq { get; set; }
            public Term Term { get; set; }
            public float Norm { get; set; }
        }
    }
}
