using System;

namespace _0._6c
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1, b = 2, c = 3;

            Console.WriteLine("Hodnoty proměnných jsou: ");
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            Console.Write("Hodnoty proměnných jsou: "); //špatně
            Console.Write(a);
            Console.Write(b);
            Console.Write(c);

            Console.WriteLine();

            Console.WriteLine("Hodnoty proměnných jsou: ");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);

            Console.WriteLine("a = 1"); //nezobrazuje hodnotu a, ale text 

            Console.WriteLine("Hodnoty všech proměnných jsou: " + a + b + c); //špatně

            Console.WriteLine("Hodnoty všech proměnných jsou: " + a + ", " + b + ", " + c + ".");

            Console.WriteLine("Hodnoty všech proměnných jsou: 1, 2, 3."); //špatně
            Console.WriteLine("Hodnoty všech proměnných jsou: a, b, c"); // špatně
            Console.WriteLine("---------------------------------------");
            c = a + b;
            Console.WriteLine("Součet čísel " + a + "+" + b + "=" + c);
            c = a - b;
            Console.WriteLine("Rozdíl čísel " + a + "-" + b + "=" + c);
            c = a * b;
            Console.WriteLine("Součin čísel " + a + "*" + b + "=" + c);
            c = a / b;
            Console.WriteLine("Podíl čísel " + a + "/" + b + "=" + c);









            Console.ReadLine();
        }
    }
}
