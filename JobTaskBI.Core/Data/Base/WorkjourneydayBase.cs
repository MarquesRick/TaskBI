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
    public class WorkjourneydayBase
    {
        #region Constructor
        public WorkjourneydayBase()
        {

        }
        #endregion

        #region Methods

        public IList<Workjourneyday> Get(Workjourneyday workjourneyday)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(workjourneyday);
            IList<Workjourneyday> response = ConNpgSqlDAL<Workjourneyday>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Workjourneyday> Get(Workjourneyday workjourneyday, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(workjourneyday, paged, total, page_quantity, page_number);
            IList<Workjourneyday> response = ConNpgSqlDAL<Workjourneyday>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Workjourneyday workjourneyday)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(workjourneyday);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Workjourneyday> GetCombo(Workjourneyday workjourneyday)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(workjourneyday);
            IList<Workjourneyday> response = ConNpgSqlDAL<Workjourneyday>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Workjourneyday workjourneyday)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(workjourneyday);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Workjourneyday workjourneyday)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(workjourneyday);
            ConNpgSqlDAL<Workjourneyday>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Workjourneyday workjourneyday)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(workjourneyday);
            ConNpgSqlDAL<Workjourneyday>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            