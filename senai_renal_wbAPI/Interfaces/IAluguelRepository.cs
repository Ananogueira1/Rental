using senai_renal_wbAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_renal_wbAPI.Interfaces
{
    interface IAluguelRepository
    {
        /// <summary>
        /// listar todos os alugueis
        /// </summary>
        /// <returns></returns>
        List<AluguelDomain> todosAlugueis();

        /// <summary>
        /// algueis cadastrados
        /// </summary>
        /// <param name="dadosAluguel">objeto aluguel a ser cadastrado</param>
        void cadastrarAluguel(AluguelDomain dadosAluguel);


        /// <summary>
        /// buscar aluguel por id
        /// </summary>
        /// <param name="idAluguel">obejeto para ser buscado</param>
        /// <returns></returns>
        AluguelDomain buscarAluguelPorId(int idAluguel);

        /// <summary>
        /// atualizar aluguel por id
        /// </summary>
        /// <param name="idAluguel">objeto as ser localizado</param>
        /// <param name="dadosAluguel">objeto a ser atualizado</param>
        void atualizarAluguelPorId(int idAluguel,AluguelDomain dadosAluguel);

        /// <summary>
        /// deletar aluguel por id
        /// </summary>
        /// <param name="idAluguel"> objeto a ser deletado </param>
        void deletarAluguelPorId(int idAluguel);
       


    
    }
}
