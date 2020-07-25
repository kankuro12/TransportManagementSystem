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
        public Viwer(staff _staff)
        {
            for(int i=0; i<8; i++)
            {
                this.SubItems.Add(new ListViewSubItem());
            }
            var db = new Model.TransportManagementEntities();
            Staff = _staff;
            SubItems[0].Text = Staff.name;
            SubItems[1].Text = Staff.address;
            SubItems[2].Text = Staff.phone;
            SubItems[3].Text = Staff.salary.ToString();
            SubItems[4].Text = Staff.post;
            SubItems[5].Text = Staff.startdate.ToString();
            SubItems[6].Text = Staff.description;
            
        }
        public void update(staff _staff)
        {
            Staff = _staff;
            SubItems[0].Text = Staff.name;
            SubItems[1].Text = Staff.address;
            SubItems[2].Text = Staff.phone;
            SubItems[3].Text = Staff.salary.ToString();
            SubItems[4].Text = Staff.post;
            SubItems[5].Text = Staff.startdate.ToString();
            SubItems[6].Text = Staff.description;
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
