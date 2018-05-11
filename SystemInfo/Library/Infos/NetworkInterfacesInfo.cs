using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.NetworkInformation;

namespace SystemWatcher.Library.Infos
{
    public class NetworkInterfacesInfo
    {
        public NetworkInterface[] NetworkInterfacesInfos { set; get; }

        public NetworkInterfacesInfo()
        {
            LoadNetworkInterfacesInfo();
        }

        public NetworkInterface Get(int index)
        {
            return this.NetworkInterfacesInfos[index];
        }
        private void LoadNetworkInterfacesInfo()
        {
            this.NetworkInterfacesInfos = NetworkInterface.GetAllNetworkInterfaces();            
        }
    }
}
