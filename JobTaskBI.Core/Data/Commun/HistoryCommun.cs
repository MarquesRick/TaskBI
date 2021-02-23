using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class HistoryCommun : HistoryBase
    {
        #region Singleton

        private static HistoryCommun _instance = null;

        public HistoryCommun()
        {
        }

        public static HistoryCommun GetInstance()
        {
            if (_instance == null)
                _instance = new HistoryCommun();

            return _instance;
        }
        #endregion
    }
}
