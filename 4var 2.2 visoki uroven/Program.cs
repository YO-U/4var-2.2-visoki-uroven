using System;

namespace _4var_2._2_visoki_uroven
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите число копеек");
                double x = double.Parse(Console.ReadLine());
                if (x >= 11 && x <= 14) Console.WriteLine("{0} копеек", x);
                else
                {
                    double y = x % 10;
                    switch (y)
                    {
                        case 0: Console.WriteLine("{0} копеек", x); break;
                        case 1: Console.WriteLine("{0} копейка", x); break;
                        case 2: case 3: case 4: Console.WriteLine("{0} копейки", x); break;
                        default: Console.WriteLine("{0} копеек", x); break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
