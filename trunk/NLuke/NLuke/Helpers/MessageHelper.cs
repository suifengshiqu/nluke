/**
 * author : yurow
 *      http://birdshover.cnblogs.com
 * description:
 *      
 * history : created by yurow 2009-8-23 5:01:54 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace NLuke.Helpers {
    /// <summary>
    /// 
    /// </summary>
    public static class MessageHelper {
        public static void ShowErrorMessage(string msg) {
            MessageBox.Show(msg, "错误提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
