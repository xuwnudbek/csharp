namespace UmumiyYuza
{
    class Program
    {
        const int roundLength = 2;

        static void VariablesAssign(out double radius, out double a, out double b)
        {
            Console.WriteLine("1. O'zgaruvchilarga qiymatlarni berish!");
            Console.Write("Doira radiusi: ");
            radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nTo'rtburchak tomonlari (a, b): ");
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
        }

        static double DoiraYuzasiniAniqlash(double r)
        {
            return Math.Round(Math.PI * r * r, roundLength);
        }

        static double TortburchakYuzasiniAniqlash(double a, double b)
        {
            return Math.Round(a * b, roundLength);
        }

        static void Main(string[] args)
        {
            // O'zgaruvchilarni elon qilish
            double radius; // Doirani radiusi
            double a; // To'rtburchani birinchi tomoni
            double b; // To'rtburchani ikkinchi tomoni
            double s; // Umumiy yuza

            // O'zgaruvchilarga qiymatlarni qabul qilish
            VariablesAssign(out radius, out a, out b);

            // Doira yuzasini aniqlash & chop etish
            // Doira yuzasi: PI * r * r;
            double doiraYuzasi = DoiraYuzasiniAniqlash(radius);
            Console.WriteLine($"Doira yuzasi: {doiraYuzasi}");

            // To'rtburchak yuzasini aniqlash & chop etish
            // To'rtburchak yuzasi: a * b;
            double tortburchakYuzasi = TortburchakYuzasiniAniqlash(a, b);
            Console.WriteLine($"Tortburchak yuzasi: {tortburchakYuzasi}");

            // Umumiy yuzani aniqlash & chop etish
            s = doiraYuzasi + tortburchakYuzasi;
            Console.WriteLine($"Umumiy yuza: {s}");
        }
    }
}
