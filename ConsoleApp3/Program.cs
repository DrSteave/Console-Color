using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите цвет с маленькой буквы");

            int k = 0;
            do
            {
                Console.WriteLine(k);

                switch(Console.ReadLine())
                {
                    case "red":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ваш цвет красный!");
                        break;

                    case "green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Ваш цвет зеленый!");
                        break;

                    case "cyan":
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Ваш цвет голубой!");
                        break;

                    case "stop":
                        Console.WriteLine("Цикл остановлен");
                        return;

                    default:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Ваш цвет хз какой. Вы -- идиот.");
                        continue;
                        
                }
                    k++;
                
            } while (k < 3);
        }
    }
}
