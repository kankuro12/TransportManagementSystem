using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Bill
{
    public partial class EditBill : Form
    {
        Model.TransportManagementEntities db;

        public int id { get; set; }
        public EditBill(int id)
        {
            InitializeComponent();
            db = DB.Instance;
            var load = db.bills.Find(id);
            this.id = id;
            betterTextBox_invoicenumber.Text = load.invoice_number;
          
            betterTextBox_dis.decVal = load.discount;
            betterTextBox_due.decVal = load.due;
            betterTextBox_nettotal.decVal = load.nettotal;
            betterTextBox_paid.decVal = load.paid;
            foreach (var item in db.customers.ToList())
            {
                comboBox_customer.Items.Add(item);
            }
            foreach (var item in db.vehicles.ToList())
            {
                comboBox_vechiclenumber.Items.Add(item);
            }
            foreach (var item in db.delivered_expences.Where(o => o.bill_id == load.id).ToList())
            {
                betterListView_addexp.Items.Add(new ListViewItem(new string[] { sn.ToString(), item.title, item.amount.ToString(), item.id.ToString() }));
                sn = sn + 1;
            }
            comboBox_vechiclenumber.Text = load.vehicle.vehicle_no;
            if (load.customer == null)
            {
                comboBox_customer.Text = "";
            }
            else
            {
                comboBox_customer.Text = load.customer.name;
            }
            if (load.vehicle == null)
            {
                comboBox_vechiclenumber.Text = "";
            }
            else
            {
                comboBox_vechiclenumber.Text = load.vehicle.vehicle_no;
            }
            foreach (var item in db.billitems.Where(o => o.bill_id == load.id).ToList())
            {

                betterListView_billitems.Items.Add(new billviewer(item, betterListView_billitems.Items.Count + 1));

            }
            decimal grosstotal = 0,totalweight=0,totalexp=0;

            foreach (ListViewItem lstItem in betterListView_billitems.Items) // listView has ListViewItem objects
            {

                totalweight += Convert.ToDecimal(lstItem.SubItems[5].Text);
                grosstotal += Convert.ToDecimal(lstItem.SubItems[6].Text); // Columns 4
                betterTextBox_totalamount.decVal = grosstotal;
                betterTextBox_grosstotal.decVal = grosstotal;
                betterTextBox_totalweight.decVal = totalweight;
            }
            foreach (ListViewItem expamount in betterListView_addexp.Items)
            {
                totalexp += Convert.ToDecimal(expamount.SubItems[2].Text);
                betterTextBox_totalexpenses.decVal = totalexp;
            }
        }
        int sn = 1;
        decimal grosstotal = 0, nettotal = 0, due = 0;
        public void savebill()
        {
            grosstotal = betterTextBox_grosstotal.decVal;
            if (betterTextBox_dis.decVal > grosstotal)
            {
                CustomControls.Alert.show("Not Valid", "Your discount amount is not valid", 3000);
                return;
            }
            else
            {
                nettotal = grosstotal - betterTextBox_dis.decVal;
                betterTextBox_nettotal.decVal = nettotal;
            }
            if (betterTextBox_paid.decVal > betterTextBox_nettotal.decVal)
            {
                betterTextBox_due.decVal = 0;
            }
            else
            {
                due = (betterTextBox_nettotal.decVal - betterTextBox_paid.decVal);
                betterTextBox_due.decVal = due;

            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sel = betterListView_billitems.SelectedItems[0] as billviewer;
            var load = db.billitems.Where(o => o.id == sel.id).First();
            db.Entry(load).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            betterTextBox_grosstotal.decVal = betterTextBox_grosstotal.decVal - sel.charge_amount;
            betterTextBox_totalweight.decVal = betterTextBox_totalweight.decVal - sel.total_weight;
            betterTextBox_totalamount.decVal = betterTextBox_totalamount.decVal - sel.charge_amount;
            sel.Remove();

        }
        public decimal editdue { get; set; }
        public int edit_id { get; set; }
        private void materialButton_addcard_Click(object sender, EventArgs e)
        {


            if (betterTextBox_itemname.Text.Trim() == "")
            {
                CustomControls.Alert.show("name", "please enter item name", 3000);
                betterTextBox_itemname.Focus();
                return;
            }
            if (betterTextBox_itemqty.decVal == 0)
            {
                CustomControls.Alert.show("name", "please enter item qty", 3000);
                betterTextBox_itemqty.Focus();
                return;
            }
            if (betterTextBox_unit.Text.Trim() == "")
            {
                CustomControls.Alert.show("name", "please enter item unit", 3000);
                betterTextBox_unit.Focus();
                return;
            }
            if (betterTextBox_itemweight.decVal == 0)
            {
                CustomControls.Alert.show("name", "please enter item weight", 3000);
                betterTextBox_itemweight.Focus();
                return;
            }
            if (betterTextBox_amount.decVal == 0)
            {
                CustomControls.Alert.show("name", "please enter amount", 3000);
                betterTextBox_amount.Focus();
                return;
            }
            decimal total_weight = (betterTextBox_itemweight.decVal * betterTextBox_itemqty.decVal);
            viewer viewer = new viewer(betterTextBox_itemname.Text, betterTextBox_itemqty.decVal, betterTextBox_unit.Text, betterTextBox_itemweight.decVal, betterTextBox_amount.decVal, betterListView_billitems.Items.Count + 1);
            betterListView_billitems.Items.Add(viewer);
            sn = sn + 1;
            betterTextBox_totalweight.decVal = betterTextBox_totalweight.decVal + total_weight;
            betterTextBox_grosstotal.decVal = betterTextBox_grosstotal.decVal + betterTextBox_amount.decVal;
            betterTextBox_totalamount.decVal = betterTextBox_totalamount.decVal + betterTextBox_amount.decVal;

            var bill_item = new Model.billitem()
            {
                charge_amount = betterTextBox_amount.decVal,
                quantity = betterTextBox_itemqty.decVal,
                unit = betterTextBox_unit.Text,
                bill_id = id,
                weight = betterTextBox_itemweight.decVal,
                date = nepaliCalender_DAte.Datestamp,
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
                item_name = betterTextBox_itemname.Text
            };
            DB.Instance.billitems.Add(bill_item);
            DB.Instance.SaveChanges();
            betterTextBox_itemname.Clear();
            betterTextBox_itemqty.Clear();
            betterTextBox_amount.Clear();
            betterTextBox_unit.Clear();
            betterTextBox_itemweight.Clear();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var sel = betterListView_addexp.SelectedItems[0];
            int sel1 = Convert.ToInt32(sel.SubItems[3].Text);
            decimal amount = Convert.ToDecimal(sel.SubItems[2].Text);
            var load = db.delivered_expences.Where(o => o.id == sel1).First();
            db.Entry(load).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            betterTextBox_totalexpenses.decVal = betterTextBox_totalexpenses.decVal - amount;
            sel.Remove();

        }
        public int sn1 { get; set; }
        private void materialButton_addexp_Click(object sender, EventArgs e)
        {
            betterListView_addexp.Items.Add(new ListViewItem(new string[] { sn1.ToString(), betterTextBox_Exptitle.Text, betterTextBox_Expamount.decVal.ToString() }));
            sn1 = sn1 + 1;
            var exp = new Model.delivered_expences()
            {
                title = betterTextBox_Exptitle.Text,
                amount = betterTextBox_Expamount.decVal,
                bill_id = id,
                vehicle_number = (comboBox_vechiclenumber.SelectedItem as Model.vehicle).id,
                admin_id = INFO.admin_id,
                updated_at = DateTime.Now,
                created_at = DateTime.Now
            };
            db.delivered_expences.Add(exp);
            db.SaveChanges();
            betterTextBox_totalexpenses.decVal = betterTextBox_totalexpenses.decVal + betterTextBox_Expamount.decVal;
            betterTextBox_Exptitle.Clear();
            betterTextBox_Expamount.Clear();
        }

        private void betterListView_billitems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void betterTextBox_dis_TextChanged(object sender, EventArgs e)
        {
            savebill();
        }

        private void betterTextBox_paid_TextChanged(object sender, EventArgs e)
        {
            savebill();
        }

        private void betterTextBox_grosstotal_TextChanged(object sender, EventArgs e)
        {
            savebill();
        }

        private void materialButton_save_Click(object sender, EventArgs e)
        {
            if (betterTextBox_invoicenumber.Text.Trim() == "")
            {
                CustomControls.Alert.show("Invoice Number(Bill No)", "please enter bill number", 3000);
                return;
            }
            if (comboBox_vechiclenumber.SelectedItem == null)
            {
                CustomControls.Alert.show("Vehicle No.", "please select vehicle number", 3000);
                return;
            }
            if (comboBox_customer.SelectedItem == null)
            {
                CustomControls.Alert.show("customer.", "please select customer", 3000);
                return;
            }

            var customer_id1 = (comboBox_customer.SelectedItem as Model.customer).id;
            var firstdue = db.bills.Where(o => o.id == id).First();
            var dueamoutfirst = db.customers.Find(customer_id1);
            dueamoutfirst.due = dueamoutfirst.due - firstdue.due;
            db.Entry(dueamoutfirst).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            var edit = db.bills.Where(o => o.id == id).First();
            edit.vehicle_number = (comboBox_vechiclenumber.SelectedItem as Model.vehicle).id;
            edit.date = nepaliCalender_DAte.Datestamp;
            edit.invoice_number = betterTextBox_invoicenumber.Text;
            edit.total_amount = betterTextBox_totalamount.decVal;
            edit.total_Weight = betterTextBox_totalweight.decVal;
            edit.total_exp = betterTextBox_totalexpenses.decVal;
            edit.grosstoal = betterTextBox_grosstotal.decVal;
            edit.discount = betterTextBox_dis.decVal;
            edit.paid = betterTextBox_paid.decVal;
            edit.due = betterTextBox_due.decVal;
            edit.nettotal = betterTextBox_nettotal.decVal;
            edit.customer_id = (comboBox_customer.SelectedItem as Model.customer).id;
            var customer_id = (comboBox_customer.SelectedItem as Model.customer).id;
            var dueamout = db.customers.Find(customer_id);
            dueamout.due += betterTextBox_due.decVal;
            db.Entry(edit).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            betterListView_billitems.Items.Clear();
            betterTextBox_invoicenumber.Clear();
            comboBox_vechiclenumber.SelectedIndex = -1;
            comboBox_customer.SelectedIndex = -1;
            betterTextBox_Exptitle.Clear();
            betterListView_addexp.Items.Clear();
            betterTextBox_Expamount.Clear();
            betterTextBox_totalamount.Clear();
            betterTextBox_totalexpenses.Clear();
            betterTextBox_totalweight.Clear();
            betterTextBox_dis.Clear();
            betterTextBox_due.Clear();
            betterTextBox_grosstotal.Clear();
            betterTextBox_nettotal.Clear();
            betterTextBox_paid.Clear();

        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }
    }
}
