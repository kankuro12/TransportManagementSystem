using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.FinalDelivered
{
    public partial class Final : Form
    {
        Model.TransportManagementEntities db;
        public Final()
        {
            InitializeComponent();
            db = DB.Instance;
        }

        private void betterTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        int i = 1;
        private void materialButton_addexp_Click(object sender, EventArgs e)
        {
        }
        int bill_id;
        private void materialButton_load_Click(object sender, EventArgs e)
        {

                   
            try
            {

                {

                    panel_list.Controls.Clear();
                    var bill = db.trips.Find(betterTextBox_invoicenumber.intVal);
                    var load = bill.tripitems.Where(o=>o.active==true).ToList();
                    label_vehiclenumber.Text = bill.vehicle.vehicle_no;
                    label_staffname.Text = bill.vehicle.staff.name;
                    this.bill_id = bill.id;
                    foreach (var item in load.ToList())
                    {
                        add(item);
                    }

                }
            }
            catch (Exception ex)
            {
                CustomControls.Alert.show("bill ", ex.Message, 3000);
                return;
            }



        }
        public void add(Model.tripitem billitem)
        {
            var viwer = new FinalDelivered.SenderViwer();
            viwer.id =billitem.id;
            viwer.itemname = (billitem.orderitemlist as Model.orderitemlist).itemname;
            viwer.sendername = billitem.sender_name;
            viwer.receiverphone = billitem.receiverphone;
            viwer.receivername = billitem.receivername;
            viwer.from = (billitem.location as Model.location).name;
            viwer.tooo = (billitem.location1 as Model.location).name;
            viwer.senderphone = billitem.sender_phone;
            viwer.weight = billitem.weight.Value;
            viwer.quantity = billitem.quantity.Value;
            viwer.deliver_place = billitem.deliver_place;
            viwer.unit = billitem.unit;
            viwer.rate = billitem.amount.Value;
            viwer.Dock = DockStyle.Top;
            panel_list.Controls.Add(viwer);

        }

        private void materialButton_close1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_save_Click(object sender, EventArgs e)
        {
            var list = panel_list.Controls.Cast<FinalDelivered.SenderViwer>().Where(o => o.sel == true).Select(o => o.id).ToList();
            
            var senddata = new FinalDelivered.Delivered.SaveDeliveredItems(list,bill_id);

            senddata.ShowDialog();
            this.Close();
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_undeliverditem_Click(object sender, EventArgs e)
        {
            var list = panel_list.Controls.Cast<FinalDelivered.SenderViwer>().Where(o => o.sel == true).Select(o => o.id).ToList();

            var senddata = new FinalDelivered.Undelivered.UndeliveredItems(list, bill_id);

            senddata.ShowDialog();
            this.Close();
        }
    }
}