// на вход принимает два целых числа и проверяет, 
// является ли первое квадратом второго

// string num1str = Console.ReadLine();
// int num1= Convert.ToInt32();
Console.Write("введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2*num2)
{
    Console.WriteLine(" первое число является квадратом второго");
}
else
{
    Console.WriteLine("первое число не является квадратом второго"); 
}

