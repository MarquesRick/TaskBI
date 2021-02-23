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
    public class ItemgroupBase
    {
        #region Constructor
        public ItemgroupBase()
        {

        }
        #endregion

        #region Methods

        public IList<Itemgroup> Get(Itemgroup itemgroup)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(itemgroup);
            IList<Itemgroup> response = ConNpgSqlDAL<Itemgroup>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Itemgroup> Get(Itemgroup itemgroup, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(itemgroup, paged, total, page_quantity, page_number);
            IList<Itemgroup> response = ConNpgSqlDAL<Itemgroup>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Itemgroup itemgroup)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(itemgroup);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        
        public IList<Itemgroup> GetCombo(Itemgroup itemgroup)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(itemgroup);
            IList<Itemgroup> response = ConNpgSqlDAL<Itemgroup>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Itemgroup itemgroup)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(itemgroup);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Itemgroup itemgroup)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(itemgroup);
            ConNpgSqlDAL<Itemgroup>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Itemgroup itemgroup)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(itemgroup);
            ConNpgSqlDAL<Itemgroup>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            