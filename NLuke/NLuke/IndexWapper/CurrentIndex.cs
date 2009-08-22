/**
 * author : yurow
 *      http://birdshover.cnblogs.com
 * description:
 *      
 * history : created by yurow 2009-8-23 4:57:31 
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace NLuke.IndexWapper {
    /// <summary>
    /// 
    /// </summary>
    public class CurrentIndex {
        private static object index_locked = new object();
        private static IndexOpen index;

        public static void SetCurrentOpendIndex(IndexOpen index) {
            lock (index_locked) {
                CurrentIndex.index = index;
            }
        }

        public static IndexOpen GetCurrentOpendIndex() {
            lock (index_locked) {
                return index;
            }
        }

        public static bool IsIndexBeOpend() {
            lock (index_locked) {
                return index != null && index.IsOpend;
            }
        }
    }
}
