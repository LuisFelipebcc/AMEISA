using AMEISA.Model;
using DAL.Persistence;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMEISA.DAO
{
    public class RanqueEpitoposDAO : Conexao
    {
        public void Inserir(RanqueEpitoposDTO ranqueEpitopos)
        {
            try
            {
                //Abrir Conexao
                AbrirConexao();
                Cmd = new MySqlCommand("insert into Coordenador (IdEpitopo, IdTranslations, Sequencen) values(@v1, @v2, @v3)", Con);

                Cmd.Parameters.AddWithValue("@v1", ranqueEpitopos.IdEpitopo);
                Cmd.Parameters.AddWithValue("@v2", ranqueEpitopos.IdTranslations);
                Cmd.Parameters.AddWithValue("@v3", ranqueEpitopos.Sequencen);

                Cmd.ExecuteNonQuery(); //executada esse nosso metodo!
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao inserir o Curso: " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
