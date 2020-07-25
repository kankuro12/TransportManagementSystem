using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Bill
{
    public partial class ListBillItems : Form
    {
        Model.TransportManagementEntities db;
        public ListBillItems(int id,string invoice_no,string vehicle_no)
        {
            InitializeComponent();
            db = DB.Instance;
            label_invoicenumber.Text = invoice_no;
            label_Vehiclenumber.Text = vehicle_no;
            foreach (var item in db.billitems.Where(o=>o.bill_id==id).ToList())
            {
                Bill.billviewer viewer = new Bill.billviewer(item, betterListView_billitems.Items.Count + 1);
                betterListView_billitems.Items.Add(viewer);
            }

        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
