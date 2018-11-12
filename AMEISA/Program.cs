using AMEISA.DAO;
using AMEISA.Model;
using System;
using System.Collections.Generic;

namespace AMEISA
{
    class Program
    {
        List<EpitopeDTO> lstEpi = new List<EpitopeDTO>();
        List<SequenceTranslationDTO> lstTrans = new List<SequenceTranslationDTO>();
        EpitopeDAO epitopeDAO = new EpitopeDAO();
        static void Main(string[] args)
        {


            compararStrs();

        }

        private static void compararStrs()
        {
            List<EpitopeDTO> lstEpi = new List<EpitopeDTO>();
            List<SequenceTranslationDTO> lstTrans = new List<SequenceTranslationDTO>();
            EpitopeDAO epitopeDAO = new EpitopeDAO();
            TranslationsDAO translationsDAO = new TranslationsDAO();
            lstEpi = epitopeDAO.Epitopes();
            //lstTrans = translationsDAO.


            foreach (EpitopeDTO item in lstEpi)
            {
                lstTrans = translationsDAO.Listar(item.IdEpitope, string.Empty);
                foreach (SequenceTranslationDTO item2 in lstTrans)
                {
                    if (item.LinearSequence == item2.Translation)
                    {

                    }
                }
            }

            //foreach (string strSecond in lstTrans)
            //{
            //if (strFirst.Length > strSecond.Length)
            //{
            //    strSecond = strSecond.PadRight(strFirst.Length, '-');
            //}
            //else
            //{
            //    strFirst.PadRight(strSecond.Length, '-');
            //}

            //for (int i = 0; i < strFirst.Length; i++)
            //{
            //    if (strFirst[i] != strSecond[i])
            //    {
            //        Console.Write("[" + strFirst[i] + "]");
            //    }
            //    else
            //    {
            //        Console.Write(strFirst[i]);
            //    }
            //}

            //Console.WriteLine();

            //for (int i = 0; i<strSecond.Length; i++)
            //{
            //    if (strFirst[i] != strSecond[i])
            //    {
            //        Console.Write("[");+ strSecond[i] + "]");
            //    }
            //    else
            //    {
            //        Console.Write(strSecond[i]);
            //    }
            //}

            Console.Read();
            //}
        }
    }
}
