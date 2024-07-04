using CellPhone.Models;

public class Program
{
    public static void Main(string[] args)
    {
        int opcao;
        Nokia nokia;
        Iphone iphone;

        List<Smartphone> smartphones = new List<Smartphone>();

        do
        {
            Console.WriteLine("Qual a marca do aparelho?\n1- Nokia;\n2- Iphone\n0- Encerrar sistema");
            opcao = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o número do aparelho?");
            string numero = Console.ReadLine();
            Console.WriteLine("Qual o modelo? do aparelho?");
            string modelo = Console.ReadLine();
            Console.WriteLine("Qual o IMEI do aparelho?");
            string imei = Console.ReadLine();
            Console.WriteLine("Qual a memória do aparelho, em GB?");
            int memoria = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                nokia = new Nokia(numero, modelo, imei, memoria);
                smartphones.Add(nokia);
            }
            else
            {
                iphone = new Iphone(numero, modelo, imei, memoria);
                smartphones.Add(iphone);
            }
        } while (opcao != 0);
    }
}