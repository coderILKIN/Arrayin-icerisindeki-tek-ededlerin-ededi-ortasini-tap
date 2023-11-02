using System;

namespace Arrayin_icerisindeki_tek_ededlerin_ededi_ortasini_tap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 3, 4, 6, 7, 8, 9 ,10, 11};

            int count = 0;

            int total = 0;


            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    total += numbers[i];
                    count++;
                }
            }

            Console.WriteLine("Arrayde icerisindeki tek ededlerin ededi ortasi" + " : " + total / count);
        }
    }
}
