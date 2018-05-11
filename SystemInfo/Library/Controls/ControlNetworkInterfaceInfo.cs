using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SystemWatcher.Library.Helpers;
using System.Net.NetworkInformation;

namespace SystemWatcher.Library.Controls
{
    public partial class ControlNetworkInterfaceInfo : UserControl
    {
        private NetworkInterface _networkInterface = null;
        private bool Expanded = false;
        private int NotExpandedHeight = 90;
        private int ExpandedHeight = 330;


        public NetworkInterface NetworkInterfaceInformation 
        {
            set
            {
                this._networkInterface = value;
                if (this._networkInterface != null)
                {
                    ShowInformation();
                }
            }
            get
            {
                return this._networkInterface;
            }
        }

        public ControlNetworkInterfaceInfo()
        {
            InitializeComponent();
        }
        private void ShowInformation()
        {
            this.lblDescription.Text = NetworkInterfaceInformation.Description;
            this.lblID.Text = NetworkInterfaceInformation.Id;
            this.lblName.Text = NetworkInterfaceInformation.Name;
            this.lblType.Text = NetworkInterfaceInformation.NetworkInterfaceType.ToString();
            this.lblOperationalStatus.Text = NetworkInterfaceInformation.OperationalStatus.ToString();
            this.lblSpeed.Text = UnitConverter.BitsPerSecondToMegaBitsPerSecond(NetworkInterfaceInformation.Speed).ToString() + " Mbps";
            this.lblSupportsMulticast.Text = NetworkInterfaceInformation.SupportsMulticast ? "Yes" : "No";
            
            
             
        }
        private void ExpandCollapse()
        {
            if (!Expanded)
            {
                Expand();                
            }
            else
            {
                Collapse();                
            }
        }

        private void btnExpand_Click(object sender, EventArgs e)
        {
            ExpandCollapse();
        }
        private void Expand()
        {
            Expanded = true;
            this.Height = ExpandedHeight;
            btnExpand.Text = "-";
            this.BackColor = Color.Orange;
        }
        private void Collapse()
        {
            Expanded = false;
            this.Height = NotExpandedHeight;
            btnExpand.Text = "+";
            this.BackColor = Color.WhiteSmoke;
        }
        
        
    }
}
