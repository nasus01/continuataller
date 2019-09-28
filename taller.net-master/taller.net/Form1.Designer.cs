namespace taller.net
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.btnpromedionotas = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnvolumen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(26, 108);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "calculando masa corp";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnpromedionotas
            // 
            this.btnpromedionotas.Location = new System.Drawing.Point(26, 206);
            this.btnpromedionotas.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnpromedionotas.Name = "btnpromedionotas";
            this.btnpromedionotas.Size = new System.Drawing.Size(200, 89);
            this.btnpromedionotas.TabIndex = 1;
            this.btnpromedionotas.Text = "promedio notas";
            this.btnpromedionotas.UseVisualStyleBackColor = true;
            this.btnpromedionotas.Click += new System.EventHandler(this.btnpromedionotas_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(26, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 89);
            this.button2.TabIndex = 2;
            this.button2.Text = "Raizcuadrada";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnvolumen
            // 
            this.btnvolumen.Location = new System.Drawing.Point(258, 206);
            this.btnvolumen.Name = "btnvolumen";
            this.btnvolumen.Size = new System.Drawing.Size(133, 89);
            this.btnvolumen.TabIndex = 3;
            this.btnvolumen.Text = "Volumen";
            this.btnvolumen.UseVisualStyleBackColor = true;
            this.btnvolumen.Click += new System.EventHandler(this.btnvolumen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 346);
            this.Controls.Add(this.btnvolumen);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnpromedionotas);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnpromedionotas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnvolumen;
    }
}

