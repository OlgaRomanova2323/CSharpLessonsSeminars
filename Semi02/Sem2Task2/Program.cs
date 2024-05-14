//Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
if (100 <= num && num <= 999)
{

    //int firstDigit = num / 100;
    int secondDigit = num / 10 % 10;
    int thirdDigit = num % 10;

    int result = secondDigit;
    int count = 1;

    while (count < thirdDigit)
    {
        result = result * secondDigit;  //result*=secondDigit 
        count++;
    }

    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Ошибка ввода");
}
