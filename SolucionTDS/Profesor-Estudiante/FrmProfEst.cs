using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionTDS.Profesor_Estudiante
{
    public partial class FrmProfEst : Form
    {

        Estudiante objestudiante = new Estudiante();
        Profesor objprofesor = new Profesor();

        public FrmProfEst()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radProfesor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCapturarDatos_Click(object sender, EventArgs e)
        {
            if (radProfesor.Checked)
            {
                objprofesor.Nombre = txtNombre.Text;
                objprofesor.Sueldo = Convert.ToDouble(txtSueldo.Text);
            }

            if (radEstudiante.Checked)
            {
                
                objestudiante.Nombre = txtNombre.Text;
                objestudiante.Calificación = Convert.ToInt32(txtCalificacion.Text);
            }
            
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            if (radProfesor.Checked)
                MessageBox.Show(objprofesor.ToString());
            if (radEstudiante.Checked)
                MessageBox.Show(objestudiante.ToString());
        }

        private void btnLimpDeDatos_Click(object sender, EventArgs e)
        {
            objestudiante = null;
            objprofesor = null;
            MessageBox.Show("Se han destuido los objetos");
            //foreach (Control x in grbDatos)
            //if x is textbox
            //textbox=""
            txtNombre.Text = "";
            txtSueldo.Text = "";
            txtCalificacion.Text = "";
        }
    }
}
