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
    
    public partial class WayItemList : Form
    {
        Model.TransportManagementEntities db;
        public WayItemList()
        {
            
            InitializeComponent();
            db = DB.Instance;
            foreach (var item in db.vehicles.Where(o => o.active == false).ToList())
            {
                comboBox_vehiclelist.Items.Add(item);  
                
            }
            
        }
        int vehicle_id;
        private void materialButton_close1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_load_Click(object sender, EventArgs e)
        {
            betterListView_orderitem.Items.Clear();
            var v_id = (comboBox_invoicelist.SelectedItem as Model.trip).id;
            var activeitem = db.tripitems.Where(o => o.active == true).ToList();
            foreach (var item in activeitem.Where(o =>o.bill_id==v_id).ToList())
            {
                betterListView_orderitem.Items.Add(new OnwayItemViwer(item,betterListView_orderitem.Items.Count+1));

            }
        }

        private void comboBox_vehiclelist_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_invoicelist.Items.Clear();
            if (comboBox_vehiclelist.SelectedIndex > -1)
            {
                var v_id = (comboBox_vehiclelist.SelectedItem as Model.vehicle).id;
                comboBox_invoicelist.Items.AddRange(db.trips.Where(o => o.vechicle_id == v_id).ToArray());
            }
            else
            {
                comboBox_invoicelist.Items.Clear();
            }

        }

        private void comboBox_invoicelist_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
