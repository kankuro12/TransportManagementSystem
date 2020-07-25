using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace CustomControls
{
    public  class TextButton:Label
    {
        private Color tempColor;
        private Color _HoverColor;
        public Color HoverColor
        {
            get
            {
                return _HoverColor;
            }
            set
            {
                _HoverColor = value;
            }
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            tempColor = this.ForeColor;
            if (HoverColor != null)
            {
                this.ForeColor = HoverColor;

            }
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (HoverColor != null)
            {
                this.ForeColor = tempColor; 
            }
            base.OnMouseLeave(e);
        }

    }
}
