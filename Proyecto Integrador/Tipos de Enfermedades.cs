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
    public partial class Tipos_de_Enfermedades : Form
    {
        public Tipos_de_Enfermedades()
        {
            InitializeComponent();

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}





