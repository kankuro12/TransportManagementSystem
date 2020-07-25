using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flurl;
using Flurl.Util;
using Flurl.Http;

namespace TransportManagementSystem.Setting
{
    public partial class AddKey : Form
    {
        [Serializable]
        private class user
        {
            public int status { set; get; }
            public dynamic data;
        }
        public AddKey()
        {
            InitializeComponent();
        }

        private void AddKey_Load(object sender, EventArgs e)
        {

        }

        private async void forgetpass_txt_Click(object sender, EventArgs e)
        {
            //var d = Properties.Settings.Default;
            //user data = await "http://medico.lulaamlaam.com/reg/"
            //    .PostJsonAsync(new
            //    {
            //        name = d.Name,
            //        usersignature = d.signature,
            //        address = d.Address,
            //        phone =d.Phone,
            //        email = d.Email,
            //        userkey = key_txt.Text,
            //        panno = d.Panno
            //    })
            //    .ReceiveJson<user>();
            //if (data.status == 1)
            //{
            //    CustomControls.Alert.show("","key added", 2000);
            //    return;
               
            //}
            //else
            //{
            //    MessageBox.Show(data.data as string);
                
            //}

            //Properties.Settings.Default.key = key_txt.Text;
            //Properties.Settings.Default.isuserregister = true;
            //Properties.Settings.Default.Save();

            //var keyold = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("5D41402ABC4B2A76B9719D911017C592");
            //if (keyold != null)
            //{
            //    var key = Convert.ToDateTime( keyold.GetValue("upto") as string);
            //    if (key < DateTime.Now)
            //    {
            //        var future = DateTime.Now.AddYears(1);
            //        keyold.SetValue("upto", future);
            //    }
            //    else
            //    {
            
            //    var future = key.AddYears(1);
            //    keyold.SetValue("upto", future);
            //    }
            //}
            //else
            //{
            //    var keynew = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("5D41402ABC4B2A76B9719D911017C592");
            //    var future = DateTime.Now.AddYears(1);
            //    keynew.SetValue("upto", future);
            //}
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
