using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.SucursalEmpleado
{
    public class Sucursal
    {
        private string _strNombre;
        private string _strDireccion;
        private List<Empleado> listaEmpleados = new List<Empleado>();

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
        public string Direccion
        {
            get
            {
                return _strDireccion;
            }
            set
            {
                _strDireccion = value;
            }
        }
        public void InsertarEmpleado(Empleado nuevoempleado)
        {

            listaEmpleados.Add(nuevoempleado);
        }
        ~Sucursal()
        {
            listaEmpleados.Clear();
        }
        public IEnumerator<Empleado> GetEnumerator()
        {
            foreach (Empleado e in listaEmpleados)
                yield return e;
        }
        public override string ToString()
        {
            return this.Nombre;
        }
        public int ContarEmpleados()
        {
            return listaEmpleados.Count;
        }
        public double SumarSueldos()
        {
            double dblSuma = 0.0;
            foreach (Empleado miEmpleado in listaEmpleados)
                dblSuma += miEmpleado.Sueldo;
            return dblSuma;

        }
        public string strMayor;
        public double dblMayor = 0;
        public void EmpleadoMayorSueldo()
        {
            foreach (Empleado miEmpleado in listaEmpleados)
            {
                if (miEmpleado.Sueldo > dblMayor)
                {
                    dblMayor = miEmpleado.Sueldo;
                    strMayor = miEmpleado.Nombre;
                }               
            }           
        }

        public double ContarSueldos()
        {
            double dblSumaSueldos = 0;
            foreach (Empleado miEmpleado in listaEmpleados)
            {
                dblSumaSueldos += miEmpleado.Sueldo;
            }
            return dblSumaSueldos;
        }



    }
}
