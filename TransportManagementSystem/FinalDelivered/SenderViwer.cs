using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.FinalDelivered
{
    public partial class SenderViwer : UserControl
    {
        public bool sel
        {
            get
            {
                return checkBox_senditem.Checked;
            }
            set
            {
                checkBox_senditem.Checked = value;
            }
        }

        public SenderViwer()
        {
            InitializeComponent();

        }
        public int id { get; set; }
        public string itemname
        {
            get
            {
                return label_itemname.Text;
            }
            set
            {
                  label_itemname.Text=value;
            }
        }
        public string sendername
        {
            get
            {
                return label_senname.Text;
            }
            set
            {
              label_senname.Text =value;
            }
        }
        public string senderphone
        {
            get
            {
                return label_senphone.Text;
            }
            set
            {
                label_senphone.Text = value;
            }
        }
        public string receiverphone
        {
            get
            {
                return label_receiverphone.Text;
            }
            set
            {
                label_receiverphone.Text = value;
            }
        }
        public string from
        {
            get
            {
                return label_locationfrom.Text;
            }
            set
            {
                label_locationfrom.Text=value.ToString();
            }
        }
        public string tooo
        {
            get
            {
                return label_locationtooo.Text;
            }
            set
            {
               label_locationtooo.Text=value.ToString();
            }
        }

        public string deliver_place
        {
            get
            {
                return label_deliverplace.Text;
            }
            set
            {
                label_deliverplace.Text = value;
            }
        }
        public string receivername
        {
            get
            {
                return label_receivername.Text;
            }
            set
            {
                label_receivername.Text = value;
            }
        }
        
        public string unit
        {
            get
            {
                return label_unit.Text;
            }
            set
            {
                label_unit.Text = value;
            }
        }
        public decimal quantity
        {
            get
            {
                return Convert.ToDecimal( label_qty.Text);
            }
            set
            {
                label_qty.Text=value.ToString();
            }
        }
        public decimal weight
        {
            get
            {
                return Convert.ToDecimal(label_weight.Text);
            }
            set
            {
               label_weight.Text = value.ToString();
            }
        }
        public decimal rate
        {
            get
            {
                return Convert.ToDecimal(label_amount.Text);
            }
            set
            {
                label_amount.Text = value.ToString();
            }
        }
        
        private void checkBox_senditem_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_senditem.Checked)
            {
                this.BackColor = Color.Red;
                this.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
            }
        }
    }
}
