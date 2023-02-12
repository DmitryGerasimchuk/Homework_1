﻿// Задача 4:
// Напишите программу,
// которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// Проверка:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Программа для вывода всех четных чисел введенного целого числа:"); //Вывод строки с названием программы

System.Console.WriteLine("Введите любое целое число N > "); // Вывод строки с запросом

int N = Convert.ToInt32(Console.ReadLine()); // Объявление переменной и перевод ее в числовой формат

int count = 0; // Объявление счетчика со значением 0

while (count < (N - 1)) // Цикл с условием: пока счетчик не превышает значения (N-1), будем делать следующее следующее (цикл). N-1 - чтобы при введении 1, программа не выполнялась
{
    count = count + 2; // Счетчик увеличения на 2, так как нам нужны только четные значения
    if (N % 2 == 0) // Условие, что для N четных, запускать следующую команду 
    {
        System.Console.Write(count + " , "); // Вывести в консоль значения (через запятую и пробел), удовлетворяющие условию цикла
    }
    else // Если же условие неверно (введенное число нечетно), то выпоняем следующую команду
    {
        System.Console.Write(count + " , "); // Вывести в консоль значение (через запятую и пробел), удовлетворяющие условию цикла
    }
}