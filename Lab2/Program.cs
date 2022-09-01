Welcome();
Question1();

static void Welcome()
{
    Console.WriteLine("Welcome to Lab 2!");
    Console.WriteLine("This is a lab that show cases some basic C# functionality.");
    Continue();
}

static void Continue()
{
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
    Console.Clear();
}

static void Question1()
{
    Console.WriteLine("For this part you have to enter in two integers and I will add them together.");
    Console.Write("First Integer: ");
    int input1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Second Integer: ");
    int input2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"{input1} + {input2} = {input1 + input2}");
    Continue();
}
