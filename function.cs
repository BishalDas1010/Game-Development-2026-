using System;

class Function
{
    static void newMAin(string[] args)
    {
        Console.WriteLine("Function description");

        int value = 10;
        int value2 = 20;

        greet(value, value2);
    }

    static void greet(int a, int b)
    {
        if (a > b)
        {
            Console.WriteLine("a is greater");
        }
        else
        {
            Console.WriteLine("b is greater");
        }
    }
}