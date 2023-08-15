
namespace SolucionTDS.SucursalEmpleado
{
    partial class FrmSucursalEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCapSuc = new System.Windows.Forms.Button();
            this.txtDireccionSucursal = new System.Windows.Forms.TextBox();
            this.txtNombreSucursal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCapEmp = new System.Windows.Forms.Button();
            this.txtSueldoEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtNumeroEmpleado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstSucursales = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMayorSueldo = new System.Windows.Forms.Button();
            this.btnMayorSueldoTodas = new System.Windows.Forms.Button();
            this.btnSucursalMenorSumaSueldos = new System.Windows.Forms.Button();
            this.btnSucMenorCantEmpleados = new System.Windows.Forms.Button();
            this.btnPromSueldoEmpSucursales = new System.Windows.Forms.Button();
            this.btnPromEmpSucursal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCapSuc);
            this.groupBox1.Controls.Add(this.txtDireccionSucursal);
            this.groupBox1.Controls.Add(this.txtNombreSucursal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la sucursal";
            // 
            // btnCapSuc
            // 
            this.btnCapSuc.Location = new System.Drawing.Point(82, 127);
            this.btnCapSuc.Name = "btnCapSuc";
            this.btnCapSuc.Size = new System.Drawing.Size(225, 31);
            this.btnCapSuc.TabIndex = 4;
            this.btnCapSuc.Text = "Capturar sucursal";
            this.btnCapSuc.UseVisualStyleBackColor = true;
            this.btnCapSuc.Click += new System.EventHandler(this.btnCapSuc_Click);
            // 
            // txtDireccionSucursal
            // 
            this.txtDireccionSucursal.Location = new System.Drawing.Point(137, 74);
            this.txtDireccionSucursal.Name = "txtDireccionSucursal";
            this.txtDireccionSucursal.Size = new System.Drawing.Size(215, 22);
            this.txtDireccionSucursal.TabIndex = 3;
            // 
            // txtNombreSucursal
            // 
            this.txtNombreSucursal.Location = new System.Drawing.Point(137, 38);
            this.txtNombreSucursal.Name = "txtNombreSucursal";
            this.txtNombreSucursal.Size = new System.Drawing.Size(215, 22);
            this.txtNombreSucursal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCapEmp);
            this.groupBox2.Controls.Add(this.txtSueldoEmpleado);
            this.groupBox2.Controls.Add(this.txtNombreEmpleado);
            this.groupBox2.Controls.Add(this.txtNumeroEmpleado);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(31, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del empleado";
            // 
            // btnCapEmp
            // 
            this.btnCapEmp.Location = new System.Drawing.Point(82, 149);
            this.btnCapEmp.Name = "btnCapEmp";
            this.btnCapEmp.Size = new System.Drawing.Size(225, 31);
            this.btnCapEmp.TabIndex = 5;
            this.btnCapEmp.Text = "Capturar empleado";
            this.btnCapEmp.UseVisualStyleBackColor = true;
            this.btnCapEmp.Click += new System.EventHandler(this.btnCapEmp_Click);
            // 
            // txtSueldoEmpleado
            // 
            this.txtSueldoEmpleado.Location = new System.Drawing.Point(116, 110);
            this.txtSueldoEmpleado.Name = "txtSueldoEmpleado";
            this.txtSueldoEmpleado.Size = new System.Drawing.Size(92, 22);
            this.txtSueldoEmpleado.TabIndex = 9;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(116, 78);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(236, 22);
            this.txtNombreEmpleado.TabIndex = 8;
            // 
            // txtNumeroEmpleado
            // 
            this.txtNumeroEmpleado.Location = new System.Drawing.Point(116, 41);
            this.txtNumeroEmpleado.Name = "txtNumeroEmpleado";
            this.txtNumeroEmpleado.Size = new System.Drawing.Size(92, 22);
            this.txtNumeroEmpleado.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sueldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número";
            // 
            // lstSucursales
            // 
            this.lstSucursales.FormattingEnabled = true;
            this.lstSucursales.ItemHeight = 16;
            this.lstSucursales.Location = new System.Drawing.Point(509, 48);
            this.lstSucursales.Name = "lstSucursales";
            this.lstSucursales.Size = new System.Drawing.Size(298, 164);
            this.lstSucursales.TabIndex = 2;
            this.lstSucursales.Click += new System.EventHandler(this.lstSucursales_Click);
            this.lstSucursales.SelectedIndexChanged += new System.EventHandler(this.lstSucursales_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sucursales del Grupo Corporativo Empresarial";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Nombre,
            this.Sueldo});
            this.dataGridView1.Location = new System.Drawing.Point(31, 458);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(463, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.MinimumWidth = 6;
            this.Sueldo.Name = "Sueldo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(509, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(298, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Contar empleados de la sucursal seleccionada";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(298, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sumar sueldos de la sucursal seleccionada";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMayorSueldo
            // 
            this.btnMayorSueldo.Location = new System.Drawing.Point(509, 324);
            this.btnMayorSueldo.Name = "btnMayorSueldo";
            this.btnMayorSueldo.Size = new System.Drawing.Size(298, 41);
            this.btnMayorSueldo.TabIndex = 7;
            this.btnMayorSueldo.Text = "Empleado Mayor Sueldo Sucursal";
            this.btnMayorSueldo.UseVisualStyleBackColor = true;
            this.btnMayorSueldo.Click += new System.EventHandler(this.btnMayorSueldo_Click);
            // 
            // btnMayorSueldoTodas
            // 
            this.btnMayorSueldoTodas.Location = new System.Drawing.Point(509, 377);
            this.btnMayorSueldoTodas.Name = "btnMayorSueldoTodas";
            this.btnMayorSueldoTodas.Size = new System.Drawing.Size(298, 41);
            this.btnMayorSueldoTodas.TabIndex = 8;
            this.btnMayorSueldoTodas.Text = "Empleado Mayor Sueldo Sucursales";
            this.btnMayorSueldoTodas.UseVisualStyleBackColor = true;
            this.btnMayorSueldoTodas.Click += new System.EventHandler(this.btnMayorSueldoTodas_Click);
            // 
            // btnSucursalMenorSumaSueldos
            // 
            this.btnSucursalMenorSumaSueldos.Location = new System.Drawing.Point(509, 424);
            this.btnSucursalMenorSumaSueldos.Name = "btnSucursalMenorSumaSueldos";
            this.btnSucursalMenorSumaSueldos.Size = new System.Drawing.Size(298, 41);
            this.btnSucursalMenorSumaSueldos.TabIndex = 9;
            this.btnSucursalMenorSumaSueldos.Text = "Sucursal con la menor suma de sueldos ";
            this.btnSucursalMenorSumaSueldos.UseVisualStyleBackColor = true;
            this.btnSucursalMenorSumaSueldos.Click += new System.EventHandler(this.btnSucursalMenorSumaSueldos_Click);
            // 
            // btnSucMenorCantEmpleados
            // 
            this.btnSucMenorCantEmpleados.Location = new System.Drawing.Point(509, 471);
            this.btnSucMenorCantEmpleados.Name = "btnSucMenorCantEmpleados";
            this.btnSucMenorCantEmpleados.Size = new System.Drawing.Size(298, 52);
            this.btnSucMenorCantEmpleados.TabIndex = 10;
            this.btnSucMenorCantEmpleados.Text = "Sucursal con la menor cantidad de empleados";
            this.btnSucMenorCantEmpleados.UseVisualStyleBackColor = true;
            this.btnSucMenorCantEmpleados.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnPromSueldoEmpSucursales
            // 
            this.btnPromSueldoEmpSucursales.Location = new System.Drawing.Point(509, 529);
            this.btnPromSueldoEmpSucursales.Name = "btnPromSueldoEmpSucursales";
            this.btnPromSueldoEmpSucursales.Size = new System.Drawing.Size(298, 52);
            this.btnPromSueldoEmpSucursales.TabIndex = 11;
            this.btnPromSueldoEmpSucursales.Text = "Promedio sueldo de empleados de todas las sucursales";
            this.btnPromSueldoEmpSucursales.UseVisualStyleBackColor = true;
            this.btnPromSueldoEmpSucursales.Click += new System.EventHandler(this.btnPromSueldoEmpSucursales_Click);
            // 
            // btnPromEmpSucursal
            // 
            this.btnPromEmpSucursal.Location = new System.Drawing.Point(509, 586);
            this.btnPromEmpSucursal.Name = "btnPromEmpSucursal";
            this.btnPromEmpSucursal.Size = new System.Drawing.Size(298, 52);
            this.btnPromEmpSucursal.TabIndex = 12;
            this.btnPromEmpSucursal.Text = "Promedio empleados por sucursal";
            this.btnPromEmpSucursal.UseVisualStyleBackColor = true;
            this.btnPromEmpSucursal.Click += new System.EventHandler(this.btnPromEmpSucursal_Click);
            // 
            // FrmSucursalEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 650);
            this.Controls.Add(this.btnPromEmpSucursal);
            this.Controls.Add(this.btnPromSueldoEmpSucursales);
            this.Controls.Add(this.btnSucMenorCantEmpleados);
            this.Controls.Add(this.btnSucursalMenorSumaSueldos);
            this.Controls.Add(this.btnMayorSueldoTodas);
            this.Controls.Add(this.btnMayorSueldo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lstSucursales);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmSucursalEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmSucursalEmpleado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCapSuc;
        private System.Windows.Forms.TextBox txtDireccionSucursal;
        private System.Windows.Forms.TextBox txtNombreSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCapEmp;
        private System.Windows.Forms.TextBox txtSueldoEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtNumeroEmpleado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstSucursales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMayorSueldo;
        private System.Windows.Forms.Button btnMayorSueldoTodas;
        private System.Windows.Forms.Button btnSucursalMenorSumaSueldos;
        private System.Windows.Forms.Button btnSucMenorCantEmpleados;
        private System.Windows.Forms.Button btnPromSueldoEmpSucursales;
        private System.Windows.Forms.Button btnPromEmpSucursal;
    }
}