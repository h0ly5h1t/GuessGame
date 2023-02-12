using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumberGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в центр игр Бегемотик!\nВыберите интересующую вас игру!\n1 - Угадай животное (В разработке), 2 - Угадай число!");
            int userInput = int.Parse(Console.ReadLine());
            
            switch (userInput)
            {
                case 1:
                    TryGuessAnimals();
                    break;
                case 2:
                    TryGuessNum();
                    break;
                default:
                    Console.WriteLine("Такой игры не существует. Повторите ввод!");
                    Console.ReadLine();
                    break;
            }
        }

        static void TryGuessNum()
        {
            int inputNumber, higherNumber, lowerNumber, numberRandom; // Вводимое число, верхний порог числа, нижний порог числа и само рандомное число
            int tryCount = 5; // количество попыток на ввод числа

            Random rnd = new Random();
            numberRandom = rnd.Next(0, 101);
            lowerNumber = rnd.Next(numberRandom - 10, numberRandom);
            higherNumber = rnd.Next(numberRandom + 1, numberRandom + 10);

            Console.WriteLine($"Добро пожаловать в игру - Угадай число!\nМы загадали число от 0 до 100, но известо, что оно больше чем {lowerNumber} и меньше чем {higherNumber}!\nВведите число, испытайте удачу!:");
            
            while (tryCount-- > 0)
            {
                inputNumber = int.Parse(Console.ReadLine());
                if (inputNumber == numberRandom)
                {
                    Console.WriteLine("Вы угадали, поздравляем!");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine($"Вы не угадали! Попробуйте еще раз\nУ вас осталось {tryCount} попыток!");
                }
            }
            Console.WriteLine($"Загаданным числом было - {numberRandom}!");
            Console.ReadKey();
        }

        static void TryGuessAnimals()
        {
            Console.WriteLine("В разработке!"); // Доделаю, когда научусь работать с БД)
            Console.ReadKey();
        }
    }
}
