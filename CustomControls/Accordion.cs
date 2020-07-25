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
    public enum AccordionState
    {
        opened,
        closed
    }
    public partial class Accordion : UserControl
    {
        public delegate void toogleHandler(object sender, AccordionState State);

        public event toogleHandler onToogle;

        public int index;

        private AccordionState _state;

        [DefaultValue(AccordionState.closed)]
        public AccordionState state
        {
            get
            {
                return _state;
            }
            set
            {

                _state = value;
                calculate();
            }
        }

        public Accordion()
        {
            InitializeComponent();
        }

        public void toogle()
        {
            if (state == AccordionState.closed)
            {
                state = AccordionState.opened;
            }
            else
            {
                state = AccordionState.closed;
            }
            calculate();
            onToogle?.Invoke(this, state);
        }

        public void calculate()
        {
            var h = panel_middle.Controls.Cast<Control>().Sum(o => o.Height);
            Debug.WriteLine(panel_middle.Height.ToString());
            if (state == AccordionState.opened)
            {
                this.Height = panel_top.Height + h;
                materialButton_toogle.Text = "-";
                Debug.WriteLine("Opened");

            }
            else
            {
                this.Height = panel_top.Height;
                materialButton_toogle.Text = "+";
                Debug.WriteLine("Closed");

            }
        }
        private void panel_middle_ControlAdded(object sender, ControlEventArgs e)
        {
        }

        private void panel_middle_ControlRemoved(object sender, ControlEventArgs e)
        {
           
        }

        private void materialButton_toogle_Click(object sender, EventArgs e)
        {
            toogle();
        }

        private void Accordion_Load(object sender, EventArgs e)
        {
            state = AccordionState.closed;
            calculate();
        }
    }
}
