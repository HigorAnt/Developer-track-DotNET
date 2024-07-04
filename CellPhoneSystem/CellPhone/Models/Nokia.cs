namespace CellPhone.Models;
public sealed class Nokia : Smartphone
{
    public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
    {
        Numero = numero;
        Modelo = modelo;
        IMEI = imei;
        Memoria = memoria;
    }
    public override void InstalarAplicativo(string nome)
    {
        if (nome == null)
        {
            throw new ArgumentNullException("Aplicativo não instalado!");
        }
        else
        {
            Console.WriteLine("Aplicativo instalado com sucesso!");
        }
    }
}
