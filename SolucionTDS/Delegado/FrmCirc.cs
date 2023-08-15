using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionTDS.Delegado
{
    public partial class FrmCirc : Form
    {
        public FrmCirc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Circunferencia miCircunferencia = new Circunferencia();
            try
            {
                miCircunferencia.Radio = double.Parse(txtRadio.Text);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
                txtRadio.Text = "";
                txtRadio.Focus();
                return;
            }
            if (radCalcularArea.Checked)
                MessageBox.Show("Área = " + miCircunferencia.Calcular(miCircunferencia.CalcularArea));
            if (radCalcularPerimetro.Checked)
                MessageBox.Show("Perímetro = " + miCircunferencia.Calcular(miCircunferencia.CalcularPerimetro));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
