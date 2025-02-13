
using SimulationF1.entities;

List<Driver> drivers = CreateDrivers();

Race race = new Race(4.0, drivers); // 4km
race.StartRace();

race.ShowResults();

static List<Driver> CreateDrivers()
{
    return new List<Driver>
    {
        new Driver("Max Verstappen", new Vehicle(350, 3.5)),
        new Driver("Lewis Hamilton", new Vehicle(345, 3.6)),
        new Driver("Charles Leclerc", new Vehicle(340, 3.7)),
        new Driver("Fernando Alonso", new Vehicle(338, 3.8)),
        new Driver("Sergio Pérez", new Vehicle(342, 3.6)),
        new Driver("Carlos Sainz", new Vehicle(340, 3.7)),
        new Driver("Lando Norris", new Vehicle(337, 3.9)),
        new Driver("George Russell", new Vehicle(344, 3.5)),
        new Driver("Pierre Gasly", new Vehicle(335, 4.0)),
        new Driver("Valtteri Bottas", new Vehicle(330, 4.2))
    };
}