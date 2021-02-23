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
    public class CustomentityvalueBase
    {
        #region Constructor
        public CustomentityvalueBase()
        {

        }
        #endregion

        #region Methods

        public IList<Customentityvalue> Get(Customentityvalue customentityvalue)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(customentityvalue);
            IList<Customentityvalue> response = ConNpgSqlDAL<Customentityvalue>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Customentityvalue> Get(Customentityvalue customentityvalue, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(customentityvalue, paged, total, page_quantity, page_number);
            IList<Customentityvalue> response = ConNpgSqlDAL<Customentityvalue>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Customentityvalue customentityvalue)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(customentityvalue);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Customentityvalue> GetCombo(Customentityvalue customentityvalue)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(customentityvalue);
            IList<Customentityvalue> response = ConNpgSqlDAL<Customentityvalue>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Customentityvalue customentityvalue)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(customentityvalue);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Customentityvalue customentityvalue)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(customentityvalue);
            ConNpgSqlDAL<Customentityvalue>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Customentityvalue customentityvalue)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(customentityvalue);
            ConNpgSqlDAL<Customentityvalue>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            