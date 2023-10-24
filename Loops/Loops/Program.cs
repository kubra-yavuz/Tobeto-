

using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        //ForLoop();
        //WhileLoop();
        int number = 10;
        do
        {
            Console.WriteLine(number);
            number--;
        } while (number>=0);

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