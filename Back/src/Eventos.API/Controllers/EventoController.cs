using Eventos.API.Data;
using Eventos.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{    
    private readonly DataContext _context;
    public EventoController(DataContext context)
    {
        _context = context;
    }

    // public IEnumerable<Evento> _evento = new Evento[] {
    //         new Evento(){
    //             EventoId = 1,
    //             Tema = "GGWP e suas variações",
    //             Local = "Rio de Janeiro",
    //             Lote = 1,
    //             QtdPessoas = 3000,
    //             DataEvento = DateTime.Now.AddDays(2).ToString("dd/mm/yyyy"),
    //             ImagemURL = "foto.png"
    //         },
    //         new Evento(){
    //             EventoId = 2,
    //             Tema = "GLHF",
    //             Local = "Rio",
    //             Lote = 4,
    //             QtdPessoas = 456,
    //             DataEvento = DateTime.Now.AddDays(3).ToString("dd/mm/yyyy"),
    //             ImagemURL = "foto.png"
    //         }
    //     }; 

    [HttpGet]
    public IEnumerable<Evento> Get() 
    {
        return _context.Eventos;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _context.Eventos.Where(Evento => Evento.EventoId == id);
    }

    [HttpPost]
    public string Post()
    {
        return "exemplo de post";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"exemplo de put com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"exemplo de Delete com id = {id}";
    }
}
