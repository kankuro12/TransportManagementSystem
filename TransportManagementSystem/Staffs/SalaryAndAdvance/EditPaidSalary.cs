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
    public partial class EditPaidSalary : Form
    {
        Model.TransportManagementEntities db;
        public delegate void edithandler(Model.paidsalary paidsalary);
        public event edithandler editdata;
        public EditPaidSalary(int id,int staff_id)
        {
            InitializeComponent();
            db = DB.Instance;
            var load = db.paidsalarys.Find(id);
            betterTextBox_amount.decVal = load.paidamount;
            betterTextBox_advance.decVal = load.usedadvence;
            betterTextBox_paidby.Text = load.paidby;
            var loaddata = db.staffs.Find(staff_id);
            label_phonenumber.Text = loaddata.phone;
            label_staffname.Text = loaddata.name;
            this.id = id;
            this.staff_id = staff_id;
        }
      int  staff_id;
        int id;
        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
            var edit = db.paidsalarys.Find(id);
            //var loadadv = db.staffs.Find(staff_id);
           // loadadv.advance = (loadadv.advance + edit.usedadvence) + betterTextBox_advance.decVal;
           // db.Entry(loadadv).State = System.Data.Entity.EntityState.Modified;
            edit.staff_id = staff_id;
            edit.paidby = betterTextBox_paidby.Text;
            edit.paidamount = betterTextBox_amount.decVal;
            edit.paid_date = nepaliCalender_paiddate.Datestamp;
            edit.paid_form = nepaliCalender_paidfrom.Datestamp;
            edit.paid_to = nepaliCalender_paidto.Datestamp;
            db.Entry(edit).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            editdata?.Invoke(edit);
            this.Close();
        }
    }
}
