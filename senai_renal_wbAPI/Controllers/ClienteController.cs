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
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private IClienteRepository _clienteRepository { get; set; }

        public ClienteController()
        {
            _clienteRepository = new ClienteRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            List<ClienteDomain> listarCliente = _clienteRepository.todosClientes();

            return Ok(listarCliente);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            ClienteDomain buscarClientePorId = _clienteRepository.buscarClientePorId(id);

            if (buscarClientePorId == null)
            {
                return NotFound("Id do cliente não foi encontrado ");
            }

            return Ok(buscarClientePorId);
        }

        [HttpPost]
        public IActionResult Post(ClienteDomain dadosCliente)
        {
            _clienteRepository.cadastrarCliente(dadosCliente);

            return Ok("cliente cadastrado");

        }

        [HttpPut("{idCliente}")]
        public IActionResult PutById(int idCliente, ClienteDomain clienteAtualizado)
        {
            ClienteDomain clienteBuscado = _clienteRepository.buscarClientePorId(clienteAtualizado.idCliente);

            if (clienteBuscado != null)
            {
                _clienteRepository.atualizarClientePorId(idCliente, clienteAtualizado);

                return Ok("dados do cliente atualizado");
            }

            return NotFound("dados do  cliente não cadastrado");

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _clienteRepository.deletarPorid(id);

            return NoContent();
        }
    }
}
