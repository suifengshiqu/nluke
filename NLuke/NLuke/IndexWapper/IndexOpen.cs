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

namespace NLuke.IndexWapper {
    /// <summary>
    /// 
    /// </summary>
    public class IndexOpen : IOpen {
        private bool isOpened = false;
        private bool isLocked;
        private string indexPath;

        private IndexReader reader;

        public IndexReader Reader {
            get {
                return reader;
            }
        }

        public string IndexPath {
            get {
                return indexPath;
            }
        }

        public bool IsOpend {
            get {
                return isOpened;
            }
        }

        public IndexOpen(string indexPath, bool isLocked) {
            this.indexPath = indexPath;
            this.isLocked = isLocked;
        }

        public bool IndexExists() {
            return IndexReader.IndexExists(indexPath);
        }

        public bool Open() {
            try {
                reader = IndexReader.Open(indexPath);
                isOpened = true;
            } catch (Exception exception) {
            }
            return isOpened;
        }

        public bool ReOpen() {
            if (isOpened) {
                isOpened = false;
                reader = reader.Reopen();
                isOpened = true;
            }
            return isOpened;
        }

        public void Close() {
            if (isOpened) {
                reader.Close();
                isOpened = false;
            }
        }
    }
}
