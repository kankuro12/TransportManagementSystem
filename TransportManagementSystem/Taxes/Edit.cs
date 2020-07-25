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
    public partial class Edit : Form
    {
        TransportManagementEntities db ;
        public delegate void editHandler(Model.tax tax);
        public event editHandler edit;
        int id;
      
        public Edit()
        {
            InitializeComponent();
            db = DB.Instance;
            foreach(var item in db.taxcategories.ToList())
            {
                comboBox1.Items.Add(item);
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_title.Text.Trim() == "")
            {
                CustomControls.Alert.show("title", "Enter Title", 1500);
            }

            try
            {


                var editdata = db.taxes.Where(o => o.id == id).First();
                editdata.taxcate_id = (comboBox1.SelectedItem as Model.taxcategory).id;
                editdata.title = txt_title.Text;
                editdata.updated_at = DateTime.Now;
                db.Entry(editdata).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                CustomControls.Alert.show("Error", "Error Data", 1500);
            }
        }
        public void loaddata(int id)
        {
            tax i = db.taxes.Where(o => o.id == id).First();
            comboBox1.Text = (i.taxcategory as Model.taxcategory).name;
            txt_title.Text = i.title;
            this.id = id;
        }
    }
}
