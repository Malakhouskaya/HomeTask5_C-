// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*
int[] FillArrayWithRandomNumbers(int size)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for(int i=0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(100,1000);
    }
    return arr;
}

int CountPositive(int[] arr)
{
    int count = 0;
    int pos = 0;
    while(pos < arr.Length)
    {
        if(arr[pos] % 2 == 0)
            count++;
        pos++;
    }
    return count;
}


Console.WriteLine("Input the array length:  ");
int size = Convert.ToInt32(Console.ReadLine());
int [] arr = FillArrayWithRandomNumbers(size);
Console.WriteLine($"[{string.Join(",",arr)}]");
Console.WriteLine("The number of positive numbers in the array is: " + CountPositive(arr));



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] FillArrayWithRandomNumbers(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

int SumOddPosition(int[] array)
{
    int sum = 0;
    for(int i=1; i < array.Length; i+=2)
    {
        sum+=array[i];
    }
    return sum;
}

Console.WriteLine("Input the size of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the minimum value of an array element: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the maximum value of an array element: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] array = FillArrayWithRandomNumbers(size, minValue, maxValue);
Console.WriteLine($"[{string.Join(",",array)}]");
Console.Write("The sum of numbers of the array on the odd positions is: " + SumOddPosition(array));



// Задача 38: Задайте массив вещественных чисел(тип double). 
//Найдите разницу между максимальным и минимальным элементами массива.
// [3,1; 7,2; 22,3; 2,4; 78,5] -> 76,1

double[] FillArrayWithRandomNumbers(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.Next(-100,100) + rnd.NextDouble(), 2);
    }
    return array;
}

double MinElement(double[] array)
{
    double min = array[0];
    
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i];
    }
    return min;
}

double MaxElement(double[] array)
{
    double max = array[0];
    
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
    }
    return max;
}


Console.WriteLine("Input the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = FillArrayWithRandomNumbers(size);
Console.WriteLine($"[{string.Join("; ", array)}]");
Console.WriteLine($"The difference between maximum and minimum values of the array elements is {MaxElement(array)-MinElement(array)}");

*/
