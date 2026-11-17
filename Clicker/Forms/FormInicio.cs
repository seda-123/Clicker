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
            CargarInicio();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }
        private void CargarInicio()
        {
            PanelContenido.Controls.Clear();

            UcInicio inicio = new UcInicio();

            inicio.Dock = DockStyle.Fill;

            PanelContenido.Controls.Add(inicio);
        }

        private void PanelContenido_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
