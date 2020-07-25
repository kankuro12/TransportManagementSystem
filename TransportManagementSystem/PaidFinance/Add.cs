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
    public partial class Add : Form
    {
        public delegate void addhandler(Model.paidfinance paidfinance);
        public event addhandler add;
        int id;
        public Add(int id)
        {
            InitializeComponent();

            var load = DB.Instance.vehicles.Find(id);
            label_vehiclenumber.Text = load.vehicle_no;

            foreach (var finance in DB.Instance.finances.ToList())
            {
                comboBox_finance.Items.Add(finance);
            }
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


            var adddata = new Model.paidfinance()
            {
                vehicle_id = id,
                title = betterTextBox_Title.Text,
                paidamount = betterTextBox_amout.decVal,
                discription = betterTextBox_dis.Text,
                date = nepaliCalender_date.Datestamp,
                finance_id = ((comboBox_finance.SelectedItem as Model.finance).id),
                paidby = betterTextBox_paidbye.Text,
                updated_at = DateTime.Now,
                created_at = DateTime.Now,
                admin_id = INFO.admin_id,

            };

            DB.Instance.paidfinances.Add(adddata);
            DB.Instance.SaveChanges();
            add?.Invoke(adddata);
            this.Close();

        }

        private void materialButton_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
