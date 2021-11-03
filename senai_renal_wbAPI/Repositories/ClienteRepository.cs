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
        private string stringConexao = "data source=NOTE0113G1\\SQLEXPRESS; initial catalog=Empresa_Veiculos; integrated security=true";


        public void deletarPorid(int idCliente)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                con.Open();

                string queryDelete = "DELETE FROM CLIENTE WHERE idCliente = @idCliente";

                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    cmd.Parameters.AddWithValue("@idCliente", idCliente);



                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void cadastrarCliente(ClienteDomain dadosCliente)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                con.Open();

                string queryInsert = "INSERT INTO CLIENTE (nomeCliente, cpf) VALUES (@nomeCliente, @cpf)";

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@nomeCliente", dadosCliente.nomeCliente);
                    cmd.Parameters.AddWithValue("@cpf", dadosCliente.cpf);

                    cmd.ExecuteNonQuery();
                }
            }

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
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                con.Open();

                string querySelectAll = "select IdCliente, nomeCliente, cpf from CLIENTE where idCliente= 2";
                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {

                    SqlDataReader leitura = cmd.ExecuteReader();
                    if (leitura.Read())
                    {
                        ClienteDomain cliente = new ClienteDomain
                        {
                            idCliente = Convert.ToInt16(leitura[0]),
                            nomeCliente = Convert.ToString(leitura[1]),
                            cpf = Convert.ToString(leitura[2])
                        };
                        return cliente;
                    }
                                      
                }
                return null;
            }

        }

        public void atualizarClientePorId(int idCliente, ClienteDomain dadosCliente)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                con.Open();


                string queryUpdate = "UPDATE CLIENTE SET nomeCliente ='" + dadosCliente.nomeCliente + "', cpf= '" + dadosCliente.cpf + "' WHERE idCliente =" + idCliente;
                using (SqlCommand cmd = new SqlCommand(queryUpdate, con))
                {
                    cmd.Parameters.AddWithValue("@idcliente", dadosCliente.idCliente);
                    cmd.Parameters.AddWithValue("@nomeCliente", dadosCliente.nomeCliente);
                    cmd.Parameters.AddWithValue("@cpf", dadosCliente.cpf);

                    cmd.ExecuteNonQuery();

                }
        }
        }
    }
   
}

