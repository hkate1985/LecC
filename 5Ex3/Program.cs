﻿// Task 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 69.4 -22 0.4 78] ->56
// 
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int y = 0; y < numbers.Length; y++)
{
    if (numbers[y] > max)
        {
            max = numbers[y];
        }
    if (numbers[y] < min)
        {
            min = numbers[y];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Маx значение = {max}, Min значение = {min}");
Console.WriteLine($"Разница между Max и Min = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}