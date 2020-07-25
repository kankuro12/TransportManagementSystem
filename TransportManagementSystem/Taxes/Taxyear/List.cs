using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Taxes.Taxyear
{
    public partial class List : Form
    {
        Model.TransportManagementEntities db;
        public List()
        {
            InitializeComponent();
            db = DB.Instance;
            foreach (var id in db.taxcategories.Select(o => o.id))
            {
                flowLayoutPanel1.Controls.Add(new Viwer(id));
            }

        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_addnew_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new Viwer());
        }
    }
}
