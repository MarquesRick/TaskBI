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
    public class ItemcategoryBase
    {
        #region Constructor
        public ItemcategoryBase()
        {

        }
        #endregion

        #region Methods

        public IList<Itemcategory> Get(Itemcategory itemcategory)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(itemcategory);
            IList<Itemcategory> response = ConNpgSqlDAL<Itemcategory>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Itemcategory> Get(Itemcategory itemcategory, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(itemcategory, paged, total, page_quantity, page_number);
            IList<Itemcategory> response = ConNpgSqlDAL<Itemcategory>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Itemcategory itemcategory)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(itemcategory);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

       

        public IList<Itemcategory> GetCombo(Itemcategory itemcategory)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(itemcategory);
            IList<Itemcategory> response = ConNpgSqlDAL<Itemcategory>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Itemcategory itemcategory)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(itemcategory);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Itemcategory itemcategory)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(itemcategory);
            ConNpgSqlDAL<Itemcategory>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Itemcategory itemcategory)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(itemcategory);
            ConNpgSqlDAL<Itemcategory>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            