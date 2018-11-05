using System;
using System.Collections.Generic;

namespace AMEISA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lstEpi = new List<string>(0);
            List<string> lstTrans = new List<string>(0);

            #region Preenchimento lista
            lstTrans.Add("Alana"); lstEpi.Add("Alexa");
            lstTrans.Add("Carolina"); lstEpi.Add("Carlota");
            lstTrans.Add("Antónia"); lstEpi.Add("Angelina");
            lstTrans.Add("Áurea"); lstEpi.Add("Aurora");
            lstTrans.Add("Betina"); lstEpi.Add("Benedita");
            lstTrans.Add("Brenda"); lstEpi.Add("Briana");
            lstTrans.Add("Carmo"); lstEpi.Add("Camila");
            lstTrans.Add("Cecília"); lstEpi.Add("Celina");
            lstTrans.Add("Concha"); lstEpi.Add("Corália");
            lstTrans.Add("Eleonor"); lstEpi.Add("Eloisa");
            lstTrans.Add("Edna"); lstEpi.Add("Edite");
            lstTrans.Add("Elena"); lstEpi.Add("Elisa");
            lstTrans.Add("Francisca"); lstEpi.Add("Frederica");
            lstTrans.Add("Helena "); lstEpi.Add("Heloísa");
            lstTrans.Add("Isabela"); lstEpi.Add("Isadora");
            lstTrans.Add("Laila"); lstEpi.Add("Lara");
            lstTrans.Add("Laura"); lstEpi.Add("Larissa");
            lstTrans.Add("Laura"); lstEpi.Add("Lavínia");
            lstTrans.Add("Lis"); lstEpi.Add("Lília");
            lstTrans.Add("Lúcia"); lstEpi.Add("Luísa");
            lstTrans.Add("Luna"); lstEpi.Add("Luz");
            lstTrans.Add("Madalena"); lstEpi.Add("Mafalda");
            lstTrans.Add("Madel"); lstEpi.Add("Manon");
            lstTrans.Add("Margarida"); lstEpi.Add("Mariana");
            lstTrans.Add("Marta"); lstEpi.Add("Mariana");
            lstTrans.Add("Maude"); lstEpi.Add("Máxima");
            lstTrans.Add("Melina"); lstEpi.Add("Melissa");
            lstTrans.Add("Mia"); lstEpi.Add("Miriam");
            lstTrans.Add("Perla"); lstEpi.Add("Petra");
            lstTrans.Add("Radija"); lstEpi.Add("Raissa");
            lstTrans.Add("Rebeca"); lstEpi.Add("Renata");
            lstTrans.Add("Sara"); lstEpi.Add("Salomé");
            lstTrans.Add("Valentina"); lstEpi.Add("Valéria");
            lstTrans.Add("Valentina"); lstEpi.Add("Valquíria");
            lstTrans.Add("Vitória"); lstEpi.Add("Viviana");
            lstTrans.Add("Yara"); lstEpi.Add("Yasmin");
            #endregion

            foreach (string str in lstEpi)
            {
                compararStrs(str, lstTrans);
            }
        }

        private static void compararStrs(string strFirst, List<string> lstTrans)
        {
            foreach (string strSecond in lstTrans)
            {
                if (strFirst.Length > strSecond.Length)
                {
                    strSecond = strSecond.PadRight(strFirst.Length, '-');
                }
                else
                {
                    strFirst.PadRight(strSecond.Length, '-');
                }

                for (int i = 0; i < strFirst.Length; i++)
                {
                    if (strFirst[i] != strSecond[i])
                    {
                        Console.Write("[" + strFirst[i] + "]");
                    }
                    else
                    {
                        Console.Write(strFirst[i]);
                    }
                }

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
            }
        }
    }
