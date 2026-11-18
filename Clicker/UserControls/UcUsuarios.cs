
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using Clicker.Models;
using Clicker.Services;

namespace Clicker.UserControls
{
    public partial class UcUsuarios : UserControl
    {
        private UsuarioService usuarioService = new UsuarioService();
        private GameService gameService = new GameService();

        public UcUsuarios()
        {
            InitializeComponent();

            this.Load += UcUsuarios_Load;
        }

        private async void UcUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos todos los usuarios
                List<Usuario> usuarios =
                    await usuarioService.ObtenerUsuariosAsync();

                // Configuramos la tabla
                ConfigurarTabla();

                // Recorremos todos los usuarios
                foreach (Usuario usuario in usuarios)
                {
                    try
                    {
                        // Obtenemos la partida del usuario
                        Game partida =
                            await gameService.ObtenerPartidaAsync(usuario.IdUser);

                        if (partida == null)
                        {
                            dgvUsuarios.Rows.Add(
                                usuario.UserName,
                                "—",
                                "—",
                                "—",
                                "Sin partida"
                            );

                            continue;
                        }

                        // Calculamos el tiempo jugado
                        DateTime fechaFinal = partida.FinishDate ?? DateTime.Now;

                        TimeSpan tiempoJugado =
                            fechaFinal - partida.StartDate;

                        string tiempo =
                            $"{(int)tiempoJugado.TotalHours} h {tiempoJugado.Minutes} min";

                        // Añadimos los datos a la tabla
                        dgvUsuarios.Rows.Add(
                            usuario.UserName,
                            partida.StartDate.ToString("dd/MM/yyyy"),
                            partida.TotalMoney.ToString("N0") + " €",
                            tiempo,
                            partida.Status ? "Activo" : "Inactivo"
                        );
                    }
                    catch (HttpRequestException)
                    {
                        // Si el usuario no tiene partida disponible
                        dgvUsuarios.Rows.Add(
                            usuario.UserName,
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
                    "Error al obtener los usuarios: " + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ConfigurarTabla()
        {
            dgvUsuarios.Rows.Clear();
            dgvUsuarios.Columns.Clear();

            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvUsuarios.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            // USUARIO
            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUsuario",
                HeaderText = "USUARIO"
            });

            // FECHA DE CREACIÓN
            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colFecha",
                HeaderText = "FECHA DE CREACIÓN"
            });

            // MONEDAS
            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colMonedas",
                HeaderText = "MONEDAS"
            });

            // TIEMPO JUGADO
            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTiempo",
                HeaderText = "TIEMPO JUGADO"
            });

            // ESTADO
            dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
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

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
