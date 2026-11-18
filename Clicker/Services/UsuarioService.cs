
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Clicker.Models;

namespace Clicker.Services
{
    internal class UsuarioService
    {
        private readonly ApiService api;

        public UsuarioService()
        {
            api = new ApiService();
        }

        public async Task<List<Usuario>> ObtenerUsuariosAsync()
        {
            var usuarios = await api.Cliente
                .GetFromJsonAsync<List<Usuario>>("api/User");

            if (usuarios == null)
            {
                return new List<Usuario>();
            }

            // Eliminamos los espacios sobrantes
            foreach (var usuario in usuarios)
            {
                usuario.UserName = usuario.UserName.Trim();
            }

            return usuarios;
        }
    }
}
