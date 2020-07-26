using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Other_Expenses
{
    public partial class Add : Form
    {
        Model.TransportManagementEntities db;
        public Add()
        {
            InitializeComponent();
            db = DB.Instance;
            foreach (var item in DB.Instance.vehicles.ToList())
            {
                comboBox_vehiclelist.Items.Add(item);
                comboBox_vehiclesave.Items.Add(item);
            }
        }

        private void materialButton_Add_Click(object sender, EventArgs e)
        {
            if (betterTextBox_title.Text.Trim() == "")
            {
                CustomControls.Alert.show("Title", "Enter title ", 3000);
                betterTextBox_title.Focus();
                return;
            }
            if (betterTextBox_amount.decVal == 0)
            {
                CustomControls.Alert.show("amount", "Enter amount ", 3000);
                betterTextBox_amount.Focus();
                return;
            }
            viewer viewer = new viewer(betterTextBox_title.Text, betterTextBox_amount.decVal, betterListView_save.Items.Count + 1);
            betterListView_save.Items.Add(viewer);
            betterTextBox_totalamount.decVal = betterTextBox_totalamount.decVal + betterTextBox_amount.decVal;
            betterTextBox_title.Clear();
            betterTextBox_amount.Clear();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (comboBox_vehiclesave.SelectedIndex == -1)
            {
                CustomControls.Alert.show("Vehicle", "please select vehicle number", 4000);
                comboBox_vehiclesave.Focus();
                return;
            }
            
            Model.otherexp otherexp = new Model.otherexp()
            {
                vehicle_id = (comboBox_vehiclesave.SelectedItem as Model.vehicle).id,
                date = nepaliCalender_date.Datestamp,
                totalamount = betterTextBox_totalamount.decVal,
                admin_id = INFO.admin_id,
                updated_at = DateTime.Now,
                created_at = DateTime.Now

            };
            DB.Instance.otherexps.Add(otherexp);
            DB.Instance.SaveChanges();
            foreach (var item in betterListView_save.Items.Cast<viewer>().ToList())
            {
                item.save(otherexp.id);
            }
            betterListView_save.Items.Clear();
            betterTextBox_totalamount.Clear();
            comboBox_vehiclesave.SelectedIndex = -1;
            
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sel = betterListView_save.SelectedItems[0];
            var amout = Convert.ToDecimal(sel.SubItems[2].Text);
            betterTextBox_totalamount.decVal = betterTextBox_totalamount.decVal - amout;
            sel.Remove();
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public decimal totalexp;
        private void materialButton2_Click(object sender, EventArgs e)
        {
            betterListView_list.Items.Clear();
            betterTextBox_Totalexpamount.Clear();
            if (comboBox_vehiclelist.SelectedIndex == -1)
            {
                CustomControls.Alert.show("Vehicle", "please select vehicle and correct date", 5000);
                return;
            }
            var vehicle_id = (comboBox_vehiclelist.SelectedItem as Model.vehicle).id;
            foreach (var item in db.otherexps.Where(o=>o.date>=nepaliCalender_From.Datestamp&&o.date<=nepaliCalender_to.Datestamp&&o.vehicle_id==vehicle_id).ToList())
            {
                exp_viwer exp_Viwer = new exp_viwer(item, betterListView_list.Items.Count + 1);
                betterListView_list.Items.Add(exp_Viwer);
            }

            foreach (ListViewItem item in betterListView_list.Items)
            {
                totalexp+= Convert.ToDecimal(item.SubItems[4].Text);
            }
            betterTextBox_Totalexpamount.decVal = totalexp;
            totalexp = 0;
        }

        private void betterListView_list_DoubleClick(object sender, EventArgs e)
        {
            var sel = betterListView_list.Items[0];
            var id = Convert.ToInt32(sel.SubItems[5].Text);
            var vehicle_no = (sel.SubItems[2].Text);
            var date = Convert.ToInt32(sel.SubItems[3].Text);
            var li = new Other_Expenses.ListExpItems(id,vehicle_no,date);
            var t = new CustomControls.Modal(li);
            t.Show();
        }
    }
}
