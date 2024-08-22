using DoAnNoSQL.Controllers;
using DoAnNoSQL.DataAccess;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DoAnNoSQL.Views
{
    public partial class MainForm : Form
    {
        private readonly CustomerController customerController;
        private string backupFolder;
        private string restorePath;

        public MainForm()
        {
            InitializeComponent();
            var connectionString = "mongodb://localhost:27017";
            var databaseName = "QLBaoHiemNhanTho";
            var context = new MongoDbContext(connectionString, databaseName);
            var repository = new CustomerRepository(context);
            customerController = new CustomerController(repository);
        }

        private void mni_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.FormClosed += (s, args) => Application.Exit();
            login.ShowDialog();
        }

        private void mni_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mni_qlkh_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customer customer = new Customer();
            customer.FormClosed += (s, args) => this.Show();
            customer.ShowDialog();
        }
        private void mni_hdbh_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_HopDongBH hdbh = new Frm_HopDongBH();
            hdbh.FormClosed += (s, args) => this.Show();
            hdbh.ShowDialog();
        }

        private void btnSelectBackupFolder_Click(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    backupFolder = folderBrowser.SelectedPath;
                    MessageBox.Show($"Backup folder selected: {backupFolder}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSelectRestorePath_Click(object sender, EventArgs e)
        {
            using (var folderBrowser = new FolderBrowserDialog())
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    restorePath = folderBrowser.SelectedPath;
                    MessageBox.Show($"Restore path selected: {restorePath}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BackupDatabase(string databaseName, string outputFolder)
        {
            var processInfo = new ProcessStartInfo
            {
                FileName = "mongodump",
                Arguments = $"--db {databaseName} --out {outputFolder}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = Process.Start(processInfo))
            {
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    MessageBox.Show("Backup successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Backup failed: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void RestoreDatabase(string databaseName, string backupPath)
        {
            var processInfo = new ProcessStartInfo
            {
                FileName = "mongorestore",
                Arguments = $"--db {databaseName} --drop {backupPath}",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (var process = Process.Start(processInfo))
            {
                string output = process.StandardOutput.ReadToEnd();
                string error = process.StandardError.ReadToEnd();
                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    MessageBox.Show("Restore successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Restore failed: {error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void mni_saoluu_Click(object sender, EventArgs e)
        {
            string databaseName = "QLBaoHiemNhanTho";

            // Hiển thị hộp thoại chọn thư mục để sao lưu
            using (var folderBrowser = new FolderBrowserDialog())
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    backupFolder = folderBrowser.SelectedPath;
                    BackupDatabase(databaseName, backupFolder);
                }
                else
                {
                    MessageBox.Show("Backup operation was cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void mni_phuchoi_Click(object sender, EventArgs e)
        {
            string databaseName = "QLBaoHiemNhanTho";

            // Hiển thị hộp thoại chọn thư mục để phục hồi
            using (var folderBrowser = new FolderBrowserDialog())
            {
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    restorePath = folderBrowser.SelectedPath;
                    RestoreDatabase(databaseName, restorePath);
                }
                else
                {
                    MessageBox.Show("Restore operation was cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void mni_quyenloi_Click(object sender, EventArgs e)
        {
            this.Hide();
            QuyenLoi ql = new QuyenLoi();
            ql.FormClosed += (s, args) => this.Show();
            ql.ShowDialog();
        }

        private void mni_lichsugd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaction transaction = new Transaction();
            transaction.FormClosed += (s, args) => this.Show();
            transaction.ShowDialog();
        }

        private void mni_ycbt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Claim claim = new Claim();
            claim.FormClosed += (s, args) => this.Show();
            claim.ShowDialog();
        }
    }
}
