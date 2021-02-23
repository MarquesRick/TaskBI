using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class AgentrouteCommun : AgentrouteBase
    {
        #region Singleton

        private static AgentrouteCommun _instance = null;

        public AgentrouteCommun()
        {
        }

        public static AgentrouteCommun GetInstance()
        {
            if (_instance == null)
                _instance = new AgentrouteCommun();

            return _instance;
        }
        #endregion
    }
}
