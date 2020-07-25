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
    public partial class PaidSalary : Form
    {
        Model.TransportManagementEntities db;
        public delegate void addhandler(Model.paidsalary paidsalary);
        public event addhandler adddata;
        public PaidSalary(int id)
        {
            InitializeComponent();
            db = DB.Instance;
            var load = db.staffs.Find(id);
            label_staffname.Text = load.name;
            label_phonenumber.Text = load.phone;
            var advance = db.staffs.Find(id);
            betterTextBox_advance.decVal = advance.advance;
            betterTextBox_advance.Enabled = false;
            this.staff_id = id;
        }
        int staff_id;
        private void materialButton_save_Click(object sender, EventArgs e)
        {
            if (betterTextBox_amount.decVal == 0)
            {
                CustomControls.Alert.show("Amount ", "enter paid amount", 2000);
                return;
            }
            if (betterTextBox_paidby.Text.Trim()=="")
            {
                CustomControls.Alert.show("name ", "enter paid by", 2000);
                return;
            }
            var add = new Model.paidsalary()
            {
                staff_id = staff_id,
                paidamount = betterTextBox_amount.decVal,
                paid_form = nepaliCalender_paidfrom.Datestamp,
                paid_to = nepaliCalender_paidto.Datestamp,
                paid_date = nepaliCalender_paiddate.Datestamp,
                paidby = betterTextBox_paidby.Text,
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
                usedadvence = betterTextBox_useadvanceamount.decVal

            };
            if (checkBox_usedadvance.Checked)
            {
                var advance = db.staffs.Find(staff_id);
                if (betterTextBox_useadvanceamount.decVal<=advance.advance)
                {
                advance.advance -= betterTextBox_useadvanceamount.decVal;
                }
                else
                {
                    CustomControls.Alert.show("Advance amount", "your used advance amount is greter then paid advance amount please check",4000);
                    return;
                }
                db.Entry(advance).State = System.Data.Entity.EntityState.Modified;
            }
            db.paidsalarys.Add(add);
            db.SaveChanges();
            adddata.Invoke(add);
            this.Close();
            this.Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_usedadvance_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
