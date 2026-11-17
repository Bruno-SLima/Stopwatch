using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        
        static void Menu()  
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => Ex: 10s = 10 segundos");
            Console.WriteLine("M = Minuto => Ex: 5m = 5 minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo gostaria de contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length -1, 1));
            int time = int.Parse(data.Substring(0, data.Length -1));
            int multiplayer = 1;

            if(type == 'm')
                multiplayer = 60;
                
            if(time == 0)
                System.Environment.Exit(0);

            Start(time * multiplayer);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime ++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); // Espera 1 segundo para atualizar o tempo.
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2000); // Aguardar 2 segundos antes de encerrar o programa.
        }
    }
}          