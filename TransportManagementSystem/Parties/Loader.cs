using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TransportManagementSystem.Parties
{
  public  class Loader:ListViewItem
    {
       private int _id { get; set; }
       private  string _invoice_num { get; set; }
        private string _vehicle_number { get; set; }
        private int _date { get; set; }
        private decimal _grossamount { get; set; }
        private decimal _dis { get; set; }
        private decimal _nettotal { get; set; }
        private decimal _paid { get; set; }
        private decimal _due { get; set; }


        public string invoice_no { get { return _invoice_num; } set { _invoice_num=value;SubItems[1].Text = value; } }
        public string vehicle_number { get { return _vehicle_number; } set { _vehicle_number = value;SubItems[2].Text = value; } }
        public int date { get { return _date; } set { _date = value; SubItems[3].Text = value.ToString(); } }
        public decimal grosstatal { get { return _grossamount; } set { _grossamount = value;SubItems[4].Text = value.ToString("0.##"); } }
        public decimal dis { get { return _dis; } set { _dis = value;SubItems[5].Text = value.ToString("0.##"); } }
        public decimal nettotal { get { return _nettotal; } set { _nettotal = value;SubItems[6].Text = value.ToString("0.##"); } }
        public decimal  paid { get { return _paid; } set { _paid = value; SubItems[7].Text = value.ToString("0.##"); } }
        public decimal due { get { return _dis; } set { _due = value; SubItems[8].Text = value.ToString("0.##"); } }
        public int id { get { return _id; } set { _id = value; SubItems[9].Text = value.ToString(); } }

        public Loader(Model.bill bill,int sn)
        {
            for(int i=1; i <= 15; i++)
            {
                SubItems.Add(new ListViewSubItem());
            }
            SubItems[0].Text = sn.ToString();
            invoice_no = bill.invoice_number;
            vehicle_number = (bill.vehicle as Model.vehicle).vehicle_no;
            date = bill.date;
            grosstatal = bill.grosstoal;
            dis = bill.discount;
            date = bill.date;
            paid = bill.paid;
            due = bill.due;
            nettotal = bill.nettotal;
            id = bill.id;
        }
        int sn = 1;
    }
}
