using FibonacciNumbers;

Console.WriteLine("Последовательность Фибоначчи\r\n");
Console.WriteLine("Программа выодит следующие N чисел Фибоначчи за заданным целым числом X.\r\n");

// Ввод и проверка начальных условий для поиска чисел Фибоначчи.
int x, n;
Console.WriteLine("Введите число после которого необходимо вывести числа Фибоначчи.\r");
if (!int.TryParse(Console.ReadLine(), out x) || x < 0)
{
    Console.WriteLine("Введено некорректное число.");
    return;
}

Console.WriteLine("\rВведите количество чисел Фибоначчи для вывода.\r");
if (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("Введено некорректное число.");
    return;
}

// Поиск по заданным условиям и вывод на экран результата.
Console.WriteLine("\nРезультирующий набор чисел Фибоначчи.");

// Реализация интерфейса для поиска чисел Фибоначчи.
IFibonacci fibonacci = new Fibonacci();

try
{
    foreach (long item in fibonacci.FibonacciMethod(x, n))
    {
        Console.WriteLine(item);
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Возникла ошибка при выполнении программы - {ex}");
}
