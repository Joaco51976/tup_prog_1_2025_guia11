using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int total = 0;
        int excelentes = 0;
        int buenos = 0;
        int insuficientes = 0;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            if (rbExcelente.Checked)
            {
                excelentes++;
            }

            else if (rbBueno.Checked)
            {
                buenos++;
            }

            else if (rbInsuficiente.Checked)
            {
                insuficientes++;
            }

            else
            {
                MessageBox.Show("Por favor seleccione una opción");
                return;
            }

            total++;

            lbTotal.Text = total.ToString();
            lbExcelentes.Text = excelentes.ToString();
            lbBuenas.Text = buenos.ToString();
            lbInsuficientes.Text = insuficientes.ToString();

            rbExcelente.Checked = false;
            rbBueno.Checked = false;
            rbInsuficiente.Checked = false;
        }
    }
}
