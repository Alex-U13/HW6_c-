// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Clear();
// // Console.Write("Количество элементов массива: ");
// // int N = Convert.ToInt32(Console.ReadLine());
// int[] Array = new int[5];   // убрала введение количества элементов пользователем, т.к. не могу вывести массив в консоль после цикла. 

// int count =0;
// for (int i =0; i<5; i++)                         
// {
//     Console.Write("Введите число: ");
//     Array[i] = Convert.ToInt32(Console.ReadLine());
//     if( Array[i]<0) count = count + 1;
// }
// Console.WriteLine($"Массив ({Array[0]}, {Array[1]}, {Array[2]}, {Array[3]}, {Array[4]}) содержит {count} положительных значений элементов");






// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)  //!!! Верно ли решение в качестве примера? 

Console.Clear();
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b1-b2)/(k1-k2);
double y = k2 * x + b2;

Console.Write($"Точка пересечения двух прямых ({x};{y})");









