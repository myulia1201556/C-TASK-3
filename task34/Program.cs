// Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
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

int CountElem(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array [i] % 2 == 0) count++;
    }
    return count;

}

int[] arr = CreateArrayRndInt(num);
PrintArray(arr);
int countS = CountElem (arr);
Console.WriteLine($"Количество четных чисел в массиве: {countS}");
