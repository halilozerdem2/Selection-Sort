using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 7, 9, 16, 2, 31, 6, 97, 6, 101, 121 };
            
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            SortTheListBySelection(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]+ " ");
            }
            Console.ReadLine();

        }

        // Selection Sort
        public static int[] SortTheListBySelection(int[] aNumbers)
        {
            int temp;

            for (int i = 0; i < aNumbers.Length; i++)
            {
                for (int j = i+1; j < aNumbers.Length; j++)
                {
                    if (aNumbers[i] < aNumbers[j])
                        continue;

                    else
                    {
                        temp = aNumbers[i];
                        aNumbers[i] = aNumbers[j];
                        aNumbers[j] = temp;
                    }
                }
            }
            return aNumbers;
        } 
    }
}
