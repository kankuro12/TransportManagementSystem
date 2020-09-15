using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Customers
{
    public partial class Edit : Form
    {
        Model.TransportManagementEntities db;
        public delegate void edithandeler(Model.customer customer);
        public event edithandeler edit;
        int id;
        public Edit(int id)
        {
            InitializeComponent();
            db = DB.Instance;
            var load = db.customers.Find(id);
            betterTextBox_name.Text = load.name;
            betterTextBox_address.Text = load.address;
            betterTextBox_phone.Text = load.phone;
            betterTextBox_email.Text = load.email;
            betterTextBox_advace.decVal = load.advance;
            betterTextBox_due.decVal = load.due;
            this.id = id;
        }

        private void betterTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void materialButton_Save_Click(object sender, EventArgs e)
        {
            if (betterTextBox_name.Text.Trim() == "")
            {
                CustomControls.Alert.show("enter name", "please enter name", 3000);
                betterTextBox_name.Focus();
                return;

            }
            if (betterTextBox_address.Text.Trim() == "")
            {
                CustomControls.Alert.show("enter address", "please enter address", 3000);
                betterTextBox_address.Focus();
                return;

            }
            if (betterTextBox_phone.Text.Trim() == "")
            {
                CustomControls.Alert.show("enter phone", "please enter phone", 3000);
                betterTextBox_phone.Focus();
                return;

            }
            var e_data = db.customers.Find(id);
            e_data.name = betterTextBox_name.Text;
            e_data.address = betterTextBox_address.Text;
            e_data.phone = betterTextBox_phone.Text;
            e_data.email = betterTextBox_email.Text;
            e_data.due = betterTextBox_due.decVal;
            e_data.advance = betterTextBox_advace.decVal;
            db.Entry(e_data).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            edit?.Invoke(e_data);
            this.Close();
        }
    }
}
