using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class MediatagsCommun : MediatagsBase
    {
        #region Singleton

        private static MediatagsCommun _instance = null;

        public MediatagsCommun()
        {
        }

        public static MediatagsCommun GetInstance()
        {
            if (_instance == null)
                _instance = new MediatagsCommun();

            return _instance;
        }
        #endregion
    }
}
