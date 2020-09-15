using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TransportManagementSystem.Parties
{
    public class Viewer : ListViewItem
    {

        private int _id { get; set; }
        private string _name { get; set; }
        private string _address { get; set; }
        private string _phoone { get; set; }
        private string _email { get; set; }
        private decimal _due { get; set; }
        private decimal _advance { get; set; }

        public int sn { get { return _id; } set { _id = value;SubItems[0].Text = value.ToString(); } }
        public string name { get { return _name; } set { _name = value; SubItems[1].Text = value.ToString(); } }
        public string address { get { return _address; } set { _address = value; SubItems[2].Text = value.ToString(); } }
        public string phone { get { return _phoone; } set { _phoone = value; SubItems[3].Text = value.ToString(); } }
        public string email { get { return _email; } set { _email = value; SubItems[4].Text = value.ToString(); } }
        public decimal due { get { return _due; } set { _due = value; SubItems[5].Text = value.ToString(); } }
        public decimal advance { get { return _advance; } set { _advance = value; SubItems[6].Text = value.ToString(); } }
        public int id { get { return _id; } set { _id = value;SubItems[7].Text = value.ToString(); } }

       public Viewer(Model.party party,int sn)
        {
            for(int i = 0; i <= 10; i++)
            {
                SubItems.Add(new ListViewSubItem());
            }
            this.SubItems[0].Text = sn.ToString();
            id = party.id;
            name = party.name;
            address =party.address;
            phone = party.phone;
            email = party.email;
            due = party.due;
            advance = party.advance;
        }
        public void update(Model.party party)
        {
            id = party.id;
            name = party.name;
            address = party.address;
            phone = party.phone;
            email = party.email;
            due = party.due;
            advance = party.advance;
        }
    }
}
