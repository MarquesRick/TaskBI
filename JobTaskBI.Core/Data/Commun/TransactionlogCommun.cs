using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class TransactionlogCommun : TransactionlogBase
    {
        #region Singleton

        private static TransactionlogCommun _instance = null;

        public TransactionlogCommun()
        {
        }

        public static TransactionlogCommun GetInstance()
        {
            if (_instance == null)
                _instance = new TransactionlogCommun();

            return _instance;
        }
        #endregion
    }
}
