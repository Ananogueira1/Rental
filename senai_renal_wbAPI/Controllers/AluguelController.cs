using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai_renal_wbAPI.Domains;
using senai_renal_wbAPI.Interfaces;
using senai_renal_wbAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_renal_wbAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AluguelController : ControllerBase
    {
        private IAluguelRepository _AluguelRepository { get; set; }

        public AluguelController()
        {
            _AluguelRepository = new AluguelRepository();
        }

        public IActionResult Get()
        {
            List<AluguelDomain> ListarAluguel = _AluguelRepository.todosAlugueis();

            return Ok(ListarAluguel);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            AluguelDomain buscarAluguelPorId = _AluguelRepository.buscarAluguelPorId(id);

            if (buscarAluguelPorId == null)
            {
                return NotFound("Id do aluguel não foi encontrado ");
            }

            return Ok(buscarAluguelPorId);
        }

        //[HttpPost]
        //public IActionResult Post(AluguelDomain novoAluguel)
        //{
        //    _AluguelRepository.atualizarAluguelPorId(novoAluguel);

        //    return Ok("Aluguel cadastrado");

        //}

        [HttpPut("{idAluguel}")]
        public IActionResult PutById(int idAluguel, AluguelDomain AluguelAtualizado)
        {
            AluguelDomain aluguelBuscado = _AluguelRepository.buscarAluguelPorId(idAluguel);

            if (aluguelBuscado != null)
            {
                _AluguelRepository.atualizarAluguelPorId(idAluguel, AluguelAtualizado);

                return Ok("dados do aluguel atualizado");

            }

            return NotFound("dados do aluguel não cadastrado");

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _AluguelRepository.deletarAluguelPorId(id);

            return NoContent();
        }
    }
}
