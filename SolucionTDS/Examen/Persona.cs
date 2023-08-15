using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.Examen
{
    public class Persona
    {
        private string _strNombre;
        private string _strApellido;
        private int _intDni;
        private string _strDireccion;
        public Persona(string strNombre, string strApellido, int intDni, string strDireccion)
        {
            _strNombre = strNombre;
            _strApellido = strApellido;
            _intDni = intDni;
            _strDireccion = strDireccion;
        }
        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }
        public string Apellido
        {
            get { return _strApellido; }
            set { _strApellido = value; }
        }
        public int Dni
        {
            get { return _intDni; }
            set { _intDni = value; }
        }
        public string Direccion
        {
            get { return _strDireccion; }
            set { _strDireccion = value; }
        }



    }
}
