/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

int ReadInt(string text) 
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[] FillArrayRandom(int tmpLength, double tmpMin, double tmpMax)
{
    double[] tmpArray = new double[tmpLength];
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

double FindMax(double[] tmpArray)
{
    double tmpMax = tmpArray[0];
    for (int i = 1; i < tmpArray.Length; i++)
    {
        if (tmpArray[i] > tmpMax) tmpMax = tmpArray[i];
    }
    return tmpMax;
}

double FindMin(double[] tmpArray)
{
    double tmpMin = tmpArray[0];
    for (int i = 1; i < tmpArray.Length; i++)
    {
        if (tmpArray[i] < tmpMin) tmpMin = tmpArray[i];
    }
    return tmpMin;
}

int len = ReadInt("Введите длину массива:");
double[] array = FillArrayRandom(len, 0, 100);
PrintArray(array);
double diff = FindMax(array) - FindMin(array);
Console.WriteLine(diff);
