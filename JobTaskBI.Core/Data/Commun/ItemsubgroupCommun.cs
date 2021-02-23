using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class ItemsubgroupCommun : ItemsubgroupBase
    {
        #region Singleton

        private static ItemsubgroupCommun _instance = null;

        public ItemsubgroupCommun()
        {
        }

        public static ItemsubgroupCommun GetInstance()
        {
            if (_instance == null)
                _instance = new ItemsubgroupCommun();

            return _instance;
        }
        #endregion
    }
}
