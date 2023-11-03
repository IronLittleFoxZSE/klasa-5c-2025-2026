using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaConsoleApp
{
    public class Point
    {
        public int x, y;

        public void Display()
        {
            Console.WriteLine(x.ToString() + ", " + y.ToString());
        }
    }
}
