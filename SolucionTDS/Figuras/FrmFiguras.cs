using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionTDS.Figuras
{
    public partial class FrmFiguras : Form
    {
        Cuadrado miCuadrado = new Cuadrado();
        Circunferencia miCircunferencia = new Circunferencia();
        private double sumaArea;
        private double areaCuadrado;
        public double areaCircunferencia;
        public FrmFiguras()
        {
            InitializeComponent();
        }

        private void btnAgregarCirc_Click(object sender, EventArgs e)
        {
            miCircunferencia.Radio = Convert.ToDouble(txtRadio.Text);
            lstFiguras.Items.Add(miCircunferencia.Nombre);

        }

        private void btnAgregarCuad_Click(object sender, EventArgs e)
        {
            miCuadrado.Lado = Convert.ToDouble(txtLado.Text);
            lstFiguras.Items.Add(miCuadrado.Nombre);

        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {


            string s1 = lstFiguras.SelectedItem.ToString();
            string s2 = "Cuadrado";
            bool b = s1.Contains(s2);
            if (b is true)
            {
                MessageBox.Show(miCuadrado.ToString());
            }
            else
            {
                MessageBox.Show(miCircunferencia.ToString());
            }


        }

        private void btnMostrarDatosTodas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(miCuadrado.ToString()+"\n\n "+ miCircunferencia.ToString() );
        }

        private void btnSumarAreas_Click(object sender, EventArgs e)
        {
            sumaArea = miCuadrado.CalcularArea() + miCircunferencia.CalcularArea();
            MessageBox.Show("La suma de las áreas es: " + sumaArea);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstFiguras.DataSource = null;
            lstFiguras.Items.Clear();
            
            foreach (Control x in Circunferencia.Controls)
                if (x is TextBox)
                {
                    x.Text = "";
                }
            foreach (Control x in Cuadrado.Controls)
                if (x is TextBox)
                {
                    x.Text = "";
                }
            
        }
    }
}

