using System.Collections.Generic;
using Core.Model;
using System.Data;
using Core.DAL;
using DbBase;


namespace Core.Data.Base
{
    ////////////////////////////////////////////
    //////// Codigo Gerado  ////////////////////
    ////////////////////////////////////////////
    public class Rs_29_Cont_CancelamentoBase
    {
        #region Constructor
        public Rs_29_Cont_CancelamentoBase()
        {

        }
        #endregion

        #region Methods

        public IList<Rs_29_Cont_Cancelamento> Get(Rs_29_Cont_Cancelamento rs_29_Cont_Cancelamento)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(rs_29_Cont_Cancelamento);
            IList<Rs_29_Cont_Cancelamento> response = ConOracleDAL<Rs_29_Cont_Cancelamento>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Rs_29_Cont_Cancelamento> Get(Rs_29_Cont_Cancelamento rs_29_Cont_Cancelamento, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(rs_29_Cont_Cancelamento, paged, total, page_quantity, page_number);
            IList<Rs_29_Cont_Cancelamento> response = ConOracleDAL<Rs_29_Cont_Cancelamento>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Rs_29_Cont_Cancelamento rs_29_Cont_Cancelamento)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(rs_29_Cont_Cancelamento);
            IList<Response> response = ConOracleDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Rs_29_Cont_Cancelamento> GetCombo(Rs_29_Cont_Cancelamento rs_29_Cont_Cancelamento)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(rs_29_Cont_Cancelamento);
            IList<Rs_29_Cont_Cancelamento> response = ConOracleDAL<Rs_29_Cont_Cancelamento>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Rs_29_Cont_Cancelamento rs_29_Cont_Cancelamento)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(rs_29_Cont_Cancelamento);
            IList<Response> response = ConOracleDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Rs_29_Cont_Cancelamento rs_29_Cont_Cancelamento)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(rs_29_Cont_Cancelamento);
            ConOracleDAL<Rs_29_Cont_Cancelamento>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Rs_29_Cont_Cancelamento rs_29_Cont_Cancelamento)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(rs_29_Cont_Cancelamento);
            ConOracleDAL<Rs_29_Cont_Cancelamento>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            