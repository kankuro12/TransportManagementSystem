using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TransportManagementSystem.PaidFinance
{
   public class Viwer:ListViewItem
    {
        private int _sn { get; set; }
        private int _id { get; set; }
        private int _financename_id { get; set; }
        private string _Title { get; set; }
        private int _date { get; set; }
        private decimal _amount { get; set; }
        private string _paidby { get; set; }
        private string _dis { get; set; }




        public int id { get { return _id; } set { _id = value;SubItems[7].Text = value.ToString(); } }
        public int finance_id { get { return _financename_id; } set { _financename_id = value;
               
                    SubItems[1].Text = DB.Instance.finances.Find(value).name; } }
        public string title { get { return _Title; } set { _Title = value;SubItems[2].Text = value; } }
        public int date { get { return _date; } set { _date = value;SubItems[3].Text = value.ToString(); } }
        public  decimal amount { get { return _amount; } set { _amount = value;SubItems[4].Text = value.ToString(); } }
        public string paidby { get { return _paidby; } set { _paidby = value;SubItems[5].Text = value; } }
        public string discription { get { return _dis; } set { _dis = value;SubItems[6].Text = value; } }



        public Viwer(Model.paidfinance paidfinance ,int sn)
        {
            if (paidfinance == null)
            {
                CustomControls.Alert.show("not available", "data is not available", 2000);
                return;
            }
            for (int i = 1; i <= 10; i++)
            {
                SubItems.Add(new ListViewSubItem());
            }
            id = paidfinance.id;
            finance_id =(int) paidfinance.finance_id;
            title = paidfinance.title;
            date =(int) paidfinance.date;
            paidby = paidfinance.paidby;
            amount = paidfinance.paidamount.Value;
            discription = paidfinance.discription;
            this.SubItems[0].Text = sn.ToString();
        }
        public void update(Model.paidfinance paidfinance)
        {
            id = paidfinance.id;
            finance_id =(int)paidfinance.finance_id;
            title = paidfinance.title;
            date = (int)paidfinance.date;
            paidby = paidfinance.paidby;
            amount = paidfinance.paidamount.Value;
            discription = paidfinance.discription;
        }
    }
}
