using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class HistoryvalueCommun : HistoryvalueBase
    {
        #region Singleton

        private static HistoryvalueCommun _instance = null;

        public HistoryvalueCommun()
        {
        }

        public static HistoryvalueCommun GetInstance()
        {
            if (_instance == null)
                _instance = new HistoryvalueCommun();

            return _instance;
        }
        #endregion
    }
}
