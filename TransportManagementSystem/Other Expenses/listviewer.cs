using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TransportManagementSystem.Other_Expenses
{
   public class listviewer:ListViewItem
    {
        private int _id { get; set; }
        private string _title { get; set; }
        private decimal _amount { get; set; }


        public string title { get { return _title; } set { _title = value; SubItems[1].Text = value; } }
        public decimal amount { get { return _amount; } set { _amount = value; SubItems[2].Text = value.ToString("0.##"); } }
        public int id { get { return _id; } set { _id = value; SubItems[3].Text = value.ToString(); } }

        public int sn = 1;

        public listviewer(Model.otherexpitem otherexpitem, int sn)
        {
            for (int i = 1; i <= 5; i++)
            {
                SubItems.Add(new ListViewSubItem());
            }
            SubItems[0].Text = sn.ToString();
            title = otherexpitem.title;
            amount = otherexpitem.amount;
            id = otherexpitem.id;

        }
    }
}
