using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class DeviceCommun : DeviceBase
    {
        #region Singleton

        private static DeviceCommun _instance = null;

        public DeviceCommun()
        {
        }

        public static DeviceCommun GetInstance()
        {
            if (_instance == null)
                _instance = new DeviceCommun();

            return _instance;
        }
        #endregion
    }
}
