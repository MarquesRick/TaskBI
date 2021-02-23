using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class CustomentityCommun : CustomentityBase
    {
        #region Singleton

        private static CustomentityCommun _instance = null;

        public CustomentityCommun()
        {
        }

        public static CustomentityCommun GetInstance()
        {
            if (_instance == null)
                _instance = new CustomentityCommun();

            return _instance;
        }
        #endregion
    }
}
