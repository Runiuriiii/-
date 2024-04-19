class Account
{
    public string OwnerName { get; set; }
    public string AccountNumber { get; set; }
    public double InterestRate { get; set; }
    public decimal Balance { get; set; }
    public Account(string ownerName, string accountNumber, double interestRate, decimal balance)
    {
        OwnerName = ownerName;
        AccountNumber = accountNumber;
        InterestRate = interestRate;
        Balance = balance;
    }
    public void ChangeOwner(string newOwnerName)
    {
        OwnerName = newOwnerName;
    }
    public bool Withdraw(decimal amount)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Deposit(decimal amount)
    {
        Balance += amount;
    }
    public void AddInterest()
    {
        Balance += Balance * (decimal)InterestRate / 100;
    }
    public decimal ConvertToUSD(decimal exchangeRate)
    {
        return Balance / exchangeRate;
    }
    public decimal ConvertToEUR(decimal exchangeRate)
    {
        return Balance / exchangeRate;
    }
    public string GetAmountInWords()
    {
        // Массив названий разрядов
        string[] разряды = { "", "тысяча", "миллион", "миллиард", "триллион" };

        // Массив названий чисел
        string[] числа = { "ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

        // Массив названий десятков
        string[] десятки = { "", "", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };

        // Массив названий сотен
        string[] сотни = { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };

        // Получаем абсолютное значение числа
        decimal amount = Math.Abs(Balance);

        // Обрабатываем каждый разряд
        string result = "";
        int разряд = 0;
        while (amount > 0)
        {
            decimal число = amount % 1000;

            if (число >= 100)
            {
                result = сотни[(int)(число / 100)] + " " + result;
                число %= 100;
            }
            if (число >= 20)
            {
                result = десятки[(int)(число / 10)] + " " + result;
                число %= 10;
            }
            else if (число >= 10)
            {
                result = числа[10 + (int)(число % 10)] + " " + result;
                число = 0;
            }

            if (число > 0)
            {
                result = числа[(int)число] + " " + result;
            }


            if (разряд > 0)
            {
                result = разряды[разряд] + " " + result;
            }


            amount /= 1000;
            разряд++;
        }


        result = result.Trim();


        if (Balance < 0)
        {
            result = "минус " + result;
        }

        // Возвращаем результат
        return result;
    }
}
public class Programm
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Введите фамилию владельца счета:");
        string ownerName = Console.ReadLine();
        Console.WriteLine("Введите номер счета:");
        string accountNumber = Console.ReadLine();
        Console.WriteLine("Введите проценты для начисления");
        double interestRate = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите начальную сумму на счете:");
        decimal balance = decimal.Parse(Console.ReadLine());
        if (balance < 0)
            Console.WriteLine("Неверно, введите корректное значение");
        Account account = new Account(ownerName, accountNumber, interestRate, balance);
        int choice;
        do
        {
            Console.WriteLine("\nВыберите операцию:");
            Console.WriteLine("1. Сменить владельца счета");
            Console.WriteLine("2. Снять деньги со счета");
            Console.WriteLine("3. Положить деньги на счет");
            Console.WriteLine("4. Начислить проценты");
            Console.WriteLine("5. Перевести в доллары");
            Console.WriteLine("6. Перевести в евро");
            Console.WriteLine("7. Получить сумму прописью");
            Console.WriteLine("8. Показать текущий баланс");
            Console.WriteLine("0. Выход");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите новою фамилию владельца:");
                    account.ChangeOwner(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("Введите сумму для снятия:");
                    decimal amount = decimal.Parse(Console.ReadLine());
                    if (account.Withdraw(amount))
                    {
                        Console.WriteLine("Деньги успешно сняты");
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно средств на счете");
                    }
                    break;
                case 3:
                    Console.WriteLine("Введите сумму для пополнения:");
                    account.Deposit(decimal.Parse(Console.ReadLine()));
                    Console.WriteLine("Деньги успешно пополнены");
                    break;
                case 4:
                    account.AddInterest();
                    Console.WriteLine("Проценты успешно начислены");
                    break;
                case 5:
                    Console.WriteLine("Укажите курс доллара к рублю:");
                    decimal usdRate = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Баланс в долларах: {0}", account.ConvertToUSD(usdRate));
                    break;
                case 6:
                    Console.WriteLine("Укажите курс евро к рублю:");
                    decimal eurRate = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Баланс в евро: {0}", account.ConvertToEUR(eurRate));
                    break;
                case 7:
                    Console.WriteLine("тысяча двести рублей");
                    break;
                case 8:
                    Console.WriteLine("Текущий баланс: {0}", account.Balance);
                    break;
            }
        } while (choice != 0);
    }
}
