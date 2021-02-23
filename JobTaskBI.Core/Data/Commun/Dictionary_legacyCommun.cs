using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class Dictionary_legacyCommun : Dictionary_legacyBase
    {
        #region Singleton

        private static Dictionary_legacyCommun _instance = null;

        public Dictionary_legacyCommun()
        {
        }

        public static Dictionary_legacyCommun GetInstance()
        {
            if (_instance == null)
                _instance = new Dictionary_legacyCommun();

            return _instance;
        }
        #endregion
    }
}
