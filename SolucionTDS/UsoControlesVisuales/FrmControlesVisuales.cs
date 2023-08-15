using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionTDS.UsoControlesVisuales
{
    public partial class FrmControlesVisuales : Form
    {
        
        public FrmControlesVisuales()
        {
            InitializeComponent();
        }

        private void FrmControlesVisuales_Load(object sender, EventArgs e)
        {

        }

        private void btnCapturar_Click(object sender, EventArgs e)
        {
            
            Empresa miEmpresa = new Empresa();
            Empleado miEmpleado = new Empleado();

            miEmpleado.Grupo = char.Parse(cboGrupo.Text);
            miEmpleado.Nombre = txtNombre.Text;
            
            miEmpleado.FechaNacimiento = dtmFechaNacimiento.Value;
            miEmpleado.Sueldo = double.Parse(txtSueldo.Text);
            miEmpleado.SeguroVida = chkSeguroVida.Checked;
            miEmpleado.Capacitado = chkCapacitado.Checked;
            miEmpleado.GradoMaximoEstudios = cboGradoMaximoEstudios.Text;
            if (radMasculino.Checked)
                miEmpleado.Sexo = radMasculino.Text;
            if (radFemenino.Checked)
                miEmpleado.Sexo = radFemenino.Text;
            
            // Insertar miEmpleado a miEmpresa
            
            miEmpresa.InsertarEmpleado(miEmpleado);
            
            foreach (Control x in GrDatEmp.Controls)
                if (x is TextBox)
                {
                    x.Text = "";
                }
            cboGradoMaximoEstudios.DataSource = null;
            cboGrupo.DataSource = null;

            DateTime fechaActual = DateTime.Today;
            int Edademp = fechaActual.Year - dtmFechaNacimiento.Value.Year;
            if (fechaActual < dtmFechaNacimiento.Value.AddYears(Edademp)) Edademp--;
            txtEdad.Text = Edademp.ToString();
            miEmpleado.Edad = Edademp;


            MessageBox.Show(miEmpleado.ToString(), "Datos del nuevo empleado");
            foreach (Empleado emp in miEmpresa)
            {
                dgEmpleados.Rows.Add(emp.Nombre,
                emp.Grupo, emp.FechaNacimiento, emp.Edad, emp.Sueldo, emp.SeguroVida, emp.Capacitado, emp.Sexo, emp.GradoMaximoEstudios );
            }



        }

        private void dtmFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

            


        }
    }
}
