using System;

namespace fifthHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //first
            int a = 5, b = 11, sum = 0, i, j, k;
            for (i = a; i <= b ; i ++)
                sum += i;
            System.Console.WriteLine(sum);


            for (i = (a / 2) * 2 + 1; i <= b; i += 2)
            System.Console.WriteLine($"i = {i}");

            //second a
            int length = 5, weight = 8;
            for ( i = 1; i <= length; i ++){
                if (i == 1 || i == length) {
                    for (j = 1; j <= weight; j++) 
                        System.Console.Write("*");
                }
                else {
                    for ( j = 1; j <= weight; j++) {
                        if (j == 1|| j == weight)
                           System.Console.Write("*");
                        else System.Console.Write(" ");;
                    }
                }
                System.Console.Write("\n");
            }


            // second b
            for (i = 0; i <= length; i ++){
                for (j = 0; j <= weight; j++){
                    if (j == (weight/2 - i) || j == (weight/2 + i) || i == weight/2  )
                        System.Console.Write("*");
                else    System.Console.Write(" ");
                }
                System.Console.Write("\n");
               }

            // second c
            for ( i = 0; i <= length; i ++){
                for ( j = 0; j <= weight; j++){
                    if (j == 0 || j == i || (i == length && j <= weight/2))
                        System.Console.Write("*");
                    else System.Console.Write(" ");
                }
                System.Console.Write("\n");
            }

            // second d
            for (i = 0; i <= length/2; i ++){
                for (j = 0; j <= weight; j++){
                    if (j == (weight/2 - i) || j == (weight/2 + i))
                        System.Console.Write("*");
                else    System.Console.Write(" ");
                }
                System.Console.Write("\n");
               }
            for (i = length/2 - 1; i >= 0; i--){
                for (j = 0; j <= weight; j++){
                    if (j == (weight/2 - i) || j == (weight/2 + i))
                        System.Console.Write("*");
                else    System.Console.Write(" ");
                }
                System.Console.Write("\n");
               }

            //third
            double s = 1000, p = 3.5;
            for (k = 0; s <= 1100; k++)
                s += p * s / 100;
            System.Console.WriteLine($"\n s = {s}, k = {k}");
            Console.ReadKey();
        }
    }
}
