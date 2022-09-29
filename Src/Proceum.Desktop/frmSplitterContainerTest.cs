using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proceum
{
    public partial class frmSplitterContainerTest : Form
    {
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView1;
        public frmSplitterContainerTest()
        {
            InitializeComponent();
        }

        private void frmSplitterContainerTest_Load(object sender, EventArgs e)
        {

        }
        private void splitContainer1_SplitterMoving(System.Object sender, System.Windows.Forms.SplitterCancelEventArgs e)
        {
            // As the splitter moves, change the cursor type.
            Cursor.Current = System.Windows.Forms.Cursors.NoMoveVert;
        }

        private void splitContainer1_SplitterMoved(System.Object sender, System.Windows.Forms.SplitterEventArgs e)
        {
            // When the splitter stops moving, change the cursor back to the default.
            Cursor.Current = System.Windows.Forms.Cursors.Default;
        }
    }
}
