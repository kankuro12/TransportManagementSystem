using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Ordercategories
{
    public partial class List : Form
    {
        
        public List()
        {
            InitializeComponent();
          
            foreach (var id in DB.Instance.orderitemtypes.Select(o => o.id))
            {
                flowLayoutPanel1.Controls.Add(new Viwer(id));
            }
        }

        private void List_Load(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new Viwer());
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
