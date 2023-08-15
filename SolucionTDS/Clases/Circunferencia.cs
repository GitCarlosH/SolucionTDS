using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.Clases
{
    class Circunferencia //CREAMOS LA CLASE CIRCUNFERENCIA
    {
        //...ATRIBUTOS...O ESTADO
        private double _dblRadio; //ESTABLECE ATRIBUTO DE LA CLASE 

        //...ACCIONES...

        public Circunferencia()
        {
            _dblRadio = 0; // INICIALIZA ATRIBUTO EN CERO
        }
        public Circunferencia(double dblRadio)
        {
            _dblRadio = dblRadio;
        }
        public void ModificarRadio(double dblR) //ENTRE PARENTESIS EL DATO QUE SE PIDE DESDE AFUERA
        {
            _dblRadio = dblR;

        }

        public double ConsultarRadio()
        {
            return _dblRadio;
        }

        public double CalcularArea()
        {
            double dblArea; //DEFINE UNA VARIABLE DENTRO DE LA ACCION
            dblArea = Math.PI * _dblRadio * _dblRadio;
            return dblArea;

        }
        public double CalcularPerimetro()
        {
            double dblPerimetro;
            dblPerimetro = Math.PI * _dblRadio * 2;
            return (dblPerimetro);
        }
        ~Circunferencia()
        { 
            System.Console.WriteLine("Se ha destruido el objeto");
        }
    }
}
