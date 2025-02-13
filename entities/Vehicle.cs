
namespace SimulationF1.entities
{
    public class Vehicle
    {
        public double MaxSpeed { get; set; }
        public double Acceleration { get; set; }
        public double Wear { get; set; } = 0;

        public Vehicle(double maxSpeed, double acceleration)
        {
            MaxSpeed = maxSpeed;
            Acceleration = acceleration;
        }

        public double CalculateCurrentSpeed()
        {
            if (Wear > 100) Wear = 100;

            double currentSpeed = MaxSpeed * (1 - Wear / 100);
            return Math.Max(currentSpeed, 0);
        }
    }
}