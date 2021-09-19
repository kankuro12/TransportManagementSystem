using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Vehicles
{
    public partial class List : Form
    {
        Model.TransportManagementEntities db;
        public List()
        {
            InitializeComponent();
            db = DB.Instance;
           
            
                foreach (var item in db.vehicles.ToList())
                {
                    add(item);
                }
            
        }

        private void materialButton_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addnew_add(Model.vehicle vehicle)
        {
            add(vehicle);
        }
        private void materialButton_add_Click(object sender, EventArgs e)
        {
            var addnew = new TransportManagementSystem.Vehicles.Add();
            var trance = new CustomControls.Modal(addnew);
            addnew.add += Addnew_add;
            trance.Show();
        }

        public void add(Model.vehicle vehicle)
        {
            var viwer = new Vehicles.Viwer();
            viwer.id = vehicle.id;
            viwer.vehiclenumber = vehicle.vehicle_no;
            flowLayoutPanel1.Controls.Add(viwer);
        }

        private void materialButton_addtype_Click(object sender, EventArgs e)
        {
            var type = new Vehicles.Type.List();
            var t = new CustomControls.Modal(type);
            t.Show();
        }
    }
}
