// Определите, является ли число степенью двойки:
//N = 16 -> "Является степень двойки"
//N = 12 -> “Не является степенью двойки”

Console.WriteLine("Введите число N: ");
String inputValue = Console.ReadLine();
int Value = int.Parse(inputValue);

while (Value > 1)
{
    if (Value%2==0)
    Value=Value/2;
    else
    {
        Console.Write("Число не является степенью двойки" + " ");
        break;
    }

    if (Value==1) Console.WriteLine($"Число является степенью двойки ");
}

