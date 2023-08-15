using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS
{
	class Rectangulo
	{
		//...ATRIBUTOS...los atributos se declaran en privado y con un "_" adelante
		private double _dblLado1, _dblLado2;

		//...ACCIONES...
		public void ModificarLado1(double dblL1)
		{
			_dblLado1 = dblL1;

		}

		public void ModificarLado2(double dblL2)
		{
			_dblLado2 = dblL2;
		}
				
		public double ConsultarLado1()
		{
			return (_dblLado1);
		
		}
		public double ConsultarLado2()
		{
			return (_dblLado2);

		}

		public double CalcularPerimetro()
		{
			double dblPerimetro;
			dblPerimetro = _dblLado1 * 2 + _dblLado2 * 2;
			return dblPerimetro;
		}

		public double CalcularArea()
		{
			double dblArea;
			dblArea = _dblLado1 * _dblLado2;
			return dblArea;
		}
	}
}
