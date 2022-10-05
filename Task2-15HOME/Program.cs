/* Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да, 7 -> да, 1 -> нет*/

void GetWeek(int number)
{
    if (number > 0 && number < 8)
        if (number == 6)
        {
            Console.WriteLine($" {number} -> да");
            return;
        }
        else if (number == 7)
        {
            Console.WriteLine($" {number} -> да");
            return;
        }
        else
        {
            Console.WriteLine($" {number} -> нет");
            return;
        }
    Console.WriteLine($" {number} - не является числом в интервале с 1 до 7");
}

GetWeek(100);