Console.WriteLine("введите три числа:");
int numberA=Convert.ToInt32(Console.ReadLine());
int numberB=Convert.ToInt32(Console.ReadLine());
int numberC=Convert.ToInt32(Console.ReadLine());
if (numberA>numberB)
{
    if (numberA>numberC)
    {
        Console.Write("Max:");
        Console.Write(numberA);
    }
    else
    {
        if (numberC>numberB)
        {
            Console.Write("Max:");
            Console.Write(numberC);
        }
        else
        {
            Console.Write("Max:");
            Console.Write(numberB);
        }
    }
}
else
{
    if (numberB>numberC)
    {
        Console.Write("Max:");
        Console.Write(numberB);
    }
    else
    {
        Console.Write("Max:");
        Console.Write(numberC);
    }
}
