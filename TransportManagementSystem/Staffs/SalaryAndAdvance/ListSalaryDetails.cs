using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Staffs.SalaryAndAdvance
{
    public partial class ListSalaryDetails : Form
    {
        int staff_id;
        int sn = 1;
        Model.TransportManagementEntities db;
        public ListSalaryDetails(int staff_id)
        {
            InitializeComponent();
            db = DB.Instance;
            var load = db.staffs.Find(staff_id);
            label_staffname.Text = load.name;
            label_staffphone.Text = load.phone;
            label_staffaddress.Text = load.address;
            label_staffphone.Text = load.phone;
            label_salaryamount.Text = load.salary.Value.ToString();
            this.staff_id = staff_id;
            foreach (var item in db.paidsalarys.Where(o => o.staff_id == staff_id).ToList())
            {
            betterListView_salary.Items.Add(new paidsalaryviwer(item, betterListView_salary.Items.Count + 1));

            }
            foreach (var item in db.paidadvances.Where(o=>o.staff_id==staff_id).ToList())
            {
            betterListView_Advance.Items.Add(new PaidAdvanceViwer(item, betterListView_Advance.Items.Count + 1));

            }
            
        }

        private void materialButton_paidsalary_Click(object sender, EventArgs e)
        {
            var paidsalary = new Staffs.SalaryAndAdvance.PaidSalary(staff_id);
            paidsalary.adddata += Paidsalary_adddata;
            var trance = new CustomControls.Modal(paidsalary);
            trance.Show();
        }

        private void Paidsalary_adddata(Model.paidsalary paidsalary)
        {
            betterListView_salary.Items.Add(new paidsalaryviwer(paidsalary,betterListView_salary.Items.Count+1));
        }

        private void editDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sel = betterListView_salary.SelectedItems[0] as paidsalaryviwer;
            var edit = new Staffs.SalaryAndAdvance.EditPaidSalary(sel.id, staff_id);
            edit.editdata += Edit_editdata;
            var trance = new CustomControls.Modal(edit);
            trance.Show();
        }

        private void Edit_editdata(Model.paidsalary paidsalary)
        {
            var sel = betterListView_salary.SelectedItems[0] as paidsalaryviwer;
            sel.update(paidsalary);
        }

        private void materialButton_paidadvence_Click(object sender, EventArgs e)
        {
            var addadvance = new Staffs.SalaryAndAdvance.PaidAdvance(staff_id);
            addadvance.adddata += Addadvance_adddata;
            var trance = new CustomControls.Modal(addadvance);
            trance.Show();
        }

        private void Addadvance_adddata(Model.paidadvance paidadvance)
        {
            betterListView_Advance.Items.Add(new PaidAdvanceViwer(paidadvance, betterListView_Advance.Items.Count + 1));
        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void editAdvanceDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sel = betterListView_Advance.SelectedItems[0] as PaidAdvanceViwer;
            var edit = new Staffs.SalaryAndAdvance.EditAdvance(sel.id,staff_id);
            edit.editdata += Edit_editdata1;
            var trance = new CustomControls.Modal(edit);
            trance.Show();
        }

        private void Edit_editdata1(Model.paidadvance paidadvance)
        {
            var sel = betterListView_Advance.SelectedItems[0] as PaidAdvanceViwer;
            sel.update(paidadvance);
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
