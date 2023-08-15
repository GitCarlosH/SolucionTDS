using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionTDS.Constructor_Clase_Base
{
    public partial class FrmEsMayorEdad : Form
    {


        public FrmEsMayorEdad()
        {
            InitializeComponent();
        }

        private void btnMayorEdad_Click(object sender, EventArgs e)
        {
            Cliente nuevoCliente = new Cliente(txtNombre.Text, dtpFechaNacimiento.Value, Convert.ToDouble(txtLimiteCredito.Text));
            if (nuevoCliente.EsMayorEdad() == true) { MessageBox.Show("La persona " + nuevoCliente.Nombre + " es mayor de edad y su límite de crédito es " + nuevoCliente.LimiteCredito, "TITULO"); }
            else { MessageBox.Show("La persona " + nuevoCliente.Nombre + " no es mayor de edad y por lo tanto no puede acceder a un crédito", "TITULO"); }
        }
    }
}
