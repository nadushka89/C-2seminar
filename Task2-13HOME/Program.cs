/*Задача 13: Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

void GetResult(int numeric)
{
    if (numeric > 99)
    {
        string numericAsString = numeric.ToString();
        int result = int.Parse(numericAsString[2].ToString());
        Console.WriteLine(result);
    }
    else
        Console.WriteLine("Третьей цифры нет");
}
GetResult(78);