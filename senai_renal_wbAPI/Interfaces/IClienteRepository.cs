using senai_renal_wbAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_renal_wbAPI.Interfaces
{
    interface IClienteRepository
    {
        // Oq vai ser feito
        // Se vamos devolver uma informação ou não


        // void = nao vai devolver nada
        List<ClienteDomain> todosClientes();

        void inserirCliente(ClienteDomain dados);

        //buscar por id
        // class = devolver cliente

        ClienteDomain buscarPorId(int id);

        //DELETAR POR ID
        // OQ VAI VOLTAR
        //NOME DO SERVIÇO
        // OQ VAI RECEBER 

        void deletarPorid(int id);





    }
}
