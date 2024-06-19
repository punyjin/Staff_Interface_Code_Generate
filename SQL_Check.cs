using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RLCM_Staff_Interface
{
    public partial class SQL_Check : Form
    {
        public string updateUrl = "http://localhost/latest_version.txt"; // URL ไฟล์เวอร์ชั่น ข้างในไฟล์จะเป็น 1.0.0.0 แล้วแต่เวอร์ชั่น ใน Assembly
        public string URL_Download = "http://localhost/download/RLCM_Staff_Interface.exe"; //ลิ้งค์ไฟล์ Build.exe
        public SQL_Check()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += new MouseEventHandler(SQL_Check_MouseDown);
        }
        // Import ฟังก์ชัน ReleaseCapture และ SendMessage จาก user32.dll
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private void SQL_Check_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            }
        }
        private void SQL_Check_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = 'X';
            if (Properties.Settings.Default.IsFirstTime == true) //เมื่อเข้าสู่โปรแกรมครั้งแรก
            {
                txtHost.Text = "localhost";
            }
            else //หากไม่ จะเรียกใช้ข้อความที่เซฟไว้
            {
                txtHost.Text = Properties.Settings.Default.Host;
                txtDatabase.Text = Properties.Settings.Default.Database;
                txtUsername.Text = Properties.Settings.Default.Username;
                txtPassword.Text = Properties.Settings.Default.Password;
            }
            CheckForUpdatesAuto();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            // เรียกเก็บข้อมูลจาก Textbox
            string host = txtHost.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string database = txtDatabase.Text;
            
            //ตรวจสอบข้อมูลนำเข้า
            if (string.IsNullOrEmpty(host) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(database))
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ","SQL Server Check");
                return;
            }
            Properties.Settings.Default.Host = txtHost.Text;
            Properties.Settings.Default.Database = txtDatabase.Text;
            Properties.Settings.Default.Username = txtUsername.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.IsFirstTime = false;
            Properties.Settings.Default.Save();
            // โครงสร้างการเชื่อมต่อ Database
            string connectionString = $"Host={host};Username={username};Password={password};Database={database}";

            // เปิด MainForm และส่ง String ของข้อมูลการตั้งค่า
            GenerateCode mainForm = new GenerateCode(connectionString);
            mainForm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else if (checkBox1.Checked == false)
            {
                txtPassword.PasswordChar = 'X';
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblCheckForUpdates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CheckForUpdatesButton();
        }
        private async Task CheckForUpdatesButton()
        {
            string currentVersion = Application.ProductVersion;
            string latestVersion = string.Empty;
            

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    latestVersion = await client.GetStringAsync(updateUrl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด : " + ex.Message, "Update Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (currentVersion != latestVersion.Trim())
            {
                DialogResult result = MessageBox.Show($"มีเวอร์ชั่นใหม่ ({latestVersion.Trim()}) \nคุณต้องการดาวน์โหลดตอนนี้เลยมั้ย ?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    // เปิด URL อัปเดตในเว็บเบราว์เซอร์เริ่มต้น
                    System.Diagnostics.Process.Start($"{URL_Download}");
                }
            }
            else
            {
                MessageBox.Show("คุณกำลังใช้เวอร์ชันล่าสุดแล้ว !", "Update Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private async Task CheckForUpdatesAuto()
        {
            string currentVersion = Application.ProductVersion;
            string latestVersion = string.Empty;
            

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    latestVersion = await client.GetStringAsync(updateUrl);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("เกิดข้อผิดพลาด : " + ex.Message, "Update Check", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (currentVersion != latestVersion.Trim())
            {
                DialogResult result = MessageBox.Show($"มีเวอร์ชั่นใหม่ ({latestVersion.Trim()}) \nคุณต้องการดาวน์โหลดตอนนี้เลยมั้ย ?", "Update Available", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    // เปิด URL อัปเดตในเว็บเบราว์เซอร์เริ่มต้น
                    System.Diagnostics.Process.Start($"{URL_Download}");
                }
            }
            
        }
    }
}
