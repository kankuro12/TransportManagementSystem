using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.PaidFinance
{
    public partial class Edit : Form
    {
        public delegate void edithandler(Model.paidfinance paidfinance);
        public event edithandler edit;
        int id;
        public Edit(int id)
        {
            InitializeComponent();
           
              var loadnum = DB.Instance.vehicles.Find(id);
                label_vehiclenumber.Text = loadnum.vehicle_no;
                var loaddata = DB.Instance.paidfinances.Find(id);
                comboBox_finance.Text = (loaddata.finance as Model.finance).name;
                betterTextBox_amout.decVal = loaddata.paidamount.Value;
                betterTextBox_paidbye.Text = loaddata.paidby;
                betterTextBox_Title.Text = loaddata.title;
                betterTextBox_dis.Text = loaddata.discription;
                this.id = id;

            
        }

        private void materialButton_save_Click(object sender, EventArgs e)
        {
            if (comboBox_finance.SelectedItem == null)
            {
                CustomControls.Alert.show("Select", "Please select finance name", 2000);
                return;
            }
            if (betterTextBox_Title.Text.Trim() == "")
            {
                CustomControls.Alert.show("Amount", "Please enter payment title", 2000);
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
           
                var editdata = DB.Instance.paidfinances.Find(id);
                editdata.finance_id = (comboBox_finance.SelectedItem as Model.paidfinance).id;
                editdata.title = betterTextBox_Title.Text;
                editdata.paidby = betterTextBox_paidbye.Text;
                editdata.paidamount = betterTextBox_amout.decVal;
                editdata.date = nepaliCalender_date.Datestamp;
                editdata.discription = betterTextBox_dis.Text;
                DB.Instance.Entry(editdata).State = System.Data.Entity.EntityState.Modified;
                DB.Instance.SaveChanges();
                edit?.Invoke(editdata);
                this.Close();
            
        }

        private void materialButton_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
