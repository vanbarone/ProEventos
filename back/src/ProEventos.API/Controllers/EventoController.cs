using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController: ControllerBase
    {
        public IEnumerable<Evento> eventos = new Evento[] {
            new Evento(){
                EventoId = 1,
                Local = "Belo Horizonte",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                Tema = "Angular 11 e .Net 5", 
                QtdePessoas = 250,
                Lote = "1o lote",
                ImagemURL = "foto.png"
            },

            new Evento(){
                EventoId = 2,
                Local = "São Paulo",
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                Tema = "Angular 11 e .Net 5", 
                QtdePessoas = 100,
                Lote = "1o lote",
                ImagemURL = "foto.png"
            }
        };

        public EventoController(){

        }

        [HttpGet]
        public IEnumerable<Evento> Get(){
            return eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id){
            return eventos.FirstOrDefault(x => x.EventoId == id);
        }

    }
}