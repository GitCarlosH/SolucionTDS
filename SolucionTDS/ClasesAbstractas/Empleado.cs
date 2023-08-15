using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.Clases_Abstractas
{
    class Empleado : Persona
    {
        private int _intClaveEmpleado;
        public override int Clave
        {
            get { return _intClaveEmpleado; }
            set { _intClaveEmpleado = value; }
        }
        public override string ConsultarTodosLosDatos()
        {
            return "------Datos del Empleado: \n" + this.Clave + " " +
            this.Nombre + " " + this.Apellido;
        }

    }
}
