using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CustomControls
{
    public partial class MenuItem : UserControl
    {
        public delegate void clickedHandler();
        public event clickedHandler clicked;

        private Color hcolor;
        private Color tempbgcolor;
        public Color HoverColor
        {
            get
            {
                return hcolor;
            }
            set
            {
                hcolor = value;
            }
        }
        public Image img
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }

        public string txt
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        public int MinWidth { get; set; } = 0;
        public MenuItem()
        {
            InitializeComponent();

        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
        }

        private void MenuItem_Load(object sender, EventArgs e)
        {
            calculate();
        }

        private void MenuItem_Resize(object sender, EventArgs e)
        {
            calculate();
        }

        private void calculate()
        {
            if (this.Width <= this.MinWidth)
            {
                this.Height = this.Width;
                pictureBox1.Dock = DockStyle.Fill;
                label1.Hide();
            }
            else
            {
                pictureBox1.Dock = DockStyle.Left;
                label1.Show();
                label1.Left = pictureBox1.Width + 15;
                label1.Top = (this.Height - label1.Height) / 2;
            }
            pictureBox1.Width = pictureBox1.Height;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            clicked?.Invoke();
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            clicked?.Invoke();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            clicked?.Invoke();

        }

        private void MenuItem_MouseEnter(object sender, EventArgs e)
        {
            if (HoverColor != null)
            {
                tempbgcolor = BackColor;
                BackColor = HoverColor;
                Debug.WriteLine("setting hovercolor");
            }
        }

        private void MenuItem_MouseLeave(object sender, EventArgs e)
        {
            if (HoverColor != null)
            {
                Debug.WriteLine("desetting hovercolor");

                BackColor = tempbgcolor;
            }
        }
    }
}
