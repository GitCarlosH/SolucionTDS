using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.Examen
{
    class Carrera
    {
        List<string> MateriasCarrera = new List<string>();

        private string _strDescripcion;
        private string _strPlanDecreto;

        public Carrera(string strDescripcion, string strPlanDecreto)
        {
            _strDescripcion = strDescripcion;
            _strPlanDecreto = strPlanDecreto;
        }

        public void AgregarMateriaCarrera(string strMateria)
        {
            MateriasCarrera.Add(strMateria);
        }

    }
}
