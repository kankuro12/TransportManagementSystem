using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TransportManagementSystem.Bill
{
   public class viewer:ListViewItem
    {
      private int _id{ get; set; }
      private string _itm_name { get; set; } 
      private decimal _quantity { get; set; }
      private string _unit { get; set; }
      private decimal _weight { get; set; }
      private decimal _total_weight { get; set; }
      private decimal _charge_amount { get; set; }





     public string itemname { get { return _itm_name; } set { _itm_name = value; SubItems[1].Text = value; } }
     public decimal quantity { get { return _quantity; } set { _quantity = value;SubItems[2].Text = value.ToString(); } }
     public string unit { get { return _unit; } set { _unit = value;SubItems[3].Text = value.ToString(); } }
     public decimal weight { get { return _weight; } set { _weight = value;SubItems[4].Text = value.ToString(); } }
     public decimal total_weight { get { return _total_weight; }set { _total_weight = value;SubItems[5].Text = value.ToString(); } }
     public decimal charge_amount { get { return _charge_amount; } set { _charge_amount = value;SubItems[6].Text = value.ToString(); } }


     public viewer(string item_name,decimal qty, string unt, decimal wight, decimal amount,int sn)
        {
            for(int i = 1; i <= 10; i++)
            {
                SubItems.Add(new ListViewSubItem());
            }
            itemname = item_name;
            quantity = qty;
            charge_amount = amount;
            unit =unt;
            total_weight = wight * qty;
            weight =wight;
            SubItems[0].Text = sn.ToString();
        }
        public int sn = 1;

    public void save(int bill_id,int date)
        {

            var bill_item = new Model.billitem()
            {
                charge_amount = charge_amount,
                quantity = quantity,
                unit = unit,
                bill_id = bill_id,
                weight = weight,
                date = date,
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
                item_name = itemname
            };
            DB.Instance.billitems.Add(bill_item);
            DB.Instance.SaveChanges();
        }
    }
}
