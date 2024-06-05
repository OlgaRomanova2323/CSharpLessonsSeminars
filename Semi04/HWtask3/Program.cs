//Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
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
int CreateFlipArray(int[] array)
{

    int i = 0;
    int num = 0;
    int index = array.Length / 2;
    int j;
    int[] FlipArray = new int[index * 2];
    while (i < index)
    {
        num = array[i];
        j = array.Length - 1 - i;
        FlipArray[i] = array[j];
        FlipArray[j] = num;
        i++;

    }
    return (FlipArray);
}


Console.WriteLine("Задайье размер массива: ");
int LenghtCount = Convert.ToInt32(Console.ReadLine());


int[] arr = CreateArrayRndInt(LenghtCount, 1, 100);
//int[] arr2= FlipArray(arr);
PrintArray(arr);
//PrintArray(arr2);
//int result = FlipArray(arr);
//Console.Write($" => {result}");



