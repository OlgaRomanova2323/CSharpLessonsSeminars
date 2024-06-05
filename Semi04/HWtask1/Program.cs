// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.


using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

while (true)
{
    Console.Write("введите целое число или q для выхода: ");
    string input = Console.ReadLine(); // Чтение строки ввода пользователя
    if (input == "q")
    {
        Console.WriteLine("программа завершена");
        break;
    }
    int number;
    if (int.TryParse(input, out number))
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        if (sum % 2 == 0)
        {
            Console.WriteLine("сумма чисел четная");
            break;
        }
    }
}