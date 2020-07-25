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
    public partial class Edit : Form
    {
        public delegate void edithandler(Model.taxpaid taxpaid);
        public event edithandler edit;
        Model.TransportManagementEntities db;
        public Edit(int id)
        {
            InitializeComponent();
            db = DB.Instance;
                foreach (var taxyear in db.taxcategories.ToList())
                {
                    comboBox_taxyear.Items.Add(taxyear);
                }
                foreach (var title in db.taxes.ToList())
                {
                    comboBox_Textitle.Items.Add(title);
                }
                var loaddata = db.taxpaids.Find(id);
                comboBox_taxyear.Text = ((loaddata.taxcategory as Model.taxcategory).name);
                comboBox_Textitle.Text = (loaddata.tax as Model.tax).title;
                betterTextBox_paidbye.Text = loaddata.paidby;
                betterTextBox_amout.decVal = loaddata.amount.Value;
                betterTextBox_dis.Text = loaddata.discription;
                this.id = id;
            
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
                return;
            }
            if (comboBox_Textitle.SelectedItem == null)
            {
                CustomControls.Alert.show("Title", "Please select tax title", 2000);
                return;
            }
            if (betterTextBox_amout.decVal == 0)
            {
                CustomControls.Alert.show("Amount", "Please enter tax amount", 2000);
                return;
            }
            if (betterTextBox_paidbye.Text.Trim() == "")
            {
                CustomControls.Alert.show("Name", "Please enter Name of paidby", 2000);
                return;
            }
            if (betterTextBox_dis.Text.Trim() == "")
            {
                CustomControls.Alert.show("Discription", "Please enter discription", 2000);
                return;
            }
              var editdata = db.taxpaids.Find(id);
                editdata.taxyear_id = ((comboBox_taxyear.SelectedItem as Model.taxcategory).id);
                editdata.tax_id = ((comboBox_Textitle.SelectedItem as Model.tax).id);
                editdata.paidby = betterTextBox_paidbye.Text;
                editdata.amount = betterTextBox_amout.decVal;
                editdata.discription = betterTextBox_dis.Text;
                editdata.date = nepaliCalender_date.Datestamp;
                db.Entry(editdata).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                edit?.Invoke(editdata);
                this.Close();
            
        }
    }
}
