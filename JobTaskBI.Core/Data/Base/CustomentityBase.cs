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
    public class CustomentityBase
    {
        #region Constructor
        public CustomentityBase()
        {

        }
        #endregion

        #region Methods

        public IList<Customentity> Get(Customentity customentity)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(customentity);
            IList<Customentity> response = ConNpgSqlDAL<Customentity>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Customentity> Get(Customentity customentity, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(customentity, paged, total, page_quantity, page_number);
            IList<Customentity> response = ConNpgSqlDAL<Customentity>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Customentity customentity)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(customentity);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       
        public IList<Customentity> GetCombo(Customentity customentity)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(customentity);
            IList<Customentity> response = ConNpgSqlDAL<Customentity>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Customentity customentity)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(customentity);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Customentity customentity)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(customentity);
            ConNpgSqlDAL<Customentity>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Customentity customentity)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(customentity);
            ConNpgSqlDAL<Customentity>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            