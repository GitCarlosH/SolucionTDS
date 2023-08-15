using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.Profesor_Estudiante
{
    class Persona
    {
        private string _strNombre;

        public Persona()
        {
            _strNombre = "No ingresó nombre";
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
        public string Asistir;
        
        
    }
}
