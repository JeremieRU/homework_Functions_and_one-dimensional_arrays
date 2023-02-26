int TakeConsoleInt(string str = "Введите число: ")
{
    int _num;
    Console.Write(str);
    int.TryParse(Console.ReadLine()!, out _num);
    return _num;
}
double TakeConsoleDouble(string str = "Введите число: ")
{
    double _num;
    Console.Write(str);
    double.TryParse(Console.ReadLine()!, out _num);
    return _num;
}
int[] FillArrayInt(int size, int min = 0, int max = 1000)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min, max);
    return arr;
}
double[] FillArrayDouble(int size, double min = 0.0, double max = 1000.0)
{
    double[] arr = new double[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().NextDouble() * (max - min) + min;
    return arr;
}
switch (TakeConsoleInt("Введите номер задачи(34, 36, 38): "))
{
    default:
        Console.Write("Введён некорректный номер задачи");
        break;
    case 34:
        Console.Write("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.\nНапишите программу, которая покажет количество чётных чисел в массиве.\n[345, 897, 568, 234]-> 2\n");
        int[] arr34 = FillArrayInt(TakeConsoleInt("Задайте размер массива:"), 100, 1000);
        int res34 = 0;
        for (int i = 0; i < arr34.Length; i++)
        {
            int z = arr34[i] % 2 == 0 ? res34 += 1 : 0; // просто тренеруюсь с тернарными операторами
            //if (arr34[i] % 2 == 0) 
            //    res34 += 1;
        }
        Console.WriteLine($"[{String.Join(", ", arr34)}] -> {res34}");
        break;
    case 36:
        Console.Write("Задача 36: Задайте одномерный массив, заполненный случайными числами.\nНайдите сумму элементов, стоящих на нечётных позициях.\n[3, 7, 23, 12]-> 19\n[-4, -6, 89, 6]-> 0\n");
        double[] arr36 = FillArrayDouble(TakeConsoleInt("Задайте размер массива:"), TakeConsoleDouble("Задайте нижний порог значений элементов массива:"), (TakeConsoleDouble("Задайте верхний порог значений элементов массива:")) + 1);
        double res36 = 0;
        for (int i = 0; i < arr36.Length; i += 2)
        {
            res36 += arr36[i];
        }
        Console.WriteLine($"[{String.Join(", ", arr36)}] -> {res36}");
        break;
    case 38:
        Console.Write("Задача 38: Задайте массив вещественных чисел.\nНайдите разницу между максимальным и минимальным элементов массива.\n[3 7 22 2 78]-> 76\n");
        double[] arr38 = FillArrayDouble(TakeConsoleInt("Задайте размер массива:"), TakeConsoleDouble("Задайте нижний порог значений элементов массива:"), (TakeConsoleDouble("Задайте верхний порог значений элементов массива:")) + 1);
        double res38 = 0;
        double min38 = arr38[0];
        double max38 = arr38[0];
        for (int i = 0; i < arr38.Length; i++)
        {
            res38 = arr38[i] < min38 ? min38 = arr38[i] : 0; //просто чтобы не создавать новую
            res38 = arr38[i] > max38 ? max38 = arr38[i] : 0; //переменную - эта всё равно потом перезаписывается
            //if (arr38[i] < min38)
            //    min38 = arr38[i];
            //if (arr38[i] > max38)
            //    max38 = arr38[i];
        }
        res38 = max38 - min38;
        Console.WriteLine($"[{String.Join(", ", arr38)}] -> {res38}");
        break;
}