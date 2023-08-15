
namespace SolucionTDS.Profesor_Estudiante
{
    partial class FrmProfEst
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
            this.grbTipoPersona = new System.Windows.Forms.GroupBox();
            this.radEstudiante = new System.Windows.Forms.RadioButton();
            this.radProfesor = new System.Windows.Forms.RadioButton();
            this.btnCapturarDatos = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpDeDatos = new System.Windows.Forms.Button();
            this.grbTipoPersona.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTipoPersona
            // 
            this.grbTipoPersona.Controls.Add(this.radEstudiante);
            this.grbTipoPersona.Controls.Add(this.radProfesor);
            this.grbTipoPersona.Location = new System.Drawing.Point(38, 63);
            this.grbTipoPersona.Name = "grbTipoPersona";
            this.grbTipoPersona.Size = new System.Drawing.Size(233, 107);
            this.grbTipoPersona.TabIndex = 0;
            this.grbTipoPersona.TabStop = false;
            this.grbTipoPersona.Text = "Tipo de persona";
            // 
            // radEstudiante
            // 
            this.radEstudiante.AutoSize = true;
            this.radEstudiante.Location = new System.Drawing.Point(42, 66);
            this.radEstudiante.Name = "radEstudiante";
            this.radEstudiante.Size = new System.Drawing.Size(96, 21);
            this.radEstudiante.TabIndex = 1;
            this.radEstudiante.TabStop = true;
            this.radEstudiante.Text = "Estudiante";
            this.radEstudiante.UseVisualStyleBackColor = true;
            // 
            // radProfesor
            // 
            this.radProfesor.AutoSize = true;
            this.radProfesor.Location = new System.Drawing.Point(42, 30);
            this.radProfesor.Name = "radProfesor";
            this.radProfesor.Size = new System.Drawing.Size(83, 21);
            this.radProfesor.TabIndex = 1;
            this.radProfesor.TabStop = true;
            this.radProfesor.Text = "Profesor";
            this.radProfesor.UseVisualStyleBackColor = true;
            this.radProfesor.CheckedChanged += new System.EventHandler(this.radProfesor_CheckedChanged);
            // 
            // btnCapturarDatos
            // 
            this.btnCapturarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCapturarDatos.Location = new System.Drawing.Point(117, 241);
            this.btnCapturarDatos.Name = "btnCapturarDatos";
            this.btnCapturarDatos.Size = new System.Drawing.Size(117, 60);
            this.btnCapturarDatos.TabIndex = 1;
            this.btnCapturarDatos.Text = "Capturar datos";
            this.btnCapturarDatos.UseVisualStyleBackColor = true;
            this.btnCapturarDatos.Click += new System.EventHandler(this.btnCapturarDatos_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMostrarDatos.Location = new System.Drawing.Point(332, 241);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(117, 60);
            this.btnMostrarDatos.TabIndex = 2;
            this.btnMostrarDatos.Text = "Mostrar datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtCalificacion);
            this.grbDatos.Controls.Add(this.txtSueldo);
            this.grbDatos.Controls.Add(this.txtNombre);
            this.grbDatos.Controls.Add(this.label3);
            this.grbDatos.Controls.Add(this.label2);
            this.grbDatos.Controls.Add(this.label1);
            this.grbDatos.Location = new System.Drawing.Point(291, 63);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(470, 107);
            this.grbDatos.TabIndex = 3;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos de la persona";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(376, 64);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(47, 22);
            this.txtCalificacion.TabIndex = 5;
            this.txtCalificacion.Text = "0";
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(149, 62);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(81, 22);
            this.txtSueldo.TabIndex = 4;
            this.txtSueldo.Text = "0";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(149, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(274, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Calificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sueldo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLimpDeDatos
            // 
            this.btnLimpDeDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLimpDeDatos.Location = new System.Drawing.Point(547, 241);
            this.btnLimpDeDatos.Name = "btnLimpDeDatos";
            this.btnLimpDeDatos.Size = new System.Drawing.Size(122, 60);
            this.btnLimpDeDatos.TabIndex = 4;
            this.btnLimpDeDatos.Text = "Limpieza de datos";
            this.btnLimpDeDatos.UseVisualStyleBackColor = true;
            this.btnLimpDeDatos.Click += new System.EventHandler(this.btnLimpDeDatos_Click);
            // 
            // FrmProfEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 335);
            this.Controls.Add(this.btnLimpDeDatos);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnCapturarDatos);
            this.Controls.Add(this.grbTipoPersona);
            this.Name = "FrmProfEst";
            this.Text = "PERSONAS DE UNA ESCUELA";
            this.grbTipoPersona.ResumeLayout(false);
            this.grbTipoPersona.PerformLayout();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTipoPersona;
        private System.Windows.Forms.RadioButton radEstudiante;
        private System.Windows.Forms.RadioButton radProfesor;
        private System.Windows.Forms.Button btnCapturarDatos;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnLimpDeDatos;
    }
}