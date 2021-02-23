using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class ItemlocalCommun : ItemlocalBase
    {
        #region Singleton

        private static ItemlocalCommun _instance = null;

        public ItemlocalCommun()
        {
        }

        public static ItemlocalCommun GetInstance()
        {
            if (_instance == null)
                _instance = new ItemlocalCommun();

            return _instance;
        }
        #endregion
    }
}
