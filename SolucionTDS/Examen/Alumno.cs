using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.Examen
{
    class Alumno : Persona
    {
        List<string> MateriasRendidas = new List<string>();
        private int _intLegajo;
        private string _strMail;
        private int _intTelefono;


        public Alumno(string strNombre, string strApellido, int intDni, string strDireccion, int intLegajo, string strMail, int intTelefono) : base(strNombre, strApellido, intDni, strDireccion)
        {
            _intLegajo = intLegajo;
            _strMail = strMail;
            _intTelefono = intTelefono;
        }

        public int Legajo
        {
            get { return _intLegajo; }
            set { _intLegajo = value; }
        }
        public string Mail
        {
            get { return _strMail; }
            set { _strMail = value; }
        }
        public int Telefono
        {
            get { return _intTelefono; }
            set { _intTelefono = value; }
        }

        public void AgregarMateriaRendida(string strMateria)
        {
            MateriasRendidas.Add(strMateria);
        }

        public string MateriaMalRendida(int NotaMateria)
        {
            if (NotaMateria < 6)
            {
                return "Rindio mal la materia";
            }
            else { return "La calificación ingresada es correcta"; }
        }




    }
}
