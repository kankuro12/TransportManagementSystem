using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportManagementSystem.Model;

namespace TransportManagementSystem.Staffs
{
    public partial class StaffList : Form
    {
        int id;
        TransportManagementEntities db;
        public StaffList()
        {
            InitializeComponent();
            db = DB.Instance;
                foreach(var item in db.staffs.ToList())
                {
                    betterListView1.Items.Add(new Viwer(item));
                
                }
            
        }

        private void eDITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (betterListView1.SelectedItems.Count > 0)
            {
                (betterListView1.SelectedItems[0] as Viwer).initEdit();
            }
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (betterListView1.SelectedItems.Count > 0)
            {
                (betterListView1.SelectedItems[0] as Viwer).initdelete();
            }
        }

        private void betterTextBox1_TextChanged(object sender, EventArgs e)
        {
            var id = (txt_search.Text);
            betterListView1.Items.Clear();
            foreach (var load in db.staffs.Where(o => o.name.Contains(id)).ToList())
            {
                betterListView1.Items.Add(new Viwer(load));
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var i = new StaffAdd();
            var trance = new CustomControls.Modal(i);
            i.add += I_add;
            trance.Show();
        }

        private void I_add(staff staff)
        {
            betterListView1.Items.Add(new Viwer(staff));
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salaryAdvanceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sel = betterListView1.SelectedItems[0] as Viwer;
            var staff = new Staffs.SalaryAndAdvance.ListSalaryDetails(sel.Staff.id);
            var trans = new CustomControls.Modal(staff);
            trans.Show();

        }
    }
}
