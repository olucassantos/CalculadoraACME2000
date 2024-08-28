using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraACME2000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um programa que solicite 2 números, e a operação desejada(+, -, /, *). 
            // Ao final o programa deve mostrar o resultado com a operação escolhida.

            Console.Write("Digite o primeiro número: ");
            decimal numero_um = decimal.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número: ");
            decimal numero_dois = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Qual operação deseja?");
            Console.WriteLine("[+] Soma");
            Console.WriteLine("[-] Subtração");
            Console.WriteLine("[*] Multiplicação");
            Console.WriteLine("[/] Divisão");
            Console.Write("--> ");

            string operacao = Console.ReadLine();

            Console.Clear();

            decimal resultado = 0;
            bool mostraResultado = true;

            if (operacao == "+")
                resultado = numero_um + numero_dois;
            else if (operacao == "-")
                resultado = numero_um - numero_dois;
            else if (operacao == "*")
                resultado = numero_um * numero_dois;
            else if (operacao == "/")
            {
                if (numero_dois != 0)
                    resultado = numero_um / numero_dois;
                else
                {
                    Console.WriteLine("Não é possivel dividir um numero por zero, ainda.");
                    mostraResultado = false;
                }
            }
            else
            {
                Console.WriteLine("Você não selecionou uma operação válida!");
                mostraResultado = false;
            }

            if (mostraResultado)
                Console.WriteLine($"O resultado é: {resultado}");
        }
    }
}
