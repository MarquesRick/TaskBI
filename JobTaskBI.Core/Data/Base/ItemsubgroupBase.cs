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
    public class ItemsubgroupBase
    {
        #region Constructor
        public ItemsubgroupBase()
        {

        }
        #endregion

        #region Methods

        public IList<Itemsubgroup> Get(Itemsubgroup itemsubgroup)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(itemsubgroup);
            IList<Itemsubgroup> response = ConNpgSqlDAL<Itemsubgroup>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Itemsubgroup> Get(Itemsubgroup itemsubgroup, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(itemsubgroup, paged, total, page_quantity, page_number);
            IList<Itemsubgroup> response = ConNpgSqlDAL<Itemsubgroup>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Itemsubgroup itemsubgroup)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(itemsubgroup);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       

        public IList<Itemsubgroup> GetCombo(Itemsubgroup itemsubgroup)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(itemsubgroup);
            IList<Itemsubgroup> response = ConNpgSqlDAL<Itemsubgroup>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Itemsubgroup itemsubgroup)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(itemsubgroup);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Itemsubgroup itemsubgroup)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(itemsubgroup);
            ConNpgSqlDAL<Itemsubgroup>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Itemsubgroup itemsubgroup)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(itemsubgroup);
            ConNpgSqlDAL<Itemsubgroup>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            