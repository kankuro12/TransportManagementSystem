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
    public partial class Paymentlist : Form
    {
        Model.TransportManagementEntities db;
        int sn = 1;
        public Paymentlist(int id)
        {
            InitializeComponent();
            db = DB.Instance;
            var load = db.customers.Where(o => o.id == id).First();
            betterTextBox_name.Text = load.name;
            betterTextBox_address.Text = load.address;
            betterTextBox_email.Text = load.email;
            betterTextBox_phone.Text = load.phone;
            betterTextBox_due.decVal = load.due;
            betterTextBox_advace.decVal = load.advance;

            foreach (var item in db.customerpyments.Where(o=>o.customer_id==id).ToList())
            {
                betterListView1.Items.Add(new ListViewItem(new string[] { sn.ToString(), item.date.ToString(), item.amount.ToString() }));
                sn = sn + 1;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
