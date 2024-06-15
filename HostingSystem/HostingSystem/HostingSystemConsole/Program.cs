using HostingSystemConsole.Models;

namespace HostingSystemConsole;
public class Program
{
    static void Main(string[] args)
    {
        Reserva reserva = new Reserva();
        int opcao;

        Console.WriteLine("Qual operação deseja realizar?");
        do
        {
            Console.WriteLine("0- Cadastrar hóspede;\n1- Cadastrar suíte;\n2- Obter quntidade de hóspedes;\n3- Calcular valor da diária;\n10- Sair;");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 0:
                    reserva.cadastrarHospede();
                    Console.WriteLine("Hóspede cadastrado com sucesso!");
                    break;
                case 1:
                    reserva.cadastrarSuite();
                    Console.WriteLine("Suite cadastrada com sucesso!");
                    break;
                case 2:
                    Console.WriteLine("O hotel possui " + reserva.obterQuantidadeHospedes() + " hóspedes");
                    break;
                case 3:
                    Console.WriteLine("O valor a ser pago é de R$ " + reserva.calcularValorDiaria());
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        } while (opcao != 10);
    }
}