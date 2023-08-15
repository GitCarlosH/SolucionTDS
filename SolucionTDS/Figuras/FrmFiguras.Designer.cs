
namespace SolucionTDS.Figuras
{
    partial class FrmFiguras
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Circunferencia = new System.Windows.Forms.TabPage();
            this.btnAgregarCirc = new System.Windows.Forms.Button();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.Radio = new System.Windows.Forms.Label();
            this.Cuadrado = new System.Windows.Forms.TabPage();
            this.btnAgregarCuad = new System.Windows.Forms.Button();
            this.txtLado = new System.Windows.Forms.TextBox();
            this.lblLado1 = new System.Windows.Forms.Label();
            this.lstFiguras = new System.Windows.Forms.ListBox();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.btnMostrarDatosTodas = new System.Windows.Forms.Button();
            this.btnSumarAreas = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Circunferencia.SuspendLayout();
            this.Cuadrado.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Circunferencia);
            this.tabControl1.Controls.Add(this.Cuadrado);
            this.tabControl1.Location = new System.Drawing.Point(140, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(499, 191);
            this.tabControl1.TabIndex = 0;
            // 
            // Circunferencia
            // 
            this.Circunferencia.Controls.Add(this.btnAgregarCirc);
            this.Circunferencia.Controls.Add(this.txtRadio);
            this.Circunferencia.Controls.Add(this.Radio);
            this.Circunferencia.Location = new System.Drawing.Point(4, 25);
            this.Circunferencia.Name = "Circunferencia";
            this.Circunferencia.Padding = new System.Windows.Forms.Padding(3);
            this.Circunferencia.Size = new System.Drawing.Size(491, 162);
            this.Circunferencia.TabIndex = 0;
            this.Circunferencia.Text = "Circunferencia";
            this.Circunferencia.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCirc
            // 
            this.btnAgregarCirc.Location = new System.Drawing.Point(290, 40);
            this.btnAgregarCirc.Name = "btnAgregarCirc";
            this.btnAgregarCirc.Size = new System.Drawing.Size(137, 52);
            this.btnAgregarCirc.TabIndex = 2;
            this.btnAgregarCirc.Text = "Agregar";
            this.btnAgregarCirc.UseVisualStyleBackColor = true;
            this.btnAgregarCirc.Click += new System.EventHandler(this.btnAgregarCirc_Click);
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(100, 40);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 22);
            this.txtRadio.TabIndex = 1;
            // 
            // Radio
            // 
            this.Radio.AutoSize = true;
            this.Radio.Location = new System.Drawing.Point(24, 40);
            this.Radio.Name = "Radio";
            this.Radio.Size = new System.Drawing.Size(59, 17);
            this.Radio.TabIndex = 0;
            this.Radio.Text = "lblRadio";
            // 
            // Cuadrado
            // 
            this.Cuadrado.Controls.Add(this.btnAgregarCuad);
            this.Cuadrado.Controls.Add(this.txtLado);
            this.Cuadrado.Controls.Add(this.lblLado1);
            this.Cuadrado.Location = new System.Drawing.Point(4, 25);
            this.Cuadrado.Name = "Cuadrado";
            this.Cuadrado.Padding = new System.Windows.Forms.Padding(3);
            this.Cuadrado.Size = new System.Drawing.Size(491, 162);
            this.Cuadrado.TabIndex = 1;
            this.Cuadrado.Text = "Cuadrado";
            this.Cuadrado.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCuad
            // 
            this.btnAgregarCuad.Location = new System.Drawing.Point(317, 48);
            this.btnAgregarCuad.Name = "btnAgregarCuad";
            this.btnAgregarCuad.Size = new System.Drawing.Size(103, 35);
            this.btnAgregarCuad.TabIndex = 4;
            this.btnAgregarCuad.Text = "Agregar";
            this.btnAgregarCuad.UseVisualStyleBackColor = true;
            this.btnAgregarCuad.Click += new System.EventHandler(this.btnAgregarCuad_Click);
            // 
            // txtLado
            // 
            this.txtLado.Location = new System.Drawing.Point(105, 61);
            this.txtLado.Name = "txtLado";
            this.txtLado.Size = new System.Drawing.Size(100, 22);
            this.txtLado.TabIndex = 2;
            // 
            // lblLado1
            // 
            this.lblLado1.AutoSize = true;
            this.lblLado1.Location = new System.Drawing.Point(23, 66);
            this.lblLado1.Name = "lblLado1";
            this.lblLado1.Size = new System.Drawing.Size(40, 17);
            this.lblLado1.TabIndex = 0;
            this.lblLado1.Text = "Lado";
            // 
            // lstFiguras
            // 
            this.lstFiguras.FormattingEnabled = true;
            this.lstFiguras.ItemHeight = 16;
            this.lstFiguras.Location = new System.Drawing.Point(5, 260);
            this.lstFiguras.Name = "lstFiguras";
            this.lstFiguras.Size = new System.Drawing.Size(375, 212);
            this.lstFiguras.TabIndex = 1;
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(386, 260);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(249, 35);
            this.btnMostrarDatos.TabIndex = 2;
            this.btnMostrarDatos.Text = "Datos de la figura seleccionada";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // btnMostrarDatosTodas
            // 
            this.btnMostrarDatosTodas.Location = new System.Drawing.Point(386, 320);
            this.btnMostrarDatosTodas.Name = "btnMostrarDatosTodas";
            this.btnMostrarDatosTodas.Size = new System.Drawing.Size(249, 35);
            this.btnMostrarDatosTodas.TabIndex = 3;
            this.btnMostrarDatosTodas.Text = "Datos de todas las figuras";
            this.btnMostrarDatosTodas.UseVisualStyleBackColor = true;
            this.btnMostrarDatosTodas.Click += new System.EventHandler(this.btnMostrarDatosTodas_Click);
            // 
            // btnSumarAreas
            // 
            this.btnSumarAreas.Location = new System.Drawing.Point(386, 378);
            this.btnSumarAreas.Name = "btnSumarAreas";
            this.btnSumarAreas.Size = new System.Drawing.Size(249, 35);
            this.btnSumarAreas.TabIndex = 4;
            this.btnSumarAreas.Text = "Suma de áreas";
            this.btnSumarAreas.UseVisualStyleBackColor = true;
            this.btnSumarAreas.Click += new System.EventHandler(this.btnSumarAreas_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(386, 437);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(249, 35);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar datos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // FrmFiguras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 516);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnSumarAreas);
            this.Controls.Add(this.btnMostrarDatosTodas);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.lstFiguras);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmFiguras";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Circunferencia.ResumeLayout(false);
            this.Circunferencia.PerformLayout();
            this.Cuadrado.ResumeLayout(false);
            this.Cuadrado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Circunferencia;
        private System.Windows.Forms.Button btnAgregarCirc;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label Radio;
        private System.Windows.Forms.TabPage Cuadrado;
        private System.Windows.Forms.Button btnAgregarCuad;
        private System.Windows.Forms.TextBox txtLado;
        private System.Windows.Forms.Label lblLado1;
        private System.Windows.Forms.ListBox lstFiguras;
        private System.Windows.Forms.Button btnMostrarDatos;
        private System.Windows.Forms.Button btnMostrarDatosTodas;
        private System.Windows.Forms.Button btnSumarAreas;
        private System.Windows.Forms.Button btnLimpiar;
    }
}