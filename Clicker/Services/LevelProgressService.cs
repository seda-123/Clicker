
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Clicker.Models;

namespace Clicker.Services
{
    internal class LevelProgressService
    {
        private readonly ApiService api;

        public LevelProgressService()
        {
            api = new ApiService();
        }

        public async Task<List<LevelProgress>> ObtenerProgresosAsync(int idGame)
        {
            var progresos = await api.Cliente
                .GetFromJsonAsync<List<LevelProgress>>(
                    $"api/Level_progress/game/{idGame}"
                );

            return progresos ?? new List<LevelProgress>();
        }
    }
}
