/**
 * author : yurow
 *      http://birdshover.cnblogs.com
 * description:
 *      
 * history : created by yurow 2009-8-23 2:58:50 
 */

using System;
using System.Collections.Generic;
using System.Text;
using Lucene.Net.Index;

namespace NLuke.LuceneAPI {
    /// <summary>
    /// 项模型，额外增加了出现次数属性。
    /// </summary>
    public class TermModle {
        private int count;
        private Term term;
        /// <summary>
        /// 创建项模型。
        /// </summary>
        /// <param name="term">项数据</param>
        /// <param name="count">出现次数</param>
        public TermModle(Term term, int count) {
            this.term = term;
            this.count = count;
        }
        /// <summary>
        /// 项数据
        /// </summary>
        public Term Term {
            get {
                return term;
            }
        }
        /// <summary>
        /// 出现次数
        /// </summary>
        public int Count {
            get {
                return count;
            }
        }
    }
}
