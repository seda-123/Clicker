
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
                List<Usuario> usuarios =
                    await usuarioService.ObtenerUsuariosAsync();

                // Filtramos únicamente los jugadores
                List<Usuario> jugadores = usuarios
                    .Where(u => u.Rol.Trim().Equals(
                        "jugador",
                        StringComparison.OrdinalIgnoreCase))
                    .ToList();

                // Obtenemos todos los niveles
                List<Level> niveles =
                    await levelService.ObtenerNivelesAsync();

                // Configuramos la tabla
                ConfigurarTabla();

                // Recorremos los jugadores
                foreach (Usuario jugador in jugadores)
                {
                    try
                    {
                        // Obtenemos la partida del jugador
                        Game partida =
                            await gameService.ObtenerPartidaAsync(jugador.IdUser);

                        if (partida == null)
                        {
                            dgvJugadores.Rows.Add(
                                jugador.UserName,
                                "—",
                                "—",
                                "—",
                                "Sin partida"
                            );

                            continue;
                        }

                        // Obtenemos los progresos de la partida
                        List<LevelProgress> progresos =
                            await progressService.ObtenerProgresosAsync(
                                partida.IdGame
                            );

                        string nombreNivel = "—";

                        if (progresos.Count > 0)
                        {
                            // Seleccionamos el progreso iniciado más recientemente
                            LevelProgress progresoActual = progresos
                                .OrderByDescending(p => p.LevelStartDate)
                                .First();

                            // Buscamos el nivel correspondiente
                            Level nivel = niveles.FirstOrDefault(
                                n => n.IdLevel == progresoActual.IdLevel
                            );

                            if (nivel != null)
                            {
                                nombreNivel = nivel.LevelName;
                            }
                        }

                        // Añadimos los datos a la tabla
                        dgvJugadores.Rows.Add(
                            jugador.UserName,
                            partida.IdGame,
                            partida.TotalMoney.ToString("N0"),
                            nombreNivel,
                            partida.Status ? "Activo" : "Inactivo"
                        );
                    }
                    catch (HttpRequestException)
                    {
                        // Si no se encuentra la partida
                        dgvJugadores.Rows.Add(
                            jugador.UserName,
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

            dgvJugadores.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvJugadores.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // USUARIO
            dgvJugadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUsuario",
                HeaderText = "USUARIO"
            });

            // ID PARTIDA
            dgvJugadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colIdPartida",
                HeaderText = "ID PARTIDA"
            });

            // MONEDAS TOTALES
            dgvJugadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMonedas",
                HeaderText = "MONEDAS TOTALES"
            });

            // NIVEL
            dgvJugadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colNivel",
                HeaderText = "NIVEL"
            });

            // ESTADO
            dgvJugadores.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colEstado",
                HeaderText = "ESTADO"
            });
        }

        // Eventos generados por el Designer
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void DescriptionLabel_Click(object sender, EventArgs e)
        {
        }

        private void dgvJugadores_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
