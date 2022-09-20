namespace FibonacciNumbers;

/// <summary>
/// Представляет класс, реализующий поиск чисел Фибоначчи.
/// </summary>
public class Fibonacci : IFibonacci
{
    /// <summary>
    /// Производит поиск чисел Фибоначчи в соответсвии с условиями поиска.
    /// </summary>
    /// <param name="startNumber">Число после которого необходимо вычислить числа Фибоначчи.</param>
    /// <param name="limitNumber">Количество чисел Фибоначчи.</param>
    /// <returns></returns>
    /// <exception cref="ArgumentOutOfRangeException">Переданны некорректные входящие параметры</exception>
    public IEnumerable<long> FibonacciMethod(int startNumber, int limitNumber)
    {
        if (startNumber < 0)
            throw new ArgumentOutOfRangeException(nameof(startNumber), "Переданны некорректные входящие параметры");
        if (limitNumber <= 0)
            throw new ArgumentOutOfRangeException(nameof(limitNumber), "Переданны некорректные входящие параметры");

        List<long> result = new();

        // Ограничение полученной коллекции через LINQ.
        foreach (long item in FibonacciCompute().SkipWhile(d => d < startNumber).Take(limitNumber))
        {
            result.Add(item);
        }

        return result;
    }

    /// <summary>
    /// Производит поиск чисел Фибоначчи на основе итератора.
    /// </summary>
    /// <returns>Коллекция чисел.</returns>
    private static IEnumerable<long> FibonacciCompute()
    {
        long current = 0, next = 1;

        yield return 0;
        yield return 1;

        while (true)
        {
            long sum;

            // Проверка на переполнение, если сумма больше максимального значения long,
            // то указывает, что последовательность больше не имеет элемтентов.
            try
            {
                sum = checked(current + next);
            }
            catch (OverflowException)
            {
                yield break;
            }

            current = next;
            next = sum;

            yield return next;
        }
    }
}
