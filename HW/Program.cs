using System;

namespace singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            float wallet =0;
            ConsoleKeyInfo choice;
            while (true)
            {
                Console.WriteLine("how much money do you want to draw from the atm?");
                Console.WriteLine("1 - 100");
                Console.WriteLine("2 - 200");
                Console.WriteLine("3 - 300");
                Console.WriteLine("4 - 400");
                Console.WriteLine("5 - more");
                Console.WriteLine("=======================================================");
                choice = Console.ReadKey(true);
                switch (choice.Key)
                {
                    case ConsoleKey.D1:
                        wallet += Singleton.Instance.DrawMoney(100);
                        break;
                    case ConsoleKey.D2:
                        wallet +=  Singleton.Instance.DrawMoney(200);
                        break;
                    case ConsoleKey.D3:
                        wallet +=  Singleton.Instance.DrawMoney(300);
                        break;
                    case ConsoleKey.D4:
                        wallet +=  Singleton.Instance.DrawMoney(400);
                        break;
                    case ConsoleKey.D5:
                        float custom = float.Parse(Console.ReadLine());
                        wallet +=  Singleton.Instance.DrawMoney(custom);
                        break;

                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
            }
        }
    }
}
