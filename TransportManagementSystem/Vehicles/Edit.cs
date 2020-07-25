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
    public partial class Edit : Form
    {
        Model.TransportManagementEntities db;
        public delegate void edithandeler(Model.vehicle vehicle);
        public event edithandeler edit;
        int id;
        public Edit()
        {
            InitializeComponent();
            db = DB.Instance;
            foreach ( var item in db.staffs.ToList())
            {
                comboBox_staffname.Items.Add(item);
            }
        }

        private void materialButton_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loadata(int id)
        {
            var load = db.vehicles.Find(id);
            betterTextBox_type.Text = load.vehicle_type;
            betterTextBox_vehiclenumber.Text = load.vehicle_no;
            betterTextBox_Enginenumber.Text = load.enginenumber;
            betterTextBox_Chassisnumber.Text = load.chassisnumber;
            betterTextBox_carringcapacity.Text = load.carringcapacity;
            betterTextBox_modelnumber.Text = load.modelnumber;
            betterTextBox_ownername.Text = load.onwername;
            nepaliCalender_startdate.Datestamp = load.date.Value;
            comboBox_staffname.Text = load.staff.name;
            this.id = id;
        }
        private void materialButton_save_Click(object sender, EventArgs e)
        {
            if (betterTextBox_vehiclenumber.Text.Trim() == "")
            {
                CustomControls.Alert.show("Number", "Please Enter Vehicle Number", 2000);
                return;
            }
            if (betterTextBox_type.Text.Trim() == "")
            {
                CustomControls.Alert.show("Type", "Please Enter Vehicle Type", 2000);
                return;
            }
            if (betterTextBox_modelnumber.Text.Trim() == "")
            {
                CustomControls.Alert.show("Model Number", "Please Enter Model Number", 2000);
                return;
            }
            if (betterTextBox_Chassisnumber.Text.Trim() == "")
            {
                CustomControls.Alert.show("Chassis Number", "Please Enter Chassis Number", 2000);
                return;
            }
            if (betterTextBox_carringcapacity.Text.Trim() == "")
            {
                CustomControls.Alert.show("Carring Capacity", "Please Enter Carring Capacity", 2000);
                return;
            }
            if (betterTextBox_ownername.Text.Trim() == "")
            {
                CustomControls.Alert.show("Name", "Please Enter owner Name", 2000);
                return;
            }

            if (comboBox_staffname.SelectedItem == null)
            {
                CustomControls.Alert.show("Select Name", "Please Select staff name", 2000);
                comboBox_staffname.Focus();
                return;
            }
            var load = db.vehicles.Find(id);
            load.vehicle_no = betterTextBox_vehiclenumber.Text;
            load.vehicle_type = betterTextBox_type.Text;
            load.modelnumber = betterTextBox_modelnumber.Text;
            load.carringcapacity = betterTextBox_carringcapacity.Text;
            load.chassisnumber = betterTextBox_Chassisnumber.Text;
            load.onwername = betterTextBox_ownername.Text;
            load.date = nepaliCalender_startdate.Datestamp;
            load.enginenumber = betterTextBox_Enginenumber.Text; 
            load.staff_id = (comboBox_staffname.SelectedItem as Model.staff).id;
            db.Entry(load).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            edit?.Invoke(load);
            this.Close();

        }
    
    }
}
