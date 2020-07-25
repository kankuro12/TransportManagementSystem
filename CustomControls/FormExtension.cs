using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
  public static  class FormExtension
    {
        public static DialogResult ShowModal(this Form form)
        {
            var t = new Modal(form);
            return t.ShowDialog();
        }

    }
}
