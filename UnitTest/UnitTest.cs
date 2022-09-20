using FibonacciNumbers;

namespace UnitTest;

/// <summary>
/// Представляет класс для тестирования класса Fibonacci.
/// </summary>
[TestClass]
public class UnitTest
{
    /// <summary>
    /// Представляет функцию тестирования входящих параметров фукнции FibonacciMethod.
    /// </summary>
    [TestMethod]
    [DataTestMethod]
    [DataRow(-2, 2)]
    [DataRow(7, -2)]
    [DataRow(7, 0)]
    public void TestFibonacciMethodParameter(int startNumber, int limitNumber)
    {
        Fibonacci fibonacci = new();

        // Проверка, что при передачи некорретных параметров выбрасывается правильное исключение.
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => fibonacci.FibonacciMethod(startNumber, limitNumber));
    }

    /// <summary>
    /// Представляет функцию для тестирования FibonacciMethod.
    /// </summary>
    [TestMethod]
    [DataTestMethod]
    [DataRow(4, 10)]
    public void TestFibonacciMethod(int startNumber, int limitNumber)
    {
        Fibonacci fibonacci = new();

        IEnumerable<long> result = fibonacci.FibonacciMethod(startNumber, limitNumber);
        
        // Проверка, что результирующий набор данных содержит заданное количество.
        Assert.AreEqual(limitNumber, result.Count());
    }
}