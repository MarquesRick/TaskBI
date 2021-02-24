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
    public class ApiBase
    {
        #region Constructor
        public ApiBase()
        {

        }
        #endregion

        #region Methods

        public IList<Api> Get(Api api)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(api);
            IList<Api> response = ConNpgSqlDAL<Api>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Api> Get(Api api, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(api, paged, total, page_quantity, page_number);
            IList<Api> response = ConNpgSqlDAL<Api>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Api api)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(api);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Api> GetCombo(Api api)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(api);
            IList<Api> response = ConNpgSqlDAL<Api>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Api api)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(api);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Api api)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(api);
            ConNpgSqlDAL<Api>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Api api)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(api);
            ConNpgSqlDAL<Api>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            