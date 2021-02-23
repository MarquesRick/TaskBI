using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class CustomfieldvalueCommun : CustomfieldvalueBase
    {
        #region Singleton

        private static CustomfieldvalueCommun _instance = null;

        public CustomfieldvalueCommun()
        {
        }

        public static CustomfieldvalueCommun GetInstance()
        {
            if (_instance == null)
                _instance = new CustomfieldvalueCommun();

            return _instance;
        }
        #endregion
    }
}
