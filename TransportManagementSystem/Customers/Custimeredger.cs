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

namespace TransportManagementSystem.Customers
{
    public partial class Custimeredger : Form
    {
        Model.TransportManagementEntities db;
        public int id { get; set; }
        public Custimeredger(int id)
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
            foreach (var item in db.bills.Where(o => o.customer_id == id).ToList())
            {
                betterListView1.Items.Add(new Customers.Loader(item, betterListView1.Items.Count + 1));
            }
            this.id = id;
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void materialButton_paid_Click(object sender, EventArgs e)
        {

            var load = db.customers.Where(o => o.id == id).First();

            decimal due = load.due;

            if (betterTextBox_receiveamout.decVal >= due)
            {
                if (checkBox1.Checked)
                {
                    var advance = new usecustomeradvance()
                    {
                        customer_id = id,
                        amount = load.advance,
                        date = nepaliCalender1.Datestamp,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now
                    };
                    db.usecustomeradvances.Add(advance);
                    due = due - load.advance;
                    load.advance = load.advance - load.advance;
                }
                load.due = due - due;
                db.Entry(load).State = System.Data.Entity.EntityState.Modified;
                var save = new customerpyment()
                {
                    customer_id = id,
                    amount = due,
                    date = nepaliCalender1.Datestamp,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                db.customerpyments.Add(save);
               
            }
            else
            {
                if (checkBox1.Checked)
                {
                    var advance = new usecustomeradvance()
                    {
                        customer_id = id,
                        amount = load.advance,
                        date = nepaliCalender1.Datestamp,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now
                    };
                    db.usecustomeradvances.Add(advance);
                    due = due - load.advance;
                    load.advance = load.advance - load.advance;
                }
                var save = new customerpyment()
                {
                    customer_id = id,
                    amount = betterTextBox_receiveamout.decVal,
                    date = nepaliCalender1.Datestamp,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                db.customerpyments.Add(save);
                load.due = due - betterTextBox_receiveamout.decVal;
                db.Entry(load).State = System.Data.Entity.EntityState.Modified;

            }

            db.SaveChanges();
            this.Close();

        }

        private void materialButton_payment_Click(object sender, EventArgs e)
        {
            var d = new Customers.Paymentlist(id);
            var t = new CustomControls.Modal(d);
            t.Show();
        }
    }
}
