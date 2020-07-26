using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TransportManagementSystem.TaxPaid
{
       
    public class Viwer : ListViewItem
    {
       
        private int _id { get; set; }
        private int _taxyear { get; set; }
        private int _title { get; set; }
        private int _date { get; set; }
        private decimal _amount { get; set; }
        private string _Discription { get; set; }
        private string _paidby { get; set; }

        public int id { get { return _id; } set { _id = value; SubItems[7].Text = value.ToString(); } }
        public int taxyear
        {
            get { return _taxyear; }
            set
            {
                _taxyear = value;
                
                {
                    SubItems[1].Text = DB.Instance.taxcategories.Find(value).name;
                }
            }

        }
        public int title { get { return _title; } set { _title = value;
               
                {
                    SubItems[2].Text = DB.Instance.taxes.Find(value).title; } }
                }
        public int date { get { return _date; } set { _date = value;SubItems[3].Text = value.ToString(); } }
        public decimal amount { get { return _amount; } set { _amount = value;SubItems[4].Text = value.ToString(); } }
        public string paidby { get { return _paidby; } set { _paidby = value; SubItems[5].Text = value; } }
        public string discription { get { return _Discription; } set { _Discription = value;SubItems[6].Text = value; } }


        public Viwer(Model.taxpaid Taxpaids, int sn)
        {
            
            for(int i = 1; i <= 10; i++)
            {
                SubItems.Add(new ListViewSubItem());
            }
            id =Taxpaids.id;            
            taxyear = (int)Taxpaids.taxyear_id;
            title = (int)Taxpaids.tax_id;
            date = (int)Taxpaids.date;
            amount = (decimal)Taxpaids.amount;
            paidby = Taxpaids.paidby;
            discription=Taxpaids.discription;
            SubItems[0].Text = sn.ToString();
        }
        public int sn = 1;
        public void update(Model.taxpaid taxpaid)
        {
            id = taxpaid.id;
            taxyear = (int)taxpaid.taxyear_id;
            title = (int)taxpaid.tax_id;
            date = (int)taxpaid.date;
            amount = (decimal)taxpaid.amount;
            paidby = taxpaid.paidby;
            discription = taxpaid.discription;
        }
    }
}
