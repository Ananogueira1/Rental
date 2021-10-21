using senai_renal_wbAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_renal_wbAPI.Interfaces
{
    interface IVeiculoRepository
    {
        /// <summary>
        /// listar todos os veiculos
        /// </summary>
        /// <returns></returns>
        List<VeiculoDomain> todosOsVeiculos();

        /// <summary>
        /// cadastrar veiculo
        /// </summary>
        /// <param name="idVeiculo">objeto a ser cadastrado </param>
        void CadastarVeiculo(VeiculoDomain dadosVeiculo);

        /// <summary>
        /// buscar bveiculo por id 
        /// </summary>
        /// <param name="idVeiculo">objeto a ser localizado</param>
        /// <returns></returns>
        VeiculoDomain buscarVeiculoPorId(int idVeiculo);

        /// <summary>
        /// atualizar veiculo por id
        /// </summary>
        /// <param name="idVeiculo">objeto a ser localizado</param>
        /// <param name="dadosVeiculo">objeto a ser atualizado</param>
        void atualizarVeiculoPorId(int idVeiculo, VeiculoDomain dadosVeiculo);

        /// <summary>
        /// deletar veiculo por id
        /// </summary>
        /// <param name="idVeiculo">objeto a ser deletado</param>
        void deletarVeiculoPorId(int idVeiculo);
    }
}
