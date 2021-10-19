using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_renal_wbAPI.Domains
{
    public class VeiculoDomain
    {
        public Int16 idVeiculo { get; set; }
        public Int16 idEmpresa { get; set; }
        public Int16 idModelo { get; set; }
        public String placa { get; set; }
    }
}
