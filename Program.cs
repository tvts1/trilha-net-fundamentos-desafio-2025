using parking.Models;

Console.Write("Valor inicial do estacionamento: R$ ");
var initialPrice = float.Parse(Console.ReadLine());

Console.Write("Valor por hora: R$ ");
var pricePerHour = float.Parse(Console.ReadLine());

var parking = new Parking(initialPrice, pricePerHour);

var menu = new Menu(parking);
menu.Show();
