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
    public class LocalclassBase
    {
        #region Constructor
        public LocalclassBase()
        {

        }
        #endregion

        #region Methods

        public IList<Localclass> Get(Localclass localclass)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(localclass);
            IList<Localclass> response = ConNpgSqlDAL<Localclass>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Localclass> Get(Localclass localclass, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(localclass, paged, total, page_quantity, page_number);
            IList<Localclass> response = ConNpgSqlDAL<Localclass>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Localclass localclass)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(localclass);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       
        public IList<Localclass> GetCombo(Localclass localclass)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(localclass);
            IList<Localclass> response = ConNpgSqlDAL<Localclass>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Localclass localclass)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(localclass);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Localclass localclass)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(localclass);
            ConNpgSqlDAL<Localclass>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Localclass localclass)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(localclass);
            ConNpgSqlDAL<Localclass>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            