using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.Clases_Abstractas
{
    class Cliente : Persona
    {
        private int _intClaveCliente;
        public override int Clave
        {
            get { return _intClaveCliente; }
            set { _intClaveCliente = value; }
        }
        public override string ConsultarTodosLosDatos()
        {
            return "******Datos del Cliente: \n" + this.Clave + " " +
            this.Nombre + " " + this.Apellido;
        }
    }

}
