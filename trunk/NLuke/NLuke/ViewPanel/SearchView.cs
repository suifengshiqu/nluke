using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace NLuke.ViewPanel {
    public partial class SearchView : UserControl, IUpdateUI {
        public SearchView() {
            InitializeComponent();
        }

        #region IUpdateUI 成员

        public void UpdateUI() {
           
        }

        #endregion
    }
}
