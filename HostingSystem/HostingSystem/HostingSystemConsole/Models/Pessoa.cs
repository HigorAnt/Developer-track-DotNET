namespace HostingSystemConsole.Models;
public sealed class Pessoa
{
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public Pessoa(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }
}
