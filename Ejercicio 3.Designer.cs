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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnImprimirNombre = new System.Windows.Forms.Button();
            this.lsbInvitaciones = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del invitado";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(117, 78);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(175, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // btnImprimirNombre
            // 
            this.btnImprimirNombre.Location = new System.Drawing.Point(310, 64);
            this.btnImprimirNombre.Name = "btnImprimirNombre";
            this.btnImprimirNombre.Size = new System.Drawing.Size(75, 47);
            this.btnImprimirNombre.TabIndex = 2;
            this.btnImprimirNombre.Text = "Imprimir Nombre";
            this.btnImprimirNombre.UseVisualStyleBackColor = true;
            this.btnImprimirNombre.Click += new System.EventHandler(this.btnImprimirNombre_Click);
            // 
            // lsbInvitaciones
            // 
            this.lsbInvitaciones.FormattingEnabled = true;
            this.lsbInvitaciones.Location = new System.Drawing.Point(44, 140);
            this.lsbInvitaciones.Name = "lsbInvitaciones";
            this.lsbInvitaciones.Size = new System.Drawing.Size(248, 147);
            this.lsbInvitaciones.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.lsbInvitaciones);
            this.Controls.Add(this.btnImprimirNombre);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnImprimirNombre;
        private System.Windows.Forms.ListBox lsbInvitaciones;
    }
}

