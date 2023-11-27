using GeometriaConsoleApp;

Point p = new Point(5, 8);
p.Display();
Console.WriteLine("Odległość od punktu (0,0) wynosi " + p.DistanceFromCenter);
//p.x = 5;
//p.SetX(5);
//p.y = 8;
//p.Y = 8;
p.Display();
Console.WriteLine("Odległość od punktu (0,0) wynosi " + p.DistanceFromCenter);
//p.DistanceFromCenter = 5; //niepoprawna ponieważ brak w propertisie SET

Point p2 = new Point();
//p2.x = 68;
p2.SetX(68);
//p2.y = 78;
p2.Y = 78;
p2.Display();



/*double x, y;

x = 5;
y = 6;

Display(x, y);
Display2();

double x2=87, y2 = 174;
Display(y2, x2);
Display3();

void Display(double a, double b)
{
    Console.WriteLine(a.ToString()+ ", " + b.ToString());
}

void Display2()
{
    Console.WriteLine(x.ToString() + ", " + y.ToString());
}

void Display3()
{
    Console.WriteLine(x2.ToString() + ", " + y2.ToString());
}


x = -547582;*/