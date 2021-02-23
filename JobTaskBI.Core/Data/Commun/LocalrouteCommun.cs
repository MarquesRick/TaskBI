using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class LocalrouteCommun : LocalrouteBase
    {
        #region Singleton

        private static LocalrouteCommun _instance = null;

        public LocalrouteCommun()
        {
        }

        public static LocalrouteCommun GetInstance()
        {
            if (_instance == null)
                _instance = new LocalrouteCommun();

            return _instance;
        }
        #endregion
    }
}
