using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Stringarra = new string[5];
            Stringarra[0] = "pirmas";
            Stringarra[1] = "antras";
            Stringarra[2] = "trecias";
            Stringarra[3] = "ketvirts";
            Stringarra[4] = "penkts";

            foreach (string s in Stringarra)
            {
                Console.WriteLine(s);
            }
            Int32[] intarra;

            intarra = new int[21];
            intarra[0] = 0;
            intarra[1] = 1;
            intarra[2] = 2;
            intarra[3] = 3;
            intarra[4] = 4;
            intarra[5] = 5;
            intarra[6] = 6;
            intarra[7] = 7;
            intarra[8] = 8;
            intarra[9] = 9;
            intarra[10] = 10;
            intarra[11] = 11;
            intarra[12] = 12;
            intarra[13] = 13;
            intarra[14] = 14;
            intarra[15] = 15;
            intarra[16] = 16;
            intarra[17] = 17;
            intarra[18] = 18;
            intarra[19] = 19;
            intarra[20] = 20;

            Console.WriteLine(intarra[0]);
            Console.WriteLine(intarra[1]);
            Console.WriteLine(intarra[2]);
            Console.WriteLine(intarra[3]);
            Console.WriteLine(intarra[4]);
            Console.WriteLine(intarra[5]);
            Console.WriteLine(intarra[6]);
            Console.WriteLine(intarra[7]);
            Console.WriteLine(intarra[8]);
            Console.WriteLine(intarra[9]);
            Console.WriteLine(intarra[10]);
            Console.WriteLine(intarra[11]);
            Console.WriteLine(intarra[12]);
            Console.WriteLine(intarra[13]);
            Console.WriteLine(intarra[14]);
            Console.WriteLine(intarra[15]);
            Console.WriteLine(intarra[16]);
            Console.WriteLine(intarra[17]);
            Console.WriteLine(intarra[18]);
            Console.WriteLine(intarra[19]);
            Console.WriteLine(intarra[20]);

            Array.Reverse(intarra);

            foreach (int A in intarra)
            {
                Console.WriteLine(A);
            }
            // pradzioj masciau komplikuotai ir ismasciau taip kaip virsuje, bet galima ir greiciau, beje size reikejo daryti 21
            int[] numbers = new int[21] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            Array.Reverse(numbers);

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}
