using System;

namespace AMEISA
{
    class Program
    {
        static void Main(string[] args)
        {
            string strFirst = "Felipe Barretto";
            string strSecond = "Felipe Barreto";

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

            Console.WriteLine();

            for (int i = 0; i < strSecond.Length; i++)
            {
                if (strFirst[i] != strSecond[i])
                {
                    Console.Write("[" + strSecond[i] + "]");
                }
                else
                {
                    Console.Write(strSecond[i]);
                }
            }

            Console.Read();
        }

    }
}
