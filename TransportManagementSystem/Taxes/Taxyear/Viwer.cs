using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Taxes.Taxyear
{
    public partial class Viwer : UserControl
    {
        Model.TransportManagementEntities db;
        public Model.taxcategory taxcategory;
        bool saveondatabase;
        public Viwer()
        {
            InitializeComponent();
         
            saveondatabase = false;
        }
        public Viwer(int id)
        {
            InitializeComponent();
            taxcategory = DB.Instance.taxcategories.Find(id);
            betterTextBox_title.Text = taxcategory.name;
            saveondatabase = true;
        }
        public int id { set; get; }
        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (saveondatabase)
            {
                taxcategory.name = betterTextBox_title.Text;
               // taxcategory.firscalyear_id = INFO.currentFiscalYear.id;
                taxcategory.admin_id = INFO.admin_id;
                taxcategory.updated_at = DateTime.Now;
                taxcategory.created_at = DateTime.Now;
                DB.Instance.SaveChanges();
            }
            else
            {
                var addnew = new Model.taxcategory()
                {
                    name = betterTextBox_title.Text,
                    admin_id = INFO.admin_id,
                   // firscalyear_id = INFO.currentFiscalYear.id,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now,

                };
                DB.Instance.taxcategories.Add(addnew);
                DB.Instance.SaveChanges();
                saveondatabase = true;
            }
        }

        private void materialButton_Delete_Click(object sender, EventArgs e)
        {
            try
            {
            if (saveondatabase)
            {
                db.Entry(taxcategory).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
            this.Parent.Controls.Remove(this);

            }
            catch
            {
                CustomControls.Alert.show("not delete", "this is not delete", 2000);
            }
        }
    }
}
