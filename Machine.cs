using System.Text.Json.Serialization;

namespace FitnessTest
{
    public class Machine
    {
        public Machine() { }

        [JsonPropertyName("MachineName")]
        public string MachineName { get; set; }

        [JsonPropertyName("id")]
        public int id { get; set; }

        [JsonPropertyName("picture")]
        public string picture { get; set; }

        [JsonPropertyName("possibleWeights")]
        public List<int> possibleWeights { get; set; }

        [JsonPropertyName("data")]
        public List<MachineData> data { get; set; }

        public Machine(string machineName, int id, string picture, List<int> possibleWeights, List<MachineData> data)
        {
            this.MachineName = machineName;
            this.id = id;
            this.picture = picture;
            this.possibleWeights = possibleWeights;
            this.data = data;
        }
    }
}
