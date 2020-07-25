using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportManagementSystem.Model;

namespace TransportManagementSystem.Taxes
{
    public partial class Viwer : UserControl
    {
        TransportManagementEntities db;
        public Model.tax tax { get; set; }

        public Viwer()
        {
            InitializeComponent();
            db = DB.Instance;
        }
        public int id { get; set; }
        public string category_id
        {
            get
            {
                return lbl_category.Text; 
            }
            set
            {
                lbl_category.Text = value.ToString();
            }
        }
        public string title
        {
            get
            {
                return lbl_title.Text;
            }
            set
            {
                lbl_title.Text = value;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            var edit = new Taxes.Edit();
            edit.loaddata(this.id);
            var trance = new CustomControls.Modal(edit);
            edit.edit += I_edit;
            trance.Show();
        }
        private void I_edit(Model.tax tax)
        {
            var viwer = new Taxes.Viwer();
            viwer.id = tax.id;
            viwer.category_id = (tax.taxcategory as Model.taxcategory).name;

            viwer.title = tax.title;
           
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wnt to delete?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CustomControls.Alert.show("Advance", "data deleted", 1500);

                var i = db.taxes.Where(o => o.id == this.id).First();
                db.Entry(i).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                this.Parent.Controls.Remove(this);

            }
        }
    }
}
