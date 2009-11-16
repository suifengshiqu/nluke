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
    /// Term文档关系处理类
    /// </summary>
    public class TermDocumentsRelation {
        private IOpen open;

        public TermDocumentsRelation(IOpen open) {
            this.open = open;
        }
        /// <summary>
        /// 得到指定Term的文档
        /// </summary>
        /// <param name="term"></param>
        /// <returns></returns>
        public IList<TermDoc> DocumentCount(Term term) {
            TermDocs docs = open.Reader.TermDocs(term);
            List<TermDoc> list = new List<TermDoc>();
            while (docs.Next()) {
                TermDoc doc2 = new TermDoc();
                doc2.Freq = docs.Freq();
                doc2.Doc = docs.Doc();
                doc2.Term = term;
                doc2.Norm = GetNorm(open.Reader, term.Field(), doc2.Doc);
                TermDoc item = doc2;
                list.Add(item);
            }
            docs.Close();
            return list;

        }
        /// <summary>
        /// 得到文档某字段的Norm
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="field"></param>
        /// <param name="docId"></param>
        /// <returns></returns>
        public static float GetNorm(IndexReader reader, string field, int docId) {
            return SmallFloat.Byte315ToFloat(reader.Norms(field)[docId]);
        }

        public class TermDoc {
            private int doc;
            public int Doc { get{return doc ;} set{doc =value;} }
            private int freq;

            public int Freq{
            	get{
            		return freq;
            	}
            	set{
            		freq = value;
            	}
            }
            
            private Term term;

            public Term Term{
            	get{
            		return term;
            	}
            	set{
            		term = value;
            	}
            }
            
            private float norm;

            public float Norm{
            	get{
            		return norm;
            	}
            	set{
            		norm = value;
            	}
            }            
        }
    }
}
