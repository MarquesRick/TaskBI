using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class ItemCommun : ItemBase
    {
        #region Singleton

        private static ItemCommun _instance = null;

        public ItemCommun()
        {
        }

        public static ItemCommun GetInstance()
        {
            if (_instance == null)
                _instance = new ItemCommun();

            return _instance;
        }
        #endregion
    }
}
