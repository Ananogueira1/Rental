using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_renal_wbAPI.Domains
{
    public class AluguelDomain
    {
        public Int16 idAluguel { get; set; }
        public Int16 idVeiculo { get; set; }
        public Int16 idCliente { get; set; }
        public DateTime dataRetirada { get; set; }
        public DateTime dataDevolucao { get; set; }

    }
}
