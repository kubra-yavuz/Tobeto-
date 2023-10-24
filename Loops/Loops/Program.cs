NewMethod();

static void NewMethod()
{
    // for (int i = 1; i <= 100; i++) = birer arttır.
    // for (int i = 1; i <= 100; i+=2) = tek sayıları yazdır.
    //for (int i = 2; i <= 100; i+=2) = çift sayıları yazdır.
    for (int i = 100; i >= 0; i=i-2) 
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Finished!");
    Console.ReadLine();


}

