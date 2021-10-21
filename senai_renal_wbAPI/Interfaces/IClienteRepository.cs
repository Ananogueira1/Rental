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
        /// <summary>
        /// listar todos os clientes
        /// </summary>
        /// <returns></returns>
        List<ClienteDomain> todosClientes();

        /// <summary>
        /// cadastrar cliente
        /// </summary>
        /// <param name="dadosCliente">objeto a ser cadastrado</param>
        void cadastrarCliente(ClienteDomain dadosCliente);

        //buscar por id
        // class = devolver cliente

        /// <summary>
        /// buscar cliente po id
        /// </summary>
        /// <param name="idCliente">objeto a ser localizado</param>
        /// <returns></returns>
        ClienteDomain buscarClientePorId(int idCliente);

        //DELETAR POR ID
        // OQ VAI VOLTAR
        //NOME DO SERVIÇO
        // OQ VAI RECEBER 

        /// <summary>
        /// atualizar cliente por id
        /// </summary>
        /// <param name="idCliente">objeto a ser localizado</param>
        /// <param name="dadosCliente">objeto a ser atualizado</param>
        void atualizarClientePorId(int idCliente, ClienteDomain dadosCliente);

        /// <summary>
        /// objeto a ser deletado
        /// </summary>
        /// <param name="id"></param>
        void deletarPorid(int id);





    }
}
