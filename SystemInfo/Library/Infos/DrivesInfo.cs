using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SystemWatcher.Library.Infos
{
    class DrivesInfo
    {
        public DriveInfo[] DriveInfos { set; get; }

        public DrivesInfo()
        {
            LoadDriversInfo();
        }

        public DriveInfo Get(int index)
        {
            return this.DriveInfos[index];
        }
        private void LoadDriversInfo()
        {
            this.DriveInfos = DriveInfo.GetDrives();
        }

    }
}
