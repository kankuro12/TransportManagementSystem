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
    public partial class EditItem : Form
    {
        public delegate void edithandler(Model.orderitemlist orderitemlist);
        public event edithandler editdata;
        Model.TransportManagementEntities db;
        public EditItem(int item_id)
        {
            InitializeComponent();
            foreach (var item in DB.Instance.orderitemtypes.ToList())
            {
                comboBox_itemtype.Items.Add(item);
            }
            foreach (var item in DB.Instance.locations.ToList())
            {
                comboBox_locationfrom.Items.Add(item);
                comboBox_locationto.Items.Add(item);
            }
            db = DB.Instance;
            var load = db.orderitemlists.Find(item_id);
            betterTextBox_sendername.Text = load.sender_name;
            betterTextBox_senderphonenumber.Text = load.sender_phone;
            betterTextBox_receivername.Text = load.receivername;
            betterTextBox_receiverphone.Text = load.receiverphone;

            betterTextBox_amount.decVal = load.amount.Value;
            betterTextBox_deliverplace.Text = load.deliveryplace;
            comboBox_itemtype.Text = (load.orderitemtype as Model.orderitemtype).name;
            comboBox_locationto.Text = (load.location1 as Model.location).name;
            comboBox_locationfrom.Text = (load.location as Model.location).name;
            betterTextBox_itemname.Text = (load.itemname);
            betterTextBox_unit.Text = load.unit;
            betterTextBox_itemqty.decVal = load.quantity.Value;
            betterTextBox_itemweight.decVal = load.weight.Value;
            betterTextBox_amount.decVal = load.amount.Value;
            this.item_id = item_id;


        }
        int item_id;
        private void materialButton_save_Click(object sender, EventArgs e)
        {
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_save_Click_1(object sender, EventArgs e)
        {

            if (betterTextBox_sendername.Text.Trim() == "")
            {
                CustomControls.Alert.show("Name", "Please enter sender name", 2000);
                return;
            }
            if (betterTextBox_receiverphone.Text.Trim() == "")
            {
                CustomControls.Alert.show("Name", "Please enter  receiver phone", 2000);
                return;
            }
            if (betterTextBox_receivername.Text.Trim() == "")
            {
                CustomControls.Alert.show("Name", "Please enter  receiver name", 2000);
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
            if (comboBox_itemtype.SelectedItem == null)
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
                CustomControls.Alert.show("To", "select location", 2000);
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
            var edit = db.orderitemlists.Find(item_id);
            edit.sender_name = betterTextBox_sendername.Text;
            edit.receiverphone = betterTextBox_receiverphone.Text;
            edit.receivername = betterTextBox_receivername.Text;
            edit.sender_phone = betterTextBox_senderphonenumber.Text;
            edit.itemname = betterTextBox_itemname.Text;
            edit.location_from = (comboBox_locationfrom.SelectedItem as Model.location).id;
            edit.location_too = (comboBox_locationto.SelectedItem as Model.location).id;
            edit.date = nepaliCalender_DAte.Datestamp;
            edit.unit = betterTextBox_unit.Text;
            edit.weight = betterTextBox_itemweight.decVal;
            edit.quantity = betterTextBox_itemqty.decVal;
            edit.orderitemtype_id = (comboBox_itemtype.SelectedItem as Model.orderitemtype).id;
            edit.deliveryplace = betterTextBox_deliverplace.Text;
            edit.amount = betterTextBox_amount.decVal;
            db.Entry(edit).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            editdata?.Invoke(edit);
            this.Close();
        }

        private void materialButton_cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
