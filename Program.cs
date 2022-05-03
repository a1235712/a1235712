//Задача 1: Определите, является ли число степенью двойки:
//N = 16 -> "Является степень двойки"
//N = 12 -> “Не является степенью двойки”

bool IsPowerOfTwo(int number)
{
    for (int x = 1; x <= number; x *= 2)
    {
        if (x == number) return true;
    }
    return false;
}

Console.WriteLine("Введите число N: ");

string strN = Console.ReadLine();
int N = int.Parse(strN);

IsPowerOfTwo(N);
if (IsPowerOfTwo(N) == true) Console.Write($"{N} является степенью двойки");
else Console.WriteLine($"{N} не является степенью двойки");

// Добавили в GITHUB


