using senai_renal_wbAPI.Domains;
using senai_renal_wbAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace senai_renal_wbAPI.Repositories
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private string stringConexao = "data source=DESKTOP - KF9VIHQ; initial catalog = Empresa_Veiculos; integrated security=true";
        private string dadosVeiculos;

        public void atualizarVeiculoPorId(int idVeiculo, VeiculoDomain dadosVeiculo)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                con.Open();
               
                string queryUpdate = @"UPDATE VEICULO
                SET idEmpresa= '" + dadosVeiculos + "'", idModelo = "'" + dadosVeiculo + "', placa= '" + dadosVeiculo + "'" +
                " WHERE  idVeiculo = '" + dadosVeiculos + "'";
            }
        }

        public VeiculoDomain buscarVeiculoPorId(int idVeiculo)
        {
            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                con.Open();

                string querrySelectAll = "select idVeiculo, idEmpresa, idModelo, placa from veiculo where idVeiculo = 3";

                using (SqlCommand cmd = new SqlCommand(querrySelectAll, con))
                {
                    SqlDataReader leitura = cmd.ExecuteReader();

                    if (leitura.Read())
                    {
                        VeiculoDomain veiculo = new VeiculoDomain()
                        {
                            idVeiculo = Convert.ToInt16(leitura[0]),
                            idEmpresa = Convert.ToInt16(leitura[1]),
                            idModelo = Convert.ToInt16(leitura[2]),
                            placa = Convert.ToString(leitura[3])
                        };

                        return veiculo;
                    }
                }

                return null;
            }

        }

        public void CadastarVeiculo(VeiculoDomain dadosVeiculo)
        {

            using (SqlConnection con = new SqlConnection(stringConexao))
            {

                con.Open();

                string queryInsert = "INSERT INTO veiculo (idModelo, placa,idEmpresa) values('" + dadosVeiculo.idModelo + "'" + ",'" + dadosVeiculo.placa + "'" + ",'" + dadosVeiculo.idEmpresa + "' )";

                using (SqlCommand cmd = new SqlCommand(queryInsert, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void deletarVeiculoPorId(int idVeiculo)
        {
            throw new NotImplementedException();
        }

        public List<VeiculoDomain> todosOsVeiculos()
        {
            List<VeiculoDomain> todosOsVeiculos = new List<VeiculoDomain>();

            using (SqlConnection con = new SqlConnection(stringConexao))
            {
                con.Open();

                string querySelectAll = "select idVeiculo, idEmpresa,idModelo, placa from veiculo";

                using (SqlCommand cmd = new SqlCommand(querySelectAll, con))
                {
                    SqlDataReader leitura = cmd.ExecuteReader();

                    while (leitura.Read())
                    {
                        VeiculoDomain veiculo = new VeiculoDomain()
                        {
                            idVeiculo = Convert.ToInt16(leitura[0]),
                            idEmpresa = Convert.ToInt16(leitura[1]),
                            idModelo = Convert.ToInt16(leitura[2]),
                            placa = Convert.ToString(leitura[3])
                        };

                        //adicionar todos os veiculos na lista 
                        todosOsVeiculos.Add(veiculo);
                    }
                }

                return todosOsVeiculos;
            }
        }
    }
}
