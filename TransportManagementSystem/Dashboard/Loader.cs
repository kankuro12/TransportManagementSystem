using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TransportManagementSystem.Dashboard
{
  public  class Loader:ListViewItem
    {
       private int _id { get; set; }
       private  string _invoice_num { get; set; }
        private string _vehicle_number { get; set; }
        private int _date { get; set; }
        private decimal _Totalamount { get; set; }
        private decimal _total_weight { get; set; }
        private decimal _expamount { get; set; }


        public string invoice_no { get { return _invoice_num; } set { _invoice_num=value;SubItems[1].Text = value; } }
        public string vehicle_number { get { return _vehicle_number; } set { _vehicle_number = value;SubItems[2].Text = value; } }
        public int date { get { return _date; } set { _date = value; SubItems[3].Text = value.ToString(); } }
        public decimal totalamount { get { return _Totalamount; } set { _Totalamount = value;SubItems[4].Text = value.ToString("0.##"); } }
        public decimal totalweight { get { return _total_weight; } set { _total_weight = value;SubItems[5].Text = value.ToString("0.##"); } }
        public decimal expamount { get { return _expamount; } set { _expamount = value;SubItems[6].Text = value.ToString("0.##"); } }
        public int id { get { return _id; } set { _id = value; SubItems[7].Text = value.ToString(); } }

        public Loader(Model.bill bill,int sn)
        {
            for(int i=1; i <= 10; i++)
            {
                SubItems.Add(new ListViewSubItem());
            }
            SubItems[0].Text = sn.ToString();
            invoice_no = bill.invoice_number;
            vehicle_number = (bill.vehicle as Model.vehicle).vehicle_no;
            date = bill.date;
            totalamount = bill.grosstoal;
            totalweight = bill.total_Weight;
            expamount = bill.total_exp;
            id = bill.id;
        }
        int sn = 1;
    }
}
