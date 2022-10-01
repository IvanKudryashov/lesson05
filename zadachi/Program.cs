//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
void zadacha34()
{
    int size = 8;
    int[] array = new int[size];
    int count = 0;
    FillArray(array,100,999);
    PrintArray(array);
     for (int i = 0; i < array.Length; i++)
     {
        if (array[i] % 2 == 0)
        count++;
     }
     Console.WriteLine($"Четных чисел в массиве: {count}");
}

void FillArray(int[] array, int minValue, int maxValue)
{
    maxValue++;
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(minValue,maxValue);
    }  
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


//Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

void zadacha36()
{
    int size = 8;
    int[] array = new int[size];
    FillArray(array,-5,15);
    PrintArray(array);
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
     {
        if (i % 2 == 1)
        sum = array[i] + sum;
     }
     Console.WriteLine($"Сумма элементов с неч индексами: {sum}");
}

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void zadacha38()
{
    int size = 8;
    double[] array = new double[size];
    FillArray2(array);
    PrintArray2(array);
    Console.WriteLine("Разница: {0,6:F2}",difMaxMin(array));
}

void FillArray2(double[] array)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.NextDouble() * 100;
    } 
}

void PrintArray2(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0,6:F2}", array[i]);
    }
    Console.WriteLine();
}

double difMaxMin(double[] array)
{
    double max = array[0], min = array[0], dif;
    for (int i = 1; i < array.Length; i++)
     {
        if (array[i] > max)
        max = array[i];
        if (array[i] < min)
        min = array[i];
     }
     dif = max - min;
     return dif;
}
//zadacha34();
//zadacha36();
zadacha38();
