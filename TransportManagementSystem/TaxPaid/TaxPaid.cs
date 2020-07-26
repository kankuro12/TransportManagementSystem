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
    public partial class TaxPaid : Form
    {
        int id;
        Model.TransportManagementEntities db;
        public TaxPaid(int id)
        {
            InitializeComponent();
            db = DB.Instance;
            var load = db.vehicles.Find(id);
            label_vehiclenumber.Text = load.vehicle_no;
            this.id = id;
            foreach (var item in db.taxpaids.Where(o=>o.vahicle_id==id).ToList())
            {
                Viwer viwer = new Viwer(item, betterListView1.Items.Count + 1);
                betterListView1.Items.Add(viwer);
            }
           

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var add = new PaidTax(id);
            var trance = new CustomControls.Modal(add);
            add.adddata += Add_adddata;
            trance.Show();
        }

        private void Add_adddata(Model.taxpaid taxpaid)
        {
      
            betterListView1.Items.Add(new Viwer(taxpaid,betterListView1.Items.Count+1));
           
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sel = betterListView1.SelectedItems[0] as Viwer;
            var edit = new TransportManagementSystem.TaxPaid.Edit(sel.id);
            edit.edit += Edit_edit;
            var trance = new CustomControls.Modal(edit);

            trance.Show();

        }

        private void Edit_edit(Model.taxpaid taxpaid)
        {
            
                var sel = betterListView1.SelectedItems[0] as Viwer;
                sel.update(taxpaid);
            
        }
    }
}
