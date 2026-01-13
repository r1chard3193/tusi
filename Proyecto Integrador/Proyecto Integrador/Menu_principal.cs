using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Proyecto_Integrador
{
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
            RedondearBoton(btnFuncion1, 50);
            RedondearBoton(btnFuncion2, 50);
            RedondearBoton(btnFuncion3, 50);
            RedondearBoton(btnFuncion4, 50);
        }

        private void RedondearBoton(Button btn, int radio) // Metodo para redondear botones
        {
            GraphicsPath pasos = new GraphicsPath();
  
            pasos.AddArc(0, 0, radio, radio, 180, 90);
            pasos.AddArc(btn.Width - radio, 0, radio, radio, 270, 90);
            pasos.AddArc(btn.Width - radio, btn.Height - radio, radio, radio, 0, 90);
            pasos.AddArc(0, btn.Height - radio, radio, radio, 90, 90);

            pasos.CloseFigure();

            btn.Region = new Region(pasos);
        }
        private void btmcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFuncion4_Click(object sender, EventArgs e)
        {
            MenuF4 menuF4 = new MenuF4();
            menuF4.Show();
            this.Close();
        }

        private void btnFuncion2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
