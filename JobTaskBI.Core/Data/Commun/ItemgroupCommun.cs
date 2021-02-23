using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class ItemgroupCommun : ItemgroupBase
    {
        #region Singleton

        private static ItemgroupCommun _instance = null;

        public ItemgroupCommun()
        {
        }

        public static ItemgroupCommun GetInstance()
        {
            if (_instance == null)
                _instance = new ItemgroupCommun();

            return _instance;
        }
        #endregion
    }
}
