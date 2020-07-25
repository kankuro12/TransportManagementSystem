using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportManagementSystem.Model;
namespace TransportManagementSystem.Item
{
    public partial class Add : Form
    {
        Model.TransportManagementEntities db;
        public delegate void addhander(Model.orderitemlist orderitem);
        public event addhander adddata;
        public Add()
        {
            InitializeComponent();
            db = DB.Instance;
            foreach (var item in DB.Instance.orderitemtypes.ToList())
            {
                comboBox_itemtype.Items.Add(item);
            }
            foreach (var item in DB.Instance.locations.ToList())
            {
                comboBox_locationfrom.Items.Add(item);
                comboBox_locationto.Items.Add(item);
            }
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_save_Click(object sender, EventArgs e)
        {
            if (betterTextBox_sendername.Text.Trim() == "")
            {
                CustomControls.Alert.show("Name", "Please enter sender name", 2000);
                return;
            }
            if (betterTextBox_receivername.Text.Trim() == "")
            {
                CustomControls.Alert.show("Address", "Please enter sender address", 2000);
                return;
            }
            if (betterTextBox_senderphonenumber.Text.Trim() == "")
            {
                CustomControls.Alert.show("Address", "Please enter sender phone", 2000);
                return;
            }
            if (betterTextBox_itemname.Text.Trim() == "")
            {
                CustomControls.Alert.show("Name", " please enter item name", 2000);
                return;
            }
            if (comboBox_itemtype.SelectedItem==null)
            {
                CustomControls.Alert.show("Item Type", " please select item type", 2000);
                return;
            }
            if (comboBox_locationfrom.SelectedItem == null)
            {
                CustomControls.Alert.show("From", " please select location ", 2000);
                return;
            }
            if (comboBox_locationto.SelectedItem == null)
            {
                CustomControls.Alert.show("To", "select location",2000);
                return;
            }
            
            if (betterTextBox_itemweight.Text.Trim() == "")
            {
                CustomControls.Alert.show("To", "enter weight of item", 2000);
                return;
            }
            if (betterTextBox_itemqty.Text.Trim() == "")
            {
                CustomControls.Alert.show("To", "enter quantity of item", 2000);
                return;
            }
            if (betterTextBox_amount.Text.Trim() == "")
            {
                CustomControls.Alert.show("To", "enter charge amount", 2000);
                return;
            }
            if (betterTextBox_unit.Text.Trim() == "")
            {
                CustomControls.Alert.show("To", "enter unit", 2000);
                return;
            }
            if (betterTextBox_deliverplace.Text.Trim() == "")
            {
                CustomControls.Alert.show("To", "enter deliver place", 2000);
                return;
            }
            var additem = new Model.orderitemlist()
            {
                sender_name = betterTextBox_sendername.Text,
                sender_phone = betterTextBox_senderphonenumber.Text,
                receivername=betterTextBox_receivername.Text,
                receiverphone=betterTextBox_receiverphone.Text,
                itemname = betterTextBox_itemname.Text,
                orderitemtype_id = ((comboBox_itemtype.SelectedItem as Model.orderitemtype).id),
                location_from = ((comboBox_locationfrom.SelectedItem as Model.location).id),
                location_too = ((comboBox_locationto.SelectedItem as Model.location).id),
                weight= betterTextBox_itemweight.decVal,
                active = true,
                deliveryplace=betterTextBox_deliverplace.Text,
                unit=betterTextBox_unit.Text,
                date = nepaliCalender_DAte.Datestamp,
                quantity = betterTextBox_itemqty.decVal,
                amount = betterTextBox_amount.decVal,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            };
            db.orderitemlists.Add(additem);
            db.SaveChanges();
            adddata?.Invoke(additem);
            this.Close();
        }

        private void materialButton_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
