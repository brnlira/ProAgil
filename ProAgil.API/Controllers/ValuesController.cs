using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProAgil.API.model;

namespace ProAgil.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Evento>> Get()
        {
            return new Evento[] {
                new Evento() {
                    EventoId = 1,
                    Local = "Online",
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    Tema = "Desprogramação Neurobiolócica",
                    QtdPessoas = 40,
                    Lote = "1º Lote"
                },
                    new Evento() {
                    EventoId = 2,
                    Local = "Online",
                    DataEvento = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy"),
                    Tema = "Tameana",
                    QtdPessoas = 50,
                    Lote = "1º Lote"
                },
                    new Evento() {
                    EventoId = 3,
                    Local = "Online",
                    DataEvento = DateTime.Now.AddDays(15).ToString("dd/MM/yyyy"),
                    Tema = "Thetahealing",
                    QtdPessoas = 150,
                    Lote = "1º Lote"
                }
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Evento> Get(int id)
        {
            return new Evento[] {
                new Evento() {
                    EventoId = 1,
                    Local = "Online",
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    Tema = "Desprogramação Neurobiolócica",
                    QtdPessoas = 40,
                    Lote = "1º Lote"
                },
                    new Evento() {
                    EventoId = 2,
                    Local = "Online",
                    DataEvento = DateTime.Now.AddDays(7).ToString("dd/MM/yyyy"),
                    Tema = "Tameana",
                    QtdPessoas = 50,
                    Lote = "1º Lote"
                },
                    new Evento() {
                    EventoId = 3,
                    Local = "Online",
                    DataEvento = DateTime.Now.AddDays(15).ToString("dd/MM/yyyy"),
                    Tema = "Thetahealing",
                    QtdPessoas = 150,
                    Lote = "1º Lote"
                }
            }.FirstOrDefault(x => x.EventoId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
