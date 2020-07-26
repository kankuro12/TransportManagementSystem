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
    public partial class PaidList : Form
    {
        Model.TransportManagementEntities db;
        int id;
        public PaidList(int id )
        {
            InitializeComponent();
            db = DB.Instance;
            foreach (var item in db.paidfinances.Where(o=>o.vehicle_id==id).ToList())
            {
                Viwer viwer = new Viwer(item, betterListView1.Items.Count + 1);
                betterListView1.Items.Add(viwer);
            }               
                var load = DB.Instance.vehicles.Find(id);
                label_vehiclenumber.Text = load.vehicle_no;
                this.id = id;
            
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var adddata = new PaidFinance.Add(id);
            var trance = new CustomControls.Modal(adddata);
            adddata.add += Adddata_add;
            trance.Show();
        }

        private void Adddata_add(Model.paidfinance paidfinance)
        {
            betterListView1.Items.Add(new Viwer(paidfinance,betterListView1.Items.Count+1));
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sel = betterListView1.SelectedItems[0] as Viwer;
            var newedit = new PaidFinance.Edit(sel.id);
            var trance = new CustomControls.Modal(newedit);
            newedit.edit += Newedit_edit;
            trance.Show();
        }

        private void Newedit_edit(Model.paidfinance paidfinance)
        {
            var sel = betterListView1.SelectedItems[0] as Viwer;
            sel.update(paidfinance);
        }
    }
}
