
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Clicker.Models;

namespace Clicker.Services
{
    internal class LevelService
    {
        private readonly ApiService api;

        public LevelService()
        {
            api = new ApiService();
        }

        public async Task<List<Level>> ObtenerNivelesAsync()
        {
            var niveles = await api.Cliente
                .GetFromJsonAsync<List<Level>>("api/Level");

            return niveles ?? new List<Level>();
        }
    }
}
