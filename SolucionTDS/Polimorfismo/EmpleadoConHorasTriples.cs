using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.EmpleadoHorasExtras
{
    class EmpleadoConHorasTriples: Empleado
    {
        public override double CalcularSalario()
        {
            if (HorasTrabajadas > 45)
            {
                int intHorasExtras = HorasTrabajadas - 40;
                double dblSueldoExtra = intHorasExtras * SueldoPorHora * 3;
                double dblSueldoNormal = 40 * SueldoPorHora;
                return (dblSueldoNormal + dblSueldoExtra);
            }
            else
            {
                return (base.CalcularSalario());
            }
        }
    }
}
