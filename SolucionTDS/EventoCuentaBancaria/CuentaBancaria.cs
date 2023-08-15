using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolucionTDS.Evento
{
    class CuentaBancaria


    {
        private string _strCuenta;
        private string _strCliente;
        private double _dblSaldo;

        public CuentaBancaria()
        { }
        public string Cuenta
        {
            get
            {

                return _strCuenta;
            }
            set
            {
                _strCuenta = value;
            }
        }
        public string Cliente
        {
            get
            {

                return _strCliente;
            }
            set
            {
                _strCliente = value;
            }
        }

        private double Saldo
        {
            get
            {

                return _dblSaldo;
            }
            set
            {
                _dblSaldo = value;
            }
        }

        public void Depositar(double dblCantidad)
        {
            if (dblCantidad > 0)
            {
                // Incrementa el saldo
                Saldo = Saldo + dblCantidad;
                // Genera el evento
                CambioSaldo(this.Cliente, this.Cuenta, this.Saldo);
            }
            else
                throw new Exception("Cantidad inválida !!!");
        }

    
    public void Retirar(double dblCantidad)
        {
            if (this.Saldo >= dblCantidad)
            {
                // Reduce el saldo
                Saldo = Saldo - dblCantidad;
                // Genera el evento
                CambioSaldo(this.Cliente, this.Cuenta, this.Saldo);
            }
            else
                throw new Exception("Saldo insuficiente !!!");
        }

        public delegate void CambiarSaldoEventHandler(string strCliente, string strCuenta, double dblSaldo);

        public event CambiarSaldoEventHandler CambioSaldo;



    }
}
