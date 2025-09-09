using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace parking.Models
{
    public class Car
    {
        public string NumberPlate { get; private set; }

        public Car(string plate)
        {
            SetNumberPlate(plate); // validaçao no construtor
        }

        // Validaçao usando expressao regular
        private static bool IsValidPlate(string plate)
        {
            return Regex.IsMatch(plate, @"^[A-Z]{3}-[0-9]{4}$");
        }

        // Metodo publico para alterar a placa
        private void SetNumberPlate(string plate)
        {
            if (!IsValidPlate(plate))
            {
                throw new ArgumentException("Placa invalida! O formato correto e ABC-1234.");
                
            }
            
            NumberPlate = plate;
        }
    }
}