// ### Шаг 2. Первая запись и чтение файла
// Console.WriteLine("=== File.WriteAllText / ReadAllText ===");

// File.WriteAllText("notes.txt", "Привет, файл!");
// string content = File.ReadAllText("notes.txt");
// Console.WriteLine($"Содержимое файла: {content}");

// ### Шаг 4. Дозапись в файл

// Console.WriteLine();
// Console.WriteLine("=== File.AppendAllText ===");

// File.AppendAllText("notes.txt", "\nВторая строка");
// File.AppendAllText("notes.txt", "\nТретья строка");

// string updatedContent = File.ReadAllText("notes.txt");
// Console.WriteLine(updatedContent);

// ### Шаг 5. Проверка существования файла

// Console.WriteLine();
// Console.WriteLine("=== File.Exists ===");

// Console.WriteLine($"notes.txt существует: {File.Exists("notes.txt")}");
// Console.WriteLine($"unknown.txt существует: {File.Exists("unknown.txt")}");

// ### Шаг 7. Запись и чтение построчно через массив

// Console.WriteLine();
// Console.WriteLine("=== WriteAllLines / ReadAllLines ===");

// string[] students = { "Иванов", "Петрова", "Сидоров" };
// File.WriteAllLines("students.txt", students);

// string[] readStudents = File.ReadAllLines("students.txt");
// Console.WriteLine($"Прочитано строк: {readStudents.Length}");
// foreach (string student in readStudents)
// {
//     Console.WriteLine($"- {student}");
// }

// ### Шаг 9. Построчная запись через using

// Console.WriteLine();
// Console.WriteLine("=== StreamWriter ===");

// using (StreamWriter writer = new StreamWriter("log.txt"))
// {
//     writer.WriteLine("Программа запущена");
//     writer.WriteLine($"Дата: {DateTime.Now:dd.MM.yyyy HH:mm}");
//     writer.WriteLine("Операция выполнена успешно");
// }

// Console.WriteLine("Файл log.txt записан");

// ### Шаг 10. Построчное чтение через using

// Console.WriteLine();
// Console.WriteLine("=== StreamReader ===");

// using (StreamReader reader = new StreamReader("log.txt"))
// {
//     string line;
//     int lineNumber = 1;
//     while ((line = reader.ReadLine()) != null)
//     {
//         Console.WriteLine($"Строка {lineNumber}: {line}");
//         lineNumber++;
//     }
// }

// ### Шаг 12. Чтение несуществующего файла безопасно

// Console.WriteLine();
// Console.WriteLine("=== Обработка ошибок ===");

// try
// {
//     string content = File.ReadAllText("несуществующий_файл.txt");
//     Console.WriteLine(content);
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Файл не найден: {ex.Message}");
// }


// ### Шаг 13. Path.Combine и Directory.CreateDirectory

// Console.WriteLine();
// Console.WriteLine("=== Path.Combine ===");

// string folderPath = "data";
// Directory.CreateDirectory(folderPath);

// string filePath = Path.Combine(folderPath, "report.txt");
// File.WriteAllText(filePath, "Отчёт находится в подпапке data");

// Console.WriteLine($"Путь к файлу: {filePath}");
// Console.WriteLine(File.ReadAllText(filePath));


// ### Шаг 15. Собираем работу с файлами в интерактивную программу

// using System;
// using System.IO;

// string diaryPath = "diary.txt";

// while (true)
// {
//     Console.WriteLine();
//     Console.WriteLine("=== Дневник событий ===");
//     Console.WriteLine("1 - Добавить запись");
//     Console.WriteLine("2 - Показать все записи");
//     Console.WriteLine("3 - Очистить дневник");
//     Console.WriteLine("0 - Выход");
//     Console.Write("Выберите пункт: ");

//     string choice = Console.ReadLine();

//     if (choice == "1")
//     {
//         Console.Write("Введите текст записи: ");
//         string entry = Console.ReadLine();

