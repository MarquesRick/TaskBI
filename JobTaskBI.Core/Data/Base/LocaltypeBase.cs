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
    public class LocaltypeBase
    {
        #region Constructor
        public LocaltypeBase()
        {

        }
        #endregion

        #region Methods

        public IList<Localtype> Get(Localtype localtype)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(localtype);
            IList<Localtype> response = ConNpgSqlDAL<Localtype>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Localtype> Get(Localtype localtype, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(localtype, paged, total, page_quantity, page_number);
            IList<Localtype> response = ConNpgSqlDAL<Localtype>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Localtype localtype)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(localtype);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        

        public IList<Localtype> GetCombo(Localtype localtype)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(localtype);
            IList<Localtype> response = ConNpgSqlDAL<Localtype>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Localtype localtype)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(localtype);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Localtype localtype)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(localtype);
            ConNpgSqlDAL<Localtype>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Localtype localtype)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(localtype);
            ConNpgSqlDAL<Localtype>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            