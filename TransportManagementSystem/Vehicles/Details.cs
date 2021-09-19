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
    public partial class Details : Form
    {
        Model.TransportManagementEntities db;
        public Details(int id)
        {
            InitializeComponent();
            db = DB.Instance;
            var load = db.vehicles.Find(id);
            betterTextBox_type.Text = load.vehicle_type;
            betterTextBox_vehiclenumber.Text = load.vehicle_no;
            betterTextBox_Enginenumber.Text = load.enginenumber;
            betterTextBox_Chassisnumber.Text = load.chassisnumber;
            betterTextBox_carringcapacity.Text = load.carringcapacity;
            betterTextBox_modelnumber.Text = load.modelnumber;
            betterTextBox_ownername.Text = load.onwername;
            comboBox_vehicletype.Text = load.vehicletype.titile;
            comboBox_staffname.Text = load.staff.name;
            label_Startdate.Text
                 = load.date.ToString();

        }

        private void materialButton_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
