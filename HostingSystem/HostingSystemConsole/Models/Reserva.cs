namespace HostingSystemConsole.Models;
public class Reserva
{
    private List<Pessoa> hospedes = new List<Pessoa>();
    private List<Suite> suites = new List<Suite>();
    private Pessoa hospede;
    private Suite suite;
    private int diasReservados, capacidade;
    private string nome, sobrenome, tipoSuite;
    private decimal valorDiaria;
    public void cadastrarHospede()
    {
        Console.WriteLine("Qual o nome do hóspede?");
        nome = Console.ReadLine();
        Console.WriteLine("Qual o sobrenome do hóspede?");
        sobrenome = Console.ReadLine();
        hospede = new Pessoa(nome, sobrenome);
        hospedes.Add(hospede);
    }
    public void cadastrarSuite()
    {
        Console.WriteLine("Qual o tipo de suíte?");
        tipoSuite = Console.ReadLine();
        Console.WriteLine("Qual a capacidade da suíte?");
        capacidade = int.Parse(Console.ReadLine());
        Console.WriteLine("Qual a diária da suíte?");
        valorDiaria = decimal.Parse(Console.ReadLine());
        suite = new Suite(tipoSuite, capacidade, valorDiaria);
        suites.Add(suite);
    }
    public int obterQuantidadeHospedes()
    {
        return hospedes.Count;
    }
    public decimal calcularValorDiaria()
    {
        Console.WriteLine("Qual o hóspede?");
        foreach (Pessoa hospede in hospedes)
        {
            Console.WriteLine(hospede.Nome.ToString());
        }
        int hospedeSaida = int.Parse(Console.ReadLine());

        for(int i = 0; i < hospedes.Count; i++)
        {
            if(hospedeSaida == i)
            {
                hospedes.Remove(hospede);
                break;
            }
        }

        Console.WriteLine("Quantos dias o hóspede passou na súite?");
        diasReservados = int.Parse(Console.ReadLine());

        if(diasReservados > 10)
        {
            return (valorDiaria * diasReservados) * (9/10);
        }
        else
        {
            return valorDiaria * diasReservados;
        }
    }
}
