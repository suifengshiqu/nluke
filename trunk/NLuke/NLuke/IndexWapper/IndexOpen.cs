/**
 * author : yurow
 *      http://birdshover.cnblogs.com
 * description:
 *      
 * history : created by yurow 2009-8-23 3:11:10 
 */

using System;
using System.Collections.Generic;
using System.Text;
using Lucene.Net.Store;
using Lucene.Net.Index;
using System.Windows.Forms;
using NLuke.Helpers;

namespace NLuke.IndexWapper {
    /// <summary>
    /// 打开索引
    /// </summary>
    public class IndexOpen : IOpen {
        private bool isOpened = false;
        private bool isLocked;
        private string indexPath;

        private IndexReader reader;
        /// <summary>
        /// 实现IOpen，返回IndexReader
        /// </summary>
        public IndexReader Reader {
            get {
                return reader;
            }
        }
        /// <summary>
        /// 实现IOpen,返回索引路径
        /// </summary>
        public string IndexPath {
            get {
                return indexPath;
            }
        }
        /// <summary>
        /// 实现IOpen，发挥索引是否被打开
        /// </summary>
        public bool IsOpend {
            get {
                return isOpened;
            }
        }

        public IndexOpen(string indexPath, bool isLocked) {
            this.indexPath = indexPath;
            this.isLocked = isLocked;
        }
        /// <summary>
        /// 指定目录是否为索引目录
        /// </summary>
        /// <returns></returns>
        public bool IndexExists() {
            return IndexReader.IndexExists(indexPath);
        }
        /// <summary>
        /// 打开操作
        /// </summary>
        /// <returns></returns>
        public bool Open() {
            try {
                reader = IndexReader.Open(indexPath);
                isOpened = true;
            } catch (Exception exception) {
                MessageHelper.ShowErrorMessage(exception.Message);
            }
            return isOpened;
        }
        /// <summary>
        /// 重新打开操作
        /// </summary>
        /// <returns></returns>
        public bool ReOpen() {
            if (isOpened) {
                isOpened = false;
                reader = reader.Reopen();
                isOpened = true;
            }
            return isOpened;
        }
        /// <summary>
        /// 关闭操作
        /// </summary>
        public void Close() {
            if (isOpened) {
                reader.Close();
                isOpened = false;
            }
        }
    }
}
