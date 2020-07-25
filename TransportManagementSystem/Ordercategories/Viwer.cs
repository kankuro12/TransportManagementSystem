using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Ordercategories
{
    public partial class Viwer : UserControl
    {
        
        public Model.orderitemtype Orderitemtype { get; set; }
        bool saveondatabase;
        public Viwer()
        {
            InitializeComponent();
           
            saveondatabase = false;
        }
        public Viwer(int id)
        {
            InitializeComponent();
            Orderitemtype = DB.Instance.orderitemtypes.Find(id);
            betterTextBox1.Text = Orderitemtype.name;
            saveondatabase = true;
        }
        public int id { get; set; }


        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (saveondatabase)
            {
                Orderitemtype.name = betterTextBox1.Text;
                Orderitemtype.updated_at = DateTime.Now;
                Orderitemtype.created_at = DateTime.Now;
                Orderitemtype.admin_id = INFO.admin_id;
                DB.Instance.SaveChanges();

            }
            else
            {
            
                var newcate = new Model.orderitemtype()
                {
                    name = betterTextBox1.Text,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now,
                    admin_id = INFO.admin_id,
                };
                DB.Instance.orderitemtypes.Add(newcate);
                DB.Instance.SaveChanges();
                saveondatabase = true;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveondatabase)
                {
                    DB.Instance.Entry(Orderitemtype).State = System.Data.Entity.EntityState.Deleted;
                    DB.Instance.SaveChanges();
                }
                this.Parent.Controls.Remove(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("not deleted");
            }
        }
    }
}
