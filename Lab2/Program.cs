using ConsoleTables;

Welcome();
Question1();
Question2();

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

static void Question2()
{
    Console.WriteLine("For this part you have to enter in two integers.");
    Console.WriteLine("The first will be a base number and the second will be a max number.");
    Console.WriteLine("I will then show the multiplication table for those two numbers.");
    Console.Write("Base: ");
    int baseInt = Convert.ToInt32(Console.ReadLine());
    Console.Write("Max Number: ");
    int maxNum = Convert.ToInt32(Console.ReadLine());

    for(int i = 0; i < maxNum + 1; i++)
        Console.WriteLine($"{baseInt} * {i} = {baseInt * i}");

    Continue();
}
