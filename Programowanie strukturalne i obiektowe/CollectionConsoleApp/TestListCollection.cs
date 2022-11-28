using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp
{
    class TestListCollection
    {
        public void FirstTest()
        {
            Random random = new Random();

            List<int> listOfInts = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                listOfInts.Add(random.Next(1, 11));
            }
            Console.WriteLine("Lista int'ów:");
            foreach (int element in listOfInts)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();

            List<double> listOfDoubles = new List<double>();
            for (int i = 0; i < 5; i++)
            {
                double number = random.NextDouble() * 10 + 1;
                number = Math.Round(number, 4);

                listOfDoubles.Add(number);
            }
            Console.WriteLine("Lista double'ów:");
            foreach (double element in listOfDoubles)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine();

            int max = MaxFromInts(listOfInts);
            Console.WriteLine("Max w liście int'ów: " + max);

            double maxDouble = MaxFromInts(listOfDoubles);
            Console.WriteLine("Max w liście double'ów: " + maxDouble);
        }

        private int MaxFromInts(List<int> list)
        {
            int max = list[0];
            foreach (int item in list)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }
    }
}
