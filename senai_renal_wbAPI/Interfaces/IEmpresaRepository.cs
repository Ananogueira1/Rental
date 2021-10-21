using senai_renal_wbAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_renal_wbAPI.Interfaces
{
    interface IEmpresaRepository
    {

        /// <summary>
        /// buscar todas as empresas
        /// </summary>
        /// <returns></returns>

        List<EmpresaDomain> buscarTodasEmpresas();


        /// <summary>
        /// cadastrar todas as empresas
        /// </summary>
        /// <param name="dadosEmpresa"></param>
        void cadastrarEmpresa(EmpresaDomain dadosEmpresa);

        /// <summary>
        /// buscar empresa por id
        /// </summary>
        /// <param name="idEmpresa"></param>
        /// <returns></returns>

        EmpresaDomain buscarEmpresaPorId(int idEmpresa);

        /// <summary>
        /// atualizar empresa por id
        /// </summary>
        /// <param name="idEmpresa">objeto a ser localizado</param>
        /// <param name="dadosEmpresa">obejto a ser atualizado</param>
        void atualizarEmpresaPorId(int idEmpresa, EmpresaDomain dadosEmpresa);

        /// <summary>
        /// deletar empresa por id
        /// </summary>
        /// <param name="idEmpresa"></param>

        void deletarEmpresaPorId(int idEmpresa);


    }
}
