/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]

ввод элеменетов через консоль (через запятую. использовать метод string.Split()) */

string[] GetArrayNumbers(string message)
{
    int result = 0;
    //Console.WriteLine(message);
    bool isCorrect = false;
    string[] str_ = new string[] { };
    while (!isCorrect)
    {
        Console.Write(message);
        string? str = Console.ReadLine();

        int counter = 0;
        str_ = str.Split(',');
        if (str_.Length == 8)
        {
            foreach (var item in str_)
            {
                if (int.TryParse(item, out result))
                    counter += 1;
                else
                {
                    Console.WriteLine("Ошибка. Введите числа через запятую \n");

                }
                if (counter / str_.Length == 1)
                    isCorrect = true;
            }
        }
        else
        {
            isCorrect = false;
            Console.WriteLine($"Должно быть введено 8 чисел, вы ввели {str_.Length}");
        }
    }

    return str_;
}

void PrintArray(string[] array)
{
    int length = array.Length;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

string[] arrStr = GetArrayNumbers("Введите 8 чисел через запятую: ");
PrintArray(arrStr);