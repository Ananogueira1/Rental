using senai_renal_wbAPI.Domains;
using senai_renal_wbAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai_renal_wbAPI.Repositories
{
    /// <summary>
    /// classe responsavel pelo repositorio cliente
    /// </summary>
    public class ClienteRepository : IClienteRepository
    {
        /// <summary>
        /// string de conexao com o bd, e recebe alguns parametros 
        /// data source = nome do servidor
        /// inital catalog = nome do banco de dados
        /// user id = sa; pdw = senai@132 
        /// integrated security = true
        /// </summary>
        private string stringConexao = "data source=DESKTOP-KF9VIHQ; initial catalog=Empresa_Veiculos; integrated security=true";


        public void deletarPorid(int id)
        {
            throw new NotImplementedException();
        }

        public void cadastrarCliente(ClienteDomain dados)
        {
            throw new NotImplementedException();
        }

        public List<ClienteDomain> todosClientes()
        {
            List<ClienteDomain> todosClientes = new List<ClienteDomain>();

            //se comunicar com o banco de dados
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                con.Open();

                string querySelectAll = "select idCliente, nomeCliente,cpf from cliente";

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    SqlDataReader leitura = cmd.ExecuteReader();

                    while (leitura.Read())
                    {
                        ClienteDomain cliente = new ClienteDomain()
                        {
                            idCliente = Convert.ToInt16(leitura[0]),
                            nomeCliente = leitura[1].ToString(),
                            cpf = leitura[2].ToString(),
                        };

                        //adicionar na lista
                        todosClientes.Add(cliente);
                    }
                }
            }

            // mandar uma instrução para o banco de dados executar
            // ler oq o bd respondeu
            // adicionar banco de dados na lista "todosClientes"
            
            // retorna a lista
            return todosClientes;
        }

        public ClienteDomain buscarClientePorId(int idCliente)
        {
            throw new NotImplementedException();
        }

        public void atualizarClientePorId(int idCliente, ClienteDomain dadosCliente)
        {
            throw new NotImplementedException();
        }
    }
}
