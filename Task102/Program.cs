// Задача 2:
// Напишите программу,
// которая принимает на вход три числа и
// выдаёт максимальное из этих чисел.

// Проверка:
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Программа для нахождения максимума для трех введенных чисел:");

System.Console.WriteLine("Введите первое число > ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число > ");
int number2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите третье число > ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}

System.Console.WriteLine($"В введенной тройке чисел максимальное число: {max}");