using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

// Інтерфейс IOutput2
interface IOutput2
{
    void ShowEven();
    void ShowOdd();
}

// Клас Array з імплементованим інтерфейсом IOutput2
class Array : IOutput2
{
    private int[] arr;

    // Конструктор для ініціалізації масиву
    public Array(int[] array)
    {
        arr = array;
    }

    // Реалізація методу інтерфейсу IOutput2 - відображає парні значення
    public void ShowEven()
    {
        Console.WriteLine("Even numbers:");
        foreach (int num in arr)
        {
            if (num % 2 == 0)
                Console.WriteLine(num);
        }
    }

    // Реалізація методу інтерфейсу IOutput2 - відображає непарні значення
    public void ShowOdd()
    {
        Console.WriteLine("Odd numbers:");
        foreach (int num in arr)
        {
            if (num % 2 != 0)
                Console.WriteLine(num);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Створення об'єкту класу Array з ініціалізацією масиву
        Array array = new Array(numbers);

        // Виклик методів для тестування функціональності
        array.ShowEven();
        array.ShowOdd();
    }
}
