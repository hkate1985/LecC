// Task 1.Напишите программу, которая принимает на 
//вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

void CheckingNum(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine("число: - палиндром");
  }
  else Console.WriteLine("число: - не палиндром");
}

if (number!.Length == 5)
{
  CheckingNum(number);
}
else Console.WriteLine("Введите правильное число");