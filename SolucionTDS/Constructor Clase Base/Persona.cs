using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.Constructor_Clase_Base
{
    public class Persona
    {
        private string _strNombre;
        private DateTime _dtmFechaNacimiento;
        public Persona(string strNombre, DateTime dtmFechaNacimiento)
        {
            _strNombre = strNombre;
            _dtmFechaNacimiento = dtmFechaNacimiento;
        }

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        public DateTime FechaNacimiento
        {
            get { return _dtmFechaNacimiento; }
            set { _dtmFechaNacimiento = value; }
        }

        public int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;
            TimeSpan calculo = fechaActual - _dtmFechaNacimiento;
            int Edad = (int)(calculo.Days / 365.25);
            return Edad;
        }
    }
}
