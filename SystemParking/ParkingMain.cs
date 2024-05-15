using System;

namespace SystemParking 
{
    public class ParkingMain
    {
        public static void Main(string[] args) 
        {
            double valueInitial = 0;
            double valueHour = 0;
            string place = "";
            int option;

            Console.WriteLine("Qual o valor inicial?");
            valueInitial = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor por hora?");
            valueHour = double.Parse(Console.ReadLine());

            ParkingModel parking = new ParkingModel(valueInitial, valueHour);

            do 
            {
                Console.WriteLine("Escolha uma opção do menu:");
                Console.WriteLine("0- Cadastrar veículo;\n1- Listar Veículo;\n2- Remover veículo;\n3- Encerrar;");
                option = int.Parse(Console.ReadLine());

                switch(option) 
                {
                    case 0:
                        Console.WriteLine("Qual a placa do veículo?");
                        place = Console.ReadLine();
                        parking.addCar(place);
                        break;
                    case 1:
                        parking.printCar();
                        break;
                    case 2:
                        Console.WriteLine("Qual veículo você deseja remover?");
                        place = Console.ReadLine();
                        parking.removeCar(place);
                        break;
                    default:
                        Console.WriteLine("Sistema encerrado!");
                        break;
                }
            } while(option!=3);
        }
    }
}