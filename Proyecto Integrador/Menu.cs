using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Integrador
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Tipos_de_Enfermedades entrar = new Tipos_de_Enfermedades();
            entrar.Show();
            this.Hide();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Estadisticas graficas = new Estadisticas();
            graficas.Show();
            this.Hide();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Causas_y_Factores factos = new Causas_y_Factores();
            factos.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
