
using System;
using System.Text.Json.Serialization;

namespace Clicker.Models
{
    public class LevelProgress
    {
        [JsonPropertyName("id_progress")]
        public byte IdProgress { get; set; }

        [JsonPropertyName("level_start_date")]
        public DateTime? LevelStartDate { get; set; }

        [JsonPropertyName("level_finish_date")]
        public DateTime? LevelFinishDate { get; set; }

        [JsonPropertyName("cleared")]
        public bool? Cleared { get; set; }

        [JsonPropertyName("id_game")]
        public int IdGame { get; set; }

        [JsonPropertyName("id_level")]
        public int IdLevel { get; set; }
    }
}
