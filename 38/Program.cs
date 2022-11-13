// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
Console.WriteLine("Программа создает и показывает массив длинной 10, заполненный случайными числами, а затем находит раницу между максимальным и минимальным элементом массива");
int [] array = new int [10];
for (int n=0; n<10; n++)
{
    array [n]=new Random().Next (-1000,1000);
}
Console.WriteLine($"Массив:");
for (int n=0; n<10; n++)
{
    Console.Write($"{array[n]}, ");
}
int max (int [] mass)
{
    int max= 0;
    for (int i=0; i<10;i++)
    {
    if (mass[i]>mass[max]) max=i;
    }
    
    return max;
}
int min (int [] mass)
{
    int min= 0;
    for (int i=0; i<10;i++)
    {
    if (mass[i]<mass[min]) min=i;
    }
    return min;
}
Console.WriteLine($" ");
Console.WriteLine($"Максимальный элемент массива {array[max(array)]}");
Console.WriteLine($"Минимальный элемент массива {array[min(array)]}");
Console.WriteLine ($"{array[max(array)]} - {array[min(array)]} = {array[max(array)]-array[min(array)]}");