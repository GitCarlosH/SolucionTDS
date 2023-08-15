using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.Interfaces
{
    class Mayusculas : ITest
    {
        public string HolaMundo()
        {
            return ("YO HAGO LO QUE QUIERO");
        }

        public string DevolverCadena(string s)
        {
            return s.ToUpper();
        }

    }
}
