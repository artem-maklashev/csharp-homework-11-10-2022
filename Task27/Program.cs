/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

string GetNumber(string message)
{
    int result = 0;
    bool isCorrect = false;

    while(!isCorrect)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result))
            isCorrect = true;
        else
           Console.WriteLine("Ошибка. Введите число ");
    }
    return result.ToString();
}

int TakeSumNumbers(string numb)
{
    int result = 0;
    foreach (var i in numb)
    {
        result=result+ int.Parse(i.ToString());
    }
    return result;
}

string number = GetNumber("Введите число: ");
int sum = TakeSumNumbers(number);
Console.WriteLine($"{number} -> {sum}");