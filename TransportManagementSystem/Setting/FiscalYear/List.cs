using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
namespace TransportManagementSystem.FiscalYear
{
    public partial class List : Form
    {
        Model.TransportManagementEntities db;
        public static List instance;
        public List()
        {
            InitializeComponent();
            db = DB.Instance;
            db = Model.DatabaseConfigure.getConfigure();
            foreach (var item in db.fiscalyears.Select(o=>o.id).ToList())
            {
                var fyviewer = new Viwer(item);
                fyviewer.defaultChange += () =>
                {
                    refreshDefault();
                };
               
               flowLayoutPanel.Controls.Add(fyviewer);
            }

            instance = this;
            this.FormClosed += (o, e) =>
            {
                instance = null;
            };
        }

        private void refreshDefault()
        {
            foreach (var item in flowLayoutPanel.Controls.Cast<Viwer>())
            {
                item.refreshDefault();
            }
        }
        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_addnew_Click(object sender, EventArgs e)
        {
            var fyviewer = new Viwer();
            fyviewer.defaultChange += () =>
            {
                refreshDefault();
            };
           
            flowLayoutPanel.Controls.Add(fyviewer);
        }

        public static void show(Panel p)
        {
            if (instance == null)
            {
                var newlist = new List();
                newlist.TopLevel = false;
                newlist.Dock = DockStyle.Fill;
                p.Controls.Add(newlist);
                newlist.Show();
                newlist.BringToFront();
            }
            else
            {
                instance.BringToFront();
            }
        }

        private void flowLayoutPanel_Resize(object sender, EventArgs e)
        {
           
        }

        private void betterTextBox_search_TextChanged(object sender, EventArgs e)
        {
            foreach (var item in flowLayoutPanel.Controls.Cast<Viwer>())
            {
                if (item.Fiscalyear.title.Contains(betterTextBox_search.Text.Trim()))
                {
                    item.Show();
                }
                else
                {
                    item.Hide();
                }
            }
        }
    }
}
