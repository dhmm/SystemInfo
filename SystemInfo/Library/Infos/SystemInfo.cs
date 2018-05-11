using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.Devices;
using SystemWatcher.Library.Helpers;


namespace SystemWatcher.Library.Infos
{
    public class SystemInfo
    {
        private ComputerInfo ComputerInfo { set; get; }

        public double TotalPhysicalMemory
        {
            get
            {
                return UnitConverter.BytesToGigaBytes((long)this.ComputerInfo.TotalPhysicalMemory);
            }
        }
        public double TotalVirtualMemory
        {
            get
            {
                return UnitConverter.BytesToGigaBytes((long)this.ComputerInfo.TotalVirtualMemory);
            }
        }
        public double AvailablePhysicalMemory
        {
            get
            {
                return UnitConverter.BytesToGigaBytes((long)this.ComputerInfo.AvailablePhysicalMemory);
            }
        }
        public double AvailableVirtualMemory
        {
            get
            {
                return UnitConverter.BytesToGigaBytes((long)this.ComputerInfo.AvailableVirtualMemory);
            }
        }
        public string OSFullName
        {
            get
            {
                return this.ComputerInfo.OSFullName;
            }
        }
        public string OSPlatform
        {
            get
            {
                return this.ComputerInfo.OSPlatform;
            }
        }
        public string OSVersion
        {
            get
            {
                return this.ComputerInfo.OSVersion;
            }
        }

        public SystemInfo()
        {
            ComputerInfo = new ComputerInfo();            
        }
        

    }
}
