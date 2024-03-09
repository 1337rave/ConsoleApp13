using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Інтерфейс ICalc2
interface ICalc2
{
    int CountDistinct();
    int EqualToValue(int valueToCompare);
}

// Клас Array з імплементованим інтерфейсом ICalc2
class Array : ICalc2
{
    private int[] arr;

    // Конструктор для ініціалізації масиву
    public Array(int[] array)
    {
        arr = array;
    }

    // Реалізація методу інтерфейсу ICalc2 - повертає кількість унікальних значень
    public int CountDistinct()
    {
        return arr.Distinct().Count();
    }

    // Реалізація методу інтерфейсу ICalc2 - повертає кількість елементів масиву, рівних valueToCompare
    public int EqualToValue(int valueToCompare)
    {
        return arr.Count(x => x == valueToCompare);
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 2, 3, 4, 5, 6, 1, 7, 8, 9, 10, 2 };

        // Створення об'єкту класу Array з ініціалізацією масиву
        Array array = new Array(numbers);

        // Виклик методів для тестування функціональності
        Console.WriteLine($"Number of distinct values: {array.CountDistinct()}");
        Console.WriteLine($"Number of values equal to 2: {array.EqualToValue(2)}");
    }
}