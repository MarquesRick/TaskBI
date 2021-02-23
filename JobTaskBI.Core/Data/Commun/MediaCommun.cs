using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class MediaCommun : MediaBase
    {
        #region Singleton

        private static MediaCommun _instance = null;

        public MediaCommun()
        {
        }

        public static MediaCommun GetInstance()
        {
            if (_instance == null)
                _instance = new MediaCommun();

            return _instance;
        }
        #endregion
    }
}
