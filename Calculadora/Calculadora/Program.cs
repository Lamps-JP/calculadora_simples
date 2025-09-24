using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Declaração de Vaariáveis ---
            // 'num1' e 'num2' armazenarão os números de entrada do usuário.
            int num1;
            int num2;
            // 'resultado' guardará o valor final da operação matemática.
            // Inicializamos com 0 para garantir que ela sempre tenha um valor.
            int resultado = 0;
            // 'resposta' armazenará a letra da operação escolhida (a, s, m, d).
            string resposta;

            // --- Interação com o Usuário ---
            Console.WriteLine("Olá, bem-vindo ao programa de calculadora!");

            // Solicita e armazena o primeiro número.
            Console.WriteLine("Por Favor, escreva seu primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

            // Solicita e armazena o segundo número
            Console.WriteLine("Por Favor, escreva seu segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            // --- Seleção da Operação ---
            Console.WriteLine("Qual Operação você gostaria de fazer? ");
            Console.WriteLine("Pressione a para Adição, s para Subitração, m para multiplicação e d para Divisão");
            resposta = Console.ReadLine();

            // --- Lógica de Cálculo ---
            // Verifica qual operação o usuário escolheu e realiza o calculo apropriado
            if (resposta == "a")
            {
                resultado = num1 + num2;

            }
            else if (resposta == "s")
            {
                resultado = num1 - num2;

            }
            else if (resposta == "m")
            {
                resultado = num1 * num2;
            }
            else if (resposta == "d")
            {

                resultado = num1 / num2;
            }
            // Caso o usuário digite uma opção inválida.
            else
            {
                Console.WriteLine("Operação não identificada");
            }

            // Exibe o resultado final para o usuário.
            Console.WriteLine( "O resultado é: " + resultado);

            // Mantém o console aberto até que o usuário pressione uma tecla.
            Console.WriteLine("Obrigado por usar a calculadora");

            Console.ReadKey();
        }

    }
}
