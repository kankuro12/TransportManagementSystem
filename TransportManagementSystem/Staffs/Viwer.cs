using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportManagementSystem.Model;

namespace TransportManagementSystem.Staffs
{
 public  class Viwer:ListViewItem
    {
        public staff Staff { get; set; }
        public int sn = 1;
        public Viwer(staff _staff,int sn)
        {
            for(int i=0; i<8; i++)
            {
                this.SubItems.Add(new ListViewSubItem());
            }
            var db = new Model.TransportManagementEntities();
            Staff = _staff;
            SubItems[0].Text = sn.ToString();
            SubItems[1].Text = Staff.name;
            SubItems[2].Text = Staff.address;
            SubItems[3].Text = Staff.phone;
            SubItems[4].Text = Staff.salary.ToString();
            SubItems[5].Text = Staff.post;
            SubItems[6].Text = Staff.startdate.ToString();
            SubItems[7].Text = Staff.validdate.ToString();
            SubItems[8].Text = Staff.license_number;
            SubItems[9].Text = Staff.description;
            
        }
        public void update(staff _staff)
        {
            Staff = _staff;
            SubItems[0].Text = sn.ToString();
            SubItems[1].Text = Staff.name;
            SubItems[2].Text = Staff.address;
            SubItems[3].Text = Staff.phone;
            SubItems[4].Text = Staff.salary.ToString();
            SubItems[5].Text = Staff.post;
            SubItems[6].Text = Staff.startdate.ToString();
            SubItems[7].Text = Staff.validdate.ToString();
            SubItems[8].Text = Staff.license_number;
            SubItems[9].Text = Staff.description;
        }
        public void initEdit()
        {
            var editstaff = new Staffs.StaffEdit(Staff.id);
            
            editstaff.edit += (_staff) =>
            {
                Staff = (_staff);
                this.update(Staff);
            };
            var trance = new CustomControls.Modal(editstaff);
           trance.ShowDialog();
        }
        public void initdelete()
        {
            try
            {
            var db = new Model.TransportManagementEntities();
            var i = db.staffs.Find(Staff.id);
            db.Entry(i).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            this.ListView.Items.Remove(this);

            }
            catch
            {
                CustomControls.Alert.show("this record is not delete", "this record is not deleted this record is related in another transaction", 3000);
               
            }
        }
    }
}
