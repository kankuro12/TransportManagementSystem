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

namespace TransportManagementSystem.Taxes
{
    public partial class List : Form
    {
        TransportManagementEntities db;
        public List()
        {
            InitializeComponent();
            db = DB.Instance;
            foreach(var item in db.taxes.ToList())
            {
                add(item);
            }
        }
        private void Newitem_savedata(tax tax)
        {
            add(tax);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Add newitem = new Add();
            var trans = new CustomControls.Modal(newitem);
            newitem.add += Newitem_savedata;
            trans.Show();
        }
        private void add(Model.tax tax)
        {
            var viwer = new Taxes.Viwer();
            viwer.id = tax.id;
            viwer.category_id = (tax.taxcategory as Model.taxcategory).name;
            viwer.title = tax.title;
            
            viwer.Dock = DockStyle.Top;
            FlowLayoutPanel1.Controls.Add(viwer);

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            foreach (Control item in FlowLayoutPanel1.Controls)
            {
                var c = item as Viwer;
                if (c.category_id.ToLower().Contains(txt_search.Text.ToLower()))
                {
                    c.Show();
                }
                else
                {
                    c.Hide();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_year_Click(object sender, EventArgs e)
        {
            var taxyear = new TransportManagementSystem.Taxes.Taxyear.List();
            var trance = new CustomControls.Modal(taxyear);
            trance.Show();
        }
    }
}
