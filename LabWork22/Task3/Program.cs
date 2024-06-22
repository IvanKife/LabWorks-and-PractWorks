namespace Task3
{
    internal class Program
    {
        static async Task WriteFileAsync(string filename, int numberLines)
        {
            Random random = new();
            int number;
            for (int i = 0; i < numberLines; i++)
            {
                number = random.Next();
                using (StreamWriter writer = new StreamWriter(filename, false))
                {
                    await writer.WriteLineAsync((Char)number);
                }
            }
            Console.WriteLine("Конец программы");
        }

        static async Task Main(string[] args)
        {
            string filename = Path.Combine(Environment.CurrentDirectory, "MyFiles", "1.txt");
            await WriteFileAsync(filename, 100000);
        }
    }
}
