using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImprimirNombre_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbNombre.Text))
            {
                lsbInvitaciones.Items.Add(tbNombre.Text);
                tbNombre.Clear();
                tbNombre.Focus();   
            }

            else
            {
                MessageBox.Show("Por favor, ingresá un nombre antes de imprimir.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
