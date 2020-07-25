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
        public Add()
        {
            InitializeComponent();
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
    }
}
