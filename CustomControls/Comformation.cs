using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class Comformation : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public Comformation()
        {
            InitializeComponent();
            
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public static DialogResult ShowModal(string title,string message,bool showcancel = false)
        {
            var n = new Comformation();
            n.label_title.Text = title;
            n.label_description.Text = message;
            n.button_cancel.Visible = showcancel;
            var t = new Modal(n);
            return t.ShowDialog();
        }

        private void button_cancel_Enter(object sender, EventArgs e)
        {
            var c = sender as Button;
            c.ForeColor = Color.FromArgb(140, 74, 232);
        }

        private void button_cancel_Leave(object sender, EventArgs e)
        {
            var c = sender as Button;
            c.ForeColor = Color.FromArgb(111, 20, 239);
        }
    }
}
