using System;
using System.Windows.Forms;

namespace DockSample
{
    public partial class DummySolutionExplorer : ToolWindow
    {
        public DummySolutionExplorer()
        {
            InitializeComponent();
        }

        protected override void OnRightToLeftLayoutChanged(EventArgs e)
        {
            treeView1.RightToLeftLayout = RightToLeftLayout;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}