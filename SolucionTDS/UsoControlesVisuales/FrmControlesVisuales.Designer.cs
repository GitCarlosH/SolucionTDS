
namespace SolucionTDS.UsoControlesVisuales
{
    partial class FrmControlesVisuales
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
            this.GrDatEmp = new System.Windows.Forms.GroupBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.dtmFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.cboGradoMaximoEstudios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grSexo = new System.Windows.Forms.GroupBox();
            this.radFemenino = new System.Windows.Forms.RadioButton();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.grCondTrab = new System.Windows.Forms.GroupBox();
            this.chkCapacitado = new System.Windows.Forms.CheckBox();
            this.chkSeguroVida = new System.Windows.Forms.CheckBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblFechNac = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgEmpleados = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeguroVida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradoEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrDatEmp.SuspendLayout();
            this.grSexo.SuspendLayout();
            this.grCondTrab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // GrDatEmp
            // 
            this.GrDatEmp.Controls.Add(this.txtSueldo);
            this.GrDatEmp.Controls.Add(this.txtEdad);
            this.GrDatEmp.Controls.Add(this.dtmFechaNacimiento);
            this.GrDatEmp.Controls.Add(this.cboGrupo);
            this.GrDatEmp.Controls.Add(this.txtNombre);
            this.GrDatEmp.Controls.Add(this.btnCapturar);
            this.GrDatEmp.Controls.Add(this.cboGradoMaximoEstudios);
            this.GrDatEmp.Controls.Add(this.label1);
            this.GrDatEmp.Controls.Add(this.grSexo);
            this.GrDatEmp.Controls.Add(this.grCondTrab);
            this.GrDatEmp.Controls.Add(this.lblSueldo);
            this.GrDatEmp.Controls.Add(this.lblEdad);
            this.GrDatEmp.Controls.Add(this.lblFechNac);
            this.GrDatEmp.Controls.Add(this.lblGrupo);
            this.GrDatEmp.Controls.Add(this.lblNombre);
            this.GrDatEmp.Location = new System.Drawing.Point(56, 39);
            this.GrDatEmp.Name = "GrDatEmp";
            this.GrDatEmp.Size = new System.Drawing.Size(976, 341);
            this.GrDatEmp.TabIndex = 0;
            this.GrDatEmp.TabStop = false;
            this.GrDatEmp.Text = "Datos del empleado";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(139, 115);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(71, 22);
            this.txtSueldo.TabIndex = 14;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(808, 72);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(59, 22);
            this.txtEdad.TabIndex = 13;
            // 
            // dtmFechaNacimiento
            // 
            this.dtmFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFechaNacimiento.Location = new System.Drawing.Point(443, 72);
            this.dtmFechaNacimiento.Name = "dtmFechaNacimiento";
            this.dtmFechaNacimiento.Size = new System.Drawing.Size(283, 22);
            this.dtmFechaNacimiento.TabIndex = 12;
            this.dtmFechaNacimiento.ValueChanged += new System.EventHandler(this.dtmFechaNacimiento_ValueChanged);
            // 
            // cboGrupo
            // 
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cboGrupo.Location = new System.Drawing.Point(139, 69);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(71, 24);
            this.cboGrupo.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(377, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(671, 257);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(115, 23);
            this.btnCapturar.TabIndex = 9;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // cboGradoMaximoEstudios
            // 
            this.cboGradoMaximoEstudios.FormattingEnabled = true;
            this.cboGradoMaximoEstudios.Items.AddRange(new object[] {
            "Ninguno",
            "Prescolar",
            "Primaria",
            "Secundaria",
            "Bachillerato",
            "Licenciatura",
            "Maestría ",
            "Doctorado",
            "Otro"});
            this.cboGradoMaximoEstudios.Location = new System.Drawing.Point(794, 160);
            this.cboGradoMaximoEstudios.Name = "cboGradoMaximoEstudios";
            this.cboGradoMaximoEstudios.Size = new System.Drawing.Size(121, 24);
            this.cboGradoMaximoEstudios.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(583, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Grado máximo de estudios";
            // 
            // grSexo
            // 
            this.grSexo.Controls.Add(this.radFemenino);
            this.grSexo.Controls.Add(this.radMasculino);
            this.grSexo.Location = new System.Drawing.Point(290, 160);
            this.grSexo.Name = "grSexo";
            this.grSexo.Size = new System.Drawing.Size(200, 100);
            this.grSexo.TabIndex = 6;
            this.grSexo.TabStop = false;
            this.grSexo.Text = "Sexo";
            // 
            // radFemenino
            // 
            this.radFemenino.AutoSize = true;
            this.radFemenino.Location = new System.Drawing.Point(23, 57);
            this.radFemenino.Name = "radFemenino";
            this.radFemenino.Size = new System.Drawing.Size(91, 21);
            this.radFemenino.TabIndex = 1;
            this.radFemenino.TabStop = true;
            this.radFemenino.Text = "Femenino";
            this.radFemenino.UseVisualStyleBackColor = true;
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Location = new System.Drawing.Point(23, 30);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(92, 21);
            this.radMasculino.TabIndex = 0;
            this.radMasculino.TabStop = true;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = true;
            // 
            // grCondTrab
            // 
            this.grCondTrab.Controls.Add(this.chkCapacitado);
            this.grCondTrab.Controls.Add(this.chkSeguroVida);
            this.grCondTrab.Location = new System.Drawing.Point(39, 160);
            this.grCondTrab.Name = "grCondTrab";
            this.grCondTrab.Size = new System.Drawing.Size(200, 100);
            this.grCondTrab.TabIndex = 5;
            this.grCondTrab.TabStop = false;
            this.grCondTrab.Text = "Condiciones de trabajo";
            // 
            // chkCapacitado
            // 
            this.chkCapacitado.AutoSize = true;
            this.chkCapacitado.Location = new System.Drawing.Point(18, 57);
            this.chkCapacitado.Name = "chkCapacitado";
            this.chkCapacitado.Size = new System.Drawing.Size(101, 21);
            this.chkCapacitado.TabIndex = 7;
            this.chkCapacitado.Text = "Capacitado";
            this.chkCapacitado.UseVisualStyleBackColor = true;
            // 
            // chkSeguroVida
            // 
            this.chkSeguroVida.AutoSize = true;
            this.chkSeguroVida.Location = new System.Drawing.Point(18, 30);
            this.chkSeguroVida.Name = "chkSeguroVida";
            this.chkSeguroVida.Size = new System.Drawing.Size(126, 21);
            this.chkSeguroVida.TabIndex = 6;
            this.chkSeguroVida.Text = "Seguro de vida";
            this.chkSeguroVida.UseVisualStyleBackColor = true;
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(36, 115);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(52, 17);
            this.lblSueldo.TabIndex = 4;
            this.lblSueldo.Text = "Sueldo";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(745, 72);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(41, 17);
            this.lblEdad.TabIndex = 3;
            this.lblEdad.Text = "Edad";
            // 
            // lblFechNac
            // 
            this.lblFechNac.AutoSize = true;
            this.lblFechNac.Location = new System.Drawing.Point(269, 72);
            this.lblFechNac.Name = "lblFechNac";
            this.lblFechNac.Size = new System.Drawing.Size(139, 17);
            this.lblFechNac.TabIndex = 2;
            this.lblFechNac.Text = "Fecha de nacimiento";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(36, 72);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(48, 17);
            this.lblGrupo.TabIndex = 1;
            this.lblGrupo.Text = "Grupo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(36, 43);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // dgEmpleados
            // 
            this.dgEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Grupo,
            this.FechaNacimiento,
            this.Edad,
            this.Sueldo,
            this.SeguroVida,
            this.Capacitado,
            this.Sexo,
            this.GradoEst});
            this.dgEmpleados.Location = new System.Drawing.Point(56, 414);
            this.dgEmpleados.Name = "dgEmpleados";
            this.dgEmpleados.RowHeadersWidth = 51;
            this.dgEmpleados.RowTemplate.Height = 24;
            this.dgEmpleados.Size = new System.Drawing.Size(976, 150);
            this.dgEmpleados.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            // 
            // Grupo
            // 
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.MinimumWidth = 6;
            this.Grupo.Name = "Grupo";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.HeaderText = "FechaNacimiento";
            this.FechaNacimiento.MinimumWidth = 6;
            this.FechaNacimiento.Name = "FechaNacimiento";
            // 
            // Edad
            // 
            this.Edad.HeaderText = "Edad";
            this.Edad.MinimumWidth = 6;
            this.Edad.Name = "Edad";
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.MinimumWidth = 6;
            this.Sueldo.Name = "Sueldo";
            // 
            // SeguroVida
            // 
            this.SeguroVida.HeaderText = "SeguroVida";
            this.SeguroVida.MinimumWidth = 6;
            this.SeguroVida.Name = "SeguroVida";
            // 
            // Capacitado
            // 
            this.Capacitado.HeaderText = "Capacitado";
            this.Capacitado.MinimumWidth = 6;
            this.Capacitado.Name = "Capacitado";
            // 
            // Sexo
            // 
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.MinimumWidth = 6;
            this.Sexo.Name = "Sexo";
            // 
            // GradoEst
            // 
            this.GradoEst.HeaderText = "Grado máximo de estudios";
            this.GradoEst.MinimumWidth = 6;
            this.GradoEst.Name = "GradoEst";
            // 
            // FrmControlesVisuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 627);
            this.Controls.Add(this.dgEmpleados);
            this.Controls.Add(this.GrDatEmp);
            this.Name = "FrmControlesVisuales";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmControlesVisuales_Load);
            this.GrDatEmp.ResumeLayout(false);
            this.GrDatEmp.PerformLayout();
            this.grSexo.ResumeLayout(false);
            this.grSexo.PerformLayout();
            this.grCondTrab.ResumeLayout(false);
            this.grCondTrab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrDatEmp;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.DateTimePicker dtmFechaNacimiento;
        private System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.ComboBox cboGradoMaximoEstudios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grSexo;
        private System.Windows.Forms.RadioButton radFemenino;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.GroupBox grCondTrab;
        private System.Windows.Forms.CheckBox chkCapacitado;
        private System.Windows.Forms.CheckBox chkSeguroVida;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblFechNac;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.DataGridView dgEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeguroVida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradoEst;
        private System.Windows.Forms.TextBox txtSueldo;
    }
}