//Task2.Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("введите число");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int count=0;
if (a<0)
{
    a=-a;
}
    while  (a>0)     
    {
        int num = a % 10;
        a = a / 10;
        sum = sum + num;
        count++;
    }
Console.WriteLine(sum);
   
