using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proceum.Customer_cloud
{
    internal partial class frmContentLoadSpinner : MetroFramework.Forms.MetroForm
    {
        public frmContentLoadSpinner()
        {
            InitializeComponent();
        }

        private void frmContentLoadSpinner_Load(object sender, EventArgs e)
        {
            LoadApplication.RunWorkerAsync();
        }

        private void LoadApplication_DoWork(object sender, DoWorkEventArgs e)
        {
           // frmDriveSelectionMetro2 Application = new frmDriveSelectionMetro2();
            Invoke(new Action(() =>
            {
                this.Hide();
            }));
            //Application.Show();
        }
    }
}
