using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionTDS.ComposicionAgregacion
{
    public partial class FrmCompAgreg : Form
    {
        List<Empleado> miEmpresa = new List<Empleado>();
        Empleado miEmpleado = new Empleado();
        public FrmCompAgreg()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumero.Text))
            {
                txtNumero.Text = "0";  
            }
            if (String.IsNullOrEmpty(txtSueldo.Text))
            {
                txtSueldo.Text = "0";
            }

            miEmpleado.Numero = Convert.ToInt32(txtNumero.Text);
            miEmpleado.Nombre = txtNombre.Text;
            miEmpleado.Sueldo = double.Parse(txtSueldo.Text);
            if  (!String.IsNullOrEmpty(txtNombre.Text))
            {
                miEmpresa.Add(miEmpleado);
            }
            
            dataGridView1.Rows.Clear();
            foreach (Empleado miEmp in miEmpresa)
            {
                dataGridView1.Rows.Add(miEmp.Numero,
                miEmp.Nombre, miEmp.Sueldo);
            }
            foreach (Control x in groupBox1.Controls)
                if (x is TextBox)
                {
                    x.Text = "";
                } 




        }

        private void listBox1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }
    }
}
