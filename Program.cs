// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;

class Program
{
    // Определяем функцию FilterShortStrings, которая принимает список строк
    static List<string> FilterShortStrings(List<string> strings)
    {
        // Создаем пустой список для хранения строк длиной не более 3 символов
        List<string> result = new List<string>();

        // Проходим по каждой строке в исходном списке
        foreach (string str in strings)
        {
            // Проверяем длину строки, и если она меньше или равна 3
            if (str.Length <= 3)
            {
                // Добавляем строку в список result
                result.Add(str);
            }
        }

        // Возвращаем отфильтрованный список
        return result;
    }

    static void Main()
    {
        // Создаем список initialStrings, содержащий несколько строк
        List<string> initialStrings = new List<string> { "cat", "dog", "elephant", "ant", "bat" };

        // Вызываем функцию FilterShortStrings с initialStrings
        // и сохраняем результат в переменной filteredStrings
        List<string> filteredStrings = FilterShortStrings(initialStrings);

        // Выводим исходный список строк
        Console.WriteLine("Исходный массив: " + string.Join(", ", initialStrings));

        // Выводим отфильтрованный список строк
        Console.WriteLine("Отфильтрованный массив: " + string.Join(", ", filteredStrings));
    }
}
