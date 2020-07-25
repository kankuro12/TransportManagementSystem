using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TransportManagementSystem.FinalDelivered.Delivered
{
    public class Viwer : ListViewItem
    {
        private int _sn { get; set; }
        private int _id { get; set; }
        private string _sendername { get; set; }
        private string _senderphone { get; set; }
        private string _receivername { get; set; }
        private string _receiverphone { get; set; }
        private string _itemname { get; set; }
        private int _itemtype { get; set; }
        private int _from { get; set; }
        private int _to { get; set; }
        private string _deliverlocatiom { get; set; }

        private decimal _quantity { get; set; }
        private decimal _weight { get; set; }
        private string _unit { get; set; }
        private decimal _chargeamount { get; set; }
        private int _date { get; set; }


        //public int sn { get { return _sn; } set { _sn = value; SubItems[0].Text = value.ToString(); } }
        public string sendername { get { return _sendername; } set { _sendername = value; SubItems[1].Text = value.ToString(); } }
        public string senderphone { get { return _senderphone; } set { _senderphone = value; SubItems[2].Text = value.ToString(); } }
        public string receivername { get { return _receivername; } set { _receivername = value; SubItems[3].Text = value.ToString(); } }
        public string receiverphone { get { return _receiverphone; } set { _receiverphone = value; SubItems[4].Text = value.ToString(); } }

        public string itemname { get { return _itemname; } set { _itemname = value; SubItems[5].Text = value.ToString(); } }
        public int itemtype_id
        {
            get { return _itemtype; }
            set
            {
                _itemtype = value;

                {
                    SubItems[6].Text = DB.Instance.orderitemtypes.Find(value).name;

                }
            }
        }
        public int from_id
        {
            get { return _from; }
            set
            {
                _from = value;

                {
                    SubItems[7].Text = DB.Instance.locations.Find(value).name;

                }
            }

        }
        public int to_id
        {
            get { return _to; }
            set
            {
                _to = value;

                {
                    SubItems[8].Text = DB.Instance.locations.Find(value).name;

                }
            }

        }
        public string deliver_place { get { return _deliverlocatiom; } set { _deliverlocatiom = value; SubItems[9].Text = value; } }
        public decimal quantity { get { return _quantity; } set { _quantity = value; SubItems[10].Text = value.ToString(); } }
        public decimal weight { get { return _weight; } set { _weight = value; SubItems[11].Text = value.ToString(); } }
        public string unit { get { return _unit; } set { _unit = value; SubItems[12].Text = value; } }
        public int date { get { return _date; } set { _date = value; SubItems[13].Text = value.ToString(); } }

        public decimal chargeamount { get { return _chargeamount; } set { _chargeamount = value; SubItems[14].Text = value.ToString(); } }
        public int id { get { return _id; } set { _id = value; SubItems[15].Text = value.ToString(); } }

        int sn1 = 1;

       
        public Viwer(Model.tripitem billitem, int sn)
        {

            for (int i = 0; i <= 16; i++)
            {
                SubItems.Add(new ListViewSubItem());
            }
            id = (int)billitem.item_id;
            sendername = billitem.sender_name;
            senderphone = billitem.sender_phone;
            receivername =billitem.receivername;
            receiverphone =billitem.receiverphone;
            itemname = (billitem.orderitemlist as Model.orderitemlist).itemname;
            itemtype_id = (int)billitem.orderitemtype_id;
            from_id = (billitem.location as Model.location).id;
            to_id = (int)billitem.location_too;
            deliver_place = billitem.deliver_place;
            unit = billitem.unit;
            quantity = (decimal)billitem.quantity;
            weight = (decimal)billitem.weight;
            date = (int)billitem.date;
            chargeamount = (decimal)billitem.amount;
            this.SubItems[0].Text = sn.ToString();
        }


        public Viwer(int id, int sn)
        {
            var db = new Model.TransportManagementEntities();
            var billitem = db.tripitems.Find(id);

            for (int i = 0; i <= 11; i++)
            {
                SubItems.Add(new ListViewSubItem());
            }
            id = billitem.id;
            sendername = billitem.sender_name;
            senderphone = billitem.sender_phone;
            receivername = billitem.receivername;
            receiverphone = billitem.receiverphone;
            itemname = (billitem.orderitemlist as Model.orderitemlist).itemname;
            itemtype_id = (int)billitem.orderitemtype_id;
            from_id = (billitem.location as Model.location).id;
            to_id = (int)billitem.location_too;
            quantity = (decimal)billitem.quantity;
            weight = (decimal)billitem.weight;
            date = (int)billitem.date;
            unit = billitem.unit;
            deliver_place = billitem.deliver_place;
            chargeamount = (decimal)billitem.amount;
            this.SubItems[0].Text = sn.ToString();
        }
        public void save(int delivereditemsave,int date)
        {
            var savedata = new Model.tripondelivereditem()
            {
                item_id = id,
                sender_name = sendername,
                receivername=receivername,
                receiverphone=receiverphone,
                sender_phone = senderphone,
                date = date,
                location_form = from_id,
                location_too = to_id,
                deliver_place = deliver_place,
                orderitemtype_id = itemtype_id,
                amount = chargeamount,
                admin_id = INFO.admin_id,
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
                unit = unit,
                weight = weight,
                quantity = quantity,
                delivered_id = delivereditemsave
            };
            DB.Instance.tripondelivereditems.Add(savedata);
            foreach (var item in DB.Instance.tripitems.Where(o => o.item_id == id).ToList())
            {
                item.active = false;
                DB.Instance.Entry(item).State = System.Data.Entity.EntityState.Modified;
            }         
            DB.Instance.SaveChanges();
        }
    }
}