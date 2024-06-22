//5.4 Поиск и вывод списка файлов на экран (GetFiles)
//Разработать приложение, запрашивающее у пользователя имя папки и часть имени файла.
//Вывести на экран список полных имен и размеров файлов из указанной папки и ее 
//подпапок, в которых имя файла содержит указанный пользователем текст.

Console.WriteLine("Введите путь к файлу: ");
var path = Console.ReadLine();

Console.WriteLine("Введите имя папки и часть имени файла: ");
var searchPattern = "*" + Console.ReadLine() + "*";

DirectoryInfo directory = new(path);
var files = directory.GetFiles(searchPattern, SearchOption.AllDirectories);
foreach (var file in files)
    Console.WriteLine($"Имя файла: {file}\nРазмер файла: {file.Length}\n");