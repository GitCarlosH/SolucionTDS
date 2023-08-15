using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.Constructor_Clase_Base
{
   public class Cliente : Persona
    {
        private double _dblLimiteCredito;
        public Cliente(string strNombre, DateTime dtmFechaNacimiento, double dblLimiteCredito) : base(strNombre, dtmFechaNacimiento)
        {
            _dblLimiteCredito = dblLimiteCredito;
        }
        public double LimiteCredito
        {
            get { return _dblLimiteCredito; }
            set { _dblLimiteCredito = value; }
        }

        public bool EsMayorEdad()
        {

            if (CalcularEdad() >= 18)
            { return true; }
            else { return false; }

            
        }

    }
}
