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
        public IActionResult buscarTodos() {


           List <ClienteDomain> buscarTodos = _clienteRepository.todosClientes();


            return Ok(buscarTodos);
        
            
        }






    }
}
