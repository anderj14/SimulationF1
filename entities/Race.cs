
namespace SimulationF1.entities
{
    class Race
    {
        private double TrackLength;
        private List<Driver> Drivers;
        private Random Rnd = new Random();
        private double TotalTime = 0;
        private Driver FastestLap;

        public Race(double trackLength, List<Driver> drivers)
        {
            TrackLength = trackLength;
            Drivers = drivers;
        }

        public void StartRace()
        {
            Console.WriteLine("🏎️ The race has started 🏁\n");
            bool raceFinished = false;

            while (!raceFinished)
            {
                TotalTime += 1; // Simulate each second of the race
                foreach (var driver in Drivers)
                {
                    if (!driver.Finished)
                    {
                        // Simulate progress
                        double speed = driver.Car.CalculateCurrentSpeed();
                        driver.DistanceCovered += speed / 3600; // Distance in km (speed in km/h)

                        // Telemetry
                        Console.WriteLine($"{driver.Name} - Speed: {Math.Round(speed)} km/h - Distance: {Math.Round(driver.DistanceCovered, 2)} km");

                        // Wear evaluation
                        driver.Car.Wear += Rnd.Next(0, 3); // Random wear

                        // Check if the driver has finished
                        if (driver.DistanceCovered >= TrackLength)
                        {
                            driver.Finished = true;
                            driver.FinishTime = TotalTime;

                            // Save fastest lap
                            if (TotalTime < driver.BestLap)
                            {
                                driver.BestLap = TotalTime;
                                FastestLap = driver;
                            }
                        }
                    }
                }

                // Simulate overtakes and standings
                List<Driver> finishedDrivers = Drivers.Where(d => d.Finished)
                                                       .OrderBy(d => d.FinishTime)
                                                       .ToList();
                List<Driver> racingDrivers = Drivers.Where(d => !d.Finished)
                                                    .OrderByDescending(d => d.DistanceCovered)
                                                    .ToList();

                // Check if all drivers have finished
                raceFinished = Drivers.All(d => d.Finished);

                // Display standings
                Console.WriteLine("\n📊 Current standings:");
                int position = 1;
                foreach (var driver in finishedDrivers)
                {
                    Console.WriteLine($"{position}. {driver.Name} - Finished ({driver.FinishTime} s)");
                    position++;
                }
                foreach (var driver in racingDrivers)
                {
                    Console.WriteLine($"{position}. {driver.Name} - {Math.Round(driver.DistanceCovered, 2)} km");
                    position++;
                }

                Console.WriteLine("\n---\n");
                Thread.Sleep(1000); // Wait 1 second to simulate real time
            }

            Console.WriteLine("\n🏁 The race is over!\n");
        }

        public void ShowResults()
        {
            Console.WriteLine("📊 Final results:");
            List<Driver> finalResults = Drivers.OrderBy(d => d.FinishTime).ToList();
            for (int i = 0; i < finalResults.Count; i++)
            {
                int points = i switch
                {
                    0 => 10,
                    1 => 8,
                    2 => 6,
                    _ => 1
                };

                finalResults[i].Points += points;
                Console.WriteLine($"{i + 1}. {finalResults[i].Name} - Points: {finalResults[i].Points}");
            }

            Console.WriteLine($"\n🏎️ Fastest lap: {FastestLap.Name} with {FastestLap.BestLap} seconds.");
        }
    }
}