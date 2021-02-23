using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class UserCommun : UserBase
    {
        #region Singleton

        private static UserCommun _instance = null;

        public UserCommun()
        {
        }

        public static UserCommun GetInstance()
        {
            if (_instance == null)
                _instance = new UserCommun();

            return _instance;
        }
        #endregion
    }
}
