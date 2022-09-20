using FibonacciNumbers;

namespace UnitTest;

/// <summary>
/// ������������ ����� ��� ������������ ������ Fibonacci.
/// </summary>
[TestClass]
public class UnitTest
{
    /// <summary>
    /// ������������ ������� ������������ �������� ���������� ������� FibonacciMethod.
    /// </summary>
    [TestMethod]
    [DataTestMethod]
    [DataRow(-2, 2)]
    [DataRow(7, -2)]
    [DataRow(7, 0)]
    public void TestFibonacciMethodParameter(int startNumber, int limitNumber)
    {
        Fibonacci fibonacci = new();

        // ��������, ��� ��� �������� ����������� ���������� ������������� ���������� ����������.
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => fibonacci.FibonacciMethod(startNumber, limitNumber));
    }

    /// <summary>
    /// ������������ ������� ��� ������������ FibonacciMethod.
    /// </summary>
    [TestMethod]
    [DataTestMethod]
    [DataRow(4, 10)]
    public void TestFibonacciMethod(int startNumber, int limitNumber)
    {
        Fibonacci fibonacci = new();

        IEnumerable<long> result = fibonacci.FibonacciMethod(startNumber, limitNumber);
        
        // ��������, ��� �������������� ����� ������ �������� �������� ����������.
        Assert.AreEqual(limitNumber, result.Count());
    }
}