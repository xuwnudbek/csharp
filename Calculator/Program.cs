using System;
using Microsoft.VisualBasic;

namespace Calculator
{
    class Program
    {
        static void SelectOption(out int optionIndex)
        {
            Console.WriteLine(
                "Please select an option:\n\n1. BMI Calculator\n2. Currency Converter\n0. Exit\n"
            );

            Console.Write("Section: ");
            optionIndex = Convert.ToInt32(Console.ReadLine());
        }

        static void BMICalculator()
        {
            // O'zgaruvchilarni e'lon qilish
            double boyi;
            double vazni;
            double bmi;

            Console.WriteLine("----------BMI Calculator----------");

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

        static void CurrencyConverter()
        {
            // O'zgaruvchilarni e'lon qilish
            int optionIndex;
            double value = 0.0;
            const double oneDollarToSum = 12000;

            void Usd2Sum()
            {
                Console.WriteLine("---------- USD to SUM ----------");

                Console.Write("USD: ");
                value = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"{value} USD = {Math.Round(oneDollarToSum * value, 2)} SUM");
            }

            void Sum2Usd()
            {
                Console.WriteLine("---------- SUM to USD ----------");

                Console.Write("SUM: ");
                value = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"{value} SUM = {Math.Round(value / oneDollarToSum, 2)} USD");
            }

            Console.WriteLine("----------Currency Converter----------");
            Console.WriteLine("Select convert type:\n\n1. USD to SUM\n2. SUM to USD\n");

            Console.Write("Type: ");
            optionIndex = Convert.ToInt32(Console.ReadLine());

            switch (optionIndex)
            {
                case 1:
                    Usd2Sum();
                    break;
                case 2:
                    Sum2Usd();
                    break;
                default:
                    Console.Beep();
                    break;
            }
        }

        static void Main(string[] args)
        {
            // O'zgaruvchilarni elon qilish
            int optionIndex;

            SelectOption(out optionIndex);

            switch (optionIndex)
            {
                case 0:
                    break;
                case 1:
                    BMICalculator();
                    break;
                case 2:
                    CurrencyConverter();
                    break;
                default:
                    Console.WriteLine("Please select correct option index!");
                    break;
            }
        }
    }
}
