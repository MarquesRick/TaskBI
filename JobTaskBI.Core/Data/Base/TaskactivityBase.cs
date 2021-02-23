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
    public class TaskactivityBase
    {
        #region Constructor
        public TaskactivityBase()
        {

        }
        #endregion

        #region Methods

        public IList<Taskactivity> Get(Taskactivity taskactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(taskactivity);
            IList<Taskactivity> response = ConNpgSqlDAL<Taskactivity>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Taskactivity> Get(Taskactivity taskactivity, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(taskactivity, paged, total, page_quantity, page_number);
            IList<Taskactivity> response = ConNpgSqlDAL<Taskactivity>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Taskactivity taskactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(taskactivity);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       
        public IList<Taskactivity> GetCombo(Taskactivity taskactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(taskactivity);
            IList<Taskactivity> response = ConNpgSqlDAL<Taskactivity>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Taskactivity taskactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(taskactivity);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Taskactivity taskactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(taskactivity);
            ConNpgSqlDAL<Taskactivity>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Taskactivity taskactivity)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(taskactivity);
            ConNpgSqlDAL<Taskactivity>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            