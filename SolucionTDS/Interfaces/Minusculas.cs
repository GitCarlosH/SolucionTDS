using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.Interfaces
{
    public class Minusculas : ITest
    {
        public string HolaMundo()
        {
            return ("jose de san martin");
        }
        public string DevolverCadena(string s)
        {
            return s.ToLower();
        }
    }
}
