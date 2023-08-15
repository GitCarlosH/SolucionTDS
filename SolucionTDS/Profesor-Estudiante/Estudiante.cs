using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.Profesor_Estudiante
{
    class Estudiante : Persona
    {
        private int _intCalificación;
        public int Calificación
        {
            get
            {
                return _intCalificación;
            }
            set
            {
                _intCalificación = value;
            }
        }
        
        public override string ToString()
        {
            return ("Datos del Estudiante:\n\nNombre: "
            + this.Nombre + "\nCalificacion: " + this.Calificación.ToString());
        }

        ~Estudiante()
        {
            
        }

    }
}
