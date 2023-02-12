// Задача 3:
// Напишите программу,
// которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Проверка:
// 4 -> да
// -3 -> нет
// 7 -> нет

System.Console.WriteLine("Программа для определения четности введенного числа:");

System.Console.WriteLine("Введите целое число > ");
int number = Convert.ToInt32(Console.ReadLine());

if(number % 2 == 0)
{
    System.Console.WriteLine("Вы ввели четное число.");
}
else
{
   System.Console.WriteLine("Вы ввели нечетное число");
}