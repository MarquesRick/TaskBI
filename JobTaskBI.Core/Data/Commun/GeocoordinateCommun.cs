using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class GeocoordinateCommun : GeocoordinateBase
    {
        #region Singleton

        private static GeocoordinateCommun _instance = null;

        public GeocoordinateCommun()
        {
        }

        public static GeocoordinateCommun GetInstance()
        {
            if (_instance == null)
                _instance = new GeocoordinateCommun();

            return _instance;
        }
        #endregion
    }
}
