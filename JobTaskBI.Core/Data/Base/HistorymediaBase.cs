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
    public class HistorymediaBase
    {
        #region Constructor
        public HistorymediaBase()
        {

        }
        #endregion

        #region Methods

        public IList<Historymedia> Get(Historymedia historymedia)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(historymedia);
            IList<Historymedia> response = ConNpgSqlDAL<Historymedia>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Historymedia> Get(Historymedia historymedia, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(historymedia, paged, total, page_quantity, page_number);
            IList<Historymedia> response = ConNpgSqlDAL<Historymedia>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Historymedia historymedia)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(historymedia);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       

        public IList<Historymedia> GetCombo(Historymedia historymedia)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(historymedia);
            IList<Historymedia> response = ConNpgSqlDAL<Historymedia>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Historymedia historymedia)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(historymedia);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Historymedia historymedia)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(historymedia);
            ConNpgSqlDAL<Historymedia>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Historymedia historymedia)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(historymedia);
            ConNpgSqlDAL<Historymedia>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            