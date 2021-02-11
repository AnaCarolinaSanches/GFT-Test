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
            
            if (multipliciador > 3000 || multipliciador < 0)
                Console.WriteLine("Multiplicador não pode ser negativo e maior que 3000");
            else if (inicio > 3000 || inicio < 0 || fim > 3000 || fim < 0)
                Console.WriteLine("O Intervalo não pode conter negativos e nem ser maior que 3000");
            else if ((inicio - fim) > 10)
                Console.WriteLine("O intervalo não pode ser maior que 10");
            else if (inicio >= fim)
                Console.WriteLine("inicio deve ser menor que o fim");
            else
            {

                for (int i = 0; i <= fim; i++)
                {
                    Console.WriteLine(multipliciador + " x " + i + " = " + (i * multipliciador));
                }
            }

        }
    }
}
