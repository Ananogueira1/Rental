using senai_renal_wbAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_renal_wbAPI.Interfaces
{
    interface IMarcaRepository
    {
        /// <summary>
        /// listar todas as marcas
        /// </summary>
        /// <returns></returns>
        List<MarcaDomain> todasAsMarcas();
        

        /// <summary>
        /// cadastrar marca
        /// </summary>
        /// <param name="dadosMarca">objeto a ser cadastrado</param>
        void cadastrarMarca(MarcaDomain dadosMarca);

        /// <summary>
        /// buscar marca por id
        /// </summary>
        /// <param name="idAluguel">objeto a ser buscado</param>
        /// <returns></returns>
        MarcaDomain buscarMarcaPorId(int idMarca);

        /// <summary>
        /// atualizar marca por id
        /// </summary>
        /// <param name="dadosMarca">objeto a ser localizado</param>
        /// <param name="idMarca">objeto a ser atualizado</param>
        void atualizarMarcaPorId(MarcaDomain dadosMarca, int idMarca);

        /// <summary>
        /// deletar marca por id
        /// </summary>
        /// <param name="idMarca">objeto a ser deletado</param>
        void deletarMarcaPorID(int idMarca);
    }
}
