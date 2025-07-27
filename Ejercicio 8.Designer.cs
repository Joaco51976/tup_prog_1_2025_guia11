namespace WindowsFormsApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lsbServicios = new System.Windows.Forms.ListBox();
            this.lbsServiciosElegidos = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servicios";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(289, 186);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lsbServicios
            // 
            this.lsbServicios.FormattingEnabled = true;
            this.lsbServicios.Items.AddRange(new object[] {
            "Cambio de aceite",
            "Reemplazo batería",
            "Reemplazo Filtros de aire",
            "Alineación y balanceo",
            "Verificación de frenos",
            "Verificación de luces",
            "Reemplazo de bobina de arranque"});
            this.lsbServicios.Location = new System.Drawing.Point(23, 151);
            this.lsbServicios.Name = "lsbServicios";
            this.lsbServicios.Size = new System.Drawing.Size(182, 108);
            this.lsbServicios.TabIndex = 2;
            this.lsbServicios.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbsServiciosElegidos
            // 
            this.lbsServiciosElegidos.FormattingEnabled = true;
            this.lbsServiciosElegidos.Location = new System.Drawing.Point(461, 151);
            this.lbsServiciosElegidos.Name = "lbsServiciosElegidos";
            this.lbsServiciosElegidos.Size = new System.Drawing.Size(120, 95);
            this.lbsServiciosElegidos.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(602, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Quitar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbsServiciosElegidos);
            this.Controls.Add(this.lsbServicios);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lsbServicios;
        private System.Windows.Forms.ListBox lbsServiciosElegidos;
        private System.Windows.Forms.Button button2;
    }
}

