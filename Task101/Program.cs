// Задача 1:
// Напишите программу,
// которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// Проверка:
// a = 5; b = 7 ->  max = 7, min = 5
// a = -9 b = -3 -> max = -3, min = -9

System.Console.WriteLine("Программа для нахождения минимального и максимального числа:");

System.Console.WriteLine("Введите первое число > ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число > ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    System.Console.WriteLine($"Введенное число {number1} больше введенного числа {number2}.");
    System.Console.WriteLine($"Или другими словами: {number1} является максимумом, а {number2} - минимумом.");
}
else
{
    System.Console.WriteLine($"Введенное число {number2} больше введенного числа {number1}.");
    System.Console.WriteLine($"Или другими словами: {number1} является минимумом, а {number2} - максимумом.");
}