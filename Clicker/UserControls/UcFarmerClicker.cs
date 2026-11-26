
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows.Forms;
using Clicker.Models;
using Clicker.Services;

namespace Clicker.UserControls
{
    public partial class UcFarmerClicker : UserControl
    {
        int dinersInicial = 2000;
        int dinersSegona = 20000;
        private UsuarioService usuarioService = new UsuarioService();
        private GameService gameService = new GameService();

        public UcFarmerClicker()
        {
            InitializeComponent();

            vardiner.Text = $"{dinersInicial}€";
            variableDinero.Text = $"{dinersInicial}-";
            SegonaMilloraDiners.Text = $"{dinersSegona}€";
            maxMoney.Text = $"{dinersSegona}+";

            this.Load += UcFarmerClicker_Load;
        }

        private async void UcFarmerClicker_Load(object sender, EventArgs e)
        {
            await CargarTarjetasAsync();
        }
        private async Task CargarTarjetasAsync()
        {
            try
            {
          
                List<Usuario> usuarios = await usuarioService.ObtenerUsuariosAsync();

                List<Usuario> jugadores = usuarios
                    .Where(u => u.Rol.Trim().Equals("jugador", StringComparison.OrdinalIgnoreCase))
                    .ToList();
                int totalSesiones = 0;
                long totalMonedas = 0;

                foreach (Usuario jugador in jugadores)
                {
                    try
                    {
                        Game partida = await gameService.ObtenerPartidaAsync(jugador.IdUser);

                        if (partida == null)
                            continue;

                        totalSesiones++;
                        totalMonedas += (long)partida.TotalMoney;
                    }
                    catch (HttpRequestException)
                    {
                        continue;
                    }
                }

                lblAlumnos.Text = jugadores.Count.ToString("N0");
                lblSesiones.Text = totalSesiones.ToString("N0");
                lblMonedas.Text = totalMonedas.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las tarjetas: " + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void titolTarjetaFarmer_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void descripcioJoc_Click(object sender, EventArgs e)
        {

        }

        private void PanelFarmer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void variablediner_Click(object sender, EventArgs e)
        {

        }

        private void PanelAlumnos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblAlumnos_Click(object sender, EventArgs e)
        {

        }

        private void lblSesiones_Click(object sender, EventArgs e)
        {

        }

        private void lblMonedas_Click(object sender, EventArgs e)
        {

        }
    }
}
