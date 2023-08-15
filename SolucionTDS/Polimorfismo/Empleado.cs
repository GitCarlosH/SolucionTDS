using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.EmpleadoHorasExtras
{
    class Empleado
    {
        // polimorfismo de sobreescritura   
        private int _intHorasTrabajadas;
        private double _dblSueldoPorHora;
        public int HorasTrabajadas
        {
            get
            {
                return _intHorasTrabajadas;
            }
            set
            {
                _intHorasTrabajadas = value;
            }
        }
        public double SueldoPorHora
        {
            get
            {
                return _dblSueldoPorHora;
            }
            set
            {
                _dblSueldoPorHora = value;
            }
        }
        public virtual double CalcularSalario()
        {
            return (HorasTrabajadas * SueldoPorHora);
        }
        
    }
}
