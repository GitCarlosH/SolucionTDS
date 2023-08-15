using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.UsoControlesVisuales
{
    class Empleado
    {
        private string _strNombre;
        private char _chrGrupo;
        private DateTime _dtmFechaNacimiento;
        private double _dblSueldo;
        private bool _blnSeguroVida;
        private bool _blnCapacitado;
        private string _strSexo;
        private string _strGradoMaximoEstudios;
        private int _intEdad;
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
        public char Grupo
        {
            get
            {
                return _chrGrupo;
            }
            set
            {
                _chrGrupo = value;
            }
        }
        public DateTime FechaNacimiento
        {
            get
            {
                return _dtmFechaNacimiento;
            }
            set
            {
                _dtmFechaNacimiento = value;
            }

        }
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
        public bool SeguroVida
        {
            get
            {
                return _blnSeguroVida;
            }
            set
            {
                _blnSeguroVida = value;
            }

        }
        public bool Capacitado
        {
            get
            {
                return _blnCapacitado;
            }
            set
            {
                _blnCapacitado = value;
            }

        }
        public string Sexo
        {
            get
            {
                return _strSexo;
            }
            set
            {
                _strSexo = value;
            }

        }
        public string GradoMaximoEstudios
        {
            get
            {
                return _strGradoMaximoEstudios;
            }
            set
            {
                _strGradoMaximoEstudios = value;
            }

        }
        public int Edad
        {
            get
            {
                return _intEdad;
            }
            set
            {
                _intEdad = value;
            }

        }



        public override string ToString()
        {
            return ("\nNombre: " + Nombre +
            "\nGrupo: " + Grupo +
            "\nFecha de nacimiento: " + FechaNacimiento.ToShortDateString() +
            "\nEdad: " + Edad.ToString() + " años" +
            "\nSueldo: " + Sueldo.ToString("C") +
            "\nSeguro de vida: " + (SeguroVida ? "Si" : "No") +
            "\nCapacitado: " + (Capacitado ? "Si" : "No") +
            "\nSexo: " + Sexo +
            "\nGrado maximo de estudios: " + GradoMaximoEstudios);
        }
    }
}




