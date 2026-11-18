
using System;
using System.Text.Json.Serialization;

namespace Clicker.Models
{
    public class Game
    {
        [JsonPropertyName("id_game")]
        public byte IdGame { get; set; }

        [JsonPropertyName("start_date")]
        public DateTime StartDate { get; set; }

        [JsonPropertyName("finish_date")]
        public DateTime? FinishDate { get; set; }

        [JsonPropertyName("total_money")]
        public int TotalMoney { get; set; }

        [JsonPropertyName("status")]
        public bool Status { get; set; }

        [JsonPropertyName("id_user")]
        public byte IdUser { get; set; }
    }
}
