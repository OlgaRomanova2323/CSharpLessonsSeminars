// написать программу котрая на вход принимает целое число N
// а на выходе показывает все целые числа в промежутке от -N до N.
// закомментировать несколько
// строк
// кода
// клавиша  cntl+/ слэш котрый рядом с Ю

using System.Globalization;

Console.WriteLine("Введите целое положительное (натуральное) число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = -num;

while (count <= num)
{
    Console.Write(count + " ");
   count++; // count = count + 1;
}

