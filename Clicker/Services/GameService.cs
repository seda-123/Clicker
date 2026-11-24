
using System.Net.Http.Json;
using System.Threading.Tasks;
using Clicker.Models;

namespace Clicker.Services
{
    public class GameService
    {
        private readonly ApiService api;

        public GameService()
        {
            api = new ApiService();
        }

        public async Task<Game?> ObtenerPartidaAsync(byte idUser)
        {
            var partidas = await api.Cliente.GetFromJsonAsync<List<Game>>($"api/Game/{idUser}"); // Ajusta la ruta a la de tu API
            return partidas?.FirstOrDefault();
        }
    }
}
