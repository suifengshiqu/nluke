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
using Lucene.Net.Store;

namespace NLuke.IndexWapper {
    /// <summary>
    /// 概况面板数据绑定
    /// </summary>
    public class GeneralBind {
        private IOpen open;

        public GeneralBind(IOpen open) {
            this.open = open;
        }
        /// <summary>
        /// 计算绑定数据
        /// </summary>
        /// <returns></returns>
        public ViewData Execute() {
            ViewData data = new ViewData();
            data.IndexPath = open.IndexPath;
            data.DocumentNum = open.Reader.NumDocs();

            data.FieldNum = FieldTermsRelation.getInstance().Fields.Length;
            data.IsOptimized = open.Reader.IsOptimized();
            data.UpdateTime = DateTime.FromBinary(IndexReader.LastModified(open.Reader.Directory()));
            data.Version = open.Reader.GetVersion();
            return data;
        }
        /// <summary>
        /// 绑定数据结构
        /// </summary>
        public class ViewData {
            public string IndexPath { get; set; }
            public int FieldNum { get; set; }
            public int DocumentNum { get; set; }
            public bool IsOptimized { get; set; }
            public DateTime UpdateTime { get; set; }
            public long Version { get; set; }
        }
    }
}
