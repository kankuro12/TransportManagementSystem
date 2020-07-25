using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Senditems
{
    public partial class List : Form
    {
        Model.TransportManagementEntities db;
        public List(List<int> IDS)
        {
            InitializeComponent();
            db = DB.Instance;

            foreach (var item in db.orderitemlists.Where(o => IDS.Contains(o.id)).ToList())
            {
                Senditems.Viwer viwer = new Senditems.Viwer(item, betterListView_orderitem.Items.Count + 1);
                betterListView_orderitem.Items.Add(viwer);
            }
            foreach (var vechicles in db.vehicles.Where(o => o.active == true))
            {

                comboBox_vehicle.Items.Add(vechicles);


            }
           



            foreach (ListViewItem lstItem in betterListView_orderitem.Items) // listView has ListViewItem objects
            {
                valorSum += Convert.ToDecimal(lstItem.SubItems[14].Text); // Columns 4
            }
            betterTextBox_total.decVal = valorSum;

        }
        public CustomControls.PrintObject PrintObject;
        public decimal valorSum;
        private void materialButton_load_Click(object sender, EventArgs e)
        {

        }
        int i = 1;
        private void materialButton_loadexp_Click(object sender, EventArgs e)
        {
            if (betterTextBox_title.Text.Trim() == "")
            {
                CustomControls.Alert.show("title", "please enter title", 2000);
                return;
            }
            if (betterTextBox_amount.Text.Trim() == "")
            {
                CustomControls.Alert.show("amount", "please enter amount", 2000);
                return;
            }

            betterListView_exp.Items.Add(new ListViewItem(new string[] { i.ToString(), betterTextBox_title.Text, betterTextBox_amount.decVal.ToString() }));
            i++;
            betterTextBox_title.Clear();
            betterTextBox_amount.Clear();
        }

        private void materialButton_staff_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeOrderItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sel = betterListView_orderitem.SelectedItems[0] as Viwer;
            betterTextBox_total.decVal -= Convert.ToDecimal(sel.SubItems[14].Text);
            sel.Remove();

        }

        private void materialButton_saveandprint_Click(object sender, EventArgs e)
        {

            if (comboBox_vehicle.SelectedItem == null)
            {
                CustomControls.Alert.show("Select", "please Select Vechicle ", 2000);
                return;
            }
           
            int date;
            var newbills = new Model.trip()
            {
                vechicle_id = (comboBox_vehicle.SelectedItem as Model.vehicle).id,
                totalamount = valorSum,
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
                admin_id = INFO.admin_id,
                date = nepaliCalender1.Datestamp
            };
            db.trips.Add(newbills);
            db.SaveChanges();
           
            foreach (var item in betterListView_orderitem.Items.Cast<Viwer>().ToList())
            {
                item.save(newbills.id,nepaliCalender1.Datestamp);
            }
            Senditems.Printing printing = new Printing();
            printing.prininte(newbills);
            foreach (ListViewItem item1 in betterListView_exp.Items)
            {
                var title = item1.SubItems[1].Text;
                var amount = Convert.ToDecimal(item1.SubItems[2].Text);
                var exp = new Model.expence()
                {
                    title = title,
                    amount = amount,
                    bill_id = newbills.id,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now,
                    date = nepaliCalender1.Datestamp,
                    admin_id = INFO.admin_id,
                    vehicle_id = (comboBox_vehicle.SelectedItem as Model.vehicle).id,
                   
                };
                db.expences.Add(exp);
                db.SaveChanges();
            }
            var deactivate_vechicle = db.vehicles.Find((comboBox_vehicle.SelectedItem as Model.vehicle).id);
            deactivate_vechicle.active = false;
            db.Entry(deactivate_vechicle).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
           
            betterListView_exp.Items.Clear();
            betterListView_orderitem.Items.Clear();
            betterTextBox_total.Clear();
            
            this.Close();


        }

        private void comboBox_vehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
           // label_staffname.Text = (comboBox_vehicle.SelectedItem as Model.vehicle).staff.name;
        }
    }
}

