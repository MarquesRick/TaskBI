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
    public class TaskdailymetricsBase
    {
        #region Constructor
        public TaskdailymetricsBase()
        {

        }
        #endregion

        #region Methods

        public IList<Taskdailymetrics> Get(Taskdailymetrics taskdailymetrics)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(taskdailymetrics);
            IList<Taskdailymetrics> response = ConNpgSqlDAL<Taskdailymetrics>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Taskdailymetrics> Get(Taskdailymetrics taskdailymetrics, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(taskdailymetrics, paged, total, page_quantity, page_number);
            IList<Taskdailymetrics> response = ConNpgSqlDAL<Taskdailymetrics>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Taskdailymetrics taskdailymetrics)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(taskdailymetrics);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       

        public IList<Taskdailymetrics> GetCombo(Taskdailymetrics taskdailymetrics)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(taskdailymetrics);
            IList<Taskdailymetrics> response = ConNpgSqlDAL<Taskdailymetrics>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Taskdailymetrics taskdailymetrics)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(taskdailymetrics);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Taskdailymetrics taskdailymetrics)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(taskdailymetrics);
            ConNpgSqlDAL<Taskdailymetrics>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Taskdailymetrics taskdailymetrics)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(taskdailymetrics);
            ConNpgSqlDAL<Taskdailymetrics>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            