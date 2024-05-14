// напишите программу котрая на вход принимает трехзначное число
// и удаляет вторую цифрю этого числа


Console.Write("Введите целое трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int firstDigit = num / 100;
    int thirdDigit = num % 10;

    int result = firstDigit * 10 + thirdDigit;

    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Некорректный ввод");
}