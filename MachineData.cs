namespace FitnessTest
{
    public class MachineData

    /* Unmerged change from project 'FitnessTest (net7.0-android)'
    Before:
        {

            public int Weight { get; set; }
    After:
        {

            public int Weight { get; set; }
    */

    /* Unmerged change from project 'FitnessTest (net7.0-ios)'
    Before:
        {

            public int Weight { get; set; }
    After:
        {

            public int Weight { get; set; }
    */

    /* Unmerged change from project 'FitnessTest (net7.0-maccatalyst)'
    Before:
        {

            public int Weight { get; set; }
    After:
        {

            public int Weight { get; set; }
    */
    {

        public int Weight { get; set; }
        public int Repetitions { get; set; }
        public DateTime DatePerformed { get; set; }

        public MachineData() { }

        public MachineData(int weight, int repetitions, DateTime datePerformed)
        {
            this.Weight = weight;
            this.Repetitions = repetitions;
            this.DatePerformed = datePerformed;
        }
    }
}
