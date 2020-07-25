using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public static class FormHelper
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
        public static void roundBorder(this Form f  ,int radius=10)
        {
            f.FormBorderStyle = FormBorderStyle.None;
           f. Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, f.Width, f.Height, radius, radius));
        }

        public static DialogResult ShowModal(this Form f)
        {
            return Modal.Show(f);
        }

        public static void  AddToControl(this Form f,Control c)
        {
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            c.Controls.Add(f);
            f.Show();
        }

        
    }
}
