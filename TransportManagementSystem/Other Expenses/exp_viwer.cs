using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TransportManagementSystem.Other_Expenses
{
  public  class exp_viwer:ListViewItem
    {
        private int _id { get; set; }
        private int _bill_no { get; set; }
        private string _Vehicle_number { get; set; }
        private int _date { get; set; }
        private decimal _amount { get; set; }


        public int bill_no { get { return _bill_no; } set { _bill_no = value;SubItems[1].Text = value.ToString(); } }
        public string vehicle_number { get { return _Vehicle_number; } set { _Vehicle_number = value; SubItems[2].Text = value; } }
        public int  date { get { return _date; }set { _date = value; SubItems[3].Text = value.ToString(); } }
        public decimal amount { get { return _amount; }set { _amount = value; SubItems[4].Text = value.ToString(); } }
        public int id { get { return _id; } set { _id = value;SubItems[5].Text = value.ToString(); } }


        public int sn;
        public exp_viwer(Model.otherexp otherexp,int sn)
        {
            for(int i = 1; i <= 10; i++)
            {
                SubItems.Add(new ListViewSubItem());
            }
            SubItems[0].Text = sn.ToString();
            bill_no = otherexp.id;
            vehicle_number = otherexp.vehicle.vehicle_no;
            date = otherexp.date;
            amount = otherexp.totalamount;
            id = otherexp.id;

        }

    }
}
