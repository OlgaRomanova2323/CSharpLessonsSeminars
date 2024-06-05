    {
static void Main()
{
int[,] numbers = new int[,] {
{1, 2, 3, 4},
{5, 6, 7, 8},
{9, 10, 11, 12}
};
}
    int x = 2; // позиция по строкам
    int y = 2; // позиция по столбцам

    int numRows = numbers.GetLength(0);
    int numCols = numbers.GetLength(1);

    if (x >= 1 && x <= numRows && y >= 1 && y <= numCols)
    {
        Console.WriteLine(numbers[x - 1, y - 1]);
    }
    else if (x < 1 || x > numRows)
    {
        Console.WriteLine("Позиция по рядам выходит за пределы массива");
    }
    else
    {
        Console.WriteLine("Позиция по колонкам выходит за пределы массива");
    }
}
