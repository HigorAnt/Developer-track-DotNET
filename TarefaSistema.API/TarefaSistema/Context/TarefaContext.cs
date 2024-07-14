using Microsoft.EntityFrameworkCore;
using TarefaSistema.Model;

namespace TarefaSistema.Context;
public class TarefaContext : DbContext
{
    public TarefaContext(DbContextOptions<TarefaContext> options) : base(options)
    {
        
    }
    public DbSet<Tarefa> Tarefas { get; set; }
}
