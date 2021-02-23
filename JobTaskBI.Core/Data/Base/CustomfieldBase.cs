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
    public class CustomfieldBase
    {
        #region Constructor
        public CustomfieldBase()
        {

        }
        #endregion

        #region Methods

        public IList<Customfield> Get(Customfield customfield)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(customfield);
            IList<Customfield> response = ConNpgSqlDAL<Customfield>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Customfield> Get(Customfield customfield, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(customfield, paged, total, page_quantity, page_number);
            IList<Customfield> response = ConNpgSqlDAL<Customfield>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Customfield customfield)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(customfield);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       
        public IList<Customfield> GetCombo(Customfield customfield)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(customfield);
            IList<Customfield> response = ConNpgSqlDAL<Customfield>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Customfield customfield)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(customfield);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Customfield customfield)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(customfield);
            ConNpgSqlDAL<Customfield>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Customfield customfield)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(customfield);
            ConNpgSqlDAL<Customfield>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            