using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{


    public enum TextboxType
    {
        Text, Integer, Decimal
    }
    public class BetterTextBox : System.Windows.Forms.TextBox
    {
        public delegate void enterHandler();
        public event enterHandler enter;
        public TextboxType textboxType { get; set; }


        public int intVal
        {
            get
            {
                try
                {

                    return Convert.ToInt32(this.Text);
                }
                catch (Exception)
                {

                    return 0;
                }
            }
            set
            {
                if (this.textboxType == TextboxType.Integer)
                {

                    this.Text = value.ToString();

                }
            }
        }

        public decimal decVal
        {
            get
            {
                try
                {
                    return Convert.ToDecimal(this.Text);
                }
                catch (Exception)
                {

                    return 0m;
                }
            }
            set
            {
                if (this.textboxType == TextboxType.Decimal)
                {
                    this.Text = value.ToString();

                }
            }
        }

        public BetterTextBox()
        {
            this.textboxType = TextboxType.Text;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                enter?.Invoke();
                return;
            }
            if (this.textboxType == TextboxType.Integer)
            {
                if ((e.KeyValue > 47 && e.KeyValue < 58) || (e.KeyValue == 13) || (e.KeyValue == 8) || (e.KeyValue == 37) || (e.KeyValue == 38) || (e.KeyValue == 39) || (e.KeyValue == 40) || (e.KeyValue > 95 && e.KeyValue < 106))
                {
                    e.SuppressKeyPress = false;

                }
                else
                {
                    e.SuppressKeyPress = true;
                }
                return;

            }
            else if (textboxType == TextboxType.Decimal)
            {
                if ((e.KeyValue > 47 && e.KeyValue < 58) || (e.KeyValue == 190) || (e.KeyValue == 13) || (e.KeyValue == 8) || (e.KeyValue == 39) || (e.KeyValue == 40) || (e.KeyValue > 95 && e.KeyValue < 106))
                {
                    if (this.Text.Contains(".") && (e.KeyValue == 190))
                    {
                        e.SuppressKeyPress = true;
                        return;
                    }

                    e.SuppressKeyPress = false;
                }
                else
                {
                    e.SuppressKeyPress = true;
                }
                return;
            }
            base.OnKeyDown(e);
        }
    }
}
