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
    public class LogBase
    {
        #region Constructor
        public LogBase()
        {

        }
        #endregion

        #region Methods

        public IList<Log> Get(Log log)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(log);
            IList<Log> response = ConOracleDAL<Log>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Log> Get(Log log, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(log, paged, total, page_quantity, page_number);
            IList<Log> response = ConOracleDAL<Log>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Log log)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(log);
            IList<Response> response = ConOracleDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Log> GetCombo(Log log)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(log);
            IList<Log> response = ConOracleDAL<Log>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Log log)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(log);
            IList<Response> response = ConOracleDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Log log)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(log);
            ConOracleDAL<Log>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Log log)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(log);
            ConOracleDAL<Log>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            