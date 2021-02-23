using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class CustomfieldCommun : CustomfieldBase
    {
        #region Singleton

        private static CustomfieldCommun _instance = null;

        public CustomfieldCommun()
        {
        }

        public static CustomfieldCommun GetInstance()
        {
            if (_instance == null)
                _instance = new CustomfieldCommun();

            return _instance;
        }
        #endregion
    }
}
