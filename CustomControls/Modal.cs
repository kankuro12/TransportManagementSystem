using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class Modal : Form
    {

        public Modal(Form f)
        {
            InitializeComponent();
            this.Load += (o, e) =>
            {
                f.BorderRadius(10);
                this.DialogResult = f.ShowDialog();
                this.Close();
            };
        }

        public Modal()
        {
            InitializeComponent();

        }




        public static DialogResult Show(Form f)
        {
            var t = new Modal(f);
            return t.ShowDialog();
            //t._show(f);


        }
    }
}
//public partial class Modal : Form
//    {

//        public Modal(Form f)
//        {
//            InitializeComponent();
//            this.Load += (o, e) =>
//            {
//                f.FormClosed += (a, s) => {
//                    this.Close();
//                };
//                this.DialogResult=f.ShowDialog();

//            };
//        }

//        public Modal()
//        {
//            InitializeComponent();
           
//        }



//        public static void Show(Form f)
//        {
//            var t = new Modal(f);
//            t.ShowDialog();
//            //t._show(f);
            

//        }
//    }
//}
