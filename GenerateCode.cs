using Discord;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RLCM_Staff_Interface
{
    public partial class GenerateCode : Form
    {

        public string connectionString;
        public DateTime lastUpdateTime; //ตัวแปร เวลา
        // Import ฟังก์ชัน ReleaseCapture และ SendMessage จาก user32.dll
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public GenerateCode(string connString)
        {
             InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += new MouseEventHandler(GenerateCode_MouseDown);
            connectionString = connString;
        }
        private void GenerateCode_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            }
        }

        private void Amount_Click(object sender, EventArgs e)
        {

        }

        private void btn_Update_To_Server_Click(object sender, EventArgs e)
        {
            // ตรวจสอบ Item ID & Item Day ว่ามีข้อมูลอยู่หรือไม่ในช่อง Textbox
            if (string.IsNullOrEmpty(tb_item_id.Text)){MessageBox.Show("กรุณากรอก Item ID !", "UI_MANAGE");return;}
            if (string.IsNullOrEmpty(tb_item_days.Text)){MessageBox.Show("กรุณากรอก Item Day !", "UI_MANAGE");return;}
            
            // เรียกนำเข้าข้อมูลจาก TextBox
            string codeName = TB_ResultCode.Text;
            int itemId = int.Parse(tb_item_id.Text);
            string itemName = tb_item_name.Text;
            int itemDay = int.Parse(tb_item_days.Text);
            int itemCategory = CategorySelect();
            int typeCode = TypecodeSelect();
            if (string.IsNullOrEmpty(codeName)  || string.IsNullOrEmpty(itemName))
            {
                MessageBox.Show("กรุณากรอกข้อมูลลงในช่องว่างให้ครบทั้งหมด", "UI_MANAGE");
                return;
            }
            
            else
            {
               
                if (typeCode == 0)
                {
                    MessageBox.Show("กรุณาเลือกประเภทของ โค้ด","UI_MANAGE");
                    return;
                }
                if (itemCategory == 0)
                {
                    MessageBox.Show("กรุณาเลือกประเภทของ หมวดหมู่", "UI_MANAGE");
                    return;
                }
                // Get countNumber from NumericUpDown
                int countNumber = (int)NUP_Data.Value;

                string codeAlert = tb_alert.Text;

                // Insert data into item_code and item_code_log tables
                InsertData(codeName, itemId, itemName, itemDay, itemCategory, typeCode, countNumber, codeAlert);
                
            }
        }
        public int TypecodeSelect()
        {
            if (RB_Ingame_Item.Checked)
                return 1;
            else if (RB_Web_Item.Checked)
                return 2;
            else if (RB_Ingame_Eco.Checked)
                return 3;
            else if (RB_Web_Eco.Checked)
                return 4;
            else
                return 0;        
        }
        public int CategorySelect()
        {
            if (rb_website.Checked)
                return 1;
            else if (rb_item.Checked)
                return 2;
            else
                return 0;
        }
        public void alert(string message)
        {
            MessageBox.Show(message);
        }
        private void GenerateCode_Load(object sender, EventArgs e)
        {
            SQL_Connect();
            NUP_Data.Hide();
            Amount.Hide();
            RB_OTU.Checked = true;
            
        }
        public void SQL_Connect()
        {
            try
            {
                // สร้างการเชื่อมต่อกับฐานข้อมูล PostgreSQL
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();
                    //MessageBox.Show("Connected to Database Successfully!"); //ไว้สำหรับตรวจสอบการเชื่อมต่อ ว่าสำเร็จหรือไม่

                    // สร้างคำสั่งเพื่อเลือกข้อมูลจากตาราง
                    using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM item_code", conn))
                    {
                        // สร้างอะแดปเตอร์ข้อมูล
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd))
                        {
                            // กรอก DataTable ด้วยผลลัพธ์
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            // ตรวจสอบว่ามีข้อมูลอยู่ใน DataTable หรือไม่
                            /*if (dt.Rows.Count > 0)
                            {
                                MessageBox.Show("ดึงข้อมูลสำเร็จ!");
                            }
                            else
                            {
                                MessageBox.Show("ไม่พบข้อมูล!");
                            }*/

                            // เชื่อม DataTable กับ DataGridView
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"เกิดข้อผิดพลาด: {ex.Message}");
            }
        }
        private void InsertData(string codeName, int itemId, string itemName, int itemDay, int itemCategory, int typeCode, int countNumber, string codeAlert)
        {
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    // Check for duplicate code_name
                    using (NpgsqlCommand checkCmd = new NpgsqlCommand("SELECT COUNT(*) FROM item_code WHERE code_name = @codeName", conn))
                    {
                        checkCmd.Parameters.AddWithValue("codeName", codeName);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (count > 0)
                        {
                            MessageBox.Show("รหัสโค้ดนี้มีอยู่ในระบบแล้ว กรุณากรอกรหัสโค้ดใหม่", "UI_MANAGE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    using (NpgsqlCommand cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;

                        // Insert into item_code
                        cmd.CommandText = "INSERT INTO item_code (code_name, item_id, item_name, item_day, item_category, type_code, count_number, code_alert) VALUES (@codeName, @itemId, @itemName, @itemDay, @itemCategory, @typeCode, @countNumber, @codeAlert)";
                        cmd.Parameters.AddWithValue("codeName", codeName);
                        cmd.Parameters.AddWithValue("itemId", itemId);
                        cmd.Parameters.AddWithValue("itemName", itemName);
                        cmd.Parameters.AddWithValue("itemDay", itemDay);
                        cmd.Parameters.AddWithValue("itemCategory", itemCategory);
                        cmd.Parameters.AddWithValue("typeCode", typeCode);
                        cmd.Parameters.AddWithValue("countNumber", countNumber);
                        cmd.Parameters.AddWithValue("codeAlert", codeAlert);
                        cmd.ExecuteNonQuery();

                        // Insert into item_code_log
                        cmd.CommandText = "INSERT INTO item_code_log (code_name, item_id, item_name, item_day, item_category, type_code, count_number, code_alert, log_date) VALUES (@codeName, @itemId, @itemName, @itemDay, @itemCategory, @typeCode, @countNumber, @codeAlert, @logDate)";
                        cmd.Parameters.AddWithValue("logDate", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }
                }
                //string HookDC = "Discord Hook API Token";
                //send_message_discord(HookDC,TB_ResultCode.Text,"Admin SQL Using Alert System"); //ส่งข้อมูลแจ้งเตือนถึงการใช้งานโปรแกรมหลังบ้านไปยังผู้ดูแลระบบ เพื่อเก็บประวัติการใช้งานผ่าน Discord Webhook
                MessageBox.Show("อัพเดทข้อมูลเสร็จสิ้น !");
                SQL_Connect(); // เรียกฟังก์ชันรีเฟรชข้อมูลใน DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show($"เกิดข้อผิดพลาด: {ex.Message}");
            }
        }
        private void CB_Data_Int_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public static void send_message_discord(string url, string message, string botname)
        {
            ConnectionByte.post(url, new System.Collections.Specialized.NameValueCollection()
            {
                {
                    "username",
                    botname
                },
                {
                    "content",
                    message
                }
            });
        }

        private void RB_MU_CheckedChanged(object sender, EventArgs e)
        {
            if (RB_MU.Checked == true)
            {
                NUP_Data.Show();
                gb_amount.Size.Width.CompareTo(66);
                Amount.Show();
            }
            else if (RB_MU.Checked == false)
            {
                NUP_Data.Hide();
                Amount.Hide();
            }
            else
            {
                MessageBox.Show("Something went wrong !", "UI_MANAGE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gen_Code();
        }
        public void Gen_Code()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var sc = new char[4];
            var sc1 = new char[4];
            var sc2 = new char[4];
            var sc3 = new char[4];
            var sc4 = new char[4];
            var random = new Random();
            

            for (int i = 0; i < sc.Length; i++)
            {
                sc[i] = chars[random.Next(chars.Length)];
                sc1[i] = chars[random.Next(chars.Length)];
                sc2[i] = chars[random.Next(chars.Length)];
                sc3[i] = chars[random.Next(chars.Length)];
                sc4[i] = chars[random.Next(chars.Length)];
            }
            var Stb32 = new String(sc);
            var Stb64 = new String(sc1);
            var Stb128 = new String(sc2);
            var Stb256 = new String(sc3);
            var Stb512 = new String(sc4);
            TB_ResultCode.Text = Stb32 + "-" + Stb64 + "-" + Stb128 + "-" + Stb256 + "-" + Stb512;
        }
        public void Gen_Code_C2()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            var sc = new char[2];
            var sc1 = new char[2];
            var random = new Random();

            for (long i = 0; i < sc.Length; i++)
            {
                sc[i] = chars[random.Next(chars.Length)];
                sc1[i] = chars[random.Next(chars.Length)];
            }

            var Stb32 = new String(sc);
            var Stb64 = new String(sc1);

            TB_ResultCode.Text = Stb32 + "_" + Stb64;
        }
        
        
        private void btn_apply_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Action will apply your Generate Code and send it to database", "Generate User Code",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            string textToDisplay = "\u202d\u200c\u206c\u206f\u206d\u206e\u202a\u200c\u202e\u202c\u200e\u202b\u206c\u206d\u206b\u206a\u200f\u202c\u206b\u200f\u206b\u202c\u202a\u202e\u200f\u200e\u206c\u200e\u202e\u202c\u200d\u200c\u200b\u200d\u202d\u200c\u202d\u206b\u206c\u202d\u202e";
            rtb_seq_result.Text = textToDisplay;
            //ฟีเจอร์ในอนาคต ไว้มาอัพเดทใหม่อีกทีนะ !
        }

        private void btn_sql_send_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("คุณกำลังจะออกจากโปรแกรมเพื่อเข้าสู่หน้าต่างตั้งค่าฐานข้อมูล \r\nต้องการดำเนินการต่อหรือไม่ ?", "xorbit256", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes){
                SQL_Check SQL_FORM = new SQL_Check();
                SQL_FORM.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No){} //ไม่ทำอะไร
        }

        private void btn_info_code_Click(object sender, EventArgs e)
        {
            MessageBox.Show("code_infomation"); //แสดงข้อมูลวิธีการใช้งาน
        }

        private void btn_info_code_name_Click(object sender, EventArgs e)
        {
            MessageBox.Show("name_send");//แสดงข้อมูลวิธีการใช้งาน
        }

        private void btn_info_code_id_Click(object sender, EventArgs e)
        {
            MessageBox.Show("id_send");//แสดงข้อมูลวิธีการใช้งาน
        }

        private void btn_info_code_days_Click(object sender, EventArgs e)
        {
            MessageBox.Show("days_send");//แสดงข้อมูลวิธีการใช้งาน
        }

        private void btn_info_code_catagory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("catagory_send");//แสดงข้อมูลวิธีการใช้งาน
        }

        private void btn_info_code_alert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("alert_send");//แสดงข้อมูลวิธีการใช้งาน
        }
        private void btn_codetype_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("alert_send");//แสดงข้อมูลวิธีการใช้งาน
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tb_item_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void rtb_stringout_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("คุณกำลังจะออกจากโปรแกรม \r\nต้องการดำเนินการต่อหรือไม่ ?", "xorbit256", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();

            }
            else if (dialogResult == DialogResult.No)
            {
                //ไม่ทำอะไร
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //ย่อโปรแกรม
        }

        private void rtb_seq_result_TextChanged(object sender, EventArgs e)
        {
            //ฟีเจอร์ในอนาคต
        }

        
    }
}
