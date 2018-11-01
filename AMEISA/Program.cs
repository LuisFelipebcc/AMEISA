using System;

namespace AMEISA
{
    class Program
    {
        static void Main(string[] args)
        {
            string strFirst = "Felipe Barretto";
            string strSecond = "Luis Felipe";

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
            for (int i = 0; i < strFirst.Length; i++)
            {


                if (strFirst[i] != strSecond[i])
                {

                    Console.Write("[" + strSecond[i] + "]");
                    //strSecond[i]
                }
                else
                {

                    Console.Write(strSecond[i]);
                }
            }

            // Compare a string to itself.
            //Console.WriteLine(CompareStrings(strFirst, strFirst));

            //Console.WriteLine(CompareStrings(strFirst, strSecond));
            //Console.WriteLine(CompareStrings(strFirst, strThird));

            // Compare a string to another string that varies only by case.
            //Console.WriteLine(CompareStrings(strFirst, strFourth));
            //Console.WriteLine(CompareStrings(strFourth, strFirst));

            //if ()
            //{

            //}

            Console.Read();
        }

        //private static string CompareStrings(string str1, string str2)
        //{
        //    // Compare the values, using the CompareTo method on the first string.
        //    int cmpVal = str1.CompareTo(str2);

        //    if (cmpVal == 0) // The strings are the same.
        //        return "As seqüências de caracteres ocorrem na mesma posição na ordem de classificação.";
        //    else if (cmpVal < 0)
        //        return "A primeira cadeia precede a segunda na ordem de classificação.";
        //    else
        //        return "A primeira seqüência segue o segundo na ordem de classificação.";
        //}
    }
}
