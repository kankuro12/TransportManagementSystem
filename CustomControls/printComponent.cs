using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControls
{
    public partial class printComponent : Component
    {
        public printComponent()
        {
            InitializeComponent();
        }

        public printComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
