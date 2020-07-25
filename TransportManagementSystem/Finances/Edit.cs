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
    public partial class Edit : Form
    {
        TransportManagementEntities db;
        public delegate void editHandler(Model.finance finance);
        public event editHandler edit;
        int id;
        public Edit()
        {
            InitializeComponent();
           db=DB.Instance;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Trim() == "")
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


                var i = db.finances.Where(o => o.id == id).First();
                i.name = txt_name.Text;
                i.address = txt_address.Text;
                i.phone = txt_phone.Text;
                i.email = txt_email.Text;
                i.updated_at = DateTime.Now;
                db.Entry(i).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                CustomControls.Alert.show("Data", "Error Data", 1500);
            }
        }
        public void loaddata(int id)
        {
            finance i = db.finances.Where(o => o.id == id).First();
            txt_name.Text = i.name;
            txt_address.Text = i.address;
            txt_phone.Text = i.phone;
            txt_email.Text = i.email;
            this.id = id;
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
