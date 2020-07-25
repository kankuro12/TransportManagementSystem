using Flurl.Http;
using System;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Windows.Forms;
namespace TransportManagementSystem.Setting
{
    public partial class UserRegister : Form
    {
        [Serializable]
        private class user
        {
            public int status { set; get; }
            public dynamic data;
        }
        public UserRegister()
        {
            InitializeComponent();
        }

        private void UserRegister_Load(object sender, EventArgs e)
        {

        }

      
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void save_btn_ClickAsync(object sender, EventArgs e)
        {

            try
            {

                foreach (Control item in this.Controls)
                {
                    if (item.GetType() == typeof(TextBox))
                    {
                        if (item.Text.Trim() == "")
                        {

                            return;


                        }
                    }
                }

                //var k = NetworkInterface.GetAllNetworkInterfaces().Where(nic => nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet).FirstOrDefault();
                //var signature = k.GetPhysicalAddress().ToString();
                //user data = await "http://medico.lulaamlaam.com/reg/"
                //.PostJsonAsync(new
                //{
                //    name = name_txt.Text,
                //    usersignature = signature,
                //    address = addr_txt.Text,
                //    phone = phn_txt.Text,
                //    email = email_txt.Text,
                //    userkey = key_txt.Text,
                //    panno = panno_txt.Text
                //})
                //.ReceiveJson<user>();
                //if (data.status == 1)
                //{
                //    CustomControls.Alert.show("", "User Registered", 1000);

                //}
                //else
                //{
                //    MessageBox.Show(data.data as string);
                //    return;
                //}
                if (key_txt.Text == "siptungkha123@")
                {

                    TransportManagementSystem.Properties.Settings.Default.Name = name_txt.Text;
                    TransportManagementSystem.Properties.Settings.Default.Address = addr_txt.Text;
                    TransportManagementSystem.Properties.Settings.Default.Phone = phn_txt.Text;
                    TransportManagementSystem.Properties.Settings.Default.Email = email_txt.Text;

                    TransportManagementSystem.Properties.Settings.Default.Panno = panno_txt.Text;
                    // TransportManagementSystem.Properties.Settings.Default.signature = signature;
                    TransportManagementSystem.Properties.Settings.Default.key = key_txt.Text;
                    TransportManagementSystem.Properties.Settings.Default.isuserregister = true;

                    TransportManagementSystem.Properties.Settings.Default.Save();
                }
                else
                {
                    MessageBox.Show("Please try again, Register USer");
                }
                //if (!sendMail())
                //{
                //    new custom.Notification(2000, "Mail", "Cannot Confirm mail,Please Try after some time");
                //}

                //var keyold = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("5D41402ABC4B2A76B9719D911017C592");
                //if (keyold != null)
                //{
                //    var key = keyold.GetValue("upto") as DateTime?;
                //    var future = key.Value.AddYears(1);
                //    keyold.SetValue("upto", future);
                //}
                //else
                //{
                //    var keynew = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("5D41402ABC4B2A76B9719D911017C592");
                //    var future = DateTime.Now.AddYears(1);
                //    keynew.SetValue("upto", future);

                //    }
                    this.Close();
            }
            catch (Exception exx)
            {
                MessageBox.Show("Please try again, Register USer" + exx.Message);
            }
            this.Close();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
