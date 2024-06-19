namespace RLCM_Staff_Interface
{
    partial class GenerateCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateCode));
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TB_ResultCode = new System.Windows.Forms.TextBox();
            this.btn_Update_To_Server = new System.Windows.Forms.Button();
            this.NUP_Data = new System.Windows.Forms.NumericUpDown();
            this.Amount = new System.Windows.Forms.Label();
            this.RB_OTU = new System.Windows.Forms.RadioButton();
            this.RB_MU = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_sql_send = new System.Windows.Forms.Button();
            this.tb_item_name = new System.Windows.Forms.TextBox();
            this.tb_item_id = new System.Windows.Forms.TextBox();
            this.tb_item_days = new System.Windows.Forms.TextBox();
            this.RB_Ingame_Item = new System.Windows.Forms.RadioButton();
            this.RB_Web_Item = new System.Windows.Forms.RadioButton();
            this.RB_Ingame_Eco = new System.Windows.Forms.RadioButton();
            this.RB_Web_Eco = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_codetype_info = new System.Windows.Forms.Button();
            this.gb_amount = new System.Windows.Forms.GroupBox();
            this.btn_info_code = new System.Windows.Forms.Button();
            this.btn_info_code_name = new System.Windows.Forms.Button();
            this.btn_info_code_days = new System.Windows.Forms.Button();
            this.btn_info_code_id = new System.Windows.Forms.Button();
            this.btn_info_code_catagory = new System.Windows.Forms.Button();
            this.btn_info_code_alert = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_alert = new System.Windows.Forms.TextBox();
            this.rtb_seq_result = new System.Windows.Forms.RichTextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.gb_Catagory = new System.Windows.Forms.GroupBox();
            this.rb_website = new System.Windows.Forms.RadioButton();
            this.rb_item = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_daysecond = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_Data)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gb_amount.SuspendLayout();
            this.gb_Catagory.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(743, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Generate Code";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_ResultCode
            // 
            this.TB_ResultCode.Location = new System.Drawing.Point(59, 51);
            this.TB_ResultCode.Name = "TB_ResultCode";
            this.TB_ResultCode.Size = new System.Drawing.Size(235, 20);
            this.TB_ResultCode.TabIndex = 3;
            // 
            // btn_Update_To_Server
            // 
            this.btn_Update_To_Server.Location = new System.Drawing.Point(945, 478);
            this.btn_Update_To_Server.Name = "btn_Update_To_Server";
            this.btn_Update_To_Server.Size = new System.Drawing.Size(95, 37);
            this.btn_Update_To_Server.TabIndex = 4;
            this.btn_Update_To_Server.Text = "Update To Server";
            this.btn_Update_To_Server.UseVisualStyleBackColor = true;
            this.btn_Update_To_Server.Click += new System.EventHandler(this.btn_Update_To_Server_Click);
            // 
            // NUP_Data
            // 
            this.NUP_Data.Location = new System.Drawing.Point(86, 66);
            this.NUP_Data.Name = "NUP_Data";
            this.NUP_Data.Size = new System.Drawing.Size(95, 20);
            this.NUP_Data.TabIndex = 7;
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Location = new System.Drawing.Point(37, 68);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(43, 13);
            this.Amount.TabIndex = 8;
            this.Amount.Text = "Amount";
            this.Amount.Click += new System.EventHandler(this.Amount_Click);
            // 
            // RB_OTU
            // 
            this.RB_OTU.AutoSize = true;
            this.RB_OTU.Location = new System.Drawing.Point(6, 20);
            this.RB_OTU.Name = "RB_OTU";
            this.RB_OTU.Size = new System.Drawing.Size(99, 17);
            this.RB_OTU.TabIndex = 9;
            this.RB_OTU.TabStop = true;
            this.RB_OTU.Text = "Once Time Use";
            this.RB_OTU.UseVisualStyleBackColor = true;
            this.RB_OTU.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RB_MU
            // 
            this.RB_MU.AutoSize = true;
            this.RB_MU.Location = new System.Drawing.Point(5, 43);
            this.RB_MU.Name = "RB_MU";
            this.RB_MU.Size = new System.Drawing.Size(83, 17);
            this.RB_MU.TabIndex = 10;
            this.RB_MU.TabStop = true;
            this.RB_MU.Text = "Multiple Use";
            this.RB_MU.UseVisualStyleBackColor = true;
            this.RB_MU.CheckedChanged += new System.EventHandler(this.RB_MU_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(343, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 439);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Table";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(685, 414);
            this.dataGridView1.TabIndex = 40;
            // 
            // btn_sql_send
            // 
            this.btn_sql_send.Location = new System.Drawing.Point(844, 478);
            this.btn_sql_send.Name = "btn_sql_send";
            this.btn_sql_send.Size = new System.Drawing.Size(95, 37);
            this.btn_sql_send.TabIndex = 0;
            this.btn_sql_send.Text = "Edit SQL";
            this.btn_sql_send.UseVisualStyleBackColor = true;
            this.btn_sql_send.Click += new System.EventHandler(this.btn_sql_send_Click);
            // 
            // tb_item_name
            // 
            this.tb_item_name.Location = new System.Drawing.Point(59, 77);
            this.tb_item_name.Name = "tb_item_name";
            this.tb_item_name.Size = new System.Drawing.Size(235, 20);
            this.tb_item_name.TabIndex = 12;
            this.tb_item_name.TextChanged += new System.EventHandler(this.tb_item_id_TextChanged);
            // 
            // tb_item_id
            // 
            this.tb_item_id.Location = new System.Drawing.Point(59, 103);
            this.tb_item_id.Name = "tb_item_id";
            this.tb_item_id.Size = new System.Drawing.Size(235, 20);
            this.tb_item_id.TabIndex = 13;
            // 
            // tb_item_days
            // 
            this.tb_item_days.Location = new System.Drawing.Point(59, 129);
            this.tb_item_days.Name = "tb_item_days";
            this.tb_item_days.Size = new System.Drawing.Size(235, 20);
            this.tb_item_days.TabIndex = 14;
            // 
            // RB_Ingame_Item
            // 
            this.RB_Ingame_Item.AutoSize = true;
            this.RB_Ingame_Item.Location = new System.Drawing.Point(13, 19);
            this.RB_Ingame_Item.Name = "RB_Ingame_Item";
            this.RB_Ingame_Item.Size = new System.Drawing.Size(88, 17);
            this.RB_Ingame_Item.TabIndex = 16;
            this.RB_Ingame_Item.TabStop = true;
            this.RB_Ingame_Item.Text = "Ingame Items";
            this.RB_Ingame_Item.UseVisualStyleBackColor = true;
            // 
            // RB_Web_Item
            // 
            this.RB_Web_Item.AutoSize = true;
            this.RB_Web_Item.Location = new System.Drawing.Point(124, 19);
            this.RB_Web_Item.Name = "RB_Web_Item";
            this.RB_Web_Item.Size = new System.Drawing.Size(76, 17);
            this.RB_Web_Item.TabIndex = 17;
            this.RB_Web_Item.TabStop = true;
            this.RB_Web_Item.Text = "Web Items";
            this.RB_Web_Item.UseVisualStyleBackColor = true;
            // 
            // RB_Ingame_Eco
            // 
            this.RB_Ingame_Eco.AutoSize = true;
            this.RB_Ingame_Eco.Location = new System.Drawing.Point(11, 42);
            this.RB_Ingame_Eco.Name = "RB_Ingame_Eco";
            this.RB_Ingame_Eco.Size = new System.Drawing.Size(107, 17);
            this.RB_Ingame_Eco.TabIndex = 18;
            this.RB_Ingame_Eco.TabStop = true;
            this.RB_Ingame_Eco.Text = "Ingame Economy";
            this.RB_Ingame_Eco.UseVisualStyleBackColor = true;
            // 
            // RB_Web_Eco
            // 
            this.RB_Web_Eco.AutoSize = true;
            this.RB_Web_Eco.Location = new System.Drawing.Point(124, 42);
            this.RB_Web_Eco.Name = "RB_Web_Eco";
            this.RB_Web_Eco.Size = new System.Drawing.Size(95, 17);
            this.RB_Web_Eco.TabIndex = 19;
            this.RB_Web_Eco.TabStop = true;
            this.RB_Web_Eco.Text = "Web Economy";
            this.RB_Web_Eco.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Item ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Days";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_codetype_info);
            this.groupBox2.Controls.Add(this.RB_Ingame_Item);
            this.groupBox2.Controls.Add(this.RB_Web_Item);
            this.groupBox2.Controls.Add(this.RB_Ingame_Eco);
            this.groupBox2.Controls.Add(this.RB_Web_Eco);
            this.groupBox2.Location = new System.Drawing.Point(7, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 68);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Code_Type";
            // 
            // btn_codetype_info
            // 
            this.btn_codetype_info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_codetype_info.BackgroundImage")));
            this.btn_codetype_info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_codetype_info.Location = new System.Drawing.Point(294, 11);
            this.btn_codetype_info.Name = "btn_codetype_info";
            this.btn_codetype_info.Size = new System.Drawing.Size(30, 25);
            this.btn_codetype_info.TabIndex = 55;
            this.btn_codetype_info.UseVisualStyleBackColor = true;
            this.btn_codetype_info.Click += new System.EventHandler(this.btn_codetype_info_Click);
            // 
            // gb_amount
            // 
            this.gb_amount.Controls.Add(this.RB_OTU);
            this.gb_amount.Controls.Add(this.RB_MU);
            this.gb_amount.Controls.Add(this.NUP_Data);
            this.gb_amount.Controls.Add(this.Amount);
            this.gb_amount.Location = new System.Drawing.Point(150, 369);
            this.gb_amount.Name = "gb_amount";
            this.gb_amount.Size = new System.Drawing.Size(187, 100);
            this.gb_amount.TabIndex = 25;
            this.gb_amount.TabStop = false;
            this.gb_amount.Text = "Amount Type";
            // 
            // btn_info_code
            // 
            this.btn_info_code.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_code.BackgroundImage")));
            this.btn_info_code.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_info_code.Location = new System.Drawing.Point(294, 13);
            this.btn_info_code.Name = "btn_info_code";
            this.btn_info_code.Size = new System.Drawing.Size(30, 25);
            this.btn_info_code.TabIndex = 26;
            this.btn_info_code.UseVisualStyleBackColor = true;
            this.btn_info_code.Click += new System.EventHandler(this.btn_info_code_Click);
            // 
            // btn_info_code_name
            // 
            this.btn_info_code_name.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_code_name.BackgroundImage")));
            this.btn_info_code_name.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_info_code_name.Location = new System.Drawing.Point(294, 40);
            this.btn_info_code_name.Name = "btn_info_code_name";
            this.btn_info_code_name.Size = new System.Drawing.Size(30, 25);
            this.btn_info_code_name.TabIndex = 27;
            this.btn_info_code_name.UseVisualStyleBackColor = true;
            this.btn_info_code_name.Click += new System.EventHandler(this.btn_info_code_name_Click);
            // 
            // btn_info_code_days
            // 
            this.btn_info_code_days.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_code_days.BackgroundImage")));
            this.btn_info_code_days.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_info_code_days.Location = new System.Drawing.Point(294, 92);
            this.btn_info_code_days.Name = "btn_info_code_days";
            this.btn_info_code_days.Size = new System.Drawing.Size(30, 25);
            this.btn_info_code_days.TabIndex = 29;
            this.btn_info_code_days.UseVisualStyleBackColor = true;
            this.btn_info_code_days.Click += new System.EventHandler(this.btn_info_code_days_Click);
            // 
            // btn_info_code_id
            // 
            this.btn_info_code_id.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_code_id.BackgroundImage")));
            this.btn_info_code_id.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_info_code_id.Location = new System.Drawing.Point(294, 66);
            this.btn_info_code_id.Name = "btn_info_code_id";
            this.btn_info_code_id.Size = new System.Drawing.Size(30, 25);
            this.btn_info_code_id.TabIndex = 28;
            this.btn_info_code_id.UseVisualStyleBackColor = true;
            this.btn_info_code_id.Click += new System.EventHandler(this.btn_info_code_id_Click);
            // 
            // btn_info_code_catagory
            // 
            this.btn_info_code_catagory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_code_catagory.BackgroundImage")));
            this.btn_info_code_catagory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_info_code_catagory.Location = new System.Drawing.Point(294, 11);
            this.btn_info_code_catagory.Name = "btn_info_code_catagory";
            this.btn_info_code_catagory.Size = new System.Drawing.Size(30, 25);
            this.btn_info_code_catagory.TabIndex = 30;
            this.btn_info_code_catagory.UseVisualStyleBackColor = true;
            this.btn_info_code_catagory.Click += new System.EventHandler(this.btn_info_code_catagory_Click);
            // 
            // btn_info_code_alert
            // 
            this.btn_info_code_alert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_info_code_alert.BackgroundImage")));
            this.btn_info_code_alert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_info_code_alert.Location = new System.Drawing.Point(294, 139);
            this.btn_info_code_alert.Name = "btn_info_code_alert";
            this.btn_info_code_alert.Size = new System.Drawing.Size(30, 25);
            this.btn_info_code_alert.TabIndex = 33;
            this.btn_info_code_alert.UseVisualStyleBackColor = true;
            this.btn_info_code_alert.Click += new System.EventHandler(this.btn_info_code_alert_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Alert";
            // 
            // tb_alert
            // 
            this.tb_alert.Location = new System.Drawing.Point(52, 144);
            this.tb_alert.Name = "tb_alert";
            this.tb_alert.Size = new System.Drawing.Size(235, 20);
            this.tb_alert.TabIndex = 31;
            // 
            // rtb_seq_result
            // 
            this.rtb_seq_result.Location = new System.Drawing.Point(7, 369);
            this.rtb_seq_result.Name = "rtb_seq_result";
            this.rtb_seq_result.Size = new System.Drawing.Size(137, 100);
            this.rtb_seq_result.TabIndex = 49;
            this.rtb_seq_result.Text = "";
            this.rtb_seq_result.TextChanged += new System.EventHandler(this.rtb_seq_result_TextChanged);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Location = new System.Drawing.Point(1010, 3);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(31, 23);
            this.btn_exit.TabIndex = 50;
            this.btn_exit.Text = "X";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.Location = new System.Drawing.Point(971, 3);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(32, 23);
            this.btn_minimize.TabIndex = 51;
            this.btn_minimize.Text = "-";
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // gb_Catagory
            // 
            this.gb_Catagory.Controls.Add(this.rb_website);
            this.gb_Catagory.Controls.Add(this.rb_item);
            this.gb_Catagory.Controls.Add(this.btn_info_code_catagory);
            this.gb_Catagory.Location = new System.Drawing.Point(7, 243);
            this.gb_Catagory.Name = "gb_Catagory";
            this.gb_Catagory.Size = new System.Drawing.Size(330, 46);
            this.gb_Catagory.TabIndex = 52;
            this.gb_Catagory.TabStop = false;
            this.gb_Catagory.Text = "Category";
            // 
            // rb_website
            // 
            this.rb_website.AutoSize = true;
            this.rb_website.Location = new System.Drawing.Point(64, 19);
            this.rb_website.Name = "rb_website";
            this.rb_website.Size = new System.Drawing.Size(64, 17);
            this.rb_website.TabIndex = 1;
            this.rb_website.TabStop = true;
            this.rb_website.Text = "Website";
            this.rb_website.UseVisualStyleBackColor = true;
            // 
            // rb_item
            // 
            this.rb_item.AutoSize = true;
            this.rb_item.Location = new System.Drawing.Point(8, 19);
            this.rb_item.Name = "rb_item";
            this.rb_item.Size = new System.Drawing.Size(50, 17);
            this.rb_item.TabIndex = 0;
            this.rb_item.TabStop = true;
            this.rb_item.Text = "Items";
            this.rb_item.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_daysecond);
            this.groupBox3.Controls.Add(this.btn_info_code_name);
            this.groupBox3.Controls.Add(this.btn_info_code);
            this.groupBox3.Controls.Add(this.btn_info_code_id);
            this.groupBox3.Controls.Add(this.btn_info_code_days);
            this.groupBox3.Controls.Add(this.btn_info_code_alert);
            this.groupBox3.Controls.Add(this.tb_alert);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(7, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 203);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generate Code System For Admin";
            // 
            // cb_daysecond
            // 
            this.cb_daysecond.AutoSize = true;
            this.cb_daysecond.Location = new System.Drawing.Point(52, 121);
            this.cb_daysecond.Name = "cb_daysecond";
            this.cb_daysecond.Size = new System.Drawing.Size(106, 17);
            this.cb_daysecond.TabIndex = 55;
            this.cb_daysecond.Text = "Days To Second";
            this.cb_daysecond.UseVisualStyleBackColor = true;
            this.cb_daysecond.CheckedChanged += new System.EventHandler(this.CB_DaySecond_CheckedChanged_1);
            // 
            // GenerateCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 527);
            this.Controls.Add(this.gb_Catagory);
            this.Controls.Add(this.btn_minimize);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_Update_To_Server);
            this.Controls.Add(this.btn_sql_send);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtb_seq_result);
            this.Controls.Add(this.gb_amount);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_item_days);
            this.Controls.Add(this.tb_item_id);
            this.Controls.Add(this.tb_item_name);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TB_ResultCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerateCode";
            this.Text = "GenerateCode";
            this.Load += new System.EventHandler(this.GenerateCode_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GenerateCode_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.NUP_Data)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gb_amount.ResumeLayout(false);
            this.gb_amount.PerformLayout();
            this.gb_Catagory.ResumeLayout(false);
            this.gb_Catagory.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TB_ResultCode;
        private System.Windows.Forms.Button btn_Update_To_Server;
        private System.Windows.Forms.NumericUpDown NUP_Data;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.RadioButton RB_OTU;
        private System.Windows.Forms.RadioButton RB_MU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_sql_send;
        private System.Windows.Forms.TextBox tb_item_name;
        private System.Windows.Forms.TextBox tb_item_id;
        private System.Windows.Forms.TextBox tb_item_days;
        private System.Windows.Forms.RadioButton RB_Ingame_Item;
        private System.Windows.Forms.RadioButton RB_Web_Item;
        private System.Windows.Forms.RadioButton RB_Ingame_Eco;
        private System.Windows.Forms.RadioButton RB_Web_Eco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gb_amount;
        private System.Windows.Forms.Button btn_info_code;
        private System.Windows.Forms.Button btn_info_code_name;
        private System.Windows.Forms.Button btn_info_code_days;
        private System.Windows.Forms.Button btn_info_code_id;
        private System.Windows.Forms.Button btn_info_code_catagory;
        private System.Windows.Forms.Button btn_info_code_alert;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_alert;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox rtb_seq_result;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.GroupBox gb_Catagory;
        private System.Windows.Forms.RadioButton rb_item;
        private System.Windows.Forms.RadioButton rb_website;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_codetype_info;
        private System.Windows.Forms.CheckBox cb_daysecond;
    }
}