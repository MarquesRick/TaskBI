using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Geocoordinate
    {
        [_MapperTO("GEO_ID")]
        public int geo_id { get; set; }

        [_MapperTO("AGE_ID")]
        public int age_id { get; set; }

        [_MapperTO("HTY_ID")]
        public int hty_id { get; set; }

        [_MapperTO("GEO_COLLECTEDDATEHOUR")]
        public int geo_collecteddatehour { get; set; }

        [_MapperTO("GEO_LATITUDE")]
        public float geo_latitude { get; set; }

        [_MapperTO("GEO_LONGITUDE")]
        public float geo_longitude { get; set; }

        [_MapperTO("GEO_OBSERVATION")]
        public string geo_observation { get; set; }

        [_MapperTO("GEO_PROVIDER")]
        public string geo_provider { get; set; }

        [_MapperTO("GEO_HASGPS")]
        public int geo_hasgps { get; set; }

        [_MapperTO("GEO_GPSENABLED")]
        public int geo_gpsenabled { get; set; }

        [_MapperTO("GEO_NETWORKENABLED")]
        public int geo_networkenabled { get; set; }

        [_MapperTO("GEO_LOCALLATITUDE")]
        public float geo_locallatitude { get; set; }

        [_MapperTO("GEO_LOCALLONGITUDE")]
        public float geo_locallongitude { get; set; }

        [_MapperTO("GEO_COORDINATESDISTANCE")]
        public int geo_coordinatesdistance { get; set; }

        [_MapperTO("GEO_COLLECTPRECISION")]
        public int geo_collectprecision { get; set; }

        [_MapperTO("GEO_DISTANCELASTCOORDINATE")]
        public int geo_distancelastcoordinate { get; set; }

        [_MapperTO("GEO_DISTANCELASTEXECUTION")]
        public int geo_distancelastexecution { get; set; }

        [_MapperTO("GEO_VALIDPRECISION")]
        public string geo_validprecision { get; set; }

    }
}
