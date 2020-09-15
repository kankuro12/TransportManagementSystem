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
    public partial class Add : Form
    {
        Model.TransportManagementEntities db;
        public delegate void addhandler(Model.customer customer);
        public event addhandler add;
        public Add()
        {
            InitializeComponent();
            db = DB.Instance;
        }

        private void materialButton_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_save_Click(object sender, EventArgs e)
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
            var new_customers = new Model.customer()
            {
                name = betterTextBox_name.Text,
                address = betterTextBox_address.Text,
                phone = betterTextBox_phone.Text,
                email = betterTextBox_email.Text,
                due = betterTextBox_due.decVal,
                advance = betterTextBox_advace.decVal,
                upadated_at = DateTime.Now,
                created_at = DateTime.Now,
                //fiscalyear_id = INFO.currentFiscalYear.fiscalyear_id,

            };
            db.customers.Add(new_customers);
            db.SaveChanges();
            add?.Invoke(new_customers);
            this.Close();
        }
    }
}
