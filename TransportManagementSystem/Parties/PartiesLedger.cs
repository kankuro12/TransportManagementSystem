using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Parties
{
    public partial class PartiesLedger : Form
    {
        Model.TransportManagementEntities db;
        public int id { get; set; }
        public PartiesLedger(int id)
        {
            InitializeComponent();
            db = DB.Instance;
            var load = db.parties.Where(o => o.id == id).First();
            betterTextBox_name.Text = load.name;
            betterTextBox_address.Text = load.address;
            betterTextBox_email.Text = load.email;
            betterTextBox_phone.Text = load.phone;
            betterTextBox_due.decVal = load.due;
            betterTextBox_advace.decVal = load.advance;
            this.id = id;

        }

        private void materialButton_paid_Click(object sender, EventArgs e)
        {
            var load = db.customers.Where(o => o.id == id).First();

            decimal due = load.due;

            if (betterTextBox_paidamount.decVal >= due)
            {
                if (checkBox1.Checked)
                {
                    var advance = new Model.usepartiesadvance()
                    {
                        partie_id = id,
                        amount = load.advance,
                        date = nepaliCalender1.Datestamp,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now
                    };
                    db.usepartiesadvances.Add(advance);
                    due = due - load.advance;
                    load.advance = load.advance - load.advance;
                }
                load.due = due - due;
                db.Entry(load).State = System.Data.Entity.EntityState.Modified;
                var save = new Model.partiespyment()
                {
                     partie_id = id,
                    amount = due,
                    date = nepaliCalender1.Datestamp,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                db.partiespyments.Add(save);

            }
            else
            {
                if (checkBox1.Checked)
                {
                    var advance = new Model.usepartiesadvance()
                    {
                        partie_id = id,
                        amount = load.advance,
                        date = nepaliCalender1.Datestamp,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now
                    };
                    db.usepartiesadvances.Add(advance);
                    due = due - load.advance;
                    load.advance = load.advance - load.advance;
                }
                var save = new Model.partiespyment()
                {
                    partie_id = id,
                    amount = betterTextBox_paidamount.decVal,
                    date = nepaliCalender1.Datestamp,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                db.partiespyments.Add(save);
                load.due = due - betterTextBox_paidamount.decVal;
                db.Entry(load).State = System.Data.Entity.EntityState.Modified;

            }

            db.SaveChanges();
            this.Close();
        }
        int sn = 1;
        private void materialButton_payment_Click(object sender, EventArgs e)
        {
            betterListView1.Items.Clear();
            foreach (var item in db.partiespyments.Where(o => o.partie_id == id).ToList())
            {
                betterListView1.Items.Add(new ListViewItem(new string[] { sn.ToString(), item.date.ToString(), item.amount.ToString() }));
                sn = sn + 1;
            }
        }
    }
}
