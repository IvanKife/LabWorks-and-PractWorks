namespace Task2
{
    internal class Program
    {
        static double GetPower(double a, int x)
        {
            double result = 1;

            if (x > 0)
                for (int i = 0; i < x; i++)
                    result *= a;
            else
                for (int i = 0; i > x; i--)
                    result /= a;

            return result;
        }

        static async Task ShowExampleAsync()
        {
            Console.WriteLine(await Task.Run(() => (GetPower(2, 3) + GetPower(2, -3)) / (GetPower(1.5, 2) - GetPower(1, 0))));
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Параллельный асинхронный вызов:");
            var results = await Task.WhenAll(
                Task.Run(() => GetPower(2, 3)),
                Task.Run(() => GetPower(2, -2)),
                Task.Run(() => GetPower(1.5, 2)));

            foreach (var result in results)
                Console.WriteLine(result);

            Console.WriteLine("Решение примера при помощи последовательного вызова метода a^x:");
            await Task.Run(() => ShowExampleAsync());
        }
    }
}
