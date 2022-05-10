using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите цвет с маленькой буквы");

            switch (Console.ReadLine())
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ваш цвет красный!");
                    return;

                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ваш цвет зеленый!");
                    return;

                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Ваш цвет голубой!");
                    break;


                default:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Ваш цвет хз какой. Вы -- идиот.");
                    return;

            }


        }
    }
}
