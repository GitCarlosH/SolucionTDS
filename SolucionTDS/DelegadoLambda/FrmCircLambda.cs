using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionTDS.DelegadoLambda
{
    public partial class FrmCircLambda : Form
    {
        public FrmCircLambda()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Circunferencia miCircunferencia = new Circunferencia();
            try
            {
                miCircunferencia.Radio = double.Parse(txtRadio.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                txtRadio.Clear();
                txtRadio.Focus();
            }
            if (radCalcularArea.Checked)
            {
                double dblArea = miCircunferencia.Calcular(() => Math.PI * Math.Pow(miCircunferencia.Radio, 2));
                MessageBox.Show("Área = " + dblArea);
                
            }
            if (radCalcularPerimetro.Checked)
            {
                double dblPerimetro = miCircunferencia.Calcular(() => Math.PI * miCircunferencia.Radio * 2);
                MessageBox.Show("Perímetro = " + dblPerimetro);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtRadio_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblRadio_Click(object sender, EventArgs e)
        {

        }
    }
}
