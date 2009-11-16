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
			private string indexPath;
            public string IndexPath { get{ return indexPath ;}set{ indexPath = value ;} }
            private int fieldNum;            
            public int FieldNum { get{return fieldNum ;} set{fieldNum = value;}}
            private int docNum;
            public int DocumentNum { get{ return docNum ;} set{ docNum = value ;} }
            private bool isOptimized;
            public bool IsOptimized { get{ return isOptimized ;} set{isOptimized = value;} }
            private DateTime updateTime;            
            public DateTime UpdateTime { get{ return updateTime ;} set{ updateTime = value ;} }
            private long version;            
            public long Version { get{ return version ;} set{ version =value;} }
        }
    }
}
