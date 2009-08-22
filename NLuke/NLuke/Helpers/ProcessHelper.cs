/**
 * author : yurow
 *      http://birdshover.cnblogs.com
 * description:
 *      
 * history : created by yurow 2009-8-23 4:32:01 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace NLuke.Helpers {
    /// <summary>
    /// 
    /// </summary>
    public static class ProcessHelper {
        public static void StartDefaultExplorer(string url) {
            Process process = Process.Start("explorer", url);
        }
    }
}
