namespace Fibonachchi
{
    class Program
    {
        static List<int> GenerateFibNumbers(int n = 2)
        {
            var fibonachchiSonlar = new List<int> { 0, 1 };
            int counter = 2;

            if (n > 2)
            {
                while (counter < n)
                {
                    int fib0 = fibonachchiSonlar[counter - 2];
                    int fib1 = fibonachchiSonlar[counter - 1];

                    int fib = fib0 + fib1;
                    fibonachchiSonlar.Add(fib);

                    counter++;
                }
            }

            return fibonachchiSonlar;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Fibonachchi sonlarni aniqlash");
            Console.Write("Nechta fibonachchi sonni aniqlay: ");
            int n = Convert.ToInt32(Console.ReadLine());

            var fibonachchiSonlar = GenerateFibNumbers(n);

            for (var i = 0; i < fibonachchiSonlar.Count; i++)
            {
                int fib = fibonachchiSonlar[i];
                Console.WriteLine($"fib[{i}]: {fib}");
            }
        }
    }
}
