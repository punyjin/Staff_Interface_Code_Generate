﻿namespace RLCM_Staff_Interface
{
    partial class SQL_Check
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQL_Check));
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.lb_host = new System.Windows.Forms.Label();
            this.lb_database = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.PB1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(140, 274);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(114, 61);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(64, 170);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(307, 20);
            this.txtHost.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(64, 222);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(307, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(64, 248);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(307, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(64, 196);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(307, 20);
            this.txtDatabase.TabIndex = 4;
            // 
            // lb_host
            // 
            this.lb_host.AutoSize = true;
            this.lb_host.Location = new System.Drawing.Point(29, 173);
            this.lb_host.Name = "lb_host";
            this.lb_host.Size = new System.Drawing.Size(29, 13);
            this.lb_host.TabIndex = 5;
            this.lb_host.Text = "Host";
            // 
            // lb_database
            // 
            this.lb_database.AutoSize = true;
            this.lb_database.Location = new System.Drawing.Point(5, 203);
            this.lb_database.Name = "lb_database";
            this.lb_database.Size = new System.Drawing.Size(53, 13);
            this.lb_database.TabIndex = 6;
            this.lb_database.Text = "Database";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Location = new System.Drawing.Point(3, 229);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(55, 13);
            this.lb_username.TabIndex = 7;
            this.lb_username.Text = "Username";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Location = new System.Drawing.Point(5, 255);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(53, 13);
            this.lb_password.TabIndex = 8;
            this.lb_password.Text = "Password";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(354, 251);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PB1
            // 
            this.PB1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PB1.BackgroundImage")));
            this.PB1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB1.Location = new System.Drawing.Point(12, 12);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(359, 145);
            this.PB1.TabIndex = 9;
            this.PB1.TabStop = false;
            // 
            // SQL_Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 340);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.lb_database);
            this.Controls.Add(this.lb_host);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.btnConnect);
            this.Name = "SQL_Check";
            this.Text = "SQL Check";
            this.Load += new System.EventHandler(this.SQL_Check_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label lb_host;
        private System.Windows.Forms.Label lb_database;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.PictureBox PB1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
