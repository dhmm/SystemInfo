using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SystemWatcher.Library.Infos;
using System.IO;
using SystemWatcher.Library.Controls;
using System.Net.NetworkInformation;

namespace SystemWatcher
{
    public partial class FormMain : Form
    {
        DrivesInfo drivesInfo = new DrivesInfo();
        NetworkInterfacesInfo networkInterfacesInfo = new NetworkInterfacesInfo();
        SystemInfo systemInfo = new SystemInfo();
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            LoadDrivesInfo();
            LoadNetworkInterfacesInfo();
            LoadSystemInfo();
        }
        private void LoadDrivesInfo()
        {
            int top = 10;
            foreach (DriveInfo dInfo in this.drivesInfo.DriveInfos)
            {
                ControlDriveInfo cDriveInfo = new ControlDriveInfo();
                cDriveInfo.DriveInformation = dInfo;
                cDriveInfo.Top = top;
                this.pnlDrivesInfo.Controls.Add(cDriveInfo);
                cDriveInfo.SendToBack();
                top += cDriveInfo.Height;
            }
        }
        private void LoadNetworkInterfacesInfo()
        {
            int top = 10;
            foreach (NetworkInterface nInfo in this.networkInterfacesInfo.NetworkInterfacesInfos)
            {
                ControlNetworkInterfaceInfo cNetworkInterfaceInfo = new ControlNetworkInterfaceInfo();
                cNetworkInterfaceInfo.NetworkInterfaceInformation = nInfo;
                cNetworkInterfaceInfo.Top = top;
                this.pnlNetworkInterfacesInfo.Controls.Add(cNetworkInterfaceInfo);
                cNetworkInterfaceInfo.SendToBack();
                top += cNetworkInterfaceInfo.Height;
            }
        }
        private void LoadSystemInfo()
        {
            lblTotalPhysicalMemory.Text = systemInfo.TotalPhysicalMemory.ToString() + " GB";
            lblTotalVirtualMemory.Text = systemInfo.TotalVirtualMemory.ToString() + " GB";
            lblAvailablePhysicalMemory.Text = systemInfo.AvailablePhysicalMemory.ToString() + " GB";
            lblAvailableVirtualMemory.Text = systemInfo.AvailableVirtualMemory.ToString() + " GB";
            lblOSFullName.Text = systemInfo.OSFullName;
            lblOSPlatform.Text = systemInfo.OSPlatform;
            lblOSVersion.Text = systemInfo.OSVersion;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
