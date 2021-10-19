using senai_renal_wbAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_renal_wbAPI.Interfaces
{
    interface IEmpresaRepository
    {

        //buscar todas as empresas

        List<EmpresaDomain> buscarTodasEmpresas();

        //cadastrar todas as empresas 

        void cadastrarEmpresa(EmpresaDomain dadosEmpresa);

        //buscar empresa por id

        EmpresaDomain buscarEmpresaPorId(int idEmpresa);

        //deletar empresa por id

        void deletarEmpresaPorId(int idEmpresa);


    }
}
