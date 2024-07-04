namespace CellPhone.Models;
public sealed class Iphone : Smartphone
{
    public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
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
            throw new Exception("Nome de aplicativo não reconhecido!");
        }
        else
        {
            Console.WriteLine("Aplicativo instaldo com sucesso!");
        }
    }
}
