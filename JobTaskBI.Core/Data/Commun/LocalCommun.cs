using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class LocalCommun : LocalBase
    {
        #region Singleton

        private static LocalCommun _instance = null;

        public LocalCommun()
        {
        }

        public static LocalCommun GetInstance()
        {
            if (_instance == null)
                _instance = new LocalCommun();

            return _instance;
        }
        #endregion
    }
}
