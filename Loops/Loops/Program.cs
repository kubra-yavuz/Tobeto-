

using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        //ForLoop();
        //WhileLoop();
        //DoWhileLoop();
        //ForEachLoop();


        if (IsPrimeNumber(6))
        {
            Console.WriteLine("This is a Prime number");
        }
        else
        {
            Console.WriteLine("This is not a prime number");
        }
        Console.ReadLine();


        static void ForLoop()
        {

            // for (int i = 1; i <= 100; i++) = birer arttır.
            // for (int i = 1; i <= 100; i+=2) = tek sayıları yazdır.
            //for (int i = 2; i <= 100; i+=2) = çift sayıları yazdır.
            ForLoop();
            Console.ReadLine();

            for (int i = 100; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
        }
    }
    
    
    private static bool IsPrimeNumber(int number)
    {
        bool result = true;
        for (int i = 2; i < number-1; i++)
        {
            if (number%i==0)
            {
                result = false;
                i = number;
            }
        }
        return result;
    }
    private static void ForEachLoop()
    {
        string[] students = new string[3] { "Engin", "Derin", "Salih" };
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    private static void DoWhileLoop()
    {
        int number = 10;
        do
        {
            Console.WriteLine(number);
            number--;
        } while (number >= 0);
    }

    private static void WhileLoop()
    {
        int number = 100;
        while (number >= 0)
        {
            Console.WriteLine(number);
            number--;
        }
        Console.WriteLine("Now number is {0}", number);
    }
}