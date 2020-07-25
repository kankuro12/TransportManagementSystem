using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.FinalDelivered.Undelivered
{
    public partial class UndeliveredItems : Form
    {
        Model.TransportManagementEntities db;
        int staffandv_id;
        int billid;
        public UndeliveredItems(List<int> ID, int bill_id)
        {
            InitializeComponent();
            db = DB.Instance;
            foreach (var item in db.tripitems.Where(o => ID.Contains(o.id)).ToList())
            {
                FinalDelivered.Delivered.Viwer viwer = new FinalDelivered.Delivered.Viwer(item, betterListView_orderitem.Items.Count + 1);
                betterListView_orderitem.Items.Add(viwer);
                var load = db.trips.Find(bill_id);
                label_vehiclenumber.Text = load.vehicle.vehicle_no;
                label_staffname.Text = load.vehicle.staff.name;
                
            }
            this.staffandv_id = bill_id;
            this.billid = bill_id;
            foreach (ListViewItem lstItem in betterListView_orderitem.Items) // listView has ListViewItem objects
            {
                valorSum += Convert.ToDecimal(lstItem.SubItems[13].Text); // Columns 4
            }
            betterTextBox_totalamount.decVal = valorSum;
        }
        decimal valorSum;
        int orderitem_id;
    

        private void materialButton_close1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_save_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lstItem in betterListView_orderitem.Items) // listView has ListViewItem objects
            {
               orderitem_id =Convert.ToInt32(lstItem.SubItems[15].Text); // Columns 4

                var orderitemactive = db.orderitemlists.Where(o=>o.id==orderitem_id).First();
                orderitemactive.active = true;
                db.Entry(orderitemactive).State = System.Data.Entity.EntityState.Modified;
                var load = db.trips.Find(billid);
                load.vehicle.active = true;
                var activatedvehicle = db.vehicles.Find(load.vechicle_id);
                db.Entry(activatedvehicle).State = System.Data.Entity.EntityState.Modified;
                foreach (var item in db.tripitems.Where(o => o.item_id == orderitem_id).ToList())
                {
                    item.active = false;
                    db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                }
               
                db.SaveChanges();
                this.Close();
            }
        }

        private void betterListView_orderitem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
