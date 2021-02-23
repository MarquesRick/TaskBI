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
    public class ItemBase
    {
        #region Constructor
        public ItemBase()
        {

        }
        #endregion

        #region Methods

        public IList<Item> Get(Item item)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(item);
            IList<Item> response = ConNpgSqlDAL<Item>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Item> Get(Item item, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(item, paged, total, page_quantity, page_number);
            IList<Item> response = ConNpgSqlDAL<Item>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Item item)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(item);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       

        public IList<Item> GetCombo(Item item)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(item);
            IList<Item> response = ConNpgSqlDAL<Item>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Item item)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(item);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Item item)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(item);
            ConNpgSqlDAL<Item>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Item item)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(item);
            ConNpgSqlDAL<Item>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            