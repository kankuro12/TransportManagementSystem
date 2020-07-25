using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public static class Extensions
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
        public static DialogResult ShowModal(this Form form)
        {
            var t = new Modal(form);
            return t.ShowDialog();
        }

        public static void MakeMiddle(this Form form, int paddingx = 50, int paddingy = 50)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.WindowState = FormWindowState.Normal;
            var h = Screen.PrimaryScreen.Bounds.Height;
            var w = Screen.PrimaryScreen.Bounds.Width;
            var hx = w - (2 * paddingx);
            var hy = h - (2 * paddingy);
            form.Size = new System.Drawing.Size(hx, hy);
            form.Location = new System.Drawing.Point(paddingx, paddingy);
        }

        public static void BorderRadius(this Form form, int Radius = 20)
        {
            form.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, form.Width, form.Height, Radius, Radius));
        }
    }
}
