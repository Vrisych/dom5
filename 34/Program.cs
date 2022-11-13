//Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();
Console.WriteLine("Программа создает и показывает массив длинной 10, заполненный случайными числами, а затем складывает четные");
int [] array = new int [10];
for (int n=0; n<10; n++)
{
    array [n]=new Random().Next (100,1000);
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
    if (mass[i]%2 == 0) schet++;
    }
    Console.WriteLine($" ");
    Console.WriteLine($"В массиве {schet} четных чисел");
}
fung(array);