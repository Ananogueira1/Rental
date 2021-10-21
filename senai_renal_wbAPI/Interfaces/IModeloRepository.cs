using senai_renal_wbAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_renal_wbAPI.Interfaces
{
    interface IModeloRepository
    {
        /// <summary>
        /// listar todos os modelos
        /// </summary>
        /// <returns></returns>
        List<ModeloDomain> todosOsModelos();

        /// <summary>
        /// cadastrar os modelos
        /// </summary>
        /// <param name="dadosModelo">objeto a ser cadastrado</param>
        void cadastrarModelo(ModeloDomain dadosModelo);

        /// <summary>
        /// buscar modelo por id
        /// </summary>
        /// <param name="idModelo">objeto a ser buscado</param>
        /// <returns></returns>
        ModeloDomain buscarModeloPorId(int idModelo);

        /// <summary>
        /// atualizar modelo por id 
        /// </summary>
        /// <param name="dadosModelo">objeto a ser localizado</param>
        /// <param name="idModelo">objeto a ser atualizado</param>
        void atualizarModeloPorId(ModeloDomain dadosModelo, int idModelo);

        /// <summary>
        /// deletar modelo por id
        /// </summary>
        /// <param name="idModelo">objeto a ser deletado</param>
        void deletarModeloPorId(int idModelo);


    }
}
