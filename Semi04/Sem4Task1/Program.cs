// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом массиве.
// Примеры
// [1 3 4 19 3] => 2       [4 3 4 1 9 5 21 13] => 3

//int[] array = new int[5];
using System.Runtime.CompilerServices;

Console.WriteLine("Введите количество чисел в массиве: ");//эти две строик можно убрать и в вызове
int size = Convert.ToInt32(Console.ReadLine());           // функции вместо size  указать магическое число

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

int[] arr = CreateArrayRndInt(size, 1, 100); //можно вместо цифр прописать переменную, предварительно ее ввести как и size
PrintArray(arr);

int CountPrimeNumbers(int[] array)
{
    int count = 0;
    //реализация 
    for (int i = 0; i < array.Length; i++)
    {
        if (IsPrime(array[i]))
        {
            count++;
        }
    }
    return count;

}
bool IsPrime(int num)
{
    for (int i = 2; i <= Math.Sqrt(num); i++)
    {
        if (num % i == 0)
        return false;
    }
    return true;
}

int countPrime = CountPrimeNumbers(arr);
Console.WriteLine($" =>{countPrime}");
