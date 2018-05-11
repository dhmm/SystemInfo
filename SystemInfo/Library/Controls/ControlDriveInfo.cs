using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using SystemWatcher.Library.Helpers;

namespace SystemWatcher.Library.Controls
{
    public partial class ControlDriveInfo : UserControl
    {
        private DriveInfo _driveInfo = null;
        private bool Expanded = false;
        private int NotExpandedHeight = 100;
        private int ExpandedHeight = 320;
              

        public DriveInfo DriveInformation 
        {
            set
            {
                this._driveInfo = value;
                if (this._driveInfo != null)
                {
                    ShowInformation();
                }
            }
            get
            {
                return this._driveInfo;
            }
        }
                        
        public ControlDriveInfo()
        {
            InitializeComponent();
        }
        private void ShowInformation()
        {
            this.lblDriveName.Text = DriveInformation.Name;
            this.lblType.Text = DriveInformation.DriveType.ToString();

            if (DriveInformation.DriveType != DriveType.CDRom &&
                DriveInformation.DriveType != DriveType.Unknown)
            {
                this.lblDriveLabel.Text = DriveInformation.VolumeLabel;
                this.lblFormat.Text = DriveInformation.DriveFormat;                
                this.lblTotalSize.Text = UnitConverter.BytesToGigaBytes(DriveInformation.TotalSize).ToString() + " GB";
                this.lblTotalFreeSpace.Text = UnitConverter.BytesToGigaBytes(DriveInformation.TotalFreeSpace).ToString() + " GB";
                this.lblAvailableSpace.Text = UnitConverter.BytesToGigaBytes(DriveInformation.AvailableFreeSpace).ToString() + " GB";
                int panelWidth = (int)((1 - ((double)this.DriveInformation.TotalFreeSpace / (double)this.DriveInformation.TotalSize)) * pnlTotalSize.Width);
                this.pnlUsedSpace.Width = panelWidth;
            }
            else
            {
                this.lblDriveLabel.Text = "-";
                this.lblFormat.Text = "-";
                this.lblTotalSize.Text = "0";
                this.lblTotalFreeSpace.Text = "0";
                this.lblAvailableSpace.Text = "0";               
                this.pnlUsedSpace.Width = 0;
            }
             
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
            this.BackColor = Color.White;
        }
        
        
    }
}
