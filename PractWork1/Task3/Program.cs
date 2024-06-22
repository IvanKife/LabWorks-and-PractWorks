using System.IO;

Console.WriteLine("Введите имя файла: ");
string filename = Console.ReadLine();

if (!File.Exists(filename))
{
    Console.WriteLine("Файла не существует");
    return;
}

Console.WriteLine("Введите текст для поиска: ");
var searchText = Console.ReadLine().ToLower();

var lines = File.ReadAllLines(filename);
int countLine = 0;

foreach (var line in lines)
{
    countLine++;
    if (line.ToLower().Contains(searchText))
    {
        Console.WriteLine($"{countLine}: {line}");
    }
}





