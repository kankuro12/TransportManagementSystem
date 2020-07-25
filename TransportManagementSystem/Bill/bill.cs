﻿using System;
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
    public partial class bill : Form
    {
        Model.TransportManagementEntities db;
        public bill()
        {
            InitializeComponent();
            db = DB.Instance;
            foreach (var item in db.vehicles.Where(o=>o.active==true).ToList())
            {
                comboBox_vechiclenumber.Items.Add(item);
            }
        }

        private void betterTextBox_amount_TextChanged(object sender, EventArgs e)
        {

        }
        public int sn = 1;
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
            viewer viewer = new viewer(betterTextBox_itemname.Text, betterTextBox_itemqty.decVal, betterTextBox_unit.Text, betterTextBox_itemweight.decVal, betterTextBox_amount.decVal,betterListView_billitems.Items.Count+1);
            betterListView_billitems.Items.Add(viewer);
            sn = sn + 1;
            betterTextBox_totalweight.decVal = betterTextBox_totalweight.decVal + total_weight;
            betterTextBox_totalamount.decVal = betterTextBox_totalamount.decVal + betterTextBox_amount.decVal;
            clear();
        }
      
        public void clear()
        {
            betterTextBox_amount.Clear();
            betterTextBox_itemname.Clear();
            betterTextBox_itemqty.Clear();
            betterTextBox_unit.Clear();
            betterTextBox_itemweight.Clear();
            
        }
        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_vechiclenumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label_vehiclenumber.Text = (comboBox_vechiclenumber.SelectedItem as Model.vehicle).vehicle_no;
        }
        public int sn1 = 1;
        private void materialButton_addexp_Click(object sender, EventArgs e)
        {
            var exp = new ListViewItem(new string[] { sn1.ToString(), betterTextBox_Exptitle.Text, betterTextBox_Expamount.decVal.ToString() });
            betterListView_addexp.Items.Add(exp);
            sn1 = sn1 + 1;
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sel = betterListView_billitems.SelectedItems[0];
            betterTextBox_totalweight.decVal -=Convert.ToDecimal( sel.SubItems[5].Text);
            betterTextBox_totalamount.decVal -= Convert.ToDecimal(sel.SubItems[6].Text);
            sel.Remove();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            var save_bill = new Model.bill()
            {
                vehicle_number = (comboBox_vechiclenumber.SelectedItem as Model.vehicle).id,
                date = nepaliCalender_DAte.Datestamp,
                invoice_number = betterTextBox_invoicenumber.Text,
                total_amount = betterTextBox_totalamount.decVal,
                total_Weight=betterTextBox_totalweight.decVal,
                total_exp=betterTextBox_totalexpenses.decVal,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            };
            db.bills.Add(save_bill);
            db.SaveChanges();
            foreach (var item in betterListView_billitems.Items.Cast<viewer>().ToList())
            {
                item.save(save_bill.id, nepaliCalender_DAte.Datestamp);
            }
            foreach (ListViewItem item in betterListView_addexp.Items)
            {
                var title = item.SubItems[1].Text;
                var amount = Convert.ToDecimal(item.SubItems[2].Text);
                var exp = new Model.delivered_expences()
                {
                    title = title,
                    amount = amount,
                    bill_id = save_bill.id,
                    vehicle_number = (comboBox_vechiclenumber.SelectedItem as Model.vehicle).id,
                    admin_id = INFO.admin_id,
                    updated_at = DateTime.Now,
                    created_at = DateTime.Now
                };
                db.delivered_expences.Add(exp);
                db.SaveChanges();
            }
            betterListView_billitems.Items.Clear();
            betterTextBox_invoicenumber.Clear();
            comboBox_vechiclenumber.SelectedIndex = -1;
            betterTextBox_Exptitle.Clear();
            betterListView_addexp.Items.Clear();
            betterTextBox_Expamount.Clear();
            betterTextBox_totalamount.Clear();
            betterTextBox_totalexpenses.Clear();
            betterTextBox_totalweight.Clear();
            clear();
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var sel = betterListView_addexp.SelectedItems[0];
            betterTextBox_Expamount.decVal -= Convert.ToDecimal(sel.SubItems[2].Text);
            sel.Remove();
        }
    }
}
