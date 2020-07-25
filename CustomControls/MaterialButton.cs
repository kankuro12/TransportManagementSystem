using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public class MaterialButton : System.Windows.Forms.Button
    {
        public int role { get; set; }
        public Boolean userole { get; set; }

        private string temptext;
        private Color tempbgcolor;
        public string Totext { get; set; }
        public float fontIncrement { get; set; }
        public string FontStyle { get; set; }
        public Image hoverimage { get; set; }
        private Image temphoverimage;
        public Color hoverforecolor { get; set; }
        public Font hoverforefont { get; set; }
        public Font tempforefont { get; set; }
        public Color tempforecolor { get; set; }

        public Size ButtonSizeIncrement { get; set; }
        public Size tempButtonSize;
        public MaterialButton()
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.userole = false;
            this.role = 0;
            Cursor = System.Windows.Forms.Cursors.Hand;


        }

        protected override void OnMouseEnter(EventArgs e)
        {
            tempforecolor = this.ForeColor;
            this.ForeColor = hoverforecolor;
            if (hoverimage != null)
            {
                temphoverimage = this.Image;
                this.Image = hoverimage;
            }
            base.OnMouseEnter(e);

            tempforefont = this.Font;
            this.Font = new Font(this.Font.FontFamily, this.Font.Size + fontIncrement, this.Font.Style);

            //for button size
            tempButtonSize = this.Size;
            this.Size = this.Size + ButtonSizeIncrement;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.ForeColor = tempforecolor;
            if (hoverimage != null)
            {
                this.Image = temphoverimage;

            }
            this.Font = this.tempforefont;
            base.OnMouseLeave(e);

            this.Size = tempButtonSize;


        }
        public MaterialButton(bool _userole = false, int _role = 0)
        {
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.userole = _userole;
            this.role = _role;
        }

        protected override void OnClick(EventArgs e)
        {
            if (this.userole)
            {
                if (this.role < RoleManagement.CurrentRole.instance.roles.role)
                {
                    Alert.show("", "This User Account IS Not Authorized To " + Totext, 3000);
                    return;

                }

            }
            base.OnClick(e);
        }

        public void settempbg(Image i, Color c)
        {
            this.temptext = this.Text;
            this.tempbgcolor = this.BackColor;
            this.BackColor = c;
            this.BackgroundImage = i;

            this.Text = "";
        }

        public void removetempbg()
        {
            this.BackgroundImage = null;
            this.Text = this.temptext;
            this.BackColor = this.tempbgcolor;

        }

    }
}
