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
    public class TeamtypeBase
    {
        #region Constructor
        public TeamtypeBase()
        {

        }
        #endregion

        #region Methods

        public IList<Teamtype> Get(Teamtype teamtype)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(teamtype);
            IList<Teamtype> response = ConNpgSqlDAL<Teamtype>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Teamtype> Get(Teamtype teamtype, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(teamtype, paged, total, page_quantity, page_number);
            IList<Teamtype> response = ConNpgSqlDAL<Teamtype>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Teamtype teamtype)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(teamtype);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       
        public IList<Teamtype> GetCombo(Teamtype teamtype)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(teamtype);
            IList<Teamtype> response = ConNpgSqlDAL<Teamtype>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Teamtype teamtype)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(teamtype);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Teamtype teamtype)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(teamtype);
            ConNpgSqlDAL<Teamtype>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Teamtype teamtype)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(teamtype);
            ConNpgSqlDAL<Teamtype>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            