using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Setting
{
    public partial class AdminSetup : Form
    {
        Model.TransportManagementEntities db;
        public AdminSetup()
        {
            InitializeComponent();
            db = DB.Instance;
            panel_main.Top = (this.Height - panel_main.Height) / 2;
            panel_main.Left = (this.Width - panel_main.Width) / 2;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_Key.Text.Trim() == "" || textBox_password.Text.Trim() == "" || textBox_repassword.Text.Trim() == "" || textBox_username.Text.Trim() == "")
            {
                CustomControls.Alert.show("Admin Setup", "Please Fill All Fields", 3000);
                return;
            }
           
            db.admins.Add(new Model.admin()
            {
                updated_at = DateTime.Now,
                created_at = DateTime.Now,
                username = "Admin",
                password = CustomControls.Encrypt.EncryptString(textBox_password.Text, "need12345")
            });
            db.SaveChanges();
            this.Close();

        }

        private void AdminSetup_Resize(object sender, EventArgs e)
        {
            panel_main.Top = (this.Height - panel_main.Height) / 2;
            panel_main.Left = (this.Width - panel_main.Width) / 2;
        }
    }
}
