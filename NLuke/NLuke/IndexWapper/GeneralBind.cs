/**
 * author : yurow
 *      http://birdshover.cnblogs.com
 * description:
 *      
 * history : created by yurow 2009-8-23 5:54:25 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using Lucene.Net.Index;

namespace NLuke.IndexWapper {
    /// <summary>
    /// 
    /// </summary>
    public class GeneralBind {
        private IOpen open;

        public GeneralBind(IOpen open) {
            this.open = open;
        }

        public ViewData Execute() {
            ViewData data = new ViewData();
            data.IndexPath = open.IndexPath;
            data.DocumentNum = open.Reader.NumDocs();

            ICollection fieldNames = open.Reader.GetFieldNames(IndexReader.FieldOption.ALL);
            data.FieldNum = fieldNames.Count;

            return data;
        }

        public class ViewData {
            public string IndexPath { get; set; }
            public int FieldNum { get; set; }
            public int DocumentNum { get; set; }
            public int TermNum { get; set; }
            public DateTime UpdateTime { get; set; }
        }
    }
}
