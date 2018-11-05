using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMEISA.DAO
{
    class TranslationsDAO
    {
        public static List<SequenceTranslation> read(int idOrganism, String orderby)
        {

            //initialize the return variable
            List<SequenceTranslation> Listofdto = new ArrayList<>();
            //start the read process
            //get the connection
            Connection conn = Conexao.getConnection();
            //Prepair the sql statement with or w/o filters.
            String sql = "SELECT feature_qualifier.value as 'translation', sequence.id as 'idsequence' FROM saga.feature_qualifier JOIN saga.sequence_feature  ON feature_qualifier.idsequence_feature = sequence_feature.id JOIN saga.sequence ON sequence_feature.idsequence = sequence.id WHERE feature_qualifier.name='translation' AND sequence.idorganism=" + idOrganism;
            if (!orderby.equals(""))
            {
                sql += " ORDER BY " + orderby;
            }
            try
            {
                //prepare the read statement
                PreparedStatement stmt = conn.prepareStatement(sql);
                // Run the statement and store the result into the resultset;
                ResultSet rs = stmt.executeQuery();
                // seach into the result set for results and place these into the Result List
                while (rs.next())
                {
                    SequenceTranslation temp = new SequenceTranslation(rs.getInt("idsequence"), rs.getString("translation"));
                    Listofdto.add(temp);
                }
                //disposes the result set
                rs.close();
                //closes the statement
                stmt.close();
            }
            catch (Exception ex)
            {
                //reading error
                log.writeOnLog("Data reading error. Please verify data into the database.");

            }
            //return what was readed. If nothing is found, return null.
            return Listofdto;
        }

        public static List<SequenceTranslation> readMapping(int idOrganism, String orderby, String EpitopeLinearSequence)
        {

            //initialize the return variable
            List<SequenceTranslation> Listofdto = new ArrayList<>();
            //start the read process
            //get the connection
            Connection conn = Conexao.getConnection();
            //Prepair the sql statement with or w/o filters.
            String sql = "SELECT feature_qualifier.value as 'translation', sequence.id as 'idsequence' FROM saga.feature_qualifier JOIN saga.sequence_feature  ON feature_qualifier.idsequence_feature = sequence_feature.id JOIN saga.sequence ON sequence_feature.idsequence = sequence.id WHERE feature_qualifier.name='translation' AND sequence.idorganism=" + idOrganism + " AND feature_qualifier.value LIKE '%" + EpitopeLinearSequence + "%'";
            if (!orderby.equals(""))
            {
                sql += " ORDER BY " + orderby;
            }
            try
            {
                //prepare the read statement
                PreparedStatement stmt = conn.prepareStatement(sql);
                // Run the statement and store the result into the resultset;
                ResultSet rs = stmt.executeQuery();
                // seach into the result set for results and place these into the Result List
                while (rs.next())
                {
                    SequenceTranslation temp = new SequenceTranslation(rs.getInt("idsequence"), rs.getString("translation"));
                    Listofdto.add(temp);
                }
                //disposes the result set
                rs.close();
                //closes the statement
                stmt.close();
            }
            catch (Exception ex)
            {
                //reading error
                log.writeOnLog("Data reading error. Please verify data into the database.");

            }
            //return what was readed. If nothing is found, return null.
            return Listofdto;
        }

        public static List<SequenceTranslation> readNonMapped(int idOrganism, String orderby)
        {

            //initialize the return variable
            List<SequenceTranslation> Listofdto = new ArrayList<>();
            //start the read process
            //get the connection
            DbConnection conn = Conexao.getConnection();
            //Prepair the sql statement with or w/o filters.
            String sql = "SELECT feature_qualifier.value as 'translation', sequence.id as 'idsequence' FROM saga.feature_qualifier JOIN saga.sequence_feature  ON feature_qualifier.idsequence_feature = sequence_feature.id JOIN saga.sequence ON sequence_feature.idsequence = sequence.id WHERE feature_qualifier.name='translation' AND sequence.idorganism=" + idOrganism + " AND sequence_feature.idsequence not in (select idsequence from epitope_map)";
            if (!orderby.equals(""))
            {
                sql += " ORDER BY " + orderby;
            }
            try
            {
                //prepare the read statement
                PreparedStatement stmt = conn.prepareStatement(sql);
                // Run the statement and store the result into the resultset;
                ResultSet rs = stmt.executeQuery();
                // seach into the result set for results and place these into the Result List
                while (rs.next())
                {
                    SequenceTranslation temp = new SequenceTranslation(rs.getInt("idsequence"), rs.getString("translation"));
                    Listofdto.add(temp);
                }
                //disposes the result set
                rs.close();
                //closes the statement
                stmt.close();
            }
            catch (Exception ex)
            {
                //reading error
                log.writeOnLog("Data reading error. Please verify data into the database.");

            }
            //return what was readed. If nothing is found, return null.
            return Listofdto;
        }


    }
}
