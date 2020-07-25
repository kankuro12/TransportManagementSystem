using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Staffs.SalaryAndAdvance
{
    public partial class EditAdvance : Form
    {
        public delegate void edithandler(Model.paidadvance paidadvance);
        public event edithandler editdata;
        Model.TransportManagementEntities db;
        public EditAdvance(int id,int staff_id)
        {
            InitializeComponent();
            db = DB.Instance;
            var load = db.staffs.Find(staff_id);
            label_staffname.Text = load.name;
            label_phonenumber.Text = load.phone;
            this.staff_id = staff_id;
            this.id = id;
            var loaddata = db.paidadvances.Find(id);
            betterTextBox_amount.decVal = loaddata.paidamount;
            betterTextBox_paidby.Text = loaddata.paidby;
        }
        int id, staff_id;
        private void materialButton_save_Click(object sender, EventArgs e)
        {
            if (betterTextBox_amount.decVal == 0)
            {
                CustomControls.Alert.show("Amount ", "enter paid amount", 2000);
                return;
            }
            if (betterTextBox_paidby.Text.Trim() == "")
            {
                CustomControls.Alert.show("name ", "enter paid by", 2000);
                return;
            }
            var edit = db.paidadvances.Find(id);
            var loaddata = db.staffs.Find(staff_id);
            loaddata.advance = (loaddata.advance - edit.paidamount) + betterTextBox_amount.decVal;
            db.Entry(loaddata).State = System.Data.Entity.EntityState.Modified;
            edit.paidamount = betterTextBox_amount.decVal;
            edit.paidby = betterTextBox_paidby.Text;
            edit.staff_id = staff_id;
            edit.paid_date = nepaliCalender_paiddate.Datestamp;
            edit.updated_at = DateTime.Now;
            edit.created_at = DateTime.Now;
            db.Entry(edit).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            editdata?.Invoke(edit);
            this.Close();
        }
    }
}
