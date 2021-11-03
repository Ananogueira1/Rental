using senai_renal_wbAPI.Domains;
using senai_renal_wbAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai_renal_wbAPI.Repositories
{
    public class AluguelRepository : IAluguelRepository
    {
        private string stringConexao = "data source=NOTE0113G1\\SQLEXPRESS; initial catalog=Empresa_Veiculos; integrated security=true";

        public void atualizarAluguelPorId(int idAluguel, AluguelDomain dadosAluguel)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                con.Open();

                string queryUpdateBody = "UPDATE ALUGUEL SET idVeiculo = @idVeiculo, idCliente = @idCliente, dataRetirada = @dataRetirada, dataDevolucao= @dataDevolucao WHERE idAluguel = @idAluguel";
                using (SqlCommand cmd = new SqlCommand(queryUpdateBody, con))
                {
                    cmd.Parameters.AddWithValue("@idVeiculo", dadosAluguel.idVeiculo);
                    cmd.Parameters.AddWithValue("@dataRetirada", dadosAluguel.dataRetirada);
                    cmd.Parameters.AddWithValue("@dataDevolucao", dadosAluguel.dataDevolucao);
                    cmd.Parameters.AddWithValue("@idCliente", dadosAluguel.idCliente);
                    cmd.Parameters.AddWithValue("@idAluguel", dadosAluguel.idAluguel);

                    cmd.ExecuteNonQuery();
                }

            }
        }   

        public AluguelDomain buscarAluguelPorId(int idAluguel)
        { 
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                con.Open();

                string querySelectAll = "select idAluguel, idVeiculo, idCliente, dataRetirada, dataDevolucao from aluguel where idAluguel= @idAluguel";

                using (SqlCommand cmd = new SqlCommand (querySelectAll, con))
                {
                    cmd.Parameters.AddWithValue("@idAluguel", idAluguel);

                    SqlDataReader leitura = cmd.ExecuteReader();

                    if (leitura.Read())
                    {
                       AluguelDomain aluguel = new AluguelDomain()
                        {
                            idAluguel = Convert.ToInt16(leitura[0]),
                            idVeiculo = Convert.ToInt16(leitura[1]),
                            idCliente = Convert.ToInt16(leitura[2]),
                            dataRetirada = Convert.ToDateTime(leitura[3]),
                            dataDevolucao = Convert.ToDateTime(leitura[4])
                        };

                        return aluguel;
                    }

                    return null;
                 
                }
            }
        }

        public void cadastrarAluguel(AluguelDomain dadosAluguel)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryInsert = "INSERT INTO ALUGUEL (idVeiculo, idCliente,dataRetirada,dataDevolucao) VALUES (@idCliente,@idVeiculo,@dataRetirada,@dataDevolucao)";
                con.Open();

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.Parameters.AddWithValue("@idVeiculo", dadosAluguel.idVeiculo);
                    cmd.Parameters.AddWithValue("@idCliente", dadosAluguel.idCliente);
                    cmd.Parameters.AddWithValue("@dataRetirada", dadosAluguel.dataRetirada);
                    cmd.Parameters.AddWithValue("@dataDevolucao", dadosAluguel.dataDevolucao);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void deletarAluguelPorId(int idAluguel)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                string queryDelete = "DELETE FROM ALUGUEL WHERE idAluguel = @idAluguel";

                using (SqlCommand cmd = new SqlCommand(queryDelete, con))
                {
                    cmd.Parameters.AddWithValue("@idAluguel", idAluguel);

                    con.Open();

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<AluguelDomain> todosAlugueis()
        {
            List<AluguelDomain> todosOsAlugueis = new List<AluguelDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                con.Open();
                
                string querySelectAll = "select idAluguel, idVeiculo, idCliente, dataRetirada, dataDevolucao from aluguel";
                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {

                    SqlDataReader leitura = cmd.ExecuteReader();

                    while (leitura.Read())
                    {
                        AluguelDomain aluguel = new AluguelDomain()
                        {
                            idAluguel = Convert.ToInt16(leitura[0]),
                            idVeiculo = Convert.ToInt16(leitura[1]),
                            idCliente = Convert.ToInt16(leitura[2]),
                            dataRetirada = Convert.ToDateTime(leitura[3]),
                            dataDevolucao = Convert.ToDateTime(leitura[4])
                        };

                        //adicionar todos os alugueis na lista 
                        todosOsAlugueis.Add(aluguel);
                    }

                }

                return todosOsAlugueis;
            }
        
        }
    }
}
