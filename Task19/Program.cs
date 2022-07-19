// Задача 19 Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да


int n, reversed = 0, remainder, original;
Console.WriteLine("Введите пятизначное число");
n = int.Parse(Console.ReadLine());


original = n;

while (n != 0)
{
    remainder = n % 10;
    reversed = reversed * 10 + remainder;
    n /= 10;
}
if (original == reversed)
    Console.WriteLine($"{original} - палиндром");
else
    Console.WriteLine($"{original} - не палиндром");