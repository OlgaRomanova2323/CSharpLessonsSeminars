//Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.


using System.Globalization;

int[] CreateArrayRndInt(int size, int min, int max)//создадим функцию которая создает массив и возвращает 
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max);
    }

    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }

        else
        {
            Console.Write($"{array[i]}");
        }
    }
}
    int CountEvenNum(int[] array)
    {
        int cnt=0;
         for (int i = 0; i < array.Length; i++)
         {
           if (array[i]%2==0)
           {
            cnt++;
           } 
         }
         return cnt;
    }

Console.WriteLine("Задайье размер массива: ");
int LenghtCount = Convert.ToInt32(Console.ReadLine());


int[] arr = CreateArrayRndInt(LenghtCount, 100, 999);
PrintArray(arr);
int result = CountEvenNum(arr);
Console.Write($" => {result}");



// using System;
// class Program
// {
// static void Main()
// {
// int[] numbers = new int[10]; // Массив для хранения случайных чисел
// Random random = new Random(); // Генератор случайных чисел
// int evenCount = 0; // Счетчик четных чисел
// // Заполнение массива случайными трехзначными числами
// for (int i = 0; i < numbers.Length; i++)
// {
// numbers[i] = random.Next(100, 1000); // Случайное число от 100 до 999
// Console.Write(numbers[i] + " "); // Вывод сгенерированного числа
// // Проверка на четность и увеличение счетчика
// if (numbers[i] % 2 == 0)
// {
// evenCount++;
// }
// }
// // Вывод количества четных чисел в массиве
// Console.WriteLine($"\nКоличество четных чисел в массиве: {evenCount}");
// }
// }