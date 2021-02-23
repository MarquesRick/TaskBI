using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class LocaltypeCommun : LocaltypeBase
    {
        #region Singleton

        private static LocaltypeCommun _instance = null;

        public LocaltypeCommun()
        {
        }

        public static LocaltypeCommun GetInstance()
        {
            if (_instance == null)
                _instance = new LocaltypeCommun();

            return _instance;
        }
        #endregion
    }
}
