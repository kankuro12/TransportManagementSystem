using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.TaxPaid
{
    public partial class PaidTax : Form
    {
        Model.TransportManagementEntities db;
        public delegate void addhandler(Model.taxpaid taxpaid);
        public event addhandler adddata;
        public PaidTax(int id)
        {
            InitializeComponent();
            db = DB.Instance;
            var loaddata = db.vehicles.Find(id);
            label_vehiclenumber.Text = loaddata.vehicle_no;
            this.id = id;

            foreach (var year in db.taxcategories.ToList())
            {
                comboBox_taxyear.Items.Add(year);
            }
            foreach (var title in db.taxes.ToList())
            {
                comboBox_Textitle.Items.Add(title);
            }

        }
        int id;
        private void materialButton_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_save_Click(object sender, EventArgs e)
        {
            if (comboBox_taxyear.SelectedItem == null)
            {
                CustomControls.Alert.show("Select", "Please select tax yearr", 2000);
                comboBox_taxyear.Focus();
                return;
            }
            if (comboBox_Textitle.SelectedItem == null)
            {
                CustomControls.Alert.show("Title", "Please select tax title", 2000);
                comboBox_Textitle.Focus();
                return;
            }
            if (betterTextBox_amout.decVal == 0)
            {
                CustomControls.Alert.show("Amount", "Please enter tax amount", 2000);
                betterTextBox_amout.Focus();
                return;
            }
            if (betterTextBox_paidbye.Text.Trim() == "")
            {
                CustomControls.Alert.show("Name", "Please enter Name of paidby", 2000);
                betterTextBox_paidbye.Focus();
                return;
            }
            if (betterTextBox_dis.Text.Trim() == "")
            {
                CustomControls.Alert.show("Discription", "Please enter discription", 2000);
                betterTextBox_dis.Focus();
                return;
            }
            var addnew = new Model.taxpaid()
            {
                vahicle_id = id,
                tax_id = ((comboBox_Textitle.SelectedItem as Model.tax).id),
                taxyear_id = ((comboBox_taxyear.SelectedItem as Model.taxcategory).id),
                date = nepaliCalender_date.Datestamp,
                paidby = betterTextBox_paidbye.Text,
                amount = betterTextBox_amout.decVal,
                discription = betterTextBox_dis.Text,
                admin_id = INFO.admin_id,
                updated_at = DateTime.Now,
                created_at = DateTime.Now
            };
            db.taxpaids.Add(addnew);
            db.SaveChanges();
            adddata?.Invoke(addnew);
            this.Close();
        }
    }

}