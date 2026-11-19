
using System.Text.Json.Serialization;

namespace Clicker.Models
{
    public class Level
    {
        [JsonPropertyName("id_level")]
        public byte IdLevel { get; set; }

        [JsonPropertyName("level_name")]
        public string LevelName { get; set; } = "";

        [JsonPropertyName("crop_type")]
        public string CropType { get; set; } = "";

        [JsonPropertyName("required_money")]
        public int RequiredMoney { get; set; }
    }
}
