/**
 * author : yurow
 *      http://birdshover.cnblogs.com
 * description:
 *      
 * history : created by yurow 2009-8-23 5:52:10 
 */

using System;
using System.Collections.Generic;
using System.Text;
using Lucene.Net.Index;

namespace NLuke.IndexWapper {
    public interface IOpen {
        IndexReader Reader { get; }
        string IndexPath { get; }
        bool IsOpend { get; }
    }
}
