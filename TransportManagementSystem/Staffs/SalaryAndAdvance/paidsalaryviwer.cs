using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TransportManagementSystem.Staffs.SalaryAndAdvance
{
  public  class paidsalaryviwer:ListViewItem
    {
        private int _paidfrom { get; set; }
        private int _paidto { get; set; }
        private int _paiddate { get; set; }
        private decimal _paidamount { get; set; }
        private string _paidby { get; set; }
        private int _id { get; set; }

        private decimal _usedadvance { get; set; }
        public int paidfrom { get { return _paidfrom; }set { _paidfrom = value; SubItems[1].Text=value.ToString(); } }
        public int paidto { get { return _paidto; } set { _paidto = value;SubItems[2].Text = value.ToString(); } }
        public int paiddate { get { return _paiddate; } set { _paiddate = value;SubItems[3].Text = value.ToString(); } }
        public decimal amount { get { return _paidamount; } set { _paidamount = value;SubItems[4].Text = value.ToString(); } }
        public decimal useadvance { get { return _usedadvance; } set { _usedadvance = value;SubItems[5].Text = value.ToString(); } }
        public string paidby { get { return _paidby; } set { _paidby = value;SubItems[6].Text = value.ToString(); } }
        public int id { get { return _id; }set { _id = value; SubItems[6].Text = value.ToString(); } }


        public paidsalaryviwer(Model.paidsalary paidsalary,int sn)
        {
            for(int i=0; i<=10; i++)
            {
                SubItems.Add(new ListViewSubItem());
            }
            id = paidsalary.id;
            paidfrom = paidsalary.paid_form;
            paidto = paidsalary.paid_to;
            paiddate =(int) paidsalary.paid_date;
            amount = paidsalary.paidamount;
            paidby = paidsalary.paidby;
            useadvance = paidsalary.usedadvence;
            this.SubItems[0].Text = sn.ToString();
        }
        public void update(Model.paidsalary paidsalary)
        {
            id = paidsalary.id;
            paidfrom = paidsalary.paid_form;
            paidto = paidsalary.paid_to;
            paiddate = (int)paidsalary.paid_date;
            amount = paidsalary.paidamount;
            paidby = paidsalary.paidby;
           

        }
    }
}
