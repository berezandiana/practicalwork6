using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Відкриємо файл для читання
        StreamReader file = new StreamReader("file.txt");

        int min = int.MaxValue;
        int max = int.MinValue;

        // Прочитаємо кожен рядок у файлі
        string line;
        while ((line = file.ReadLine()) != null)
        {
            // Спробуємо перетворити рядок у число
            if (int.TryParse(line, out int number))
            {
                // Якщо перетворення вдалося, порівняємо число з мінімальним та максимальним значенням
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
            }
        }

        // Закриємо файл
        file.Close();

        // Виведемо результати
        Console.WriteLine("Мiнiмальне значення: " + min);
        Console.WriteLine("Максимальне значення: " + max);

        // Зачекаємо на натискання користувачем клавіші перед завершенням програми
        Console.ReadLine();
    }
}
