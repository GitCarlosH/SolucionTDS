using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.EmpleadoHorasExtras
{
    class EmpleadoSinHorasExtras: Empleado
    {
        public override double CalcularSalario()
        {
            return (base.CalcularSalario());
        }
    }
}
