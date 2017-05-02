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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public bool checkObjeck()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên đăng nhập", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }
            return true;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (checkObjeck())
            {
                if (txtUsername.Text.Equals("admin") && txtPassword.Text.Equals("admin"))
                {
                    this.Hide();
                }
                else
                {
                    lblMessage.Visible = true;
                    lblMessage.Text = "Bạn đã nhập sai tên người dùng hoặc mật khẩu";
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
             
    }
}
