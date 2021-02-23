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
    public class MediaBase
    {
        #region Constructor
        public MediaBase()
        {

        }
        #endregion

        #region Methods

        public IList<Media> Get(Media media)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(media);
            IList<Media> response = ConNpgSqlDAL<Media>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Media> Get(Media media, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(media, paged, total, page_quantity, page_number);
            IList<Media> response = ConNpgSqlDAL<Media>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Media media)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(media);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        

        public IList<Media> GetCombo(Media media)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(media);
            IList<Media> response = ConNpgSqlDAL<Media>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Media media)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(media);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Media media)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(media);
            ConNpgSqlDAL<Media>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Media media)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(media);
            ConNpgSqlDAL<Media>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            