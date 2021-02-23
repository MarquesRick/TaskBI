using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class Dictionary_newCommun : Dictionary_newBase
    {
        #region Singleton

        private static Dictionary_newCommun _instance = null;

        public Dictionary_newCommun()
        {
        }

        public static Dictionary_newCommun GetInstance()
        {
            if (_instance == null)
                _instance = new Dictionary_newCommun();

            return _instance;
        }
        #endregion
    }
}
