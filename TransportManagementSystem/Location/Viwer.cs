using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem
{
    public partial class Viwer : UserControl
    {
       
        public Model.location location { get; set; }
        bool saveondatabase;
        public Viwer()
        {
            InitializeComponent();
           
            saveondatabase = false;
        }
        public Viwer(int id)
        {
            InitializeComponent();
            location = DB.Instance.locations.Find(id);
            betterTextBox1.Text = location.name;
            saveondatabase = true;
        }
        public int id { get; set; }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            if (saveondatabase)
            {
                location.name = betterTextBox1.Text;
                location.updated_at = DateTime.Now;
                location.created_at = DateTime.Now;
                location.admin_id = INFO.admin_id;             
                DB.Instance.SaveChanges();
            }
            else
            {
               
                var newcate = new Model.location()
                {
                    name = betterTextBox1.Text,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now,
                    admin_id = INFO.admin_id,
                };
                DB.Instance.locations.Add(newcate);
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
                    DB.Instance.Entry(location).State = System.Data.Entity.EntityState.Deleted;
                    DB.Instance.SaveChanges();
                }
                this.Parent.Controls.Remove(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("not deleted");
            }
        }

        private void Viwer_Load(object sender, EventArgs e)
        {

        }
    }
}
