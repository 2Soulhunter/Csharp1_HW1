/*                          Домашнее задание к семинару 1 С#
Задача 8. 
Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Например:
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int index = 1;

while (index <= N)     // выводит все чётные числа от index до N
{
    if (index % 2 != 1)
    {
        Console.Write($"{index} ");
    }
    index++;
}