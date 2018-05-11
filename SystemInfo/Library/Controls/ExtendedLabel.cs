using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SystemWatcher.Library.Controls
{
    public partial class ExtendedLabel : UserControl
    {
        public string Text
        {
            set
            {
                this.lblLabel.Text = value;
            }
            get
            {
                return this.lblLabel.Text;
            }
        }
        public ExtendedLabel()
        {
            InitializeComponent();
        }
    }
}
