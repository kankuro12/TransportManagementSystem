using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Other_Expenses
{
    public partial class ListExpItems : Form
    {
        Model.TransportManagementEntities db;
        public ListExpItems(int id,string vehicle_no,int date)
        {
            InitializeComponent();
            db = DB.Instance;
            label_id.Text = id.ToString();
            label_vehicleno.Text = vehicle_no;
            label_date.Text = date.ToString();
            foreach (var item in db.otherexpitems.Where(o=>o.otherexp_id==id).ToList())
            {
                listviewer viewer = new listviewer(item,betterListView_list.Items.Count+1);
                betterListView_list.Items.Add(viewer);
            }
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
