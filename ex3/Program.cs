Console.WriteLine("Введите число:");
int numberA=Convert.ToInt32(Console.ReadLine());
if (numberA%2==0)
{
    Console.Write(numberA);
    Console.Write("-четное число");
}
else
{
    Console.Write(numberA);
    Console.Write("-нечетное число");
}