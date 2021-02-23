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
    public class HistoryvalueBase
    {
        #region Constructor
        public HistoryvalueBase()
        {

        }
        #endregion

        #region Methods

        public IList<Historyvalue> Get(Historyvalue historyvalue)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(historyvalue);
            IList<Historyvalue> response = ConNpgSqlDAL<Historyvalue>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Historyvalue> Get(Historyvalue historyvalue, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(historyvalue, paged, total, page_quantity, page_number);
            IList<Historyvalue> response = ConNpgSqlDAL<Historyvalue>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Historyvalue historyvalue)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(historyvalue);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       

        public IList<Historyvalue> GetCombo(Historyvalue historyvalue)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(historyvalue);
            IList<Historyvalue> response = ConNpgSqlDAL<Historyvalue>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Historyvalue historyvalue)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(historyvalue);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Historyvalue historyvalue)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(historyvalue);
            ConNpgSqlDAL<Historyvalue>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Historyvalue historyvalue)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(historyvalue);
            ConNpgSqlDAL<Historyvalue>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            