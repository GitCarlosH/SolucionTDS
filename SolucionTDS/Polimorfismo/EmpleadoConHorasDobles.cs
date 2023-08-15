using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.EmpleadoHorasExtras
{
    class EmpleadoConHorasDobles: Empleado
    {
        public override double CalcularSalario()
        {
            if (HorasTrabajadas >= 41 & HorasTrabajadas <= 45)
            {
                int intHorasExtras = HorasTrabajadas - 40;
                double dblSueldoExtra = intHorasExtras * SueldoPorHora * 2;
                double dblSueldoNormal = 40 * SueldoPorHora;
                return (dblSueldoNormal + dblSueldoExtra);
            }
            else
            {
                return base.CalcularSalario();
            }
        }
    }
}
