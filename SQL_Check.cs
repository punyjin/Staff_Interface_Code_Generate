﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RLCM_Staff_Interface
{
    public partial class SQL_Check : Form
    {
        public SQL_Check()
        {
            InitializeComponent();
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
    }
}
