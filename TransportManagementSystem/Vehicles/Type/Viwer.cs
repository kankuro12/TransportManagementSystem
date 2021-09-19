using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Vehicles.Type
{
    public partial class Viwer : UserControl
    {
       
        public Model.vehicletype vehicletype { get; set; }
        bool saveondatabase;
        public Viwer()
        {
            InitializeComponent();
           
            saveondatabase = false;
        }
        public Viwer(int id)
        {
            InitializeComponent();
            vehicletype = DB.Instance.vehicletypes.Find(id);
            betterTextBox1.Text = vehicletype.titile;
            saveondatabase = true;
        }
        public int id { get; set; }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (saveondatabase)
            {
                vehicletype.titile = betterTextBox1.Text;
                vehicletype.updated_at = DateTime.Now;
                vehicletype.created_at = DateTime.Now;
                //location.admin_id = INFO.admin_id;             
                DB.Instance.SaveChanges();
            }
            else
            {
               
                var newcate = new Model.vehicletype()
                {
                    titile = betterTextBox1.Text,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now,
                   // admin_id = INFO.admin_id,
                };
                DB.Instance.vehicletypes.Add(newcate);
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
                    DB.Instance.Entry(vehicletype).State = System.Data.Entity.EntityState.Deleted;
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
