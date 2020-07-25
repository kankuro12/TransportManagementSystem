using Microsoft.Win32;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TransportManagementSystem.Setting
{
    public partial class DatabaseSetup : Form
    {
        public DatabaseSetup()
        {
            InitializeComponent();
        }

        private void DatabaseSetup_Resize(object sender, EventArgs e)
        {
            panel_main.Top = (this.Height - panel_main.Height) / 2;
            panel_main.Left = (this.Width - panel_main.Width) / 2;
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_save_Click(object sender, EventArgs e)
        { 
            if (textBox_database.Text.Trim() == "" || textBox_password.Text.Trim() == "" || textBox_server.Text.Trim() == "" || textBox_username.Text.Trim() == "")
            {
                CustomControls.Alert.show("Database Setup", "Please Fill All Fields", 3000);
                return;
            }

            SqlConnectionStringBuilder constr = new SqlConnectionStringBuilder()
            {
                UserID = textBox_username.Text.Trim(),
                Password = textBox_password.Text.Trim(),
                DataSource = textBox_server.Text.Trim(),
                InitialCatalog = textBox_database.Text.Trim()
            };
            try
            {
                using (SqlConnection con = new SqlConnection(constr.ToString()))
                {
                    con.Open();
                }
                if (ManageKeys.Manage.checkForDatabase())
                {
                    if (CustomControls.Comformation.ShowModal("Database Setup", "Database Already setup, Do you want to Add New Database Info?") == DialogResult.No)
                    {
                        TransportManagementSystem.Properties.Settings.Default.isdatabasesetup = true;
                        TransportManagementSystem.Properties.Settings.Default.Save();

                    }
                    else
                    {
                        RegistryKey reg = Registry.CurrentUser.OpenSubKey(INFO.guid + "\\database", true);
                        reg.SetValue("server", constr.DataSource);
                        reg.SetValue("database", constr.InitialCatalog);
                        reg.SetValue("username", constr.UserID);
#if DEBUG
                        reg.SetValue("password", CustomControls.Encrypt.EncryptString(constr.Password, "Kankuro9800916365"));
#else
                        reg.SetValue("password", CustomControls.Encrypt.EncryptString(constr.Password, "Kankuro9800916365"));

#endif
                        TransportManagementSystem.Properties.Settings.Default.isdatabasesetup = true;
                        TransportManagementSystem.Properties.Settings.Default.Save();

                    }
                }
                else
                {
                    RegistryKey reg = ManageKeys.Manage.NewDatabseKey();
                    reg.SetValue("server", constr.DataSource);
                    reg.SetValue("database", constr.InitialCatalog);
                    reg.SetValue("username", constr.UserID);
#if DEBUG
                    reg.SetValue("password", CustomControls.Encrypt.EncryptString(constr.Password, "Kankuro9800916365"));
#else
                    reg.SetValue("password", CustomControls.Encrypt.EncryptString(constr.Password, "Kankuro9800916365"));

#endif
                    TransportManagementSystem.Properties.Settings.Default.isdatabasesetup = true;
                    TransportManagementSystem.Properties.Settings.Default.Save();

                }


                var db = Model.DatabaseConfigure.getConfigure();
                db.Database.CreateIfNotExists();
                this.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Failed to connect, \n error:" + ex.Message);
            }




        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DatabaseSetup_Load(object sender, EventArgs e)
        {
            
        }
    }
}
