
using System;
using System.Net.Http;

namespace Clicker.Services
{
    public class ApiService
    {
        private readonly HttpClient cliente;

        public ApiService()
        {
            cliente = new HttpClient();

            cliente.BaseAddress =
                new Uri("http://localhost:5141/");
        }

        public HttpClient Cliente => cliente;
    }
}
