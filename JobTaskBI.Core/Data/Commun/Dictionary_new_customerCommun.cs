using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class Dictionary_new_customerCommun : Dictionary_new_customerBase
    {
        #region Singleton

        private static Dictionary_new_customerCommun _instance = null;

        public Dictionary_new_customerCommun()
        {
        }

        public static Dictionary_new_customerCommun GetInstance()
        {
            if (_instance == null)
                _instance = new Dictionary_new_customerCommun();

            return _instance;
        }
        #endregion
    }
}
