// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
Console.WriteLine("Программа создает и показывает массив длинной 10, заполненный случайными числами, а затем складывает четные");
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
void fung (int [] mass)
{
    int schet =0;
    for (int i=0; i<10;i++)
    {
    if (mass[i]%2 != 0) schet=schet+mass[i];
    }
    Console.WriteLine($" ");
    Console.WriteLine($"Сумма нечетных чисел в массиве равна {schet}");
}
fung(array);