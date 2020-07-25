using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class Notice : CustomControls.Blank
    {
        public Notice( string text, string title = "", int mode=0)
        {
            InitializeComponent();
            label1.Text = title;label2.Text = text;textButtoncancel.Visible = mode == 1;
            this.roundBorder();
        }

        private void Message_Load(object sender, EventArgs e)
        {

        }

        public static DialogResult show(string text, string title = "", int mode = 0)
        {
            var n = new Notice(text, title, mode);
            return n.ShowModal();
        }

        private void textButtoncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textButtonok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
