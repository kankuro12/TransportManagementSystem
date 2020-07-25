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
    
    public partial class PaidAdvance : Form
    {
        public delegate void addhandler(Model.paidadvance paidadvance);
        public event addhandler adddata;
        public PaidAdvance(int staff_id)
        {
            InitializeComponent();
            var load = DB.Instance.staffs.Find(staff_id);
            label_staffname.Text = load.name;
            label_phonenumber.Text = load.phone;
            this.staff_id = staff_id;
        }
        int staff_id;
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
            var add = new Model.paidadvance()
            {
                paid_date = nepaliCalender_paiddate.Datestamp,
                staff_id = staff_id,
                paidamount = betterTextBox_amount.decVal,
                paidby = betterTextBox_paidby.Text,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            };
           var load= DB.Instance.staffs.Find(staff_id);
            load.advance += betterTextBox_amount.decVal;
            DB.Instance.Entry(load).State = System.Data.Entity.EntityState.Modified;
            DB.Instance.paidadvances.Add(add);
            DB.Instance.SaveChanges();
            adddata?.Invoke(add);
            this.Close();
        }

        private void materialButton_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_clsoe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
