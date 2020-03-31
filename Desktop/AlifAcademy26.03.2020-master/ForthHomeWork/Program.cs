using System;

namespace ForthHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            double purchase = 657;
            if (purchase > 1000)
                purchase -= purchase * 0.05;
            else if (purchase > 500)
                purchase -= purchase * 0.03;
            System.Console.WriteLine($"Cost of your purchase with discount is {purchase}");
            int a = 2, b = 2, c = 8, d = 9;
            if (a == b && b == c && c == d)
                System.Console.WriteLine($" a*b*c*d = {a * b * c * d}");
            else if (a <= b && b <= c && c <= d)
                System.Console.WriteLine("Numbers are ascending");
            else if (c <= a && c <= b && c <= d)
                System.Console.WriteLine($"Min = {c}");
            else if (b <= a && b <= c && b <= d)
                System.Console.WriteLine($"Min = {b}");
            else  if (a <= b && a <= c && a <= d) 
                System.Console.WriteLine($"Min = {a}");
            else System.Console.WriteLine($"Min = {d}");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (b >= a){
                b += a;
                a = b - a;
                b = b - a;
            }
            if (c >= b){
                c += b;
                b = c - b;
                c = c - b;
            }
            if (b >= a){
                b += a;
                a = b - a;
                b = b - a;
            }
            System.Console.WriteLine($"a = {a}, b = {b}, c = {c}");
            Console.ReadKey();
        }
    }
}
