using System.IO;

Console.WriteLine("Введите имя файла для дозаписи текста: ");
string filename = Console.ReadLine();

if (File.Exists(filename))
    Console.WriteLine("Файл открыт на дозапись: ");
else
{
    File.Create(filename);
    Console.WriteLine("Файл с указанным названием создан");
}

Console.WriteLine("Введите строки на дозапись. Для окончания дозаписи введите - end");
while (true)
{
    string text = Console.ReadLine();
    if (text == "end")
        break;
    File.AppendAllText(filename, $"{text}\n");
}
Console.WriteLine(File.ReadAllText(filename));