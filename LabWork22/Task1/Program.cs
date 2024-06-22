namespace Task1
{
    internal class Program
    {
        static void GetPower(double a, int x)
        {
            double result = 1;
            if (x > 0)
                for (int i = 0; i < x; i++)
                    result *= a;
            else
                for (int i = 0; i > x; i--)
                    result /= a;

            Console.WriteLine($"{a}^{x} = {result}");
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Последовательный асинхронный вызов:");
            await Task.Run(() => GetPower(2, 3));
            await Task.Run(() => GetPower(2, -2));
            await Task.Run(() => GetPower(1.5, 2));

            Console.WriteLine("Параллельный асинхронный вызов:");
            await Task.WhenAll(
                Task.Run(() => GetPower(2, 3)),
                Task.Run(() => GetPower(2, -2)),
                Task.Run(() => GetPower(1.5, 2)));

        }
    }
}
