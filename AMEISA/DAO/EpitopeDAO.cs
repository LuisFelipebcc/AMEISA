using AMEISA.Model;
using DAL.Persistence;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMEISA.DAO
{
    public class EpitopeDAO : Conexao
    {
        public List<EpitopeDTO> Epitopes()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SELECT epitopeid,linearsequence FROM saga.epitope");

            try
            {
                //Abrir Conexao
                AbrirConexao();
                Cmd = new MySqlCommand(sb.ToString(), Con);
                Dr = Cmd.ExecuteReader();

                List<EpitopeDTO> Listofdto = new List<EpitopeDTO>();

                while (Dr.Read())
                {
                    EpitopeDTO temp = new EpitopeDTO
                    {
                        IdEpitope = Convert.ToInt32(Dr["epitopeid"]),
                        LinearSequence = Convert.ToString(Dr["linearsequence"]),
                    };

                    Listofdto.Add(temp);
                }

                return Listofdto;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao listar os Sequence Translation: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
