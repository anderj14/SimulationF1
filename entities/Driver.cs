
namespace SimulationF1.entities
{
    public class Driver
    {
        public string Name { get; set; }
        public Vehicle Car { get; set; }
        public double DistanceCovered { get; set; } = 0;
        public double BestLap { get; set; } = double.MaxValue;
        public int Points { get; set; }
        public bool Finished { get; set; } = false;
        public double FinishTime { get; set; } = 0;

        public Driver(string name, Vehicle car)
        {
            Name = name;
            Car = car;
        }
    }
}