namespace FitnessTest
{
    public class Machine
    {
        public Machine() { }
        public string MachineName { get; set; }
        public int id { get; set; }
        public string picture { get; set; }
        public List<int> possibleWeights { get; set; }
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
