using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaConsoleApp
{
    public class Point
    {
        private int x, y;

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value > 0)
                {
                    y = value;
                }
                else
                    throw new ArgumentException("Nie można ustawić wartości ujemnych");
            }
        }

        public double DistanceFromCenter
        {
            get
            {
                return Math.Sqrt(x * x + y * y);
            }
        }

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int x, int y)
        {
            
            SetX(x);
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine(x.ToString() + ", " + y.ToString());
        }

        //w języku c++
        public void SetX(int a)
        {
            if (a > 0)
            {
                x = a;
            }
            else
                throw new ArgumentException("Nie można ustawić wartości ujemnych");
        }

        public int GetX() 
        { 
            return x;
        }

    }
}
