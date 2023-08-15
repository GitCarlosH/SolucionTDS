using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.ComposicionAgregacion
{
    class Empleado
    {
        private int _intNumero;
        private string _strNombre;
        private double _dblSueldo;

        public Empleado()
        {
            _strNombre = "none";
            _intNumero = 0;
            _dblSueldo = 0;
        }
        public int Numero
        {
            get
            {
                return _intNumero;
            }
            set
            {
                _intNumero = value;
            }

        }
        public string Nombre
        {
            get
            {
                return _strNombre;
            }
            set
            {
                _strNombre = value;
            }
        }

        public double Sueldo
        {
            get
            {
                return _dblSueldo;
            }
            set
            {
                _dblSueldo = value;
            }
        }


    }
}
