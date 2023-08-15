
namespace SolucionTDS.DelegadoLambda
{
    partial class FrmCircLambda
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
            this.lblRadio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCalcularPerimetro = new System.Windows.Forms.RadioButton();
            this.radCalcularArea = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRadio
            // 
            this.lblRadio.AutoSize = true;
            this.lblRadio.Location = new System.Drawing.Point(58, 43);
            this.lblRadio.Name = "lblRadio";
            this.lblRadio.Size = new System.Drawing.Size(45, 17);
            this.lblRadio.TabIndex = 0;
            this.lblRadio.Text = "Radio";
            this.lblRadio.Click += new System.EventHandler(this.lblRadio_Click);
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(150, 43);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 22);
            this.txtRadio.TabIndex = 1;
            this.txtRadio.TextChanged += new System.EventHandler(this.txtRadio_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radCalcularPerimetro);
            this.groupBox1.Controls.Add(this.radCalcularArea);
            this.groupBox1.Location = new System.Drawing.Point(61, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 164);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de operacion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radCalcularPerimetro
            // 
            this.radCalcularPerimetro.AutoSize = true;
            this.radCalcularPerimetro.Location = new System.Drawing.Point(58, 86);
            this.radCalcularPerimetro.Name = "radCalcularPerimetro";
            this.radCalcularPerimetro.Size = new System.Drawing.Size(144, 21);
            this.radCalcularPerimetro.TabIndex = 1;
            this.radCalcularPerimetro.TabStop = true;
            this.radCalcularPerimetro.Text = "Calcular perímetro";
            this.radCalcularPerimetro.UseVisualStyleBackColor = true;
            // 
            // radCalcularArea
            // 
            this.radCalcularArea.AutoSize = true;
            this.radCalcularArea.Location = new System.Drawing.Point(58, 40);
            this.radCalcularArea.Name = "radCalcularArea";
            this.radCalcularArea.Size = new System.Drawing.Size(113, 21);
            this.radCalcularArea.TabIndex = 0;
            this.radCalcularArea.TabStop = true;
            this.radCalcularArea.Text = "Calcular área";
            this.radCalcularArea.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(61, 363);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FrmCircLambda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.lblRadio);
            this.Name = "FrmCircLambda";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radCalcularPerimetro;
        private System.Windows.Forms.RadioButton radCalcularArea;
        private System.Windows.Forms.Button btnCalcular;
    }
}