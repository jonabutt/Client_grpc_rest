using System.Text.Json.Serialization;

namespace Client_Console_Grpc_Rest_Testing.RestDTO
{
    public class Permissions
    {
        [JsonPropertyName("admin")]
        public bool Admin { get; set; }

        [JsonPropertyName("maintain")]
        public bool Maintain { get; set; }

        [JsonPropertyName("push")]
        public bool Push { get; set; }

        [JsonPropertyName("triage")]
        public bool Triage { get; set; }

        [JsonPropertyName("pull")]
        public bool Pull { get; set; }
    }
}
