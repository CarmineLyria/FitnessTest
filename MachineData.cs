using System.Text.Json.Serialization;

namespace FitnessTest
{
    public class MachineData
    {
        [JsonPropertyName("Weight")]
        public int Weight { get; set; }

        [JsonPropertyName("Repetitions")]
        public int Repetitions { get; set; }

        [JsonPropertyName("DatePerformed")]
        public string DatePerformed { get; set; }

        public MachineData() { }

        public MachineData(int weight, int repetitions, DateTime datePerformed)
        {
            this.Weight = weight;
            this.Repetitions = repetitions;
            this.DatePerformed = datePerformed.ToString();
        }
    }
}
