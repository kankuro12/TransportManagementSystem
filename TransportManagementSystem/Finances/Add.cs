using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportManagementSystem.Model;

namespace TransportManagementSystem.Finances
{
    public partial class Add : Form
    {
        TransportManagementEntities db;
        public delegate void addHandler(Model.finance finance);
        public event addHandler add;
        public Add()
        {
            InitializeComponent();
            db = DB.Instance;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_name.Text.Trim()=="")
            {
                CustomControls.Alert.show("name", "enter name", 1500);
                return;
            }
            if (txt_address.Text.Trim() == "")
            {
                CustomControls.Alert.show("address", "enter address", 1500);
                return;
            }
            if (txt_phone.Text.Trim() == "")
            {
                CustomControls.Alert.show("phone", "enter phone", 1500);
                return;
            }

            try
            {
                var i = new finance()
                {
                    name = txt_name.Text,
                    address = txt_address.Text,
                    phone = txt_phone.Text,
                    email = txt_email.Text,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now,
                };
                db.finances.Add(i);
                db.SaveChanges();
                add?.Invoke(i);
                this.Close();
            }
            catch (Exception ex)
            {
                CustomControls.Alert.show("Data", "Error Data", 1500);
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
