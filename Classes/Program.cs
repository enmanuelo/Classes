using Classes;

Car myCar = new Car();
myCar.Make = "Chevrolet";
myCar.Model = "Camaro SS";
myCar.Year = 1969;

var yourCar = new Car() // Object intitialization
{
    Make = "Dodge",
    Model = "Charger",
    Year = 1970
};

var theirCar = new Car("Toyota", "Supra", 1993);

var carList = new List<Car>() { myCar, yourCar, theirCar };

foreach (var vehicle in carList)
{
    Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
}