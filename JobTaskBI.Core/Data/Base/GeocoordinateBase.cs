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
    public class GeocoordinateBase
    {
        #region Constructor
        public GeocoordinateBase()
        {

        }
        #endregion

        #region Methods

        public IList<Geocoordinate> Get(Geocoordinate geocoordinate)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(geocoordinate);
            IList<Geocoordinate> response = ConNpgSqlDAL<Geocoordinate>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Geocoordinate> Get(Geocoordinate geocoordinate, bool paged, int total, int page_quantity, int page_number)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetAll(geocoordinate, paged, total, page_quantity, page_number);
            IList<Geocoordinate> response = ConNpgSqlDAL<Geocoordinate>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> GetCount(Geocoordinate geocoordinate)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCount(geocoordinate);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        

        public IList<Geocoordinate> GetCombo(Geocoordinate geocoordinate)
        {
            string dbBase = DbBase.DbBase.GetInstance().GetCombo(geocoordinate);
            IList<Geocoordinate> response = ConNpgSqlDAL<Geocoordinate>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public IList<Response> Create(Geocoordinate geocoordinate)
        {
            string dbBase = DbBase.DbBase.GetInstance().Insert(geocoordinate);
            IList<Response> response = ConNpgSqlDAL<Response>.Instance.ExecuteSQL(dbBase);
            return response;
        }

        public void Update(Geocoordinate geocoordinate)
        {
            string dbBase = DbBase.DbBase.GetInstance().Update(geocoordinate);
            ConNpgSqlDAL<Geocoordinate>.Instance.ExecuteSQL(dbBase);
        }

        public void Delete(Geocoordinate geocoordinate)
        {
            string dbBase = DbBase.DbBase.GetInstance().Delete(geocoordinate);
            ConNpgSqlDAL<Geocoordinate>.Instance.ExecuteSQL(dbBase);
        }
		
        #endregion

    }
}
            