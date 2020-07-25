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
using TransportManagementSystem.Taxes;

namespace TransportManagementSystem.Finances
{
    public partial class List : Form
    {
        TransportManagementEntities db;
        public List()
        {
            InitializeComponent();
            db = DB.Instance;
            foreach (var item in db.finances.ToList())
            {
                add(item); 
            }
        }
        private void Newitem_savedata(finance finance)
        {
            add(finance);
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            Add newitem = new Add();
            var trans = new CustomControls.Modal(newitem);
            newitem.add += Newitem_savedata;
            trans.Show();
        }
        private void add(Model.finance finance)
        {
            var viwer = new Finances.Viwer();
            viwer.id = finance.id;
            viwer.name = finance.name;
            viwer.address = finance.address;
            viwer.phone = finance.phone;
            viwer.email = finance.email;
            viwer.Dock = DockStyle.Top;
            flowLayoutPanel1.Controls.Add(viwer);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            foreach (Control item in flowLayoutPanel1.Controls)
            {
                var c = item as Viwer;
                if (c.name.ToLower().Contains(txt_search.Text.ToLower()))
                {
                    c.Show();
                }
                else
                {
                    c.Hide();
                }
            }
        }

        private void panel_top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
