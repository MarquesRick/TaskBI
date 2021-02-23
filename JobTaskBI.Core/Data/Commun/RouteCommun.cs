using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class RouteCommun : RouteBase
    {
        #region Singleton

        private static RouteCommun _instance = null;

        public RouteCommun()
        {
        }

        public static RouteCommun GetInstance()
        {
            if (_instance == null)
                _instance = new RouteCommun();

            return _instance;
        }
        #endregion
    }
}
