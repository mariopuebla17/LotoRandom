using System;
using System.Collections.Generic;

namespace LotoRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtd = 25;
            Random rd = new Random();
            List<int> numeros = new List<int>();
            int number = 1;
            for (int i = 1; i <= qtd; i++)
            {
                number = rd.Next(1, qtd + 1);
                while (numeros.Contains(number))
                {
                    if (numeros.Count >= qtd + 1) // quando ficar em loop infinito vou quebrar o laço                        
                        break;
                    else
                        number = rd.Next(1, qtd + 1);
                }
                numeros.Add(number);
                Console.WriteLine(number.ToString());
            }
            Console.ReadLine();
        }
    }
}
