using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int multipliciador = 0;
            int inicio = 0;
            int fim = 0;

            Console.WriteLine("Digite o multiplicador: ");
            multipliciador = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Inicio do intervalo");
            inicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o fim do intervalo");
            fim = int.Parse(Console.ReadLine());


            Console.WriteLine("Multiplicando: " + multipliciador);
            Console.WriteLine("Inicio: " + inicio);
            Console.WriteLine("Fim: " + fim);

            for (int i = 0; i <= fim; i++)
            {
                Console.WriteLine(multipliciador + " x " + i + " = " + (i * multipliciador));
            }
        }
    }
}
