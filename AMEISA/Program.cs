using System;

namespace AMEISA
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esse vai a String Principal
            string sequence_1;
            //Sequence_2 vai ser utilizada para fazer a comparação com a Sequence que é a string base.
            string sequence_2;

            sequence_1 = Console.ReadLine();
            sequence_2 = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(sequence_1 + "     " + sequence_2);

            Console.WriteLine();
            Console.WriteLine(string.Compare(strA: sequence_1, strB: sequence_2, ignoreCase: true));
            Console.WriteLine(string.Equals(a: sequence_1, b: sequence_2));
            Console.WriteLine(string.CompareOrdinal(sequence_1, sequence_2));

            bool output = string.Compare("Luis", "Luiz", StringComparison.CurrentCultureIgnoreCase) == 0;
            Console.WriteLine(output);
            output = string.Compare("Luis", "LUiz", true) == 0;
            Console.WriteLine(output);
            output = "Luis".Equals("luiz", StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(output);



            //if ()
            //{

            //}

            Console.Read();
        }
    }
}
