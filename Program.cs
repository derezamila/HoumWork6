// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write("Введите число M (количество чисел): ");
int M = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[M];
Console.Write("Введите числа: ");
for (int i = 0; i < M; ++i){
    Array[i] = int.Parse(Console.ReadLine());
}
int Method (int[] Array){
    int count = 0;
    for (int i = 0; i < Array.Length; i++){
        if (Array[i] > 0) count +=1;
    }
    return count;
}
Console.WriteLine($"Введено чисел больше 0: {Method(Array)} ");
*/
//Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");