//Task 3.Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// (int size = 8);
int[] array = new int[8];
Random ARandom = new Random();
Console.WriteLine("Вывод массива");
for (int i = 0; i < array.Length; i++)
    {
        array[i] = ARandom.Next(0,8);
        Console.Write("{0} ", array[i]);
    }
 

