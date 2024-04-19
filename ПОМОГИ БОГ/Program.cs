using System;

namespace HexadecimalSplitter
{
    internal class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Hexadec2 number1 = new Hexadec2("");
                Hexadec2 number2 = new Hexadec2("");

                Console.WriteLine("Введите первое 16-ричное дробное число:");
                string input1 = Console.ReadLine();
                number1 = new Hexadec2(input1);

                Console.WriteLine("Введите второе 16-ричное дробное число:");
                string input2 = Console.ReadLine();
                number2 = new Hexadec2(input2);
                

                Console.WriteLine("Первое число:");
                Console.WriteLine("Целая часть: " + number1.WholePart);
                Console.WriteLine("Дробная часть: " + number1.FractionalPart);
                Console.WriteLine("Второе число:");
                Console.WriteLine("Целая часть: " + number2.WholePart);
                Console.WriteLine("Дробная часть: " + number2.FractionalPart);

                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1. Вычитание");
                Console.WriteLine("2. Деление");
                int choice = int.Parse(Console.ReadLine());

                Hexadec2 result;
                    switch (choice)
                    {
                        case 1:
                            result = number1.Subtract(number2);
                            break;
                        case 2:
                            result = number1.Divide(number2);
                            break;
                        default:
                            Console.WriteLine("Неверный выбор операции.");
                            return;
                    }
                    Console.WriteLine("Результат:");
                    Console.WriteLine("Целая часть: " + result.WholePart);
                    Console.WriteLine("Дробная часть: " + result.FractionalPart);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка -" + ex.Message);
            }
        }
    }
    public class Hexadec2
    {
        public string WholePart { get; set; }
        public string FractionalPart { get; set; }
        public Hexadec2(string number)
        {
            string[] parts = number.Split('.');
            WholePart = parts[0];
            FractionalPart = parts.Length > 1 ? parts[1] : "";
        }
        public Hexadec2 Divide(Hexadec2 other)
        {
            if (other.WholePart == "0" && other.FractionalPart == "0")
            {
                throw new DivideByZeroException();
            }
            decimal decimal1 = HexadecimalToDecimal(this);
            decimal decimal2 = HexadecimalToDecimal(other);

            decimal quotient;
            try
            {
                quotient = decimal1 / decimal2;
            }
            catch (OverflowException)
            {
                return new Hexadec2("Infinity");
            }
            return new Hexadec2(DecimalToHexadecimal(quotient));
        }
        public Hexadec2 Subtract(Hexadec2 other)
        {
            decimal decimal1 = HexadecimalToDecimal(this);
            decimal decimal2 = HexadecimalToDecimal(other);
            decimal difference = decimal1 - decimal2;
            return new Hexadec2(DecimalToHexadecimal(difference));
        }
        private static decimal HexadecimalToDecimal(Hexadec2 number)
        {
            long wholePart = long.Parse(number.WholePart, System.Globalization.NumberStyles.HexNumber);
            decimal fractionalPart = 0;
            if (number.FractionalPart != "")
            {
                int fractionalPartLength = number.FractionalPart.Length;
                for (int i = 0; i < fractionalPartLength; i++)
                {
                    char digit = number.FractionalPart[i];
                    int digitValue = int.Parse(digit.ToString(), System.Globalization.NumberStyles.HexNumber);
                    fractionalPart += (decimal)digitValue / (decimal)Math.Pow(16, i + 1);
                }
            }
            return wholePart + fractionalPart;
        }
        private static string DecimalToHexadecimal(decimal number)
        {
            if (number == 0)
            {
                return "0";
            }

            long wholePart = (long)Math.Floor(number);
            decimal fractionalPart = number - wholePart;

            List<string> hexadecimalDigits = new List<string>();

            while (wholePart > 0)
            {
                int digit = (int)(wholePart % 16);
                hexadecimalDigits.Insert(0, digit.ToString("X"));
                wholePart /= 16;
            }

            List<string> fractionalDigits = new List<string>();
            HashSet<decimal> previousFractionalParts = new HashSet<decimal>();
            int повторение = 0;
            while (fractionalPart != 0 && повторение < 100)
            {
                fractionalPart *= 16;

                int digit = (int)Math.Floor(fractionalPart);

                fractionalDigits.Add(digit.ToString("X"));

                fractionalPart -= digit;

                previousFractionalParts.Add(fractionalPart);

                повторение++;
            }

            return string.Join("", hexadecimalDigits) + (fractionalDigits.Count > 0 ? "." + string.Join("", fractionalDigits) : "");
        }

    }
}