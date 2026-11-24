using Clicker.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clicker
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            MostrarUserControl(new UcInicio());
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }


        private void PanelContenido_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MostrarUserControl(UserControl uc)
        {
            PanelContenido.Controls.Clear();

            uc.Dock = DockStyle.Fill;

            PanelContenido.Controls.Add(uc);
        }

        private void usuarios_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new UcUsuarios());
        }

        private void inicio_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new UcInicio());
        }

        private void jugadores_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new UcJugadores());
        }

        private void Farmer_Clicker_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new UcFarmerClicker());
        }

        private void Historial_partidas_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new UcHistorial());
        }

        private void configuracion_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new UcConfiguracion());
        }
    }
}

