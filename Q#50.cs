 using System;

namespace Mine
{
    class Major
    {
        static void Main(string[] args)
        {
            double c = 0;
            double b = 0;
            float x = 1;
            float y = 2;
            float z = 3;
            Console.WriteLine(x*x+3*x-4); // (a)
            Console.WriteLine((x+y)*z); // (b)
            Console.WriteLine((x+3*y)/(2*x-y)); // (c)
            Console.WriteLine(1/(x*x+x+3)); // (d)
            Console.WriteLine((x+y)/7); // (e)
            Console.WriteLine((2*b)*(c*c*c)); // (f)
            float a = (3*y)/(5-z);
            Console.WriteLine(a); // (g)
            double sqrt;
            double area = 100;
            sqrt = Math.Sqrt(area);
            b = area*sqrt;
            Console.WriteLine(b); // (h)
            Console.WriteLine((x+32)/(y-32)-(x-2*y)); // (i)
            c = (3*x*y*z+Math.Pow(z, 9))/(7*x*z-5*Math.Sqrt(y+z));
            Console.WriteLine(c); // (g)
        }
    }
}
