using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Item
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();

            foreach (var item in DB.Instance.orderitemlists.ToList())
            {
                if (item.active == true)
                {
                    add(item);
                }

            }
        }
        public void add(Model.orderitemlist orderitemlist)
        {
            var viwer = new Item.SenderViwer();
            viwer.id = orderitemlist.id;
            viwer.itemname = orderitemlist.itemname;
            viwer.sendername = orderitemlist.sender_name;
            viwer.senderphone = orderitemlist.sender_phone;
            viwer.from = (orderitemlist.location as Model.location).name;
            viwer.tooo = (orderitemlist.location1 as Model.location).name;
            viwer.senderphone = orderitemlist.sender_phone;
            viwer.receivername = orderitemlist.receivername;
            viwer.receiverphone = orderitemlist.receiverphone;
            viwer.weight = orderitemlist.weight.Value;
            viwer.quantity = orderitemlist.quantity.Value;
            viwer.rate = orderitemlist.amount.Value;
            viwer.deliver_place = orderitemlist.deliveryplace;
            viwer.unit = orderitemlist.unit;
            viwer.Dock = DockStyle.Top;
            panel_list.Controls.Add(viwer);

        }
        private void materialButton2_Click(object sender, EventArgs e)
        {
            var add = new Item.Add();
            var trance = new CustomControls.Modal(add);
            add.adddata += Add_adddata;
            trance.Show();
        }

        private void Add_adddata(Model.orderitemlist orderitem)
        {
            throw new NotImplementedException();
        }

        private void materialButton_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_manageitemtype_Click(object sender, EventArgs e)
        {
            var newtype = new TransportManagementSystem.Ordercategories.List();
            var trance = new CustomControls.Modal(newtype);
            trance.Show();
        }

        private void materialButton_managelocation_Click(object sender, EventArgs e)
        {
            var newlocation = new TransportManagementSystem.Location.List();
            var trance = new CustomControls.Modal(newlocation);
            trance.Show();
        }

        private void materialButton_send_Click(object sender, EventArgs e)
        {
            var list = panel_list.Controls.Cast<SenderViwer>().Where(o => o.sel == true).Select(o => o.id).ToList();
            var listsender = new Senditems.List(list);
            listsender.ShowDialog();
        }
    }
}
