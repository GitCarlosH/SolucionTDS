using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionTDS.EmpleadoHorasExtras
{
    public partial class FrmEmpHorExt : Form
    {

        public FrmEmpHorExt()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtHoras.Text) < 40)
            {
                EmpleadoSinHorasExtras miEmpleado = new EmpleadoSinHorasExtras();
                miEmpleado.HorasTrabajadas = Convert.ToInt32(txtHoras.Text);
                miEmpleado.SueldoPorHora = Convert.ToInt32(txtSueldo.Text);
                txtSalarioFinal.Text = Convert.ToString(miEmpleado.CalcularSalario());
            }
            else if (int.Parse(txtHoras.Text) >= 41 & int.Parse(txtHoras.Text) <= 45)
            {
                EmpleadoConHorasDobles miEmpleado = new EmpleadoConHorasDobles();
                miEmpleado.HorasTrabajadas = Convert.ToInt32(txtHoras.Text);
                miEmpleado.SueldoPorHora = Convert.ToInt32(txtSueldo.Text);
                txtSalarioFinal.Text = Convert.ToString(miEmpleado.CalcularSalario());
            }
            else
            {
                EmpleadoConHorasTriples miEmpleado = new EmpleadoConHorasTriples();
                miEmpleado.HorasTrabajadas = Convert.ToInt32(txtHoras.Text);
                miEmpleado.SueldoPorHora = Convert.ToInt32(txtSueldo.Text);
                txtSalarioFinal.Text = Convert.ToString(miEmpleado.CalcularSalario());
            }
        }
    }
}
