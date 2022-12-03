Console.WriteLine("введите два числа:");
int numberA=Convert.ToInt32(Console.ReadLine());
int numberB=Convert.ToInt32(Console.ReadLine());
if (numberA>numberB)
{
    Console.Write("Max:");
    Console.Write(numberA);
}
else
{
    Console.Write("Max:");
    Console.Write(numberB);
}