//Напишите программу которая на вход принимает трехзначное число и 
//на выход выводит сумму превой и третьей цифры

    
        Console.WriteLine("Введите трехзначное число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (99 < num  && num < 1000)
    {

        int firstDigit = num / 100;
        int thirdDigit = num % 10;
        int sum = firstDigit + thirdDigit;
        Console.WriteLine($"Сумма первой и третьей цифры: {sum}"); //интерполяция на выовд , без плюсов
    }
    else
    {
        Console.WriteLine("Число не является трехзначным. Попробуйте снова.");
    }

