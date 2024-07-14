using System.ComponentModel.DataAnnotations;
using TarefaSistema.Model.Enum;

namespace TarefaSistema.Model;
public class Tarefa
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Titulo { get; set; }
    public string Descricao { get; set; }
    public DateTime Data { get; set; }
    [Required]
    public StatusTarefa Status { get; set; }
}
