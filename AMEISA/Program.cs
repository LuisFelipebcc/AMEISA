using AMEISA.DAO;
using AMEISA.Model;
using System;
using System.Collections.Generic;

namespace AMEISA
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Vai tomar no cu";
            string stn = "mar";

            char[] text1 = str.ToCharArray();
            char[] text2 = stn.ToCharArray();

            for (int i = 0; i < text1.Length; i++)
            {

            }

            Console.Write(str.IndexOf("uis"));

            //compararStrs();

            Console.Read();
        }

        private static void CompararStrs()
        {
            List<EpitopeDTO> lstEpi = new List<EpitopeDTO>();
            List<SequenceTranslationDTO> lstTrans = new List<SequenceTranslationDTO>();
            EpitopeDAO epitopeDAO = new EpitopeDAO();
            List<object> listMath = new List<object>();
            TranslationsDAO translationsDAO = new TranslationsDAO();
            lstEpi = epitopeDAO.Epitopes();
            lstTrans = translationsDAO.Listar();
            int contador = 0;

            foreach (EpitopeDTO item in lstEpi)
            {
                foreach (SequenceTranslationDTO item2 in lstTrans)
                {
                    contador = 0;
                    for (int i = 0; i < item.LinearSequence.Length; i++)
                    {
                        if (item2.Translation.IndexOf(item.LinearSequence) != -1)
                        {
                            Console.WriteLine("Eu sou igual");
                        }
                        if (item2.Translation.IndexOf(item.LinearSequence) == -1)
                        {
                            Console.WriteLine("Imprementar para verificar se não validar posições");
                        }
                        //item2.Translation.IndexOf(item.LinearSequence));

                        //if (item2.Translation.IndexOf(item.LinearSequence[i].ToString()) > 0)
                        //if (item2.Translation.Contains(item.LinearSequence[i].ToString()))
                        //{
                        //    contador++;
                        //    Console.Write(item.LinearSequence[i]);
                        //}
                    }
                    Console.WriteLine();
                }





                //foreach (EpitopeDTO item in lstEpi)
                //{
                //    foreach (SequenceTranslationDTO item2 in lstTrans)
                //    {
                //        contador = 0;
                //        int i = 0;
                //        while (contador <= 2 || i < item.LinearSequence.Length)
                //        {
                //            if (!item2.Translation.Contains(item.LinearSequence[i].ToString()))
                //            {
                //                contador++;
                //            }
                //            i++;
                //        }
                //        if (contador == 0)
                //        {

                //        }
                //        else if (contador == 1)
                //        {

                //        }
                //        else
                //        {

                //        }

                //        Console.Write("  Tamanho Total: " + item.LinearSequence.Length + " Encontrados: " + contador);
                //        Console.WriteLine();
                //    }
                //}

                Console.Read();
            }
        }

    }
}
