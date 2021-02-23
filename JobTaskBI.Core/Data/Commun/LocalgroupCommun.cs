using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class LocalgroupCommun : LocalgroupBase
    {
        #region Singleton

        private static LocalgroupCommun _instance = null;

        public LocalgroupCommun()
        {
        }

        public static LocalgroupCommun GetInstance()
        {
            if (_instance == null)
                _instance = new LocalgroupCommun();

            return _instance;
        }
        #endregion
    }
}
