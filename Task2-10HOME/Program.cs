/*Задача 10: Напишите программу, которая принимает 
на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

void GetResult(int numeric)
{
    if (numeric < 1000 && numeric > 99)
    {
        string numericAsString = numeric.ToString();
        int result = int.Parse(numericAsString[1].ToString());
        Console.WriteLine(result);
    }
    else
        Console.WriteLine("Введено не трехзначное число");
}
GetResult(918);
