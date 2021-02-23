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
    public class ActivitysectionBase
    {
        #region Constructor
        public ActivitysectionBase()
        {

        }
        #endregion

        #region Methods

        public IList<Activitysection> Get(Activitysection activitysection)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(activitysection);
            IList<Activitysection> response = ConNpgSqlDAL<Activitysection>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Activitysection> Get(Activitysection activitysection, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(activitysection, paged, total, page_quantity, page_number);
            IList<Activitysection> response = ConNpgSqlDAL<Activitysection>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Activitysection activitysection)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(activitysection);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }


        public IList<Activitysection> GetCombo(Activitysection activitysection)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(activitysection);
            IList<Activitysection> response = ConNpgSqlDAL<Activitysection>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Activitysection activitysection)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(activitysection);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Activitysection activitysection)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(activitysection);
            ConNpgSqlDAL<Activitysection>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Activitysection activitysection)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(activitysection);
            ConNpgSqlDAL<Activitysection>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            