using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Customers
{
    public partial class List : Form
    {
        Model.TransportManagementEntities db;

        public List()
        {
            InitializeComponent();
            db = DB.Instance;
            foreach (var item in db.customers.ToList())
            {
                betterListView1.Items.Add(new Viewer(item, betterListView1.Items.Count + 1));
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var add = new Customers.Add();
            var trance = new CustomControls.Modal(add);
            add.add += Add_add;
            trance.Show();
        }

        private void Add_add(Model.customer customer)
        {
            betterListView1.Items.Add(new Viewer(customer, betterListView1.Items.Count+1));
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sel = betterListView1.SelectedItems[0] as Viewer;
            var data = new Customers.Edit(sel.id);
            var t = new CustomControls.Modal(data);
            data.edit += Data_edit;
            t.Show();
            
        }

        private void Data_edit(Model.customer customer)
        {
            var sel = betterListView1.SelectedItems[0] as Viewer;
            sel.update(customer);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            var id = (txt_search.Text);
            betterListView1.Items.Clear();
            foreach (var load in db.customers.Where(o => o.name.Contains(id)).ToList())
            {
                betterListView1.Items.Add(new Viewer(load, betterListView1.Items.Count + 1));
            }
        }

        private void betterListView1_DoubleClick(object sender, EventArgs e)
        {
            var sel = betterListView1.SelectedItems[0] as Customers.Viewer;
            var load = new Customers.Custimeredger(sel.id);
            var t = new CustomControls.Modal(load);
            t.Show();

        }
    }
}
