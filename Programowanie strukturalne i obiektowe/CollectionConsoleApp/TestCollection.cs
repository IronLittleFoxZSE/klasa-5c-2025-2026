using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionConsoleApp
{
    class TestCollection
    {
        public void TestArrayCollection()
        {
            /*
            C++:
            typ nazwa[rozmiar];

            int tab1[5];

            tab1[2] = 2137;

            const int rozmiar = 19;
            //rozmiar = 17;
            int tab2[rozmiar];
            for (int i = 0; i < rozmiar; i++)
            {

            }


            */
            int[] arrayOfNumbers = new int[10];
            arrayOfNumbers[5] = 2137;

            Random random = new Random();
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                arrayOfNumbers[i] = random.Next();
            }

            foreach (int item in arrayOfNumbers)
            {
                Console.Write(item + ", ");
            }


        }
    }
}
