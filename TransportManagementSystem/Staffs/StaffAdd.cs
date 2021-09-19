using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportManagementSystem.Model;

namespace TransportManagementSystem.Staffs
{
    public partial class StaffAdd : Form
    {
        TransportManagementEntities db;
        public delegate void addHandler(Model.staff staff);
        public event addHandler add;
        public StaffAdd()
        {
            InitializeComponent();
            db = DB.Instance;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btn_add_Click(object sender, EventArgs e)
        {
            if(txt_name.Text.Trim()=="")
            {
                CustomControls.Alert.show("name", "Enter Name", 1500);
                return;
            }
            if (txt_address.Text.Trim() == "")
            {
                CustomControls.Alert.show("address", "Enter Address", 1500);
                return;
            }
            if (txt_phone.Text.Trim() == "")
            {
                CustomControls.Alert.show("phone", "Enter phone", 1500);
                return;
            }
            if (txt_salary.Text.Trim() == "")
            {
                CustomControls.Alert.show("salary", "Enter Salary", 1500);
                return;
            }
            if (txt_post.Text.Trim() == "")
            {
                CustomControls.Alert.show("post", "Enter post", 1500);
                return;
            }
            if (betterTextBox_licenseno.Text.Trim() == "")
            {
                CustomControls.Alert.show("post", "Enter license number", 1500);
                return;
            }

            try
            {


                var i = new staff()
                {
                    name = txt_name.Text,
                    address = txt_address.Text,
                    phone = txt_phone.Text,
                    salary = txt_salary.decVal,
                    post = txt_post.Text,
                    //photo = txt_photo.Text,
                    description = txt_description.Text,
                    startdate = nepaliCalender1.Datestamp,
                    license_number=betterTextBox_licenseno.Text,
                    validdate=nepaliCalender_validdate.Datestamp,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                db.staffs.Add(i);
                db.SaveChanges();
                add?.Invoke(i);
                this.Close();
            }
            catch (Exception ex)
            {
                CustomControls.Alert.show("Data", "Error Data", 1500);
            }
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
