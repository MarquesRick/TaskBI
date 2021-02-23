using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class HistorymediaCommun : HistorymediaBase
    {
        #region Singleton

        private static HistorymediaCommun _instance = null;

        public HistorymediaCommun()
        {
        }

        public static HistorymediaCommun GetInstance()
        {
            if (_instance == null)
                _instance = new HistorymediaCommun();

            return _instance;
        }
        #endregion
    }
}
