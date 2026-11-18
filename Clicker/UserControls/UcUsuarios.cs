
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Clicker.Models;
using Clicker.Services;

namespace Clicker.UserControls
{
    public partial class UcUsuarios : UserControl
    {
        private UsuarioService usuarioService = new UsuarioService();

        public UcUsuarios()
        {
            InitializeComponent();

            this.Load += UcUsuarios_Load;
        }

        private async void UcUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                List<Usuario> usuarios =
                    await usuarioService.ObtenerUsuariosAsync();

                dgvUsuarios.AutoGenerateColumns = false;

                dgvUsuarios.Columns.Clear();

                
                dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colId",
                    HeaderText = "ID",
                    DataPropertyName = "IdUser",
                    Visible = false
                });

                
                dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "colUsuario",
                    HeaderText = "USUARIO",
                    DataPropertyName = "UserName"
                });

                dgvUsuarios.DataSource = usuarios;
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
