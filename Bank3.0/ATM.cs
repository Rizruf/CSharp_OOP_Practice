using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Bank3._0
{
    internal class ATM
    {
        private Bank _bank;

        public ATM(Bank bank)
        {
            _bank = bank;
        }

        bool atmWork = true;

        public void Start()
        {
            while (atmWork)
            {
                Console.WriteLine("Добро пожаловать в банк!");

                Console.WriteLine("Введите номер карты!");
                string enterNum = Console.ReadLine();

                Card card = _bank.GetCard(enterNum);

                if (card == null)
                {
                    Console.WriteLine("Карта не найдена. Повторите!");
                    continue;
                }

                Console.WriteLine($"Карта найдена!");

                Console.Write("Введите пароль: ");
                string pin = Console.ReadLine();

                if (card.CheckPin(pin))
                {
                    Console.WriteLine($"Доступ разрешен! Баланс: {card.Balance}");
                    choosingAction(card);
                }
                else
                {
                    Console.WriteLine("Неверный пароль!");
                    continue;
                }
            }
        }

        public void choosingAction(Card card)
        {
            bool sessionActive = true;
            while (sessionActive)
            {
                Console.WriteLine("Выберите действие! Напишите только число!\n");
                Console.WriteLine("1.Пополнить баланс");
                Console.WriteLine("2.Снять наличные");
                Console.WriteLine("3.Посмотреть баланс");
                Console.WriteLine("4.Выход\n");

                string enterChoice = Console.ReadLine();

                bool choiceCorrect = ChoiceValid(enterChoice);

                if (choiceCorrect)
                {
                    switch (enterChoice)
                    {
                        case "1":
                            Console.WriteLine("Вы выбрали пополнить баланс какую сумму внесете?");
                            while (true)
                            {
                                Console.WriteLine("Введите сумму взноса!");
                                string moneyEnter = Console.ReadLine();
                                bool moneyCorrect= MoneyEnterCorrect(moneyEnter);

                                if (moneyCorrect && decimal.TryParse(moneyEnter, out decimal money))
                                {
                                    card.Deposit(money);
                                    Console.WriteLine("Сумма добавлена вам на карту");
                                    break;
                                }
                                else continue;
                            }
                            continue;

                        case "2":
                            Console.WriteLine("Вы выбрали снять деньги с карты, какую сумму для снятия??");
                            while (true)
                            {
                                Console.WriteLine("Введите сумму для снятия!");
                                string moneyEnter = Console.ReadLine();
                                bool moneyCorrect = MoneyEnterCorrect(moneyEnter);

                                if (moneyCorrect && decimal.TryParse(moneyEnter, out decimal money))
                                {
                                    if (money > card.Balance)
                                    {
                                        Console.WriteLine("Вы не можете снять столько. У вас меньше денег на карте");
                                        continue;
                                    }
                                    card.Withdraw(money);
                                    Console.WriteLine("Наличные выданы!");
                                    break;
                                }
                                else continue;
                            }
                            continue;

                        case "3":
                            Console.WriteLine($"Ваш баланс {card.Balance}");
                            continue;

                        case "4":
                            Console.WriteLine("Заберите карту. До свидания!");
                            sessionActive = false;
                            break;

                        default:
                            Console.WriteLine("Нет такого варианта выбора!");
                            continue;
                    }
                }
                else { Console.WriteLine("Действие либо не выбрано, либо ввод не корректный"); }
            }
        }

        public bool MoneyEnterCorrect(string moneyEnter)
        {
            if (string.IsNullOrEmpty(moneyEnter))
            {
                return false;
            }

            foreach (char symbol in moneyEnter)
            {
                if (!char.IsDigit(symbol))
                {
                    return false;
                }
            }

            return true;
        }

        public bool ChoiceValid(string input)
        {
            if (input.Length != 1 || !char.IsDigit(input[0])) return false;

            return true;
        }
    }
}
