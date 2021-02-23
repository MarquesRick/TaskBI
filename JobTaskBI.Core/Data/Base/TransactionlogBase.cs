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
    public class TransactionlogBase
    {
        #region Constructor
        public TransactionlogBase()
        {

        }
        #endregion

        #region Methods

        public IList<Transactionlog> Get(Transactionlog transactionlog)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(transactionlog);
            IList<Transactionlog> response = ConNpgSqlDAL<Transactionlog>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Transactionlog> Get(Transactionlog transactionlog, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(transactionlog, paged, total, page_quantity, page_number);
            IList<Transactionlog> response = ConNpgSqlDAL<Transactionlog>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Transactionlog transactionlog)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(transactionlog);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       
        public IList<Transactionlog> GetCombo(Transactionlog transactionlog)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(transactionlog);
            IList<Transactionlog> response = ConNpgSqlDAL<Transactionlog>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Transactionlog transactionlog)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(transactionlog);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Transactionlog transactionlog)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(transactionlog);
            ConNpgSqlDAL<Transactionlog>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Transactionlog transactionlog)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(transactionlog);
            ConNpgSqlDAL<Transactionlog>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            