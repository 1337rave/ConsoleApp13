using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

// Інтерфейс ICalc
interface ICalc
{
    int Less(int valueToCompare);
    int Greater(int valueToCompare);
}

// Клас Array з імплементованим інтерфейсом ICalc
class Array : ICalc
{
    private int[] arr;

    // Конструктор для ініціалізації масиву
    public Array(int[] array)
    {
        arr = array;
    }

    // Реалізація методу інтерфейсу ICalc - повертає кількість менших значень
    public int Less(int valueToCompare)
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (num < valueToCompare)
                count++;
        }
        return count;
    }

    // Реалізація методу інтерфейсу ICalc - повертає кількість більших значень
    public int Greater(int valueToCompare)
    {
        int count = 0;
        foreach (int num in arr)
        {
            if (num > valueToCompare)
                count++;
        }
        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 5, 10, 15, 20, 25 };

        // Створення об'єкту класу Array з ініціалізацією масиву
        Array array = new Array(numbers);

        // Виклик методів для тестування функціональності
        int lessCount = array.Less(18);
        int greaterCount = array.Greater(18);

        Console.WriteLine($"Number of elements less than 18: {lessCount}");
        Console.WriteLine($"Number of elements greater than 18: {greaterCount}");
    }
}
