using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.FinalDelivered.Delivered
{
    public partial class SaveDeliveredItems : Form
    {
        Model.TransportManagementEntities db;
        int staffandv_id;
        public SaveDeliveredItems(List<int>ID,int bill_id)
        {
            InitializeComponent();
            db = DB.Instance;
            foreach (var item in db.tripitems.Where(o => ID.Contains(o.id)).ToList())
            {
                FinalDelivered.Delivered.Viwer viwer = new FinalDelivered.Delivered.Viwer(item,betterListView_orderitem.Items.Count + 1);
                betterListView_orderitem.Items.Add(viwer);
                var load = db.trips.Find(bill_id);
                label_vehiclenumber.Text = load.vehicle.vehicle_no;
                label_staffname.Text = load.vehicle.staff.name;
                
            }
            this.staffandv_id = bill_id;
            foreach (ListViewItem lstItem in betterListView_orderitem.Items) // listView has ListViewItem objects
            {
                valorSum += Convert.ToDecimal(lstItem.SubItems[14].Text); // Columns 4
            }
            betterTextBox_totalamount.decVal = valorSum;
        }
        decimal valorSum;
        int sn;
        private void materialButton_addexp_Click(object sender, EventArgs e)
        {
            if (betterTextBox_Exptitle.Text.Trim() == "")
            {
                CustomControls.Alert.show("expenses title", "entet  expenses title", 3000);
                betterTextBox_Exptitle.Focus();
                return;
            }

            if (betterTextBox_expamount.Text.Trim() == "")
            {
                CustomControls.Alert.show("expenses amount", "entet  expenses amount", 3000);
                betterTextBox_expamount.Focus();
                return;
            }
            var load = new ListViewItem(new string[] { sn.ToString(), betterTextBox_Exptitle.Text, betterTextBox_expamount.decVal.ToString() });
            betterListView_exp.Items.Add(load);
            sn++;
            betterTextBox_Exptitle.Clear();
            betterTextBox_expamount.Clear();
        }
        int date;
        private void materialButton_save_Click(object sender, EventArgs e)
        {
            var load = db.trips.Find(staffandv_id);
            var savedelivered = new Model.tripondelivered()
            {
                staff_id = load.staff_id,
                vehicle_id = load.vechicle_id,
                date =nepaliCalender_date.Datestamp ,
                updated_at = DateTime.Now,
                created_at = DateTime.Now,
                admin_id = INFO.admin_id,
                amount=betterTextBox_expamount.decVal,
                bill_id=load.id,

            };
            date = nepaliCalender_date.Datestamp;
            var activatedvehicle = db.vehicles.Find(load.vechicle_id);
            activatedvehicle.active = true;
            db.Entry(activatedvehicle).State = System.Data.Entity.EntityState.Modified;
            db.tripondelivereds.Add(savedelivered);
            
            db.SaveChanges();

            foreach (var item in betterListView_orderitem.Items.Cast<Viwer>().ToList())
            {
                item.save(savedelivered.id,savedelivered.date);
            }
            foreach (ListViewItem item1 in betterListView_exp.Items)
            {
                var title = item1.SubItems[1].Text;
                var amount = Convert.ToDecimal(item1.SubItems[2].Text);
                var exp = new Model.expence()
                {
                    title = title,
                    amount = amount,
                    bill_id = load.id,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now,
                    date = nepaliCalender_date.Datestamp,
                    admin_id = INFO.admin_id,
                    vehicle_id =load.vechicle_id
                };
                db.expences.Add(exp);
                db.SaveChanges();
               

            }

            this.Close();
        }

        private void betterTextBox_totalamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton_close1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
