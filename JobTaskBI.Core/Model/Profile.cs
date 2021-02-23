using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Profile
    {
        [_MapperTO("ID_PROFILE")]
        public int id_profile { get; set; }

        [_MapperTO("PROFILE_NAME")]
        public string profile_name { get; set; }

        [_MapperTO("ACTIVE")]
        public string active { get; set; }
    }
}