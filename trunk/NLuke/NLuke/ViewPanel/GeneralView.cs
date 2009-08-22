using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using NLuke.IndexWapper;

namespace NLuke.ViewPanel {
    public partial class GeneralView : UserControl {
        public GeneralView() {
            InitializeComponent();
        }

        private void GeneralView_Load(object sender, EventArgs e) {
            if (CurrentIndex.IsIndexBeOpend()) {
                IndexOpen open = CurrentIndex.GetCurrentOpendIndex();
                IndexPath_Lab.Text += open.IndexPath;
            }
        }
    }
}
