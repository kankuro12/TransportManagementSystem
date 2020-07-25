using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace CustomControls
{
    public partial class Notify : UserControl
    {
        public Color[] Colors = new Color[]
        {
            Color.FromArgb(66, 133, 244),
            Color.FromArgb(52, 168, 83),
            Color.FromArgb(251, 188, 5),
            Color.FromArgb(234, 67, 53),

        };
        public Notify(string text,int mode =1,int time =5000)
        {
            InitializeComponent();
            label1.Text = text;
            this.BackColor = Colors[mode];
            timer.Interval = time;
            timer.Enabled = true;
        }

        public static void  show(string text, int mode = 1, int time = 5000)
        {
            var n = new Notify(text, mode, time);
            if (NotificationBar.Instance == null)
            {
                NotificationBar.init();
            }

            NotificationBar.Instance.flowLayoutPanel.Controls.Add(n);
        }

        private void textButtonclose_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void Notify_Paint(object sender, PaintEventArgs e)
        {
            if (label1.Height > 30)
            {
                this.Height = label1.Height + 20;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {

                this.Parent.Controls.Remove(this);

            }
            catch (Exception )
            {

                
            }

        }
    }
}
