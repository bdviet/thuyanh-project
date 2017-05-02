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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void nvstBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nvstBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tbNV);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            // TODO: This line of code loads data into the 'tbNV.nvst' table. You can move, or remove it, as needed.
            this.nvstTableAdapter.Fill(this.tbNV.nvst);
            Xulycontrol(true);
        }
        private void Xulycontrol(bool b)
        {
            btnF.Enabled = btnP.Enabled = btnN.Enabled = btnL.Enabled = b;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = b;
            nvstDataGridView.Enabled = b;
            gprThongTin.Enabled = !b;
            btnLuu.Enabled = btnHuy.Enabled = !b;

        }

        private void btnF_Click(object sender, EventArgs e)
        {
            nvstBindingSource.MoveFirst();
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            nvstBindingSource.MovePrevious();
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            nvstBindingSource.MoveNext();
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            nvstBindingSource.MoveLast();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Xulycontrol(false);
            nvstBindingSource.AddNew();
            manvTextBox.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                MessageBox.Show("Bạn đã xóa thành công", "Thông Báo", MessageBoxButtons.OK);
                nvstBindingSource.RemoveCurrent();
                this.tableAdapterManager.UpdateAll(tbNV);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.nvstBindingSource.CancelEdit();
            Xulycontrol(true);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Xulycontrol(false);
            manvTextBox.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (manvTextBox.TextLength == 0)
                MessageBox.Show("Mã sinh viên không được bỏ trống");
            else
                if (manvTextBox.TextLength > 10)
                    MessageBox.Show("Mã nhân viên không được quá 10 ký tự");
                else
                    if (tennvTextBox.TextLength == 0)
                        MessageBox.Show("Tên nhân viên không được bỏ trống");
            else
                    {
                        try
                        {
                            this.Validate();
                            this.nvstBindingSource.EndEdit();
                            this.tableAdapterManager.UpdateAll(this.tbNV);
                            Xulycontrol(true);
                        }
                        catch
                        {
                            MessageBox.Show("Mã nhân viên " + manvTextBox.Text + " đã tồn tại");
                        }
                     }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            Application.Exit();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BC bc = new BC();
            bc.Show();
        }

        private void nvstDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
