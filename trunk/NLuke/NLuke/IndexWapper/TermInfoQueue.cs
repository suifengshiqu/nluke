/**
 * author : yurow
 *      http://birdshover.cnblogs.com
 * description:
 *      
 * history : created by yurow 2009-8-23 2:56:37 
 */

using System;
using System.Collections.Generic;
using System.Text;
using Lucene.Net.Util;

namespace NLuke.LuceneAPI {
    /// <summary>
    /// 实现Lucene.Net类库PriorityQueue类，用来排序。
    /// </summary>
    public class TermInfoQueue : PriorityQueue {
        public TermInfoQueue(int size) {
            base.Initialize(size);
        }

        public override bool LessThan(object a, object b) {
            TermModel modle = (TermModel)a;
            TermModel modle2 = (TermModel)b;
            return (modle.Count < modle2.Count);
        }

    }
}
