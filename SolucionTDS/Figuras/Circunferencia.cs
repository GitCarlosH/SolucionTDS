using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.Figuras
{
    class Circunferencia : Figura
    {
        private double _dblRadio;
        private string _strNombre;
        public string Nombre
        {
            get
            {
                _strNombre = "CircunferenciaRadio" + (Convert.ToString(_dblRadio));
                return _strNombre;
            }
            set
            {
                _strNombre = value;
            }
        }
        public double Radio
        {
            get
            {
                return _dblRadio;
            }
            set
            {
                _dblRadio = value;
            }
        }
        public override double CalcularArea()
        {
            double dblArea; //DEFINE UNA VARIABLE DENTRO DE LA ACCION
            dblArea = Math.PI * _dblRadio * _dblRadio;
            return dblArea;

        }
        public override string ConsultarDatos()
        {
            return ("Datos de la Circunferencia :\n\n Radio: "
            + this.Radio + "\nArea: " + this.CalcularArea().ToString());

        }
        public override string ToString()
        {
            return this.ConsultarDatos();
        }

    }
}
