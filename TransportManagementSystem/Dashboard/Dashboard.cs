using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Dashbord
{
    public partial class Dashboard : Form
    {
        Model.TransportManagementEntities db;
        public static Dashboard instance;
        public Dashboard()
        {
            InitializeComponent();
            db = DB.Instance;
            foreach (var item in db.vehicles.ToList())
            {
                comboBox_vehiclenumber.Items.Add(item);
            }
            var counts = db.staffs.ToList().Count;
            label_totalstaff.Text = counts.ToString();
            var activeitem = db.orderitemlists.Where(o => o.active == true).ToList().Count;
            
            var activevehicle = db.vehicles.Where(o => o.active == true).ToList().Count;
            //lbl_remainingvehicle.Text = activevehicle.ToString();
            var onwayvehicle = db.vehicles.Where(o => o.active == false).ToList().Count;
            //lbl_onwayvehicle.Text = onwayvehicle.ToString();
            var totalvehicle = db.vehicles.ToList().Count;
            lbl_totalvehicle.Text = totalvehicle.ToString();
            var onwayitem = db.tripitems.Where(o => o.active == true).ToList().Count;
            
            var deliverditem = db.tripondelivereditems.ToList().Count;
            
            var sum = db.expences.Sum(o => o.amount);
            lbl_deliveredexp.Text = sum.ToString();
            var expectedincome = db.orderitemlists.Sum(o => o.amount);
            lbl_totalexpectedcome.Text = expectedincome.ToString();

        }

        private void materialButton_location_Click(object sender, EventArgs e)
        {
            var list = new TransportManagementSystem.Location.List();
            var trance = new CustomControls.Modal(list);
            trance.Show();
        }

        private void materialButton_orderlist_Click(object sender, EventArgs e)
        {
            var list = new TransportManagementSystem.Item.List();
            var trance = new CustomControls.Modal(list);
            trance.Show();
        }

        private void materialButton_ordercate_Click(object sender, EventArgs e)
        {
            var list = new TransportManagementSystem.Ordercategories.List();
            var trance = new CustomControls.Modal(list);
            trance.Show();
        }

        private void betterListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButton_createorder_Click(object sender, EventArgs e)
        {
            var addnew = new Bill.bill();
            var modal = new CustomControls.Modal(addnew);
            
            modal.Show();
        }

        private void Addnew_adddata(Model.orderitemlist orderitem)
        {
           
        }

        private void materialButton_orderdetails_Click(object sender, EventArgs e)
        {
            var details = new TransportManagementSystem.Item.List();
            details.ShowDialog();
        }

        private void materialButton_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void financeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void taxToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void materialButton_vehicle_Click(object sender, EventArgs e)
        {
            var addnew = new TransportManagementSystem.Vehicles.List();
            var trance = new CustomControls.Modal(addnew);
            trance.Show();
        }

        private void materialButton_staffdetails_Click(object sender, EventArgs e)
        {
            var staffdetails = new Staffs.StaffList();
            var trance = new CustomControls.Modal(staffdetails);
            trance.Show();
        }

        private void materialButton_refresh_Click(object sender, EventArgs e)
        {
            
            var counts = db.staffs.ToList().Count;
            label_totalstaff.Text = counts.ToString();
            var activeitem = db.orderitemlists.Where(o => o.active == true).ToList().Count;
            
            var activevehicle = db.vehicles.Where(o => o.active == true).ToList().Count;
           // lbl_remainingvehicle.Text = activevehicle.ToString();
            var onwayvehicle = db.vehicles.Where(o => o.active == false).ToList().Count;
            //lbl_onwayvehicle.Text = onwayvehicle.ToString();
            var totalvehicle = db.vehicles.ToList().Count;
            lbl_totalvehicle.Text = totalvehicle.ToString();
            var onwayitem = db.tripitems.Where(o=>o.active==true).ToList().Count;
          
            var deliverditem = db.tripondelivereditems.ToList().Count;
           
            var sum = db.expences.Sum(o => o.amount);
            lbl_deliveredexp.Text = sum.ToString();
            var expectedincome = db.orderitemlists.Sum(o => o.amount);
            lbl_totalexpectedcome.Text = expectedincome.ToString();
        }

        

        private void finalDeliverdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var finallist = new FinalDelivered.Final();
            //var trance =new CustomControls.Modal(finallist);
            finallist.Show();
        }

        //private void editOrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    var sel= betterListView_orderitem.SelectedItems[0] as Item.Viwer;
        //    var edit = new Item.EditItem(sel.id);
        //    edit.editdata += Edit_editdata;
        //    var trance = new CustomControls.Modal(edit);
        //    trance.Show();
        //}

        //private void Edit_editdata(Model.orderitemlist orderitemlist)
        //{
        //    var sel = betterListView_orderitem.SelectedItems[0] as Item.Viwer;
        //    sel.update(orderitemlist);
        //}

        private void onWayOrderListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var onwaylist = new Senditems.WayItemList();
            onwaylist.ShowDialog();
        }

        private void materialButton_load_Click(object sender, EventArgs e)
        {
            betterListView1.Items.Clear();
            foreach (var item in db.bills.Where(o=> o.date<=nepaliCalender_From.Datestamp ||o.date>=nepaliCalender_to.Datestamp).ToList())
            {
                TransportManagementSystem.Dashboard.Loader loader = new TransportManagementSystem.Dashboard.Loader(item,betterListView1.Items.Count+1);
                betterListView1.Items.Add(loader);
            }
        }

        private void materialButton_Finance_Click(object sender, EventArgs e)
        {
            var finance = new TransportManagementSystem.Finances.List();
            var trance = new CustomControls.Modal(finance);
            trance.Show();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var tax = new TransportManagementSystem.Taxes.List();
            var trance = new CustomControls.Modal(tax);
            trance.Show();
        }

        private void betterListView1_DoubleClick(object sender, EventArgs e)
        {
            var sel = betterListView1.SelectedItems[0];
            var id =Convert.ToInt32(sel.SubItems[7].Text);
            var invoice_no = sel.SubItems[1].Text;
            var vehicle_no = sel.SubItems[2].Text;
            var list = new Bill.ListBillItems(id,invoice_no,vehicle_no);
            var t = new CustomControls.Modal(list);
            t.Show();
             
        }

        private void otherExpensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void materialButton_incomeexpdetails_Click(object sender, EventArgs e)
        {
            var o_exp = new Other_Expenses.Add();
            var t = new CustomControls.Modal(o_exp);
            t.Show();
        }
    }
}
