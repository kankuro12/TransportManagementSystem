using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportManagementSystem.Other_Expenses
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void materialButton_Add_Click(object sender, EventArgs e)
        {
            if (betterTextBox_title.Text.Trim() == "")
            {
                CustomControls.Alert.show("Title", "Enter title ", 3000);
                betterTextBox_title.Focus();
                return;
            }
            if (betterTextBox_amount.decVal == 0)
            {
                CustomControls.Alert.show("amount", "Enter amount ", 3000);
                betterTextBox_amount.Focus();
                return;
            }
            viewer viewer = new viewer(betterTextBox_title.Text, betterTextBox_amount.decVal, betterListView1.Items.Count + 1);
            betterListView1.Items.Add(viewer);
        }
    }
}
