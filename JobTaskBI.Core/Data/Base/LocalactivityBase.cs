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
    public class LocalactivityBase
    {
        #region Constructor
        public LocalactivityBase()
        {

        }
        #endregion

        #region Methods

        public IList<Localactivity> Get(Localactivity localactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(localactivity);
            IList<Localactivity> response = ConNpgSqlDAL<Localactivity>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Localactivity> Get(Localactivity localactivity, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(localactivity, paged, total, page_quantity, page_number);
            IList<Localactivity> response = ConNpgSqlDAL<Localactivity>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Localactivity localactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(localactivity);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       
        public IList<Localactivity> GetCombo(Localactivity localactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(localactivity);
            IList<Localactivity> response = ConNpgSqlDAL<Localactivity>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Localactivity localactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(localactivity);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Localactivity localactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(localactivity);
            ConNpgSqlDAL<Localactivity>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Localactivity localactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(localactivity);
            ConNpgSqlDAL<Localactivity>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            