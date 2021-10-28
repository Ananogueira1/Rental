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
    public class VeiculoController : ControllerBase
    {
        private IVeiculoRepository _veiculoRepository { get; set; }

        public VeiculoController()
        {
            _veiculoRepository = new VeiculoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<VeiculoDomain> listarVeiculos = _veiculoRepository.todosOsVeiculos();

            return Ok(listarVeiculos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            VeiculoDomain buscarVeiculoPorId = _veiculoRepository.buscarVeiculoPorId(id);

            if (buscarVeiculoPorId == null)
            {
                return NotFound("Id do veiculo não foi encontrado ");
            }

            return Ok(buscarVeiculoPorId);
        }

        [HttpPost]
        public IActionResult Post(VeiculoDomain novoVeiculo)
        {
            _veiculoRepository.CadastarVeiculo(novoVeiculo);

            return Ok("veiculo cadastrado");

        }

        [HttpPut("{idVeiculo}")]
        public IActionResult PutById(int idVeiculo, VeiculoDomain veiculoAtualizado)
        {
            VeiculoDomain veiculoBuscado = _veiculoRepository.buscarVeiculoPorId(veiculoAtualizado.idVeiculo);

            if (veiculoBuscado != null)
            {
                _veiculoRepository.atualizarVeiculoPorId(idVeiculo, veiculoAtualizado);

                return Ok("dados do veiculo atualizado");

            }

            return NotFound("dados do veiculo não cadastrado");
            
        }

        [HttpDelete ("{id}")]
        public IActionResult Delete(int id )
        {
            _veiculoRepository.deletarVeiculoPorId(id);

            return NoContent();
        }
    }
}
