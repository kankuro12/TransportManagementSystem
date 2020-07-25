using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TransportManagementSystem.Staffs.SalaryAndAdvance
{
  public  class PaidAdvanceViwer:ListViewItem
    {
        
        private int _paiddate { get; set; }
        private decimal _paidamount { get; set; }
        private string _paidby { get; set; }
        private int _id { get; set; }


       
        public int paiddate { get { return _paiddate; } set { _paiddate = value; SubItems[1].Text = value.ToString(); } }
        public decimal amount { get { return _paidamount; } set { _paidamount = value; SubItems[2].Text = value.ToString(); } }
        public string paidby { get { return _paidby; } set { _paidby = value; SubItems[3].Text = value.ToString(); } }
        public int id { get { return _id; } set { _id = value; SubItems[4].Text = value.ToString(); } }


        public PaidAdvanceViwer(Model.paidadvance paidadvance, int sn)

        {
            for (int i = 0; i <= 10; i++)
            {
                SubItems.Add(new ListViewSubItem());
            }
            id = paidadvance.id;
            paiddate = (int)paidadvance.paid_date;
            amount = paidadvance.paidamount;
            paidby = paidadvance.paidby;
            this.SubItems[0].Text = sn.ToString();
        }
        public void update(Model.paidadvance paidadvance)
        {
            id = paidadvance.id;
            paiddate = (int)paidadvance.paid_date;
            amount = paidadvance.paidamount;
            paidby = paidadvance.paidby;


        }
    }
}

   