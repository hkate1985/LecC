Console.WriteLine("Выберите задание");
Console.WriteLine("Task1.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine("Task2.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
int a =Convert.ToInt32(Console.ReadLine());

switch (a)

{
    case 1:
        Task1();
        break;
    case 2:
        Task2();
        break;   
    default:
       break; 
}
void Task1()
{  
    int CalculateSumm(int m, int n)
		{
			int start = m;
			int end = n;
			if(m > n)
			{
				start = n;
				end = m;
			}
			return (end + start)*(end - start + 1)/2; //  формула суммы членов арифметической прогрессии
		}
		
		Console.WriteLine(CalculateSumm(4,8));
}


void Task2()
{ 
   int AkkermanFunc(int m, int n)
		{
			if(m == 0)
			{
				return n + 1;
			}
			if(m > 0 && n == 0)
			{
				return AkkermanFunc(m - 1, 1);
			}
			return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
		}
		
		Console.WriteLine(AkkermanFunc(2,3));
}

