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
    public class LocalBase
    {
        #region Constructor
        public LocalBase()
        {

        }
        #endregion

        #region Methods

        public IList<Local> Get(Local local)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(local);
            IList<Local> response = ConNpgSqlDAL<Local>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Local> Get(Local local, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(local, paged, total, page_quantity, page_number);
            IList<Local> response = ConNpgSqlDAL<Local>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Local local)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(local);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       
        public IList<Local> GetCombo(Local local)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(local);
            IList<Local> response = ConNpgSqlDAL<Local>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Local local)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(local);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Local local)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(local);
            ConNpgSqlDAL<Local>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Local local)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(local);
            ConNpgSqlDAL<Local>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            