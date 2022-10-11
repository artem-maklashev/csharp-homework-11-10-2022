/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

int GetNumber(string message)
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
    return result;
}

int GetExponentiation(int x, int y)
{
    int result = 1;
    for (int i = 1; i <= y ; i++)
        result=result*x;    
    return result;
}

int a = GetNumber("Введите число А: ");
int b = GetNumber("Введите число B: ");
int exp = GetExponentiation(a,b);
Console.WriteLine($"{a},{b} -> {exp}");