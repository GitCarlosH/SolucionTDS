using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.UsoControlesVisuales
{
    class Empresa
    {
        private List<Empleado> miEmpresa = new List<Empleado>();

        public void InsertarEmpleado(Empleado miEmpleado)
        {
            miEmpresa.Add(miEmpleado);
        }

        ~Empresa()
        {
            miEmpresa.Clear();
        }
        public IEnumerator<Empleado> GetEnumerator()
        {
            foreach (Empleado e in miEmpresa)
                yield return e;
        }
    }
}
