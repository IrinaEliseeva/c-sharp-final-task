//Написать программу которая из имеющегося массива строк формирует массив из строк длина которых меньше, либо равна трём символам
class Program
{

    static string[] readStrings()
    {
        string originalString = Console.ReadLine() ?? "";
        return originalString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    }

    static void PrintStrings(string[] strings)
    {
        for (int i = 0; i < strings.Length; i++)
            Console.Write(strings[i] + " ");
        Console.WriteLine();
    }

    static string[] Filter(string[] strings, int len)
    {
        var result = new string[strings.Length];
        var i = 0;
        foreach (var s in strings)
        {
            if (s.Length <= len)
            {
                result[i] = s;
                i++;
            }
        }
        return result;
    }
    static void Main()
    {
        Console.WriteLine("Введите желаемую строку для обработки: ");
        string[] from = readStrings();

        Console.WriteLine("Исходный массив: ");
        PrintStrings(from);
        Console.WriteLine("Отфильтрованный массив: ");
        string[] filtered = Filter(from, 3);
        PrintStrings(filtered);
    }
}