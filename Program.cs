// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным
// и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.Next(leftRange, rightRange) + rand.NextDouble(), 3);
    }
    return arr;
}

double result = 0.0;
double min = 0.0;
double max = 0.0;

double MinMax(double[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
        else if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    result = max - min;
    return result;
}

void PrintArray(double[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

double[] array = FillArrayWithRandomNumbers(9, -10, 10);

PrintArray(array);

MinMax(array);

System.Console.WriteLine($"Разница между Max и Min: {Math.Round(result, 3)}.");
