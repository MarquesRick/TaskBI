using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Data.Base;

namespace Core.Data
{
    public class Rs_29_Cont_CancelamentoCommun : Rs_29_Cont_CancelamentoBase
    {
        #region Singleton

        private static Rs_29_Cont_CancelamentoCommun _instance = null;

        public Rs_29_Cont_CancelamentoCommun()
        {
        }

        public static Rs_29_Cont_CancelamentoCommun GetInstance()
        {
            if (_instance == null)
                _instance = new Rs_29_Cont_CancelamentoCommun();

            return _instance;
        }
        #endregion
    }
}
