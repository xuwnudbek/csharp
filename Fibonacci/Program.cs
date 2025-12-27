namespace Fibonachchi
{
    class Program
    {
        static List<int> GenerateFibNumbers(int n = 2)
        {
            var fibonacciSonlar = new List<int> { 0, 1 };
            int counter = 2;

            while (counter < n)
            {
                int prePrev = fibonacciSonlar[counter - 2];
                int prev = fibonacciSonlar[counter - 1];

                int newFib = prePrev + prev;
                fibonacciSonlar.Add(newFib);

                counter++;
            }

            return fibonacciSonlar;
        }

        static void Main(string[] args)
        {
            int maxFibCount = 30;

            Console.WriteLine("Fibonacci sonlarni aniqlash");
            Console.Write("Nechta fibonacci sonni aniqlay: ");
            int n = Convert.ToInt32(Console.ReadLine());

            while (n > maxFibCount)
            {
                Console.Write($"Iltimos, {maxFibCount} yoki undan kichik son kiriting: ");
                n = Convert.ToInt32(Console.ReadLine());
            }

            var fibonacciSonlar = GenerateFibNumbers(n);

            for (var i = 0; i < fibonacciSonlar.Count; i++)
            {
                int fib = fibonacciSonlar[i];
                Console.WriteLine($"{i + 1}-fibonacci: {fib}");
            }
        }
    }
}
