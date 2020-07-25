using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Vehicles
{
    public partial class Viwer : UserControl
    {
        Model.TransportManagementEntities db;
        public Model.vehicle vehicle { get; set; }
        public Viwer()
        {
            InitializeComponent();
            db = DB.Instance;
        }

        private void Viwer_Load(object sender, EventArgs e)
        {

        }
        public int id { get; set; }

        public string vehiclenumber
        {
            get
            {
                return label_vehiclenumber.Text;
            }
            set
            {
                label_vehiclenumber.Text = value;
            }
        }

        private void materialButton_edit_Click(object sender, EventArgs e)
        {
            var editdata = new Vehicles.Edit();
            editdata.loadata(this.id);
            var  trance = new CustomControls.Modal(editdata);
            editdata.edit += Editdata_edit;
            trance.Show();
        }

        private void Editdata_edit(Model.vehicle vehicle)
        {
            var viwer = new Vehicles.Viwer();
            viwer.id = vehicle.id;
            viwer.vehiclenumber = vehicle.vehicle_no;
        }

        private void materialButton_taxpaid_Click(object sender, EventArgs e)
        {
            var taxlist = new TaxPaid.TaxPaid(id);
            var trance = new CustomControls.Modal(taxlist);
            trance.Show();
        }

        private void materialButton_Finance_Click(object sender, EventArgs e)
        {
            var financelist = new PaidFinance.PaidList(id);
            var trance = new CustomControls.Modal(financelist);
            trance.Show();
        }

        private void materialButton_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var delete = db.vehicles.Find(id);
                db.Entry(delete).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                this.Parent.Controls.Remove(this);

            }
            catch (Exception ex)
            {
                CustomControls.Alert.show("not delete", "this record it's record is used in another transaction", 3000);
                return;
            }
        }

        private void materialButton_details_Click(object sender, EventArgs e)
        {
            var details = new Vehicles.Details(id);
            var trance = new CustomControls.Modal(details);
            trance.Show();
        }
    }
}
