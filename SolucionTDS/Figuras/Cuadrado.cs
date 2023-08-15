using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.Figuras
{
    class Cuadrado : Figura
    {
        private double _dblLado;
        private string _strNombre;
        public string Nombre
        {
            get
            {
                _strNombre = "CuadradoLado" + (Convert.ToString(_dblLado));
                return _strNombre;
            }
            set
            {
                _strNombre = value;
            }
        }
        public double Lado
        {
            get
            {
                return _dblLado;
            }
            set
            {
                _dblLado = value;
            }
        }
        public override double CalcularArea()
        {
            double dblArea; //DEFINE UNA VARIABLE DENTRO DE LA ACCION
            dblArea = _dblLado * _dblLado;
            return dblArea;

        }
        public override string ConsultarDatos()
        {
            return ("Datos del Cuadrado :\n\n Lado: "
            + this.Lado + "\nArea: " + this.CalcularArea().ToString());

        }
        public override string ToString()
        {
            return this.ConsultarDatos();
        }

    }
}
