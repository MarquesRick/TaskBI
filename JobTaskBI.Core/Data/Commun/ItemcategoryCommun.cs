using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class ItemcategoryCommun : ItemcategoryBase
    {
        #region Singleton

        private static ItemcategoryCommun _instance = null;

        public ItemcategoryCommun()
        {
        }

        public static ItemcategoryCommun GetInstance()
        {
            if (_instance == null)
                _instance = new ItemcategoryCommun();

            return _instance;
        }
        #endregion
    }
}
