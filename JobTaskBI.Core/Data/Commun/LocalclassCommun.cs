using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class LocalclassCommun : LocalclassBase
    {
        #region Singleton

        private static LocalclassCommun _instance = null;

        public LocalclassCommun()
        {
        }

        public static LocalclassCommun GetInstance()
        {
            if (_instance == null)
                _instance = new LocalclassCommun();

            return _instance;
        }
        #endregion
    }
}
