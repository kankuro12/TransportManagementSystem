using CustomControls.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class Alert : Form
    {
        public static int row = 1;

        public static int rowheight = 0;

        public Alert()
        {
            InitializeComponent();
            this.Left = Screen.PrimaryScreen.Bounds.Width - 310;
            rowheight += this.Height;
            this.Top = Screen.PrimaryScreen.Bounds.Height - rowheight ;
            row += 1;
            if (row == 5)
            {
                row = 1;
                rowheight = 0;
            }
            ThreadPool.QueueUserWorkItem(ignoredState =>
            {
                using (var audioMemory = Resources.ResourceManager.GetStream("alert"))
                {
                    using (var player = new SoundPlayer(audioMemory))
                    {
                        player.PlaySync();
                    }
                }
            });
        }

        private void label_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void show(string title,string msg,int time)
        {
            var alert = new Alert();
            alert.TopMost = true;
            alert.label_msg.Text = msg;
            alert.label_title.Text = title;
            alert.timer.Interval = time;
            alert.Show(); 
        }

        private void Alert_Load(object sender, EventArgs e)
        {
           
            timer.Enabled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
