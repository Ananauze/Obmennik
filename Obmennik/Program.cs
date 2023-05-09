using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obmennik
{
    internal class Program
    {
        private static string userInput;

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            const string CommandRubToUsd = "1";
            const string CommandUsdToRub = "2";
            const string CommandRubToEuro = "3";
            const string CommandEuroToRub = "4";
            const string CommandEuroToUsd = "5";
            const string CommandUdsToEuro = "6";

            string userinput = "";
            float currencyCount;
            string stopProgramWord = "Exit";

            Console.WriteLine("Добро пожаловать в наш обменник.");
            Console.Write("Введите количество ЕВРО на Вашем счету: ");
            float euro = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите количество Долларов на Вашем счету: ");
            float usd = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите количество Рублей на Вашем счету: ");
            float rub = Convert.ToSingle(Console.ReadLine());

            while (userinput != stopProgramWord)
            {
                Console.Clear();
                Console.WriteLine($"У Вас в кармане {rub} рублей, {euro} Евро и {usd} долларов.");
                Console.WriteLine("Что вы хотите сделать?");
                Console.WriteLine($"{CommandRubToUsd} - поменять рубли на доллары");
                Console.WriteLine($"{CommandUsdToRub} - поменять доллары на рубли");
                Console.WriteLine($"{CommandRubToEuro} - поменять рубли на евро");
                Console.WriteLine($"{CommandEuroToRub} - поменять евро на рубли");
                Console.WriteLine($"{CommandEuroToUsd} - поменять евро на доллары");
                Console.WriteLine($"{CommandUdsToEuro} - поменять доллары на евро");
                Console.Write("Введите номер необходимого варианта: ");
                userinput = Console.ReadLine();

                switch (userinput)
                {
                    case CommandRubToUsd:
                        float rubToUsd = 0.0125f;
                        Console.WriteLine($"Обмен рублей на доллары по курсу {rubToUsd}");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            usd += currencyCount * rubToUsd;
                        }
                        else
                        {
                            Console.WriteLine("У вас нет столько рублей");
                        }
                        break;

                    case CommandUsdToRub:
                        float usdToRub = 79.7f;
                        Console.WriteLine($"Обмен долларов на рубли по курсу {usdToRub}!");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (usd >= currencyCount)
                        {
                            usd -= currencyCount;
                            rub += currencyCount * usdToRub;
                        }
                        else
                        {
                            Console.WriteLine("У вас нет столько долларов");
                        }
                        break;

                    case CommandRubToEuro:
                        float rubToEuro = 0.114f;
                        Console.WriteLine($"Обмен рублей на евро по курсу {rubToEuro}!");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (rub >= currencyCount)
                        {
                            rub -= currencyCount;
                            euro += currencyCount * rubToEuro;
                        }
                        else
                        {
                            Console.WriteLine("У вас нет столько рублей");
                        }
                        break;

                    case CommandEuroToRub:
                        float euroToRub = 87.37f;
                        Console.WriteLine($"Обмен евро на рубли по курсу {euroToRub}!");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (euro >= currencyCount)
                        {
                            euro -= currencyCount;
                            rub += currencyCount * euroToRub;
                        }
                        else
                        {
                            Console.WriteLine("У вас нет столько евро");
                        }
                        break;

                    case CommandEuroToUsd:
                        float euroToUsd = 1.09f;
                        Console.WriteLine($"Обмен евро на доллары {euroToUsd}!");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (euro >= currencyCount)
                        {
                            euro -= currencyCount;
                            usd += currencyCount * euroToUsd;
                        }
                        else
                        {
                            Console.WriteLine("У вас нет столько евро");
                        }
                        break;

                    case CommandUdsToEuro:
                        float usdToEuro = 0.91f;
                        Console.WriteLine($"Обмен доллары на евро по курсу {usdToEuro}!");
                        Console.Write("Сколько вы хотите обменять: ");
                        currencyCount = Convert.ToSingle(Console.ReadLine());

                        if (euro >= currencyCount)
                        {
                            euro -= currencyCount;
                            usd += currencyCount * usdToEuro;
                        }
                        else
                        {
                            Console.WriteLine("У вас нет столько евро");
                        }
                        break;

                    default:
                        Console.WriteLine("Приходите еще!");
                        break;
                }

                Console.WriteLine($"Сейчас у вас {rub} рублей, {usd} долларов и {euro} евро.");
                Console.Write($"Для выхода напишите {stopProgramWord}, для продолжения нажмите Enter: ");
                userinput = Console.ReadLine();
            }
        }
    }
}
