/*
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. 
Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int ReadInt(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

bool CheckEven(int number)
{
    bool even = false;
    if (number%2==0) even = true;
    return even;
}

int[] FillArrayRandom(int tmpLength, int tmpMin, int tmpMax)
{
    int[] tmpArray = new int[tmpLength];
    Random randnum = new Random();

    for (int i = 0; i < tmpArray.Length; i++)
    {
        tmpArray[i] = randnum.Next(tmpMin, tmpMax+1);
    };

    return tmpArray;
}

void PrintArray(int[] tmpArray)
{
    Console.WriteLine($"[" + string.Join(", ", tmpArray) + "]");
}

int NumEven(int[] tmpArray)
{
    int count = 0;
    for (int i =0; i< tmpArray.Length; i++)
    {
        if (CheckEven(tmpArray[i]) == true) count++;
    }
    return count;
}

int len = ReadInt("Укажите длину массива:");
int[] array = FillArrayRandom(len, 100, 1000);
PrintArray(array);

System.Console.WriteLine(NumEven(array)); 
