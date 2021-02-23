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
    public class LocalrouteBase
    {
        #region Constructor
        public LocalrouteBase()
        {

        }
        #endregion

        #region Methods

        public IList<Localroute> Get(Localroute localroute)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(localroute);
            IList<Localroute> response = ConNpgSqlDAL<Localroute>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Localroute> Get(Localroute localroute, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(localroute, paged, total, page_quantity, page_number);
            IList<Localroute> response = ConNpgSqlDAL<Localroute>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Localroute localroute)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(localroute);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

      

        public IList<Localroute> GetCombo(Localroute localroute)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(localroute);
            IList<Localroute> response = ConNpgSqlDAL<Localroute>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Localroute localroute)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(localroute);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Localroute localroute)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(localroute);
            ConNpgSqlDAL<Localroute>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Localroute localroute)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(localroute);
            ConNpgSqlDAL<Localroute>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            