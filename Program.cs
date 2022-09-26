double[,] FillMas(int n, int m)
{
    double[,] mas = new double[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] = new Random().Next(-100, 101);
            mas[i, j] /= 10;
        }
    }
    return mas;
}
void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1)
                Console.Write($"|{arr[i, j]}|, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1)
                Console.WriteLine($"|{arr[i, j]}|");
            else if (j == arr.GetLength(1) - 1)
                Console.WriteLine($"|{arr[i, j]}|,");
        }
    }
}

System.Console.Write("Введите количество строк n = ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов m = ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] newArray = FillMas(n, m);
PrintArray(newArray);