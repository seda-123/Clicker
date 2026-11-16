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
    }
}
