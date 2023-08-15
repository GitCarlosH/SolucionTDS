using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolucionTDS.SucursalEmpleado
{
    public partial class FrmSucursalEmpleado : Form
    {
        public FrmSucursalEmpleado()
        {
            InitializeComponent();
        }

        private void btnCapSuc_Click(object sender, EventArgs e) // capturar nueva sucursal
        {
            Sucursal nuevaSucursal = new Sucursal();
            nuevaSucursal.Nombre = txtNombreSucursal.Text;
            nuevaSucursal.Direccion = txtDireccionSucursal.Text;
            lstSucursales.Items.Add(nuevaSucursal);
            MessageBox.Show("Nueva sucursal capturada correctamente");
            foreach (Control x in groupBox1.Controls)
                if (x is TextBox)
                {
                    x.Text = "";
                }
        }

        private void btnCapEmp_Click(object sender, EventArgs e) // capturar nuevo empleado
        {
            Sucursal sucursalSeleccionada = new Sucursal();
            sucursalSeleccionada = (Sucursal)lstSucursales.SelectedItem;
            if (sucursalSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una sucursal de la lista");
                return;
            }
            Empleado nuevoEmpleado = new Empleado();
            nuevoEmpleado.Numero = int.Parse(txtNumeroEmpleado.Text);
            nuevoEmpleado.Nombre = txtNombreEmpleado.Text;
            nuevoEmpleado.Sueldo = double.Parse(txtSueldoEmpleado.Text);
            sucursalSeleccionada.InsertarEmpleado(nuevoEmpleado);
            dataGridView1.Rows.Clear();
            foreach (Empleado emp in sucursalSeleccionada)
            {
                dataGridView1.Rows.Add(emp.Numero, emp.Nombre, emp.Sueldo);
            }
            MessageBox.Show("Nuevo empleado insertado a la sucursal");
            foreach (Control x in groupBox2.Controls)
                if (x is TextBox)
                {
                    x.Text = "";
                }

        }

        private void lstSucursales_Click(object sender, EventArgs e) //al hacer click en el listbox
        {
            Sucursal sucursalSeleccionada = new Sucursal();
            sucursalSeleccionada = (Sucursal)lstSucursales.SelectedItem;
            txtNombreSucursal.Text = sucursalSeleccionada.Nombre.ToString();
            txtDireccionSucursal.Text = sucursalSeleccionada.Direccion.ToString();
            if (sucursalSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una sucursal de la lista");
                return;
            }
            dataGridView1.Rows.Clear();
            foreach (Empleado emp in sucursalSeleccionada)
            {
                dataGridView1.Rows.Add(emp.Numero, emp.Nombre, emp.Sueldo); 
            }


        }

        private void button1_Click(object sender, EventArgs e) // Contar empleados de la sucursal
        {
            Sucursal sucursalSeleccionada = new Sucursal();
            sucursalSeleccionada = (Sucursal)lstSucursales.SelectedItem;
            if (sucursalSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una sucursal de la lista");
                return;
            }
            MessageBox.Show("La sucursal " + sucursalSeleccionada.Nombre + " tiene " + sucursalSeleccionada.ContarEmpleados()+" empleados");

        }

        private void button2_Click(object sender, EventArgs e) // La suma de los sueldos de todos los empleados
        {
            double dblSumaSueldos = 0.0;
            foreach (Sucursal miSucursal in lstSucursales.Items)
                dblSumaSueldos += miSucursal.SumarSueldos();
            MessageBox.Show("La suma de los sueldos de todos los empleados es " + dblSumaSueldos.ToString("C"));
        }

        private void FrmSucursalEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void lstSucursales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMayorSueldo_Click(object sender, EventArgs e) // empleado mayor sueldo
        {
            Sucursal sucursalSeleccionada = new Sucursal();
            sucursalSeleccionada = (Sucursal)lstSucursales.SelectedItem;
            if (sucursalSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una sucursal de la lista");
                return;
            }
            sucursalSeleccionada.EmpleadoMayorSueldo();

            MessageBox.Show("El empleado con mayor sueldo es " + sucursalSeleccionada.strMayor);
        }
        public string strMayorSueldo;
        public double dblMayorSueldo = 0;
        private void btnMayorSueldoTodas_Click(object sender, EventArgs e) //Mayor sueldo de todas las sucursales
        {         
            foreach (Sucursal miSucursal in lstSucursales.Items)
            {
                miSucursal.EmpleadoMayorSueldo();
                if (miSucursal.dblMayor > dblMayorSueldo)
                {
                    dblMayorSueldo = miSucursal.dblMayor;
                    strMayorSueldo = miSucursal.strMayor;
                }
            }           
            MessageBox.Show("El empleado con mayor sueldo es " + strMayorSueldo);                
            
        }
        public string strSucMenSueldo;
        public double dblSumaSueldos = double.MaxValue;
        private void btnSucursalMenorSumaSueldos_Click(object sender, EventArgs e) // Sucursal con la menor suma de sueldos
        {
            foreach (Sucursal miSucursal in lstSucursales.Items)
            {
                if (miSucursal.ContarSueldos() < dblSumaSueldos)
                {
                    dblSumaSueldos = miSucursal.ContarSueldos();
                    strSucMenSueldo = miSucursal.Nombre;
                }
            }
            MessageBox.Show("La sucursal con la menor suma de sueldos es " + strSucMenSueldo);
            dblSumaSueldos = double.MaxValue;
        }

        public int intSumaEmpleados = int.MaxValue;
        public string strSucMenEmp;
        private void button3_Click(object sender, EventArgs e) // Sucursal con la menor cantidad de empleados
        {
            foreach (Sucursal miSucursal in lstSucursales.Items)
            {
                if (miSucursal.ContarEmpleados() < intSumaEmpleados)
                {
                    intSumaEmpleados = miSucursal.ContarEmpleados();
                    strSucMenEmp = miSucursal.Nombre;
                }
            }
            MessageBox.Show("La sucursal con la menor cantidad de empleados " + strSucMenEmp);
            intSumaEmpleados = int.MaxValue;
        }

        public double dblSumaSueldosSucursales = 0;
        public int intSumaEmpleadosSucursales = 0;
        public double dblPromedio;

        private void btnPromSueldoEmpSucursales_Click(object sender, EventArgs e)
        {
            foreach (Sucursal miSucursal in lstSucursales.Items)
            {             
                dblSumaSueldosSucursales += miSucursal.ContarSueldos();
                intSumaEmpleadosSucursales += miSucursal.ContarEmpleados();
            }
            dblPromedio = dblSumaSueldosSucursales / intSumaEmpleadosSucursales;
            MessageBox.Show("El promedio de los sueldos de los empleados es " + dblPromedio);
            dblPromedio = 0;
            dblSumaSueldosSucursales = 0;
            intSumaEmpleadosSucursales = 0;
        }
        public int intSumaDeSucursales = 0;
        public double dblPromedioEmpleadosPorSucursal;
        private void btnPromEmpSucursal_Click(object sender, EventArgs e) // Promedio Empleados por Sucursal
        {
            foreach (Sucursal miSucursal in lstSucursales.Items)
            {
                intSumaDeSucursales += 1;
                intSumaEmpleadosSucursales+=miSucursal.ContarEmpleados();  
            }
            dblPromedioEmpleadosPorSucursal = intSumaEmpleadosSucursales / intSumaDeSucursales;
            MessageBox.Show("El promedio de empleados por sucursal es " + dblPromedioEmpleadosPorSucursal);
            dblPromedioEmpleadosPorSucursal = 0;
            intSumaDeSucursales = 0;
            intSumaEmpleadosSucursales = 0;
        }
    }
}
