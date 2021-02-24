using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Model
{
    public class Api
    {
        [_MapperTO("ID")]
        public int id { get; set; }

        [_MapperTO("NOME")]
        public string nome { get; set; }

        [_MapperTO("EMAIL")]
        public string email { get; set; }

        [_MapperTO("SENHA")]
        public string senha { get; set; }

        [_MapperTO("CREATEDAT")]
        public DateTime createdat { get; set; }

        [_MapperTO("UPDATEDAT")]
        public DateTime updatedat { get; set; }




    }
}
