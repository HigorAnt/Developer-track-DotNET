using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Extensions;
using System.Globalization;
using TarefaSistema.Context;
using TarefaSistema.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TarefaSistema.Controllers;
[ApiController]
[Route("controller")]
public class TarefaController : ControllerBase
{
    public readonly TarefaContext _context;
    public TarefaController(TarefaContext context)
    {
        _context = context;
    }
    [HttpPost]
    public IActionResult CriarTarefa(Tarefa tarefa)
    {
        _context.Add(tarefa);
        _context.SaveChanges();

        return Ok();
    }
    [HttpGet("{id}")]
    public IActionResult ObterPorId(int id)
    {
        var tarefa = _context.Tarefas.Find(id);

        if (tarefa == null)
        {
            return NotFound();
        }

        return Ok(tarefa);
    }
    [HttpGet("ObterTodos")]
    public IActionResult ObterTodos()
    {
        var tarefa = _context.Tarefas;

        return Ok(tarefa);
    }
    [HttpGet("ObterPorTitulo")]
    public IActionResult ObterPorTitulo(string nome)
    {
        var tarefas = _context.Tarefas.Where(h => h.Titulo.Contains(nome));
        
        return Ok(tarefas);
    }
    [HttpGet("ObterPorData")]
    public IActionResult ObterPorData(DateTime data)
    {
        var tarefa = _context.Tarefas.Where(h => h.Data ==  data);

        return Ok(tarefa);
    }
    [HttpGet("ObterPorStatus")]
    public IActionResult ObterPorStatus(int status)
    {
        var tarefa = _context.Tarefas.Where(h => (int)h.Status == status);

        return Ok(tarefa);
    }
    [HttpGet("ObterPorDescricao")]
    public IActionResult ObtetPorDescricao(string descricao)
    {
        var tarefa = _context.Tarefas.Where(h => h.Descricao.Contains(descricao)); 

        return Ok(tarefa);
    }
    [HttpPut]
    public IActionResult AtualizarTarefa(int id, Tarefa tarefa)
    {
        var tarefaBanco = _context.Tarefas.Find(id);

        if (tarefaBanco == null)
        {
            return NotFound();
        }

        tarefaBanco.Titulo = tarefa.Titulo;
        tarefaBanco.Descricao = tarefa.Descricao;
        tarefaBanco.Data = tarefa.Data;
        tarefaBanco.Status = tarefa.Status;

        _context.Tarefas.Update(tarefaBanco);
        _context.SaveChanges();

        return Ok(tarefaBanco);
    }
    [HttpDelete("{id}")]
    public IActionResult DeletarTarefa(int id)
    {
        var tarefa = _context.Tarefas.Find(id);
        
        if(tarefa == null)
        {
            return NotFound();
        }

        _context.Tarefas.Remove(tarefa);
        _context.SaveChanges();

        return NoContent();
    }
}
