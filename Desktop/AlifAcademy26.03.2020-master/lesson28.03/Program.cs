using System;

namespace lesson28._03
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWord = "Bill";
            int chances = 5;
            System.Console.WriteLine("Do you remember the name of the boy from \"It\"?");
            while (chances > 0)
            {
                string name = Console.ReadLine();
                if (name == keyWord)
                {
                    System.Console.WriteLine("Your answer is right!");
                    break;
                }
                chances--;
                System.Console.WriteLine($"Try again. You have {chances}");
            }
            if (chances == 0)
                System.Console.WriteLine("you died!");
            Console.ReadKey();
        }
    }
}
