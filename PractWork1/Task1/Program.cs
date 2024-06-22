using System.IO;

Console.WriteLine("Введите имя файла: ");
string filename = Console.ReadLine();

if (File.Exists(filename))
    Console.WriteLine(File.ReadAllText(filename));
else
    Console.WriteLine("Файла не существует");

