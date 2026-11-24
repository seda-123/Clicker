using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using Clicker.Models;
using Clicker.Services;

namespace Clicker.UserControls
{
    public partial class UcJugadores : UserControl
    {
        private UsuarioService usuarioService = new UsuarioService();
        private GameService gameService = new GameService();
        private LevelService levelService = new LevelService();
        private LevelProgressService progressService = new LevelProgressService();

        public UcJugadores()
        {
            InitializeComponent();
            this.Load += UcJugadores_Load;
        }

        private async void UcJugadores_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos todos los usuarios
                List<Usuario> usuarios = await usuarioService.ObtenerUsuariosAsync();

                // Filtramos únicamente los jugadores
                List<Usuario> jugadores = usuarios
                    .Where(u => u.Rol.Trim().Equals("jugador", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                // Obtenemos todos los niveles
                List<Level> niveles = await levelService.ObtenerNivelesAsync();

                // Configuramos la tabla con las 6 columnas
                ConfigurarTabla();

                // Recorremos los jugadores
                foreach (Usuario jugador in jugadores)
                {
                    try
                    {
                        // Obtenemos la partida del jugador
                        Game partida = await gameService.ObtenerPartidaAsync(jugador.IdUser);

                        if (partida == null)
                        {
                            dgvJugadores.Rows.Add(
                                jugador.UserName,
                                "—",
                                "—",
                                "—",
                                "—",
                                "Sin partida"
                            );
                            continue;
                        }

                        // Obtenemos los progresos de la partida
                        List<LevelProgress> progresos =
                            await progressService.ObtenerProgresosAsync(partida.IdGame);

                        string nombreNivel = "—";

                        if (progresos.Count > 0)
                        {
                            // Seleccionamos el progreso iniciado más recientemente
                            LevelProgress progresoActual = progresos
                                .OrderByDescending(p => p.LevelStartDate)
                                .First();

                            // Buscamos el nivel correspondiente
                            Level nivel = niveles.FirstOrDefault(
                                n => n.IdLevel == progresoActual.IdLevel);

                            if (nivel != null)
                            {
                                nombreNivel = nivel.LevelName;
                            }
                        }

                        // Formateo de duración (ajusta "partida.Duration" al nombre real de tu propiedad en Game.cs)
                        TimeSpan duracion = (partida.FinishDate ?? DateTime.Now) - partida.StartDate;
                        string duracionFormateada = FormatearDuracion(duracion);

                        // Añadimos los datos respetando el nuevo orden de columnas:
                        // User | id Partida | Nivel | Monedas totales | Duración partida | Estado
                        dgvJugadores.Rows.Add(
                            jugador.UserName,
                            partida.IdGame,
                            nombreNivel,
                            partida.TotalMoney.ToString("N0"),
                            duracionFormateada,
                            partida.Status ? "Activo" : "Inactivo"
                        );
                    }
                    catch (HttpRequestException)
                    {
                        // Si no se encuentra la partida (404, etc.)
                        dgvJugadores.Rows.Add(
                            jugador.UserName,
                            "—",
                            "—",
                            "—",
                            "—",
                            "Sin partida"
                        );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al obtener los jugadores: " + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ConfigurarTabla()
        {
            dgvJugadores.Rows.Clear();
            dgvJugadores.Columns.Clear();

            dgvJugadores.AutoGenerateColumns = false;
            dgvJugadores.AllowUserToAddRows = false;
            dgvJugadores.AllowUserToDeleteRows = false;
            dgvJugadores.ReadOnly = true;
            dgvJugadores.RowHeadersVisible = false;

            dgvJugadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvJugadores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // 1. USER
            dgvJugadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUser",
                HeaderText = "User"
            });

            // 2. ID PARTIDA
            dgvJugadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colIdPartida",
                HeaderText = "id Partida"
            });

            // 3. NIVEL
            dgvJugadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNivel",
                HeaderText = "Nivel"
            });

            // 4. MONEDAS TOTALES
            dgvJugadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMonedas",
                HeaderText = "Monedas totales"
            });

            // 5. DURACIÓN PARTIDA
            dgvJugadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDuracion",
                HeaderText = "Duración partida"
            });

            // 6. ESTADO
            dgvJugadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEstado",
                HeaderText = "Estado"
            });
        }

        /// <summary>
        /// Método auxiliar para mostrar la duración de forma legible.
        /// </summary>
        private string FormatearDuracion(TimeSpan? duracion)
        {
            if (duracion == null) return "—";
            return string.Format("{0:D2}:{1:D2}:{2:D2}",
                (int)duracion.Value.TotalHours,
                duracion.Value.Minutes,
                duracion.Value.Seconds);
        }

        // Sobrecarga por si la duración en tu modelo Game viene en segundos (int o double)
        private string FormatearDuracion(double segundosTotales)
        {
            TimeSpan t = TimeSpan.FromSeconds(segundosTotales);
            return string.Format("{0:D2}:{1:D2}:{2:D2}",
                (int)t.TotalHours,
                t.Minutes,
                t.Seconds);
        }

        // Eventos generados por el Designer
        private void label1_Click(object sender, EventArgs e) { }
        private void DescriptionLabel_Click(object sender, EventArgs e) { }
        private void dgvJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}