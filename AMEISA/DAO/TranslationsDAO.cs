using AMEISA.Model;
using DAL.Persistence;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace AMEISA.DAO
{
    class TranslationsDAO : Conexao
    {
        static Conexao conexao = new Conexao();
        static MySqlCommand cmd = new MySqlCommand();
        public string mensagem = string.Empty;


        public List<SequenceTranslationDTO> Listar(int idOrganism, String orderby)
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SELECT feature_qualifier.value AS 'translation',");
            sb.AppendLine("       sequence.id AS 'idsequence'");
            sb.AppendLine("FROM saga.feature_qualifier");
            sb.AppendLine("JOIN saga.sequence_feature ON feature_qualifier.idsequence_feature = sequence_feature.id");
            sb.AppendLine("JOIN saga.sequence ON sequence_feature.idsequence = sequence.id");
            sb.AppendLine("WHERE feature_qualifier.name='translation'");
            sb.AppendLine("  AND sequence.idorganism =" + idOrganism);
            if (!orderby.Equals(""))
            {
                sb.AppendLine(" ORDER BY " + orderby);
            }
            try
            {
                //Abrir Conexao
                AbrirConexao();
                Cmd = new MySqlCommand(sb.ToString(), Con);
                Dr = Cmd.ExecuteReader();

                List<SequenceTranslationDTO> Listofdto = new List<SequenceTranslationDTO>();

                while (Dr.Read())
                {
                    SequenceTranslationDTO temp = new SequenceTranslationDTO
                    {
                        IdSequence = Convert.ToInt32(Dr["idsequence"]),
                        Translation = Convert.ToString(Dr["translation"]),
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

        public List<SequenceTranslationDTO> readMapping(int idOrganism, string orderby, string EpitopeLinearSequence)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SELECT feature_qualifier.value AS 'translation',");
            sb.AppendLine("       sequence.id AS 'idsequence'");
            sb.AppendLine("FROM saga.feature_qualifier");
            sb.AppendLine("JOIN saga.sequence_feature ON feature_qualifier.idsequence_feature = sequence_feature.id");
            sb.AppendLine("JOIN saga.sequence ON sequence_feature.idsequence = sequence.id");
            sb.AppendLine("WHERE feature_qualifier.name='translation'");
            sb.AppendLine("  AND sequence.idorganism = " + idOrganism);
            sb.AppendLine("  AND feature_qualifier.value LIKE '%" + EpitopeLinearSequence + "%'");
            if (!orderby.Equals(""))
            {
                sb.AppendLine(" ORDER BY " + orderby);
            }
            try
            {
                //Abrir Conexao
                AbrirConexao();
                Cmd = new MySqlCommand(sb.ToString(), Con);
                Dr = Cmd.ExecuteReader();

                List<SequenceTranslationDTO> Listofdto = new List<SequenceTranslationDTO>();

                while (Dr.Read())
                {
                    SequenceTranslationDTO temp = new SequenceTranslationDTO
                    {
                        IdSequence = Convert.ToInt32(Dr["idsequence"]),
                        Translation = Convert.ToString(Dr["translation"]),
                    };

                    Listofdto.Add(temp);
                }

                return Listofdto;
            }
            catch (Exception ex)
            {
                throw new Exception("Data reading error.Please verify data into the database. : " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        public List<SequenceTranslationDTO> readNonMapped(int idOrganism, String orderby)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SELECT feature_qualifier.value AS 'translation',");
            sb.AppendLine("       sequence.id AS 'idsequence'");
            sb.AppendLine("FROM saga.feature_qualifier");
            sb.AppendLine("JOIN saga.sequence_feature ON feature_qualifier.idsequence_feature = sequence_feature.id");
            sb.AppendLine("JOIN saga.sequence ON sequence_feature.idsequence = sequence.id");
            sb.AppendLine("WHERE feature_qualifier.name='translation'");
            sb.AppendLine("  AND sequence.idorganism = " + idOrganism);
            sb.AppendLine("  AND sequence_feature.idsequence NOT IN");
            sb.AppendLine("    (SELECT idsequence");
            sb.AppendLine("     FROM epitope_map)");
            if (!orderby.Equals(""))
            {
                sb.AppendLine(" ORDER BY " + orderby);
            }
            try
            {
                //Abrir Conexao
                AbrirConexao();
                Cmd = new MySqlCommand(sb.ToString(), Con);
                Dr = Cmd.ExecuteReader();

                List<SequenceTranslationDTO> Listofdto = new List<SequenceTranslationDTO>();

                while (Dr.Read())
                {
                    SequenceTranslationDTO temp = new SequenceTranslationDTO
                    {
                        IdSequence = Convert.ToInt32(Dr["idsequence"]),
                        Translation = Convert.ToString(Dr["translation"]),
                    };

                    Listofdto.Add(temp);
                }

                return Listofdto;
            }
            catch (Exception ex)
            {
                throw new Exception("Data reading error.Please verify data into the database. : " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

        //public static List<SequenceTranslation> readNonMapped(int idOrganism, String orderby)
        //{

        //    //initialize the return variable
        //    List<SequenceTranslation> Listofdto = new ArrayList<>();
        //    //start the read process
        //    //get the connection
        //    DbConnection conn = Conexao.getConnection();
        //    //Prepair the sql statement with or w/o filters.
        //    String sql = "SELECT feature_qualifier.value as 'translation', sequence.id as 'idsequence' FROM saga.feature_qualifier JOIN saga.sequence_feature  ON feature_qualifier.idsequence_feature = sequence_feature.id JOIN saga.sequence ON sequence_feature.idsequence = sequence.id WHERE feature_qualifier.name='translation' AND sequence.idorganism=" + idOrganism + " AND sequence_feature.idsequence not in (select idsequence from epitope_map)";
        //    if (!orderby.equals(""))
        //    {
        //        sql += " ORDER BY " + orderby;
        //    }
        //    try
        //    {
        //        //prepare the read statement
        //        PreparedStatement stmt = conn.prepareStatement(sql);
        //        // Run the statement and store the result into the resultset;
        //        ResultSet rs = stmt.executeQuery();
        //        // seach into the result set for results and place these into the Result List
        //        while (rs.next())
        //        {
        //            SequenceTranslation temp = new SequenceTranslation(rs.getInt("idsequence"), rs.getString("translation"));
        //            Listofdto.add(temp);
        //        }
        //        //disposes the result set
        //        rs.close();
        //        //closes the statement
        //        stmt.close();
        //    }
        //    catch (Exception ex)
        //    {
        //        //reading error
        //        log.writeOnLog("Data reading error. Please verify data into the database.");

        //    }
        //    //return what was readed. If nothing is found, return null.
        //    return Listofdto;
        //}


    }
}
