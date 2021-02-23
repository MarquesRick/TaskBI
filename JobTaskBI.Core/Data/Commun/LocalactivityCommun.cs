using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class LocalactivityCommun : LocalactivityBase
    {
        #region Singleton

        private static LocalactivityCommun _instance = null;

        public LocalactivityCommun()
        {
        }

        public static LocalactivityCommun GetInstance()
        {
            if (_instance == null)
                _instance = new LocalactivityCommun();

            return _instance;
        }
        #endregion
    }
}
