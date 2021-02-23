using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class CustomentityvalueCommun : CustomentityvalueBase
    {
        #region Singleton

        private static CustomentityvalueCommun _instance = null;

        public CustomentityvalueCommun()
        {
        }

        public static CustomentityvalueCommun GetInstance()
        {
            if (_instance == null)
                _instance = new CustomentityvalueCommun();

            return _instance;
        }
        #endregion
    }
}
