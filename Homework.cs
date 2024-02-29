string massive = new string[3];

Создание блок схемы:

  Начало
    |
    V
  Создать пустой массив
    |
    V
  Для каждой строки в исходном массиве
    |
    V
  ┌─────────────┐
  │ Если длина   │
  │ строки <= 3, │
  │ добавить её  │
  │ в новый      │
  │ массив       │
  └─────────────┘
    |
    V
  Вернуть новый массив
    |
    V
  Конец


class Program
{
    static string[] FilterStrings(string[] array)
    {
        int count = 0;

        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] result = new string[count];
        int index = 0;

        foreach (string str in array)
        {
            if (str.Length <= 3)
            {
                result[index++] = str;
            }
        }

        return result;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Введите массив строк через запятую:");
        string[] array = Console.ReadLine().Split(',');

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i].Trim();
        }

        string[] filteredArray = FilterStrings(array);

        Console.WriteLine("Новый массив:");
        foreach (string str in filteredArray)
        {
            Console.WriteLine(str);
        }
    }
}