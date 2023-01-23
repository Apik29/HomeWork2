// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введи число: 👋");

int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if (numberText.Length > 2)
{
    Console.WriteLine( numberText[2]);
}
else
{
    Console.WriteLine("Нет третьей цифры");
}