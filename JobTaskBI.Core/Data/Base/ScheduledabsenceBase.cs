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
    public class ScheduledabsenceBase
    {
        #region Constructor
        public ScheduledabsenceBase()
        {

        }
        #endregion

        #region Methods

        public IList<Scheduledabsence> Get(Scheduledabsence scheduledabsence)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(scheduledabsence);
            IList<Scheduledabsence> response = ConNpgSqlDAL<Scheduledabsence>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Scheduledabsence> Get(Scheduledabsence scheduledabsence, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(scheduledabsence, paged, total, page_quantity, page_number);
            IList<Scheduledabsence> response = ConNpgSqlDAL<Scheduledabsence>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Scheduledabsence scheduledabsence)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(scheduledabsence);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       

        public IList<Scheduledabsence> GetCombo(Scheduledabsence scheduledabsence)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(scheduledabsence);
            IList<Scheduledabsence> response = ConNpgSqlDAL<Scheduledabsence>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Scheduledabsence scheduledabsence)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(scheduledabsence);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Scheduledabsence scheduledabsence)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(scheduledabsence);
            ConNpgSqlDAL<Scheduledabsence>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Scheduledabsence scheduledabsence)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(scheduledabsence);
            ConNpgSqlDAL<Scheduledabsence>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            