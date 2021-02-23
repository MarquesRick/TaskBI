using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Response
    {
        [_MapperTO("RESULTADO")]
        public int resultado { get; set; }

        [_MapperTO("TEXTO")]
        public string texto { get; set; }

        [_MapperTO("QTDREG")]
        public int qtdReg { get; set; }
    }
}
