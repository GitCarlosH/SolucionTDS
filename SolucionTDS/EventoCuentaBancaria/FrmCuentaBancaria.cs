using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionTDS.Evento
{
    public partial class FrmCuentaBancaria : Form


    {

        CuentaBancaria miCuentaBancaria = new CuentaBancaria();



        public FrmCuentaBancaria()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            miCuentaBancaria.Cliente = txtNombre.Text;
            miCuentaBancaria.Cuenta = txtCuenta.Text;
            miCuentaBancaria.Depositar(Convert.ToDouble(txtMonto.Text));

        }

        public void MetodoGestor(string strCliente, string strCuenta, double dblSaldo)
        {

            MessageBox.Show("Estimado(a) " + strCliente + ":\nSe le notifica que el saldo de su cuenta " + strCuenta + " se ha modificado.\nNuevo saldo: " + dblSaldo.ToString("C"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            miCuentaBancaria.Cliente = txtNombre.Text;
            miCuentaBancaria.Cuenta = txtCuenta.Text;
            miCuentaBancaria.Retirar(Convert.ToDouble(txtMonto.Text));
        }

        private void FrmCuentaBancaria_Load(object sender, EventArgs e)
        {
            miCuentaBancaria.CambioSaldo += MetodoGestor;
        }
    }
}
