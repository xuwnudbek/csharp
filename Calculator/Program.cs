using System;

namespace Calculator
{
    class Program
    {
        static void BMICalculator()
        {
            // O'zgaruvchilarni e'lon qilish
            double boyi;
            double vazni;
            double bmi;

            Console.WriteLine("BMI Calculator ishga tushdi!");
            Console.WriteLine("----------BMI----------");

            Console.Write("Bo'yingiz (sm): ");
            boyi = Convert.ToDouble(Console.ReadLine());

            Console.Write("Vazningiz (kg): ");
            vazni = Convert.ToDouble(Console.ReadLine());

            /* BMI ni hisoblash
                bmi = vazn(kg) / (bo'y(m) * bo'y(m));

                bmi < 18.5 = Ozg'in;
                bmi in 18.5 - 24.9 = Normal;
                bmi in 25 - 29.9 = Ortiqcha Vazn;
                bmi in 30 - 34.9 = Semizlik (1-daraja);
                bmi in 35 - 39.9 = Semizlik (2-daraja);
                bmi >= 40 = Og'ir Semizlik;
            */

            bmi = Math.Round(vazni / Math.Pow(boyi / 100, 2), 2);

            Console.WriteLine($"BMI: {bmi}");

            switch (bmi)
            {
                case < 18.5:
                    Console.WriteLine("Siz \"Ozg'insiz\", ko'proq yeng!");
                    break;

                case <= 24.9:
                    Console.WriteLine("Siz \"Normalsiz\"!");
                    break;

                case <= 29.9:
                    Console.WriteLine("Siz \"Semiryapsiz\", parhez qiling!");
                    break;

                case <= 34.9:
                    Console.WriteLine(
                        "Siz \"Semizlikni 1-darajasidasiz\", parhez qiling va fitnes bilan shug'ullaning!"
                    );
                    break;

                case <= 39.9:
                    Console.WriteLine(
                        "Siz \"Semizlikni 2-darajasidasiz\", parhez qiling va fitnes bilan ko'proq shug'ullaning!"
                    );
                    break;

                case >= 40:
                    Console.WriteLine(
                        "Siz \"Juda Semizsiz\", parhez qiling va bugundan fitnes bilan shug'ullaning!\nErtaga kexh bo'lishi mumkin!"
                    );
                    break;

                default:
                    Console.WriteLine("Nimadur xato ketti!");
                    break;
            }
        }

        static void Main(string[] args)
        {
            BMICalculator();
        }
    }
}
