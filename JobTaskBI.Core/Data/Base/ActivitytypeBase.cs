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
    public class ActivitytypeBase
    {
        #region Constructor
        public ActivitytypeBase()
        {

        }
        #endregion

        #region Methods

        public IList<Activitytype> Get(Activitytype activitytype)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(activitytype);
            IList<Activitytype> response = ConNpgSqlDAL<Activitytype>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Activitytype> Get(Activitytype activitytype, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(activitytype, paged, total, page_quantity, page_number);
            IList<Activitytype> response = ConNpgSqlDAL<Activitytype>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Activitytype activitytype)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(activitytype);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Activitytype> GetCombo(Activitytype activitytype)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(activitytype);
            IList<Activitytype> response = ConNpgSqlDAL<Activitytype>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Activitytype activitytype)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(activitytype);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Activitytype activitytype)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(activitytype);
            ConNpgSqlDAL<Activitytype>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Activitytype activitytype)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(activitytype);
            ConNpgSqlDAL<Activitytype>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            