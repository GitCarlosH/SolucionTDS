using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.DelegadoLambda
{
    class Circunferencia
    {
        private double _dblRadio;
        public double Radio
        {
            get { return _dblRadio; }
            set { _dblRadio = value; }
        }
        // Delegado
        public delegate double Operacion();
        // Método que recibe como parámetro el código a ejecutar enviado a través de una expresión lambda
        public double Calcular(Operacion miOperacion)
        {
            return miOperacion();
        }

    }
}
