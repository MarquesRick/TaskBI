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
    public class HistoryBase
    {
        #region Constructor
        public HistoryBase()
        {

        }
        #endregion

        #region Methods

        public IList<History> Get(History history)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(history);
            IList<History> response = ConNpgSqlDAL<History>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<History> Get(History history, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(history, paged, total, page_quantity, page_number);
            IList<History> response = ConNpgSqlDAL<History>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(History history)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(history);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

     
        public IList<History> GetCombo(History history)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(history);
            IList<History> response = ConNpgSqlDAL<History>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(History history)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(history);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(History history)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(history);
            ConNpgSqlDAL<History>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(History history)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(history);
            ConNpgSqlDAL<History>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            