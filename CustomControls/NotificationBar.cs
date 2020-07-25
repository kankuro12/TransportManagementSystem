using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class NotificationBar : Form
    {
        public static NotificationBar Instance;
        public NotificationBar()
        {
            InitializeComponent();
            Instance = this;
            this.FormClosed += (o, e) =>
            {
                Instance = null;
            };
            this.Width = 300;
            this.Top = 0;
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - 300;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height ;

        }

        public static void init()
        {
            if (Instance == null)
            {
                new NotificationBar().Show();
            }
        }

        private void NotificationBar_Load(object sender, EventArgs e)
        {

        }
    }
}
