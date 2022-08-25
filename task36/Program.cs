// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих 
// на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество элементов массива: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 0 || num < 0)
{
    Console.Write("Ошибка ввода, повторите попытку");
    return;
}
int[] CreateArrayRndInt(int arrays)
{
    int[] array = new int[arrays];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write($"[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine($"]");
}

int SumElem(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
       if (i % 2 != 0) sum += array[i];
    }
    return sum;

}

int[] arr = CreateArrayRndInt(num);
PrintArray(arr);
int Sum = SumElem (arr);
Console.WriteLine($"Сумма элементов массива занимающих нечётные позиции в массиве: {Sum}");
