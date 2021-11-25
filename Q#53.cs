using System;

namespace New_folder__3_
{
    class Program
    {
        static void Main(string[] args)
        {
            // part (a)
            int x = 20, y = 35;
            x = y++ + x++;
            y = ++y + ++x;
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine();
            {
            // part (b)
            int a = 10, b = 15;
            x = a++;
            y = ++b;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine();  
            }
            {
              // part (c)
            int c = 10;
            c++;
            Console.WriteLine(c);
            Console.WriteLine();   
            }
            {
              // part (d)
            int c = 10;
            Console.WriteLine(c++);
            Console.WriteLine();  
            }
            {
             // part (e)
            int n = 10;
            int d = 0;
            d = n--;
            Console.WriteLine(d);
            Console.WriteLine();   
            }
            {
              // part (f)
            int i = 5, j = 6, k = 7, n= 3;
            Console.WriteLine(i + j * k - k % n);
            Console.WriteLine(i / n);
            Console.WriteLine();   
            }
            {
                //part (g)
                 int g;
                float f;
                f = 3;
            
               
            

                // part (h)
                int a = 6;
                Console.WriteLine(a);
                Console.ReadLine();

                  a = a + 3;
                Console.WriteLine(a);
                Console.ReadLine();

                 a -= 5;
                Console.WriteLine(a);
                Console.ReadLine();
                
                a++;
                Console.WriteLine(a);
                Console.ReadLine();
            

            }
        }

    }
}
