using ConsoleTables;

Welcome();
Question1();
Question2();
Question3();
Question4();

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

static void Question3()
{
    ConsoleTable table = new ConsoleTable("Type", "Byte(s) of Memory", "Min", "Max");
    Console.WriteLine("For this part, I will show you a table with some information regarding multiple types in C#");
    table.AddRow("sbyte", $"{sizeof(sbyte)}", $"{sbyte.MinValue}", $"{sbyte.MaxValue}");
    table.AddRow("byte", $"{sizeof(byte)}", $"{byte.MinValue}", $"{byte.MaxValue}");
    table.AddRow("short", $"{sizeof(short)}", $"{short.MinValue}", $"{short.MaxValue}");
    table.AddRow("ushort", $"{sizeof(ushort)}", $"{ushort.MinValue}", $"{ushort.MaxValue}");
    table.AddRow("int", $"{sizeof(int)}", $"{int.MinValue}", $"{int.MaxValue}");
    table.AddRow("uint", $"{sizeof(uint)}", $"{uint.MinValue}", $"{uint.MaxValue}");
    table.AddRow("long", $"{sizeof(long)}", $"{long.MinValue}", $"{long.MaxValue}");
    table.AddRow("ulong", $"{sizeof(ulong)}", $"{ulong.MinValue}", $"{ulong.MaxValue}");
    table.AddRow("float", $"{sizeof(float)}", $"{float.MinValue}", $"{float.MaxValue}");
    table.AddRow("double", $"{sizeof(double)}", $"{double.MinValue}", $"{double.MaxValue}");
    table.AddRow("decimal", $"{sizeof(decimal)}", $"{decimal.MinValue}", $"{decimal.MaxValue}");
    table.Write();
    Continue();
}

static void Question4()
{
    Console.WriteLine("This part of the program is a calculator. It allows for +, -, *, /, and %");
    Console.WriteLine("First it will ask you for an integer, then a operator, then another number.");
    Console.WriteLine("It will give you a result and then allow you to continue operating on the result.");
    Console.WriteLine("Type in \"esc\" to exit the program.");

    int firstInt = GetNum();

    string input;

    while (true)
    {
        input = PrintMenu(firstInt);

        if (input == "esc")
        {
            break;
        }

        int secondInt = GetNum();
        if (input == "+")
        {
            Console.WriteLine($"{firstInt} + {secondInt} = {firstInt + secondInt}");
            firstInt += secondInt;
        }
        else if (input == "-")
        {
            Console.WriteLine($"{firstInt} - {secondInt} = {firstInt + secondInt}");
            firstInt -= secondInt;
        }
        else if (input == "*")
        {
            Console.WriteLine($"{firstInt} * {secondInt} = {firstInt + secondInt}");
            firstInt *= secondInt;
        }
        else if (input == "/")
        {
            Console.WriteLine($"{firstInt} / {secondInt} = {firstInt + secondInt}");
            firstInt /= secondInt;
        }
        else if (input == "%")
        {
            Console.WriteLine($"{firstInt} % {secondInt} = {firstInt + secondInt}");
            firstInt %= secondInt;
        }
    }
}

static string PrintMenu(int result)
{
    Console.WriteLine("+. Add");
    Console.WriteLine("-. Subtract");
    Console.WriteLine("*. Multiply");
    Console.WriteLine("/. Divide");
    Console.WriteLine("%. Modulus");

    Console.Write($"Enter in a symbol to apply to {result}: ");
    string op = Console.ReadLine();
    return op;
}

static int GetNum()
{
    Console.Write("Enter in an integer: ");
    return Convert.ToInt32(Console.ReadLine());
}
