using System.Text.Json.Serialization;

namespace Clicker.Models
{
    public class Usuario
    {
        [JsonPropertyName("id_user")]
        public byte IdUser { get; set; }

        [JsonPropertyName("user_name")]
        public string UserName { get; set; } = "";

        [JsonPropertyName("rol")]
        public string Rol { get; set; } = "";
    }
}