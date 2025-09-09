namespace parking.Models;

public class Menu
{
    private Parking _parking;

    public Menu(Parking parking)
    {
        _parking = parking;
    }

    // Exibe um menu interativo
    public void Show()
    {
        while (true)
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1 - Adicionar carro");
            Console.WriteLine("2 - Remover carro");
            Console.WriteLine("3 - Listar carros");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Console.Write("Digite a placa: ");
                    var plateToAdd = Console.ReadLine();

                    try
                    {
                        _parking.AddCar(plateToAdd); 
                        Console.WriteLine("Carro adicionado.");
                    }
                    catch (ArgumentException e)
                    {
                            Console.WriteLine($"Erro: {e.Message}");
                    }
                   
                    Console.ReadKey();
                    break;

                case "2":
                    Console.Write("Digite a placa: ");
                    var plateToRemove = Console.ReadLine();
                    
                    Console.Write("Horas estacionado: ");
                    var hours = int.Parse(Console.ReadLine());
                    
                    _parking.DeleteCar(plateToRemove, hours);
                    
                    Console.ReadKey();
                    break;

                case "3":
                    _parking.ListCars();
                    
                    Console.ReadKey();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
