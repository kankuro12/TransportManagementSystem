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

namespace TransportManagementSystem.Finances
{
    public partial class Viwer : UserControl
    {
        Model.TransportManagementEntities db;
        public Model.finance finance { get; set; }
        public Viwer()
        {
            InitializeComponent();
            db = DB.Instance;
        }
        public int id { get; set; }
        public string name
        {
            get
            {
                return lbl_name.Text;
            }
            set
            {
                lbl_name.Text = value;
            }
        }
        public string address
        {
            get
            {
                return lbl_address.Text;
            }
            set
            {
                lbl_address.Text = value;
            }
        }
        public string phone
        {
            get
            {
                return lbl_phone.Text;
            }
            set
            {
                lbl_phone.Text = value;
            }
        }
        public string email
        {
            get
            {
                return lbl_email.Text;
            }
            set
            {
                lbl_email.Text = value;
            }
        }
        private void btn_edit_Click(object sender, EventArgs e)
        {
            var edit = new Finances.Edit();
            edit.loaddata(this.id);
            var trance = new CustomControls.Modal(edit);
            edit.edit += I_edit;
            trance.Show();
        }
        private void I_edit(finance finance)
        {
            var viwer = new Finances.Viwer();
            viwer.id = finance.id;
            viwer.name = finance.name;
            viwer.address = finance.address;
            viwer.phone = finance.phone;
            viwer.email = finance.email;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wnt to delete?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CustomControls.Alert.show("Finance", "data deleted", 1500);

                var i = db.finances.Where(o => o.id == this.id).First();
                db.Entry(i).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                this.Parent.Controls.Remove(this);

            }
        }

        private void Viwer_Load(object sender, EventArgs e)
        {

        }
    }
}
