using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.Profesor_Estudiante
{
    class Profesor : Persona
    {
        private double _dblSueldo;
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
        public string Enseñar;
        public override string ToString()
        {
            return ("Datos del Profesor:\n\nNombre: "
            + this.Nombre + "\nSueldo: " + this.Sueldo.ToString());
        }
        ~Profesor()
        {
            System.Console.WriteLine("Se ha destruido el Profesor ");
        }
    }
}
