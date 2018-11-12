using System;
using MySql.Data.MySqlClient;

namespace DAL.Persistence
{
    public class Conexao
    {
        //Atributos:
        protected MySqlConnection Con;
        protected MySqlCommand Cmd;
        protected MySqlDataReader Dr;

        //Metodos -Abrir Conexao
        protected void AbrirConexao()
        {
            try
            {
                //Connection String
                Con = new MySqlConnection("user id=root;server=localhost;persistsecurityinfo=True;database=saga;password=Wijpjivq16;");
                Con.Open();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }

        //Metodo - Fechar Conexao
        protected void FecharConexao()
        {
            try
            {
                Con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
