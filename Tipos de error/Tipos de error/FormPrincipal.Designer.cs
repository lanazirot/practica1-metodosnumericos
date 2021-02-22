namespace Tipos_de_error {
    partial class FormPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.grbDatosValores = new System.Windows.Forms.GroupBox();
            this.txtValorAproximado = new System.Windows.Forms.TextBox();
            this.txtValorVerdadero = new System.Windows.Forms.TextBox();
            this.lblValorAproximado = new System.Windows.Forms.Label();
            this.lblValorVerdadero = new System.Windows.Forms.Label();
            this.grbOperaciones = new System.Windows.Forms.GroupBox();
            this.btnTodasLasOperaciones = new System.Windows.Forms.Button();
            this.grbDatosValores.SuspendLayout();
            this.grbOperaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosValores
            // 
            this.grbDatosValores.Controls.Add(this.txtValorAproximado);
            this.grbDatosValores.Controls.Add(this.txtValorVerdadero);
            this.grbDatosValores.Controls.Add(this.lblValorAproximado);
            this.grbDatosValores.Controls.Add(this.lblValorVerdadero);
            this.grbDatosValores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatosValores.Location = new System.Drawing.Point(12, 12);
            this.grbDatosValores.Name = "grbDatosValores";
            this.grbDatosValores.Size = new System.Drawing.Size(412, 259);
            this.grbDatosValores.TabIndex = 0;
            this.grbDatosValores.TabStop = false;
            this.grbDatosValores.Text = "Valores ";
            // 
            // txtValorAproximado
            // 
            this.txtValorAproximado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorAproximado.Location = new System.Drawing.Point(178, 157);
            this.txtValorAproximado.Name = "txtValorAproximado";
            this.txtValorAproximado.Size = new System.Drawing.Size(128, 26);
            this.txtValorAproximado.TabIndex = 3;
            this.txtValorAproximado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorAproximado_KeyPress);
            // 
            // txtValorVerdadero
            // 
            this.txtValorVerdadero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorVerdadero.Location = new System.Drawing.Point(178, 55);
            this.txtValorVerdadero.Name = "txtValorVerdadero";
            this.txtValorVerdadero.Size = new System.Drawing.Size(128, 26);
            this.txtValorVerdadero.TabIndex = 2;
            this.txtValorVerdadero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorVerdadero_KeyPress);
            // 
            // lblValorAproximado
            // 
            this.lblValorAproximado.AutoSize = true;
            this.lblValorAproximado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorAproximado.Location = new System.Drawing.Point(40, 157);
            this.lblValorAproximado.Name = "lblValorAproximado";
            this.lblValorAproximado.Size = new System.Drawing.Size(132, 20);
            this.lblValorAproximado.TabIndex = 1;
            this.lblValorAproximado.Text = "Valor aproximado";
            // 
            // lblValorVerdadero
            // 
            this.lblValorVerdadero.AutoSize = true;
            this.lblValorVerdadero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorVerdadero.Location = new System.Drawing.Point(51, 58);
            this.lblValorVerdadero.Name = "lblValorVerdadero";
            this.lblValorVerdadero.Size = new System.Drawing.Size(121, 20);
            this.lblValorVerdadero.TabIndex = 0;
            this.lblValorVerdadero.Text = "Valor verdadero";
            // 
            // grbOperaciones
            // 
            this.grbOperaciones.Controls.Add(this.btnTodasLasOperaciones);
            this.grbOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOperaciones.Location = new System.Drawing.Point(430, 12);
            this.grbOperaciones.Name = "grbOperaciones";
            this.grbOperaciones.Size = new System.Drawing.Size(135, 259);
            this.grbOperaciones.TabIndex = 1;
            this.grbOperaciones.TabStop = false;
            this.grbOperaciones.Text = "Operaciones";
            // 
            // btnTodasLasOperaciones
            // 
            this.btnTodasLasOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodasLasOperaciones.Location = new System.Drawing.Point(6, 101);
            this.btnTodasLasOperaciones.Name = "btnTodasLasOperaciones";
            this.btnTodasLasOperaciones.Size = new System.Drawing.Size(123, 51);
            this.btnTodasLasOperaciones.TabIndex = 3;
            this.btnTodasLasOperaciones.Text = "Calcular &todos los errores";
            this.btnTodasLasOperaciones.UseVisualStyleBackColor = true;
            this.btnTodasLasOperaciones.Click += new System.EventHandler(this.btnTodasLasOperaciones_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 284);
            this.Controls.Add(this.grbOperaciones);
            this.Controls.Add(this.grbDatosValores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de error - Práctica 1";
            this.grbDatosValores.ResumeLayout(false);
            this.grbDatosValores.PerformLayout();
            this.grbOperaciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosValores;
        private System.Windows.Forms.TextBox txtValorAproximado;
        private System.Windows.Forms.TextBox txtValorVerdadero;
        private System.Windows.Forms.Label lblValorAproximado;
        private System.Windows.Forms.Label lblValorVerdadero;
        private System.Windows.Forms.GroupBox grbOperaciones;
        private System.Windows.Forms.Button btnTodasLasOperaciones;
    }
}

