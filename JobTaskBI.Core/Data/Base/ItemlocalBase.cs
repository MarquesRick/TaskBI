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
    public class ItemlocalBase
    {
        #region Constructor
        public ItemlocalBase()
        {

        }
        #endregion

        #region Methods

        public IList<Itemlocal> Get(Itemlocal itemlocal)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(itemlocal);
            IList<Itemlocal> response = ConNpgSqlDAL<Itemlocal>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Itemlocal> Get(Itemlocal itemlocal, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(itemlocal, paged, total, page_quantity, page_number);
            IList<Itemlocal> response = ConNpgSqlDAL<Itemlocal>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Itemlocal itemlocal)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(itemlocal);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       
        public IList<Itemlocal> GetCombo(Itemlocal itemlocal)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(itemlocal);
            IList<Itemlocal> response = ConNpgSqlDAL<Itemlocal>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Itemlocal itemlocal)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(itemlocal);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Itemlocal itemlocal)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(itemlocal);
            ConNpgSqlDAL<Itemlocal>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Itemlocal itemlocal)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(itemlocal);
            ConNpgSqlDAL<Itemlocal>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            