using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController: ControllerBase
    {
        private readonly DataContext contexto;

        public EventoController(DataContext contexto){
            this.contexto = contexto;
        }

        [HttpGet]
        public IEnumerable<Evento> Get(){
            return contexto.Eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id){
            return contexto.Eventos.FirstOrDefault(x => x.EventoId == id);
        }

    }
}