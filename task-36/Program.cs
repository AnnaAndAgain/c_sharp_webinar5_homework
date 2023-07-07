/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int ReadInt(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
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

int SumOddPositionElements(int[] tmpArray)
{
    int tmpSum = 0;
    for (int i = 1; i < tmpArray.Length; i+=2)
    {
        tmpSum = tmpSum+ tmpArray[i];
    }
    return tmpSum;
}

int len = ReadInt("Введите длину массива:");
int[] array = FillArrayRandom(len, -255, 255);
PrintArray(array);
Console.WriteLine(SumOddPositionElements(array));