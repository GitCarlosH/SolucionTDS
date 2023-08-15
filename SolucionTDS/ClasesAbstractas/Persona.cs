using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.Clases_Abstractas
{
    abstract class Persona
    {
        private string _strNombre;
        private string _strApellido;
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
        public abstract int Clave
        { get; set; }
        public abstract string ConsultarTodosLosDatos();
        public string ObtenerNombreCompleto()
        {
            return
            this.Nombre + " " + this.Apellido;
        }
    }

}
