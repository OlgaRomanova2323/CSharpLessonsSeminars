//Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

int[] numbers = { 10, 5, 10, 20, 30, 40, 99, 4, 91, 3, 87 };

int count = 0;
int dev;
for (int i = 0; i < numbers.Length; i++)
{
    dev = numbers[i] % 2;
    if (dev == 0)
    {
        count++;
    }
}
Console.WriteLine(count);




