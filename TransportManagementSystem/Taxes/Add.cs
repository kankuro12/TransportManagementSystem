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
    public partial class Add : Form
    {
        TransportManagementEntities db;
        public delegate void addHandler(Model.tax tax);
        public event addHandler add;
      
        public Add()
        {
            InitializeComponent();
            db = DB.Instance;
            foreach(var item in db.taxcategories.ToList())
            {
                comboBox1.Items.Add(item);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_title.Text.Trim()=="")
            {
                CustomControls.Alert.show("title", "Enter Title", 1500);
            }

            try
            {
                var i = new tax()
                {
                    taxcate_id = (comboBox1.SelectedItem as Model.taxcategory).id,
                    title = txt_title.Text,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now
                };
                db.taxes.Add(i);
                db.SaveChanges();
                add?.Invoke(i);
                this.Close();
            }
            catch (Exception ex)
            {
                CustomControls.Alert.show("Erroe", "Error Data", 1500);
            }
        }
    }
}
