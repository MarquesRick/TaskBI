using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class ApiCommun : ApiBase
    {
        #region Singleton

        private static ApiCommun _instance = null;

        public ApiCommun()
        {
        }

        public static ApiCommun GetInstance()
        {
            if (_instance == null)
                _instance = new ApiCommun();

            return _instance;
        }
        #endregion
    }
}
