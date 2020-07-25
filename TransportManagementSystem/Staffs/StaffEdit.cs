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
    public partial class StaffEdit : Form
    {
     
        public delegate void editHandler(Model.staff staff);
        public event editHandler edit;
        int id;
        Model.TransportManagementEntities db;
        public StaffEdit(int _id)
        {
            InitializeComponent();
            db = DB.Instance;
            id = _id;           
            var selected = db.staffs.Where(o => o.id == id).First();
            txt_name.Text = selected.name;
            txt_address.Text = selected.address;
            txt_phone.Text = selected.phone;
             txt_salary.decVal = selected.salary.Value;
            txt_post.Text = selected.post;
            //txt_photo.Text = selected.photo;
            txt_description.Text = selected.description;
            nepaliCalender1.Datestamp = selected.startdate.Value;
        }

        private void StaffEdit_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Trim() == "")
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

            try
            {
                var i = db.staffs.Find(id);
                i.name = txt_name.Text;
                i.address = txt_address.Text;
                i.phone = txt_phone.Text;
                i.salary = txt_salary.decVal;
                i.post = txt_post.Text;
                //i.photo = txt_photo.Text;
                i.description = txt_description.Text;
                i.startdate = nepaliCalender1.Datestamp;
                i.created_at = DateTime.Now;
                i.updated_at = DateTime.Now;
                db.Entry(i).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                edit?.Invoke(i);
                this.Close();
            }
            catch (Exception ex)
            {
                CustomControls.Alert.show("Data", "Error Data", 1500);
            }
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {
            
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
