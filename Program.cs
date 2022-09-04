//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Clear();
// Console.Write("Введите трехзначное число: ");
// string input = Console.ReadLine();
// Console.WriteLine("{0} -> {1}",input, input[1]);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.Write("Введите число: ");
string input = Console.ReadLine();
if (input.Length > 2)
{
  Console.WriteLine("Третья цифра: " + input[2]);
}
else {
  Console.WriteLine("Третьей цифры нет");
}