using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Login
{
    public partial class Login : Form
    {
        public Login()
        {
            DB.init();
            db = DB.Instance;
            InitializeComponent();
        }
        Model.TransportManagementEntities db;

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.isdatabasesetup == false)
            {
                new Setting.DatabaseSetup().ShowDialog();
            }
            if (Properties.Settings.Default.isdatabasesetup == false)
            {
                Application.Exit();
            }
            if (!Properties.Settings.Default.isuserregister)
            {
                var m = new Setting.UserRegister();
                var trans = new CustomControls.Modal(m);

                trans.ShowDialog();
            }
            if (!Properties.Settings.Default.isuserregister)
            {
                MessageBox.Show("Please Register User first");
                this.Close();
            }
           
            var keyold = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("5D41402ABC4B2A76B9719D911017C592");
            if (keyold != null)
            {
                var key = Convert.ToDateTime((string)keyold.GetValue("upto"));
                if (key < DateTime.Now)
                {
                    var m = new Setting.AddKey();
                    var trans = new CustomControls.Modal(m);


                    trans.ShowDialog();
                }
                key = Convert.ToDateTime((string)keyold.GetValue("upto"));
                if (key < DateTime.Now)
                {
                    MessageBox.Show("Your Key has expired");
                    this.Close();
                }
            }
           
            if (DB.Instance.admins.Count() <= 0)
            {
                new Setting.AdminSetup().ShowDialog();
            }

            if (DB.Instance.admins.Count() <= 0)
            {
                this.Close();
            }

        }
        private int _showstate;

        public int ShowState
        {
            set
            {
                _showstate = value;
                if (value == 0)
                {

                    this.materialButton2_closeX.Enabled = true;
                    materialButton2_closeX.Enabled = true;
                }
                else if (value == 1)
                {
                    materialButton2_closeX.Enabled = false;
                    materialButton2_closeX.Enabled = false;
                }
            }
            get
            {
                return _showstate;
            }
        }
       
        private void materialButton2_closeX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton1_login_Click(object sender, EventArgs e)
        {
            var o = new Dashbord.Dashboard();
            o.Show();
  
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton2_closeX_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void betterTextBox1_username_Enter(object sender, EventArgs e)
        {
            label1.Top =173;
        }

        private void betterTextBox1_username_Leave(object sender, EventArgs e)
        {
            if (betterTextBox1_username.Text.Trim() == "")
            {
                label1.Top = 187;
            }
        }

        private void betterTextBox2_password_Enter(object sender, EventArgs e)
        {
            label2.Top = 231;
        }

        private void betterTextBox2_password_Leave(object sender, EventArgs e)
        {
            if (betterTextBox2_password.Text.Trim() == "")
                label2.Top = 244;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            label1.Top = 187;
            betterTextBox1_username.Focus();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            label2.Top = 244;
            betterTextBox2_password.Focus();
        }

        private void materialButton1_login_Click_1(object sender, EventArgs e)
        {
            //try
            //{
                var password = CustomControls.Encrypt.EncryptString(betterTextBox2_password.Text, "need12345");
            if (db.admins.Count(o => o.username == betterTextBox1_username.Text && o.password == password)== 0)
            {
                CustomControls.Alert.show("Login", "UserName Password MisMatch, Please try again", 5000);
                }
                else
                {
                    var user = db.admins.First(o => o.username == betterTextBox1_username.Text && o.password == password);
                    if(user.enabled)
                    {
                        if (this.ShowState == 0)
                        {

                            RoleManagement.CurrentRole.addRole(new RoleManagement.Roles()
                            {
                                role =user.role,
                                rolename = RoleManagement.CurrentRole.rolename[user.role],
                                SessionStarted = DateTime.Now,
                                session_id = "",
                                username = user.username,
                                admin_id = user.id
                            });
                        }

                        this.Hide();
                        if (Dashbord.Dashboard.instance == null)
                        {

                            var dash = new Dashbord.Dashboard();
                            dash.FormClosed += (o, ee) =>
                            {
                                this.ShowState = 0;
                                this.Show();

                            };
                            dash.Show();
                        }
                        else
                        {
                           Dashbord.Dashboard.instance.Show();
                        }
                    }
                    else
                    {
                        CustomControls.Alert.show("Login", "This User Account Have Been Disabled, Please Contact Administrator", 5000);

                    }
                }

            }
        //    catch (Exception ex)
        //    {
        //        CustomControls.Alert.show("Login", "Error:" + ex.Message + "\n" + "Please Contact NeedTechnosft", 5000);


        //    }
        //    betterTextBox2_password.Clear();
        //}

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (ShowState == 1)
            {
                if (keyData == (Keys.Alt | Keys.F4))
                {
                    return false;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void textBox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ShowState == 1)
            {
                e.Cancel = true;
            }
        }

        private void panel_main_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void betterTextBox1_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel_link.LinkVisited = true;
            System.Diagnostics.Process.Start("http://needtechnosoft.tech");
        }
    }
}
