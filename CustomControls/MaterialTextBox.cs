using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class MaterialTextBox : UserControl
    {
        public string Placeholder
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
        

        public Color LineColor
        {
            get
            {
                return panel1.BackColor;
            }
            set
            {
                panel1.BackColor = value;
            }
        }
        public Color PlaceholderColor
        {
            get
            {
                return label1.ForeColor;
            }
            set
            {
                label1.ForeColor = value;
            }
        }

        public  string text
        {
            get
            {
               return betterTextBox1.Text;
            }
            set
            {
                betterTextBox1.Text = value;

            }
        }
        public Color TextForeColor 
        {
            get
            {
                return betterTextBox1.ForeColor;
            }
            set
            {
                betterTextBox1.ForeColor = value;
            }
        }

        public MaterialTextBox()
        {
            InitializeComponent();
        }

        private void MaterialTextBox_Paint(object sender, PaintEventArgs e)
        {
            label1.Font = new Font(betterTextBox1.Font.FontFamily, betterTextBox1.Font.Size + 3);
            this.Height = label1.Height + betterTextBox1.Height + 10;
            if (betterTextBox1.Focused)
            {
            label1.Top = this.Height-label1.Height-betterTextBox1.Height-7;

            }
            else
            {
                if (betterTextBox1.Text.Trim() == "")
                {
                    label1.Top = this.Height - label1.Height-2;
                }
                else
                {
                    label1.Top = this.Height - label1.Height - betterTextBox1.Height - 7;

                }
            }

        }

        private void betterTextBox1_Enter(object sender, EventArgs e)
        {
            label1.Top = this.Height - label1.Height - betterTextBox1.Height - 7;

        }

        private void betterTextBox1_Leave(object sender, EventArgs e)
        {
            if (betterTextBox1.Text.Trim() == "")
            {
                label1.Top = this.Height - label1.Height-2;
            }
            else
            {
                label1.Top = this.Height - label1.Height - betterTextBox1.Height-7;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            betterTextBox1.Focus();
        }
    }
}
