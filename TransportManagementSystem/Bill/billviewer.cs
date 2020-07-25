using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TransportManagementSystem.Bill
{
  public  class billviewer:ListViewItem
    {
        private int _id { get; set; }
        private string _itm_name { get; set; }
        private decimal _quantity { get; set; }
        private string _unit { get; set; }
        private decimal _weight { get; set; }
        private decimal _total_weight { get; set; }
        private decimal _charge_amount { get; set; }





        public string itemname { get { return _itm_name; } set { _itm_name = value; SubItems[1].Text = value; } }
        public decimal quantity { get { return _quantity; } set { _quantity = value; SubItems[2].Text = value.ToString("0.##"); } }
        public string unit { get { return _unit; } set { _unit = value; SubItems[3].Text = value.ToString(); } }
        public decimal weight { get { return _weight; } set { _weight = value; SubItems[4].Text = value.ToString("0.##"); } }
        public decimal total_weight { get { return _total_weight; } set { _total_weight = value; SubItems[5].Text = value.ToString("0.##"); } }
        public decimal charge_amount { get { return _charge_amount; } set { _charge_amount = value; SubItems[6].Text = value.ToString("0.##"); } }
        public int id { get { return _id; } set { _id = value;SubItems[7].Text = value.ToString(); } }
        public int sn = 1;
        public billviewer(Model.billitem billitem, int sn)
        {
            for (int i = 1; i <= 10; i++)
            {
                SubItems.Add(new ListViewSubItem());
            }
            itemname =billitem.item_name;
            quantity =billitem.quantity;
            charge_amount =billitem.charge_amount;
            unit =billitem.unit;
            total_weight =billitem.weight*billitem.quantity;
            weight =billitem.weight;
            id = billitem.id;
            SubItems[0].Text = sn.ToString();
        }
      
    }
}
