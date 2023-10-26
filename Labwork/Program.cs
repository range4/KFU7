using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Labwork
{


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BankAccount\n");
            Bank account = new Bank(0001, 345000, AccountType.Current);
            Console.WriteLine(account);
            Console.WriteLine("Press Enter");
            Console.ReadKey();

            Console.WriteLine("Generated AccountNumber\n");
            GeneratedAccountNumber account1 = new GeneratedAccountNumber(250000, AccountType.Savings);
            Console.WriteLine(account1);
            Console.WriteLine("Press Enter");
            Console.ReadKey();



            Console.WriteLine("Withdraw, Deposit and Transfer\n");
            Console.WriteLine("Список возможных команд:|Перевести| |Внести| |Вывести| |Баланс| |Выход|");
            string command;
            do
            {
                Console.WriteLine("Введите команду");
                command = Console.ReadLine().ToLower();
                switch (command)
                {
                    case "внести":
                        Console.WriteLine("Введите сумму, которую хотите внести\n");
                        bool dep = decimal.TryParse(Console.ReadLine(), out decimal dep_money);
                        if (!dep)
                        {
                            do
                            {
                                Console.WriteLine("Вы ввели не число, повторите попытку");
                                dep = decimal.TryParse(Console.ReadLine(), out dep_money);

                            }
                            while (!dep);

                        }
                        account.Deposit(dep_money);
                        break;
                    case "вывести":
                        Console.WriteLine("Введите сумму, которую хотите вывести");
                        bool with = decimal.TryParse(Console.ReadLine(), out decimal with_money);
                        if (!with)
                        {
                            do
                            {
                                Console.WriteLine("Вы ввели не число, повторите попытку");
                                dep = decimal.TryParse(Console.ReadLine(), out with_money);

                            }
                            while (!with);

                        }
                        account.WithDraw(with_money);
                        break;
                    case "баланс":
                        account.GetBalance();
                        break;
                    case "перевести":
                        Console.WriteLine("Введите номер счета на который хотите перевести деньги");
                        bool flag_accountNumber = uint.TryParse(Console.ReadLine(), out uint accountNumber);
                        if (!flag_accountNumber)
                        {
                            do
                            {
                                Console.WriteLine("Введен не верный номер счета, повторите попытку");
                                flag_accountNumber = uint.TryParse(Console.ReadLine(), out accountNumber);

                            } while (!flag_accountNumber);
                            
                        }
                        Console.WriteLine("Введите сумму которую хотите перевести");
                        bool money_amount = decimal.TryParse(Console.ReadLine(), out decimal amount);
                        if (!money_amount)
                        {
                            do
                            {
                                Console.WriteLine("Вы ввели не число, повторите попытку");
                                money_amount = decimal.TryParse(Console.ReadLine(), out amount);
                            } while (!money_amount);
                        }
                        {

                        }
                        account.Transfer(account, amount, account1);
                        break;
                    case "выход":
                        break;
                    default:
                        Console.WriteLine("Вы ввели неверную команду\n");
                        break;
                }
            } while (!command.Equals("выход"));



            static string ReverseString(string s)
            {
                char[] char_array = s.ToCharArray();
                Array.Reverse(char_array);
                return new string(char_array);
            }

            Console.WriteLine("Task 8.2\n Введите строку, которую хотите перевернуть");
            string s = Console.ReadLine();
            Console.WriteLine($"s ---> {ReverseString(s)}");


            static void CheckIFormatable(object obj)
            {
                if (obj is IFormattable)
                {
                    IFormattable formattable_obj = obj as IFormattable;
                    if (formattable_obj != null)
                    {
                        Console.WriteLine("Объект совмещается с типом");
                    }
                    else
                    {
                        Console.WriteLine("Объект не совмещается с типом");
                    }
                }
            }

            Console.WriteLine("Task 8.4\n");
            object number = 23;
            CheckIFormatable(number);

            Console.WriteLine("DZ 2");
            Songs[] songs = new Songs[]
            {
            new Songs("Split", "Yeat"),
            new Songs("Turban", "Yeat"),
            new Songs("All Eyes On Me", "2Pac"),
            new Songs("Just A Lil Bit", "50Cent")
            };
            Console.WriteLine("Список песен:");
            foreach (Songs a in songs)
            {
                Console.WriteLine(a.Title());
            }
            if (songs[0].Equals(songs[1]))
            {
                Console.WriteLine("Песни одинаковые");
            }
            else
            {
                Console.WriteLine("Песни разные");
            }
        }
    }
}


