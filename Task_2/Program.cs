// Задача 2: Проверка на простое число:
//N = 13 -> "Это простое число"
//N = 12 -> “Это не простое число”

Console.WriteLine("Введите число N: ");
String inputValue = Console.ReadLine();
int N = int.Parse(inputValue);
int i = 1;
int quantity = 0;
while (i <= N)
{
    if (N % i == 0) quantity += 1;
    i += 1;
}
//Console.WriteLine($"{quantity} => количество чисел - делителей без остатка для заданного числа {N}");
Console.WriteLine();
if (quantity > 2) Console.WriteLine($"Число {N} не является простым ");
else Console.WriteLine($"Число {N} является простым ");