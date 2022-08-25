// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и 
//  минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

Console.WriteLine("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 0)
{
    Console.Write("Ошибка ввода, повторите попытку");
    return;
}

double[] CreateArrayRndDouble(int size, double min, double max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{Math.Round(array[i], 2)} ");
    }
    Console.WriteLine($"]");
}

double[] arr = CreateArrayRndDouble(num, -99.9, 99);
PrintArray(arr);

double FindMinMaxDiffNumber(double [] array)
{
    double diff = 0;
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < arr.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
        
    }
    diff = (max - min);
    return diff;
}


double Difference = FindMinMaxDiffNumber(arr);
Console.WriteLine($"-> {Math.Round(Difference, 2)}");
