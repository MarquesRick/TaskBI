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
    public class ActivitydefaultBase 
    {
        #region Constructor
        public ActivitydefaultBase()
        {

        }
        #endregion

        #region Methods

        public IList<Activitydefault> Get(Activitydefault activitydefault)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(activitydefault);
            IList<Activitydefault> response = ConNpgSqlDAL<Activitydefault>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Activitydefault> Get(Activitydefault activitydefault, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(activitydefault, paged, total, page_quantity, page_number);
            IList<Activitydefault> response = ConNpgSqlDAL<Activitydefault>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Activitydefault activitydefault)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(activitydefault);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }


        public IList<Activitydefault> GetCombo(Activitydefault activitydefault)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(activitydefault);
            IList<Activitydefault> response = ConNpgSqlDAL<Activitydefault>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Activitydefault activitydefault)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(activitydefault);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Activitydefault activitydefault)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(activitydefault);
            ConNpgSqlDAL<Activitydefault>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Activitydefault activitydefault)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(activitydefault);
            ConNpgSqlDAL<Activitydefault>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            