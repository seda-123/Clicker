
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

        public async Task<Game> ObtenerPartidaAsync(byte idUser)
        {
            var partida = await api.Cliente
                .GetFromJsonAsync<Game>($"api/Game/{idUser}");

            return partida;
        }
    }
}
