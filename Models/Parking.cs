using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parking.Models
{
    public class Parking
    {
        private float InitialPrice { get;}
        private float PricePerHour { get;}
        private readonly List<Car> _cars = new();

        public Parking(float initialPrice, float pricePerHour)
        {
            InitialPrice = initialPrice;
            PricePerHour = pricePerHour;
        }

        // Adiciona um carro a lista
        public void AddCar(string numberPlate)
        {
            var car = new Car(numberPlate);
            _cars.Add(car);
        }

        // Remove um carro da lista
        public void DeleteCar(string numberPlate, int hoursParked)
        {
            var carToDelete = _cars.Find(c => c.NumberPlate == numberPlate);
            if (carToDelete != null)
            {
                var totalPrice = InitialPrice + (hoursParked * PricePerHour);
                Console.WriteLine($"Total a pagar: {totalPrice}");
                _cars.Remove(carToDelete);
            }
            else
            {
                Console.WriteLine("Placa nao encontrada no sistema");
            }
        }

        // Lista os carros
        public void ListCars()
        {
            _cars.ForEach(c => Console.WriteLine("Placa: " + c.NumberPlate));
        }
    }
}