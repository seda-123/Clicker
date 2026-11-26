using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clicker.Models;
using Clicker.Services;

namespace Clicker.UserControls
{
    public partial class UcInicio : UserControl
    {
        private UsuarioService usuarioService = new UsuarioService();
        private GameService gameService = new GameService();
       

        public UcInicio()
        {
            InitializeComponent();
            this.Load += UcInicio_Load;
        }

        private async void UcInicio_Load(object sender, EventArgs e)
        {
            await CargarDatosInicioAsync();
        }

        private async Task CargarDatosInicioAsync()
        {
            try
            {
                // 1. Obtenemos todos los usuarios y filtramos los jugadores
                List<Usuario> usuarios = await usuarioService.ObtenerUsuariosAsync();
                List<Usuario> jugadores = usuarios
                    .Where(u => u.Rol.Trim().Equals("jugador", StringComparison.OrdinalIgnoreCase))
                    .ToList();

           

                // Configuramos la tabla de partidas recientes
                ConfigurarTabla();

                // Acumuladores para las 4 tarjetas
                int totalSesiones = 0;
                long totalMonedas = 0;
                TimeSpan tiempoTotalAcumulado = TimeSpan.Zero;

                // 3. Recorremos los jugadores
                foreach (Usuario jugador in jugadores)
                {
                    try
                    {
                        Game partida = await gameService.ObtenerPartidaAsync(jugador.IdUser);

                        if (partida == null)
                        {
                            dgvPartidasRecientes.Rows.Add(
                                jugador.UserName,
                                "—",
                                "—",
                                "—",
                                "—",
                                "Sin partida"
                            );
                            continue;
                        }

                        // Calculamos la duración de esta partida
                        TimeSpan duracion = (partida.FinishDate ?? DateTime.Now) - partida.StartDate;

                        // Sumamos a los totales de las tarjetas
                        totalSesiones++;
                        totalMonedas += (long)partida.TotalMoney;
                        tiempoTotalAcumulado += duracion;

                        // Obtenemos los progresos de la partida
                        

                       

                        // Añadimos la fila a la tabla
                        dgvPartidasRecientes.Rows.Add(
                            jugador.UserName,
                            partida.IdGame,
                      
                            partida.TotalMoney.ToString("N0"),
                            FormatearDuracion(duracion),
                            partida.Status ? "Activo" : "Inactivo"
                        );
                    }
                    catch (HttpRequestException)
                    {
                        dgvPartidasRecientes.Rows.Add(
                            jugador.UserName,
                            "—",
                            "—",
                            "—",
                            "—",
                            "Sin partida"
                        );
                    }
                }

                // 4. Mostramos los resultados en las 4 tarjetas
                lblAlumnos.Text = jugadores.Count.ToString("N0");
                lblSesiones.Text = totalSesiones.ToString("N0");
                lblMonedas.Text = totalMonedas.ToString("N0");
                lblTiempoTotal.Text = FormatearTiempoTotalTarjeta(tiempoTotalAcumulado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los datos de inicio: " + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ConfigurarTabla()
        {
            dgvPartidasRecientes.Rows.Clear();
            dgvPartidasRecientes.Columns.Clear();

            dgvPartidasRecientes.AutoGenerateColumns = false;
            dgvPartidasRecientes.AllowUserToAddRows = false;
            dgvPartidasRecientes.AllowUserToDeleteRows = false;
            dgvPartidasRecientes.ReadOnly = true;
            dgvPartidasRecientes.RowHeadersVisible = false;

            dgvPartidasRecientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPartidasRecientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvPartidasRecientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUser",
                HeaderText = "User"
            });

            dgvPartidasRecientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colIdPartida",
                HeaderText = "id Partida"
            });

            dgvPartidasRecientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNivel",
                HeaderText = "Nivel"
            });

            dgvPartidasRecientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMonedas",
                HeaderText = "Monedas totales"
            });

            dgvPartidasRecientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDuracion",
                HeaderText = "Duración partida"
            });

            dgvPartidasRecientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEstado",
                HeaderText = "Estado"
            });
        }

        // Formato HH:mm:ss para la tabla
        private string FormatearDuracion(TimeSpan duracion)
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}",
                (int)duracion.TotalHours,
                duracion.Minutes,
                duracion.Seconds);
        }

        // Formato legible para la tarjeta "Tiempo total" (ej: "2h 15m" o "45m 12s")
        private string FormatearTiempoTotalTarjeta(TimeSpan duracion)
        {
            if (duracion.TotalHours >= 1)
            {
                return $"{(int)duracion.TotalHours}h {duracion.Minutes}m";
            }
            return $"{duracion.Minutes}m {duracion.Seconds}s";
        }

        // Eventos generados por el Designer
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void PartidasRecientes_Paint(object sender, PaintEventArgs e) { }

        private void LblTituloAlumnos_Click(object sender, EventArgs e)
        {

        }

        private void lblTitulSessions_Click(object sender, EventArgs e)
        {

        }

        private void lblAlumnos_Click(object sender, EventArgs e)
        {

        }
    }
}