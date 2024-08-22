using DoAnNoSQL.Controllers;
using DoAnNoSQL.DataAccess;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNoSQL.Properties;

namespace DoAnNoSQL.Views
{
    public partial class Login : Form
    {
        private readonly CustomerController customerController;
        public Login()
        {
            InitializeComponent();
            this.Text = "Đăng nhập";
            var connectionString = "mongodb://localhost:27017";
            var databaseName = "QLBaoHiemNhanTho";
            var context = new MongoDbContext(connectionString, databaseName);
            var repository = new CustomerRepository(context);
            customerController = new CustomerController(repository);
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "admin" && txtPassword.Text == "123")
            {
                if (chk_ghinhodn.Checked)
                {
                    Settings.Default.Username = txtUsername.Text;
                    Settings.Default.Password = txtPassword.Text;
                    Settings.Default.RememberMe = true;
                    Settings.Default.Save();
                }
                else
                {
                    Settings.Default.Username = string.Empty;
                    Settings.Default.Password = string.Empty;
                    Settings.Default.RememberMe = false;
                    Settings.Default.Save();
                }
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.FormClosed += (s, args) => this.Show();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Settings.Default.RememberMe)
            {
                chk_ghinhodn.Checked = true;
                txtUsername.Text = Settings.Default.Username;
                txtPassword.Text = Settings.Default.Password;
            }
            else
            {
                chk_ghinhodn.Checked = false;
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
            this.SelectNextControl(null, false, true, true, true);
        }

        private void ckb_showmatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_showmatkhau.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }
    }
}