//         try
//         {
//             string record = $"[{DateTime.Now:dd.MM.yyyy HH:mm}] {entry}";
//             File.AppendAllText(diaryPath, record + Environment.NewLine);
//             Console.WriteLine("Запись добавлена");
//         }
//         catch (IOException ex)
//         {
//             Console.WriteLine($"Ошибка ввода-вывода: {ex.Message}");
//         }
//     }
//     else if (choice == "2")
//     {
//         if (!File.Exists(diaryPath))
//         {
//             Console.WriteLine("Дневник пуст");
//         }
//         else
//         {
//             try
//             {
//                 using (StreamReader reader = new StreamReader(diaryPath))
//                 {
//                     string line;
//                     int number = 1;
//                     while ((line = reader.ReadLine()) != null)
//                     {
//                         Console.WriteLine($"{number}. {line}");
//                         number++;
//                     }
//                 }
//             }
//             catch (IOException ex)
//             {
//                 Console.WriteLine($"Ошибка ввода-вывода: {ex.Message}");
//             }
//         }
//     }
//     else if (choice == "3")
//     {
//         if (File.Exists(diaryPath))
//         {
//             try
//             {
//                 File.Delete(diaryPath);
//                 Console.WriteLine("Дневник очищен");
//             }
//             catch (IOException ex)
//             {
//                 Console.WriteLine($"Ошибка ввода-вывода: {ex.Message}");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Дневник и так пуст");
//         }
//     }
//     else if (choice == "0")
//     {
//         Console.WriteLine("Выход из программы");
//         break;
//     }
//     else
//     {
//         Console.WriteLine("Неизвестный пункт меню, попробуйте ещё раз");
//     }
// }


// ## Самостоятельные задания

// ### Задание 1. Подсчёт строк и слов в файле ★

// ### Задание 2. Копирование файла вручную ★★

// using System;
// using System.IO;


// void CopyFileManually(string sourcePath, string destinationPath)
// {
//     using (StreamReader reader = new StreamReader(sourcePath))
//     using (StreamWriter writer = new StreamWriter(destinationPath))
//     {
//         string line;
//         while ((line = reader.ReadLine()) != null)
//         {
//             writer.WriteLine(line);
//         }
//     }
// }

// string sourcePath = "source.txt";
// string destinationPath = "copy.txt";

// File.WriteAllText(sourcePath, "Первая строка исходника\nВторая строка исходника\nТретья строка исходника");

// Console.WriteLine("Содержимое исходного файла:");
// Console.WriteLine(File.ReadAllText(sourcePath));

// CopyFileManually(sourcePath, destinationPath);

// Console.WriteLine();
// Console.WriteLine("Содержимое скопированного файла:");
// Console.WriteLine(File.ReadAllText(destinationPath));

// Console.WriteLine($"Копирование прошло успешно: {File.ReadAllText(sourcePath) == File.ReadAllText(destinationPath)}");


// ### Задание 3. Учёт посещаемости в файле ★★★

using System;
using System.IO;

string attendancePath = "attendance.csv";

while (true)
{
    Console.WriteLine();
    Console.WriteLine("=== Учёт посещаемости ===");
    Console.WriteLine("1 - Отметить студента");
    Console.WriteLine("2 - Показать статистику по студенту");
    Console.WriteLine("0 - Выход");
    Console.Write("Выберите пункт: ");

    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Write("Введите ФИО студента: ");
        string name = Console.ReadLine();

        Console.Write("Присутствовал? (Да/Нет): ");
        string status = Console.ReadLine();

        try
        {
            string record = $"{name},{DateTime.Now.ToString("dd.MM.yyyy")},{status}";
            File.AppendAllText(attendancePath, record + Environment.NewLine);
            Console.WriteLine("Отметка добавлена");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Ошибка ввода-вывода: {ex.Message}");
        }
    }
    else if (choice == "2")
    {
        Console.Write("Введите ФИО студента: ");
        string name = Console.ReadLine();

        try
        {
            string[] records = File.ReadAllLines(attendancePath);
            int presentCount = 0;
            int absentCount = 0;

            foreach (string record in records)
            {
                string[] parts = record.Split(',');

                if (parts[0] == name)
                {
                    if (parts[2] == "Да")
                    {
                        presentCount++;
                    }
                    else
                    {
                        absentCount++;
                    }
                }
            }

            Console.WriteLine($"Студент: {name}");
            Console.WriteLine($"Присутствовал: {presentCount} раз");
            Console.WriteLine($"Отсутствовал: {absentCount} раз");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Записей ещё нет");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Ошибка ввода-вывода: {ex.Message}");
        }
    }
    else if (choice == "0")
    {
        Console.WriteLine("Выход из программы");
        break;
    }
    else
    {
        Console.WriteLine("Неизвестный пункт меню, попробуйте ещё раз");
    }
}
