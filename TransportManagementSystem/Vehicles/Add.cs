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
    public partial class Add : Form
    {
        Model.TransportManagementEntities db;
        public delegate void addhandler(Model.vehicle vehicle);
        public event addhandler add;
        public Add()
        {
            InitializeComponent();
            db = DB.Instance;
            foreach (var item in db.staffs.ToList())
            {
                comboBox_staffname.Items.Add(item);
            }
        }

        private void materialButton_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            var addnew = new Model.vehicle()
            {
                vehicle_type = betterTextBox_type.Text,
                vehicle_no = betterTextBox_vehiclenumber.Text,
                modelnumber = betterTextBox_modelnumber.Text,
                chassisnumber = betterTextBox_Chassisnumber.Text,
                carringcapacity = betterTextBox_carringcapacity.Text,
                enginenumber = betterTextBox_Enginenumber.Text,
                date = nepaliCalender_startdate.Datestamp,
                onwername = betterTextBox_ownername.Text,
                staff_id = (comboBox_staffname.SelectedItem as Model.staff).id,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now,
                    admin_id = INFO.admin_id,
                   
                    active=true
                };
                db.vehicles.Add(addnew);
                db.SaveChanges();
                add?.Invoke(addnew);
            this.Close();
            
        }
    }
}
