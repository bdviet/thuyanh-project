using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Nhân_Viên
{
    public partial class REPORT : Form
    {
        public REPORT()
        {
            InitializeComponent();
        }

        private void REPORT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.nvst' table. You can move, or remove it, as needed.
            this.nvstTableAdapter.Fill(this.DataSet1.nvst);

            this.reportViewer1.RefreshReport();
        }
    }
}
